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
    public partial class SobreForm : Form
    {
        public SobreForm()
        {
            InitializeComponent();
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            var mainmenuForm = new MainMenuForm();
            mainmenuForm.Show();
            this.Hide();
        }
        private void BtnLGPD_Click(object sender, EventArgs e)
        {
            var lgpdForm = new LGPDForm();
            lgpdForm.Show();
            this.Hide();
        }
        private void BtnVersao_Click(object sender, EventArgs e)
        {
            var versaoForm = new VersaoForm();
            versaoForm.Show();
            this.Hide();
        }
        private void BtnFale_Click(object sender, EventArgs e)
        {
            var faleForm = new FaleForm();
            faleForm.Show();
            this.Hide();
        }
    }
}
