using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SeuProjeto
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Uid=root;Database=projetoacademia;Port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Cliente WHERE CPF = @CPF AND Senha = @Senha";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CPF", txtCpf.Text);
                command.Parameters.AddWithValue("@Senha", txtPassword.Text);

                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 1)
                    {
                        MessageBox.Show("Login bem-sucedido!");
                        var mainMenu = new MainMenuForm();
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("CPF ou Senha incorretos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao fazer login: " + ex.Message);
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
