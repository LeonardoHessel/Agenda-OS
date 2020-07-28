using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashScreen splashScreen = new SplashScreen();
            DialogResult dialogResult = splashScreen.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                bool exit = false;
                while (!exit)
                {
                    exit = true;
                    FormLogin login = new FormLogin();
                    login.ID_Modulo = 1;
                    login.Action = "Login";
                    DialogResult respLog = login.ShowDialog();

                    if (respLog == DialogResult.Yes)
                    {
                        FormAgenda Agenda = new FormAgenda();
                        Agenda.Usuario = login.Usuario;
                        DialogResult respOS = Agenda.ShowDialog();
                        if (respOS == DialogResult.Ignore)
                        {
                            exit = false;
                        }
                    }
                }
            }
        }
    }
}
