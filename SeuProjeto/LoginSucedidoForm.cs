using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeuProjeto
{
    public partial class LoginSucedidoForm : Form
    {

        private Timer timer; //variavel do timer
        public LoginSucedidoForm()
        {
            InitializeComponent();

            //criação do timer
            timer = new Timer();
            timer.Interval = 1500;//timer pra 1,5s
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        //evento do timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }
    }
}
