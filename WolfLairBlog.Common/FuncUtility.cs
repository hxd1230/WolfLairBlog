using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WolfLairBlog.Common
{
    /************************************************************************************
         * Copyright (c) 2017  All Rights Reserved.
         * CLR版本： 4.0.30319.42000
         * 机器名称：DESKTOP-C7IEETR
         * 公司名称：南京马普科技有限公司
         * 文件名：  FuncUtility
         * 版本号：  V1.0.0.0
         * 唯一标识：c52e0447-da05-4c3d-9bf3-193cd18d92f7
         * 当前的用户域：DESKTOP-C7IEETR
         * 创建人：  hexd 贺晓冬
         * 电子邮箱：675556820@qq.com
         * 创建时间：2017/2/15 10:12:41
         * 描述    :
         * =====================================================================
        *************************************************************************************/
    public class FuncUtility
    {
        public static string Encrypt(string str)
        {
            return Encrypt(Encoding.UTF8.GetBytes(str));
        }
        public static string Encrypt(byte[] data)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hash = md5.ComputeHash(data);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x").PadLeft(2, '0'));
            }
            return sb.ToString();
        }
    }
}
