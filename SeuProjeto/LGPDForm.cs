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
    public partial class LGPDForm : Form
    {
        public LGPDForm()
        {
            InitializeComponent();
        }
        private void BtnLGPDBack_Click(object sender, EventArgs e)
        {
            var sobreMenu = new SobreForm();
            sobreMenu.Show();
            this.Hide();
        }
    }
}
