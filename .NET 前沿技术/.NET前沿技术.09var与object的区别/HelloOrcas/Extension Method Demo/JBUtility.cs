using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloOrcas
{
    /// <summary>
    /// 扩展方法必须放在一个非泛型的静态类里
    /// </summary>
    static class JBUtility
    {
        /// <summary>
        /// 带参数的扩展方法
        /// </summary>
        /// <param name="s">原始字符串</param>
        /// <param name="title">提示信息</param>
        public static void SayHi(this string s, string caption)
        {
            string message = string.Format(
            "Hi, 我是一个字符串，我的值是: \"{0}\"。", s);
            MessageBox.Show(message, caption, 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// 可以重载的扩展方法
        /// </summary>
        /// <param name="i">原始整数</param>
        public static void SayHi(this int i)
        {
            string message = string.Format(
            "Hi, 我是一个整数，我的值是: \"{0}\"。", i.ToString());
            MessageBox.Show(message, "JBUtility", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }



        /// <summary>
        /// 将一个字符串转化为 Pascal 大小写格式
        /// </summary>
        /// <param name="s">原始字符串</param>
        /// <returns>返回结果</returns>
        public static string ToPascal(this string s)
        {
            string[] words = s.Split(new char[] { ' ' });
            string result = string.Empty;

            foreach (string word in words)
            {
                result += word.Substring(0, 1).ToUpper() + 
                    word.Substring(1).ToLower();
            }
            return result;
        }

        /// <summary>
        /// 作业：将一个字符串转化为 Camel 大小写格式
        /// </summary>
        /// <param name="s">原始字符串</param>
        /// <returns>返回结果</returns>
        public static string ToCamel(this string s)
        {
            string result;
            result = s.ToPascal();
            result = result.Substring(0,1).ToLower() + result.Substring(1);
            return result;
        }

        /// <summary>
        /// 泛型扩展方法
        /// </summary>
        /// <typeparam name="T">泛型参数</typeparam>
        /// <param name="obj">原始数据</param>
        /// <returns>返回结果</returns>
        public static string AddHi<T>(this T obj)
        { 
            string message = string.Empty;
            message = "Hi, " + obj.ToString();
            return message;
        }

        public static void SayHi(this ISingable singer)
        {
            Console.WriteLine("我是一名歌手！");
        }
    }
}
