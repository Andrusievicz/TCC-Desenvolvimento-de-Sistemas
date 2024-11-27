using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SeuProjeto
{
    public partial class FaleForm : Form
    {
        public FaleForm()
        {
            InitializeComponent();
        }
        private string connectionString = "Server=127.0.0.1;Uid=root;Database=shapesharp;Port=3306;";
        private void BtnSalvar_Click(object sender, EventArgs e)
        {           
            string texto = txtFaleConosco.Text;

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("O campo não pode estar vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Cliente SET FaleConosco = @texto WHERE ID_Cliente = @ID_Cliente";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@texto", texto);
                        cmd.Parameters.AddWithValue("@ID_Cliente", UsuarioSessao.UsuarioAtual.ID_Cliente);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Texto enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi atualizado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o texto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnLGPDBack_Click(object sender, EventArgs e)
        {
            var sobreMenu = new SobreForm();
            sobreMenu.Show();
            this.Hide();
        }
    }
}
