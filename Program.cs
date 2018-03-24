/*
 * Author: PECman
 * Date: 2018/3/24
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GreatCaptain
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GreatCaptain());
        }
    }
}
