using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;


namespace SeuProjeto
{
    public partial class AreaDoClienteForm : Form
    {
        public AreaDoClienteForm()
        {
            InitializeComponent();
        }

        private void ClientInfoForm_Load(object sender, EventArgs e)
        {
            // Preenche as informações do usuário logado
            var usuario = UsuarioSessao.UsuarioAtual;

            lblNome.Text = usuario.Nome;
            lblCpf.Text = usuario.CPF;
            txtEndereco.Text = usuario.Endereco;
            txtCartaoDeCredito.Text = usuario.Cartao_de_credito;
            txtTelefone.Text = usuario.Telefone;
            txtSenha.Text = usuario.Senha;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var usuario = UsuarioSessao.UsuarioAtual;

            // Atualiza os dados do usuário na memória
            usuario.Endereco = txtEndereco.Text;
            usuario.Cartao_de_credito = txtCartaoDeCredito.Text;
            usuario.Telefone = txtTelefone.Text;
            usuario.Senha = txtSenha.Text;

            string connectionString = "Server=localhost;Database=shapesharp;Uid=root;Port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"
                    UPDATE Cliente 
                    SET Endereco = @Endereco, 
                        Cartao_de_credito = @Cartao_de_credito, 
                        Telefone = @Telefone, 
                        Senha = @Senha 
                    WHERE ID_Cliente = @ID_Cliente";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", usuario.Nome);
                command.Parameters.AddWithValue("@Endereco", usuario.Endereco);
                command.Parameters.AddWithValue("@Cartao_de_credito", usuario.Cartao_de_credito);
                command.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                command.Parameters.AddWithValue("@Senha", usuario.Senha);
                command.Parameters.AddWithValue("@CPF", usuario.CPF);
                command.Parameters.AddWithValue("@ID_Cliente", usuario.ID_Cliente);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Informações atualizadas com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar informações: " + ex.Message);
                }
            }
        }
        private void BtnMainMenuBack_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Hide();
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double peso = double.Parse(txtPeso.Text);
                double altura = double.Parse(txtAltura.Text);
                double imc = peso / (altura * altura);

                lblResultado.Text = $"Resultado: Seu IMC é {imc:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha os campos e use virgula na altura!");
            }
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            lblResultado.Text = "Resultado:";
        }

    }
}
