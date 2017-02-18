﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfLairBlog.Common.LogUtil
{
   public class NLogHelper
    {
       private static Logger logger = LogManager.GetCurrentClassLogger();
       public static void Debug(string msg)
       {
           logger.Debug(msg);
       }
       public static void Trace(string msg)
       {
           logger.Trace(msg);
       }
       public static void Info(string msg)
       {
           logger.Info(msg);
       }
       public static void Error(string msg)
       {
           logger.Error(msg);
       }
       public static void Fatal(string msg)
       {
           logger.Fatal(msg);
       }
       public static void Warn(string msg)
       {
           logger.Warn(msg);
       }
    }
}
