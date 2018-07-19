using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberaBanco_v2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new controleAcesso());
                        
            bool canLogon = false;
            
            // Tela de login
            using (frmLogin ca = new frmLogin())
            {
                ca.ShowDialog();

                if (ca.DialogResult == DialogResult.OK)
                {
                    canLogon = ca.DialogResult == DialogResult.OK;
                }
            }
            if (canLogon)
            {
                if (frmLogin.telaAcesso == "principal")
                {
                    // Tela principal
                    Application.Run(new frmPrincipal());
                }
                else if (frmLogin.telaAcesso == "solicitacao")
                {
                    // Tela Solicitação
                    Application.Run(new frmSolicitacoes());
                }
            }
        }
    }
}
