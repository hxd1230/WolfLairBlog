using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WolfLairBlog.Common.LogUtil;
using WolfLairBlog.Entity.DB;

namespace WolfLairBlog.Crawler
{
    class Program
    {
        static object _obj = new object();
        static int count;
        static AutoResetEvent autoReset = new AutoResetEvent(false);
        static void Main(string[] args)
        {

            //Chuli();
            Thread t = new Thread(Temp);
            t.Start();
            Thread t2;
            // for (int i = 0; i < 3; i++)
            //  {
            t2 = new Thread(Chuli);
            autoReset.WaitOne();
            Console.WriteLine("开始处理队列，队列剩余数量为：{0}", TempQueue.Count);
            t2.Start();
            // }
            Console.ReadKey();
        }
        static void Chuli()
        {
            WolfLairBlogEntities db = new WolfLairBlogEntities();
            //  ThreadPool.QueueUserWorkItem(c =>
            //  {
            while (true)
            {
                Console.WriteLine("队列剩余数量为：{0}", TempQueue.Count);
                // Thread.Sleep(500);
                // lock (_obj)
                //{
                if (TempQueue.Count > 0)
                {
                    Result r = TempQueue.Dequeue() as Result;
                    HtmlWeb htmlWeb = new HtmlWeb();
                    HtmlDocument htmlDoc = htmlWeb.Load(r.Url);
                    string innerHtml = string.Empty;
                    innerHtml = htmlDoc.DocumentNode.SelectSingleNode("//*[@id='cnblogs_post_body']").InnerHtml;
                    Article articleEntity = new Article
                    {
                        CategoryId = 1,
                        Content = innerHtml,
                        PubTime = DateTime.Now,
                        Title = r.Title,
                        UserId = 2
                    };
                    db.Articles.Add(articleEntity);
                    db.SaveChanges();
                    // count++;

                    try
                    {
                        #region MyRegion
                        //SqlParameter[] pms = new SqlParameter[] {
                        //    new SqlParameter("@CategoryId",1),
                        //    new SqlParameter("@Content",innerHtml),
                        //    new SqlParameter("@PubTime",DateTime.Now),
                        //    new SqlParameter("@Title",r.Title),
                        //    new SqlParameter("@UserId",2)
                        //};
                        //using (SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=1125;database=WolfLairBlog"))
                        //{
                        //    using (SqlCommand cmd = new SqlCommand("INSERT INTO Article(CategoryId,Content,PubTime,Title,UserId)VALUES(@CategoryId,@Content,@PubTime,@Title,@UserId)", con))
                        //    {
                        //        con.Open();
                        //        cmd.Parameters.AddRange(pms);
                        //        cmd.ExecuteNonQuery();
                        //        //if (cmd.ExecuteNonQuery() > 0)
                        //        //{
                        //        //   // count++;
                        //        //  //  Console.WriteLine(string.Format("标题：{0}，地址为：{1}", r.Title, r.Url));
                        //        //}
                        //    }
                        //}
                        ////if (db.SaveChanges() > 0)
                        //{

                        //}
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        NLogHelper.Error(ex.ToString());
                    }
                    //  }
                }
            }
            // });
        }
        private static void Temp()
        {
            for (int i = 1; i <= 200; i++)
            {
                Thread.Sleep(500);
                if (i == 1)
                {
                    PaChong("http://www.cnblogs.com/");
                }
                else
                {
                    PaChong(string.Format("http://www.cnblogs.com/sitehome/p/{0}", i));
                }
            }
            autoReset.Set();
            Console.WriteLine("数据抓取完毕！");
        }
        static Queue<Result> TempQueue = new Queue<Result>();
        static void PaChong(string url)
        {
            // IList<Result> results = new List<Result>();
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDoc = htmlWeb.Load(url);
            htmlDoc.DocumentNode.SelectNodes("//*[@id='post_list']/div[@class='post_item']").AsParallel().ToList().ForEach(c =>
            {
                HtmlNode node = c.SelectSingleNode(".//p[@class='post_item_summary']/a/img");
                Result r = new Result
                {
                    Url = c.SelectSingleNode(".//a[@class='titlelnk']").Attributes["href"].Value,
                    Title = c.SelectSingleNode(".//a[@class='titlelnk']").InnerText
                    // Content = c.SelectSingleNode(".//p[@class='post_item_summary']").InnerText
                };
                // results.Add(r);
                //lock (_obj)
                //{
                TempQueue.Enqueue(r);
                // }
                Console.WriteLine(string.Format("标题：{0}，地址为：{1}", r.Title, r.Url));

            });
            count++;
            Console.WriteLine("成功处理第{0}页，待处理数据量为：{1}", count, TempQueue.Count);
        }
    }
    class Result
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
