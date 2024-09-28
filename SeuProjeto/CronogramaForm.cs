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
    public partial class CronogramaForm : Form
    {
        public CronogramaForm()
        {
            InitializeComponent();
        }

        private void BtnCronoBack_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Hide();
        }
    }
}
