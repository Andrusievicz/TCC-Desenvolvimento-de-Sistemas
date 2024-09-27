using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SeuProjeto
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para a aplicação.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Inicializa com a tela inicial
        }
    }
}
