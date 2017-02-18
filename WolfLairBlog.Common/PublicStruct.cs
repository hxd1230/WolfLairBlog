using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfLairBlog.Common
{
    public class PublicStruct<T1, T2>
        where T1 : class,new()
        where T2 : class
    {
        public T1 Class { get; set; }
        public T2 String { get; set; }
    }
}
