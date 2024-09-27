using System;
using System.Windows.Forms;

namespace SeuProjeto
{
    public partial class MainMenuForm : Form
    {
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

        private void BtnRegistrarAula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade Registrar Aula.");
        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade Agenda.");
        }

        private void BtnInfoUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade Informações do Usuário.");
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade Sobre.");
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
