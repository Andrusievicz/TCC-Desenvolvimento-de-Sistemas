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
            string connectionString = "Server=localhost;Uid=root;Database=projetoacademia;Port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Cliente (Nome, CPF, RG, Endereco, Cartao_de_credito, Telefone, Senha) " +
                               "VALUES (@Nome, @CPF, @RG, @Endereco, @Cartao_de_credito, @Telefone, @Senha)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", txtName.Text);
                command.Parameters.AddWithValue("@CPF", txtCpf.Text);
                command.Parameters.AddWithValue("@RG", txtRg.Text);
                command.Parameters.AddWithValue("@Endereco", txtAddress.Text);
                command.Parameters.AddWithValue("@Cartao_de_credito", txtCreditCard.Text);
                command.Parameters.AddWithValue("@Telefone", txtPhone.Text);
                command.Parameters.AddWithValue("@Senha", txtPassword.Text);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuário registrado com sucesso!");
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
