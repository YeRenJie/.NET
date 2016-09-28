using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloOrcas
{
   public static class SampleExtentionMethord
    {
        /// <summary>
        /// 简单的扩展方法
        /// </summary>
        /// <param name="s">原始字符串</param>
        public static void SayHi(this string s)
        {
            string message = string.Format(
                "Hi, 我是一个字符串，我的值是: \"{0}\"。", s);
            MessageBox.Show(message, "简单的扩展方法",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// 简单的扩展方法
        /// </summary>
        /// <param name="s">原始字符串</param>
        public static void SayHi(this object o)
        {
            string message = string.Format(
            "Hi, 我是一个object，我的值是: \"{0}\"。", o.ToString());
            MessageBox.Show(message, "简单的扩展方法", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
