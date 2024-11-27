using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;


namespace SeuProjeto
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }        
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Verifica se algum campo está vazio
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text) ||                
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtCreditCard.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                txtName.Text == "Name" ||
                txtCpf.Text == "CPF" ||
                txtAddress.Text == "Endereço" ||
                txtCreditCard.Text == "Cartão de Crédito" ||
                txtPhone.Text == "Telefone" ||
                txtPassword.Text == "Senha")                
                
            {
                // Mostra um alerta se algum campo estiver vazio
                MessageBox.Show("Por favor, preencha todos os campos antes de registrar.",
                                "Campos obrigatórios",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            //conexão de registro no banco
            string connectionString = "Server=127.0.0.1;Uid=root;Database=shapesharp;Port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Cliente (Nome, CPF, Endereco, Cartao_de_credito, Telefone, Senha) " +
                               "VALUES (@Nome, @CPF, @Endereco, @Cartao_de_credito, @Telefone, @Senha)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", txtName.Text);
                command.Parameters.AddWithValue("@CPF", txtCpf.Text);
                command.Parameters.AddWithValue("@Endereco", txtAddress.Text);
                command.Parameters.AddWithValue("@Cartao_de_credito", txtCreditCard.Text);
                command.Parameters.AddWithValue("@Telefone", txtPhone.Text);
                command.Parameters.AddWithValue("@Senha", txtPassword.Text);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuário registrado com sucesso!");
                    // Limpar os campos após o registro
                    ClearFields();
                    //volta ao menu principal
                    var mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar usuário: " + ex.Message);
                }
            }
        }
        //botao voltar
        private void BtnBack_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
        // Método para limpar os campos após o registro
        private void ClearFields()
        {
            txtName.Text = "";
            txtCpf.Text = "";          
            txtAddress.Text = "";
            txtCreditCard.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
        }
    }
}
