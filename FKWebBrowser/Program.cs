﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKWebBrowser
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            FKConsoleWrapper p = new FKConsoleWrapper();
            p.ShowForm();
            p.ExitApp();
        }
    }
}
