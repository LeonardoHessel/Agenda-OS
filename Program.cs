using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS
{
    static class Program
    {
        public static Usuario Usuario { get; set; }
        public static bool Acesso { get; set; }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            bool exit = true;
            while (exit)
            {
                exit = false;
                Usuario = null;
                FormLogin login = new FormLogin();
                login.Action = "Login";
                Application.Run(login);
                if (Usuario != null)
                {
                    FormAgenda form = new FormAgenda();
                    form.Usuario = Usuario;                    
                    DialogResult resp = form.ShowDialog();
                    if (resp == DialogResult.Ignore)
                    {
                        exit = true;
                    }
                }
            }
        }
    }
}
