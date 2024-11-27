using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SeuProjeto
{
    public partial class AtividadeForm : Form
    {
        public AtividadeForm()
        {
            InitializeComponent();
        }
        private void BtnAtividadeBack_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Hide();
        }
        private void BtnCrossFit_Click(object sender, EventArgs e)
        {
            var crossfitForm = new CrossFitForm();
            crossfitForm.Show();
            this.Close();
        }
        private void BtnMuayThai_Click(object sender, EventArgs e)
        {
            var muaythaiForm = new MuayThaiForm();
            muaythaiForm.Show();
            this.Close();
        }
        private void BtnSpinning_Click(object sender, EventArgs e)
        {
            var spinningForm = new SpinningForm();
            spinningForm.Show();
            this.Close();
        }
        private void BtnYoga_Click(object sender, EventArgs e)
        {
            var yogaForm = new YogaForm();
            yogaForm.Show();
            this.Close();
        }
        private void BtnPilates_Click(object sender, EventArgs e)
        {
            var pilatesForm = new PilatesForm();
            pilatesForm.Show();
            this.Close();
        }
        private void BtnMusculacao_Click(object sender, EventArgs e)
        {
            var musculacaoForm = new MusculacaoForm();
            musculacaoForm.Show();
            this.Close();
        }
        private void BtnBoxe_Click(object sender, EventArgs e)
        {
            var boxeForm = new BoxeForm();
            boxeForm.Show();
            this.Close();
        }
        private void BtnCapoeira_Click(object sender, EventArgs e)
        {
            var capoeiraForm = new CapoeiraForm();
            capoeiraForm.Show();
            this.Close();
        }
        private void BtnZumba_Click(object sender, EventArgs e)
        {
            var zumbaForm = new ZumbaForm();
            zumbaForm.Show();
            this.Close();
        }
    }
}