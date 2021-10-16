using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Clipboard.SetText("designpatterns");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormFacebookPage());
        }
    }
}
