﻿using MSSQL_SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lessons2206.Forms;
using Lessons2206.Engine;

namespace Lessons2206
{
    static class Program
    {
        public static Connection db { get; set; }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            db = new Connection("127.0.0.1", "roman", "Itstep123", "itstep");
            db.MakeConnection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
        }
    }
}
