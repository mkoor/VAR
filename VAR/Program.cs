using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAR
{   
    public struct User
    {
            public string login;
            public string password;
            public string type;
    }

    static class Program
    {
        public static VAREntities varr = new VAREntities();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGlavnaya());
        }
    }
}
