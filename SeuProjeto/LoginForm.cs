using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string connectionString = "Server=127.0.0.1;Uid=root;Database=shapesharp;Port=3306;";
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
                    connection.Close();
                    if (count == 1)
                    {
                        using (MySqlConnection com = new MySqlConnection(connectionString))
                        {
                            try
                            {
                                connection.Open();

                                // DEFINE A CONSULTA SQL PARA PEGAR TODOS OS REGISTROS DA TABELA 'CLIENTES'
                                string selectQuery = "SELECT * FROM Cliente WHERE CPF = @CPF AND Senha = @Senha";

                                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                                {
                                    // EXECUTA A CONSULTA E OBTÉM UM MySqlDataReader PARA ACESSAR OS DADOS RETORNADOS
                                    cmd.Parameters.AddWithValue("@CPF", txtCpf.Text);
                                    cmd.Parameters.AddWithValue("@Senha", txtPassword.Text);
                                    using (MySqlDataReader reader = cmd.ExecuteReader())
                                    {
                                        int ID_Cliente = 0;
                                        string Nome = "";
                                        string CPF = "";
                                        string Endereco = "";
                                        string Cartao_de_credito = "";
                                        string Telefone = "";
                                        string Senha = "";

                                        // PERCORRE CADA LINHA DE RESULTADOS RETORNADA PELA CONSULTA
                                        while (reader.Read())
                                        {
                                            // LÊ O VALOR DAS COLUNAS 'NOME' E 'EMAIL' DA LINHA ATUAL
                                            ID_Cliente = Convert.ToInt32(reader["ID_Cliente"].ToString());
                                            Nome = reader["Nome"].ToString();
                                            CPF = reader["CPF"].ToString();
                                            Endereco = reader["Endereco"].ToString();
                                            Cartao_de_credito = reader["Cartao_de_credito"].ToString();
                                            Telefone = reader["Telefone"].ToString();
                                            Senha = reader["Senha"].ToString();
                                        }

                                        UsuarioSessao.UsuarioAtual = new Usuario();
                                        UsuarioSessao.UsuarioAtual.ID_Cliente = ID_Cliente;
                                        UsuarioSessao.UsuarioAtual.Nome = Nome;
                                        UsuarioSessao.UsuarioAtual.CPF = CPF;
                                        UsuarioSessao.UsuarioAtual.Endereco = Endereco;
                                        UsuarioSessao.UsuarioAtual.Cartao_de_credito = Cartao_de_credito;
                                        UsuarioSessao.UsuarioAtual.Telefone = Telefone;
                                        UsuarioSessao.UsuarioAtual.Senha = Senha;
                                        LoginSucedidoForm loginsucedido = new LoginSucedidoForm();
                                        loginsucedido.ShowDialog();
                                        var mainMenu = new MainMenuForm();
                                        mainMenu.Show();
                                        this.Hide();
                                    }
                                }
                                connection.Close();
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao fazer login: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        CPFouSenhaInvalidoForm cpfousenhainvalido = new CPFouSenhaInvalidoForm();
                        cpfousenhainvalido.ShowDialog();
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

