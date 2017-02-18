using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WolfLairBlog.Common.LogUtil
{
    /************************************************************************************
         * Copyright (c) 2017  All Rights Reserved.
         * CLR版本： 4.0.30319.42000
         * 机器名称：DESKTOP-C7IEETR
         * 公司名称：南京马普科技有限公司
         * 文件名：  LogUtility
         * 版本号：  V1.0.0.0
         * 唯一标识：20f256c0-4c77-4967-b7d4-38ed7fbccc1c
         * 当前的用户域：DESKTOP-C7IEETR
         * 创建人：  hexd 贺晓冬
         * 电子邮箱：675556820@qq.com
         * 创建时间：2017/2/15 14:26:00
         * 描述    :
         * =====================================================================
        *************************************************************************************/
    public static class LogUtility
    {
        public static string GetExceptionDetails(Exception ex)
        {
            Exception logException = ex;
            if (ex.InnerException != null)
            {
                logException = ex.InnerException;
            }
            StringBuilder message = new StringBuilder();
            message.AppendLine();
            message.AppendLine("要求虚拟路径：" + HttpContext.Current.Request.Path);
            message.AppendLine("要求原始URL：" + HttpContext.Current.Request.RawUrl);
            message.AppendLine("例外类型：" + logException.GetType().Name);
            message.AppendLine("例外信息：" + logException.Message);
            message.AppendLine("例外来源：" + logException.Source);
            message.AppendLine("Stack Trace：" + logException.StackTrace);
            message.AppendLine("TargetSite：" + logException.TargetSite);
            return message.ToString();
        }
    }
}
