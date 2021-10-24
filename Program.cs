using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abashkin_Denis_MDM_171_333
{
    static class Program
    {
        public static string PostavhikDalee;
        public static string TowarDalee;
        public static string PhoneDalee;
        public static string LoginTitle;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            
        }
    }
}
