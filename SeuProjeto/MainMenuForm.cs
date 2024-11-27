using System;
using System.Windows.Forms;

namespace SeuProjeto
{
    public partial class MainMenuForm : Form
    {
        private string cpfUsuarioLogado;
        public MainMenuForm()
        {
            InitializeComponent();            
        }
        private void BtnCronograma_Click(object sender, EventArgs e)
        {
            var cronoForm = new CronogramaForm();
            cronoForm.Show();
            this.Close();
        }
        private void BtnAtividade_Click(object sender, EventArgs e)
        {
            var atividadeForm = new AtividadeForm();
            atividadeForm.Show();
            this.Close();
        }
        private void BtnInfoUsuario_Click(object sender, EventArgs e)
        {
            var areadoclienteForm = new AreaDoClienteForm();
            areadoclienteForm.Show();
            this.Close();
        }
        private void BtnSobre_Click(object sender, EventArgs e)
        {
            var sobreForm = new SobreForm();
            sobreForm.Show();
            this.Close();
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Fecha o menu principal e volta para o formulário de login ou inicial
            var mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

    }
}
