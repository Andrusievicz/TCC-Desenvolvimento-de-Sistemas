using System;
using System.Windows.Forms;

namespace SeuProjeto
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtCpf;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnBack;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCpf
            // 
            this.txtCpf.ForeColor = System.Drawing.Color.Gray;
            this.txtCpf.Location = new System.Drawing.Point(62, 116);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(250, 20);
            this.txtCpf.TabIndex = 0;
            this.txtCpf.Text = "CPF";
            this.txtCpf.Enter += new System.EventHandler(this.txtCpf_Enter);
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(62, 184);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Senha";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLogin.Location = new System.Drawing.Point(62, 248);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBack.Location = new System.Drawing.Point(188, 248);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 30);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "CPF";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Senha";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.BackgroundImage = global::SeuProjeto.Properties.Resources.backlogin;
            this.ClientSize = new System.Drawing.Size(367, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // txtCpf evento placeholder
        private void txtCpf_Enter(object sender, EventArgs e)
        {
            // Verifica se o campo de senha contém o texto "CPF"
            if (txtCpf.Text == "CPF")
            {
                txtCpf.Text = "";// Limpa o campo de texto
                txtCpf.ForeColor = System.Drawing.Color.Black;// Muda a cor do texto para preto (indica que é uma entrada válida)
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                txtCpf.Text = "CPF";// Define o texto como "CPF" (o placeholder)
                txtCpf.ForeColor = System.Drawing.Color.Gray;// Muda a cor do texto para cinza (indicando que é um placeholder)
            }
        }

        // txtPassword evento placeholder
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            // Verifica se o campo de senha contém o texto "Senha"
            if (txtPassword.Text == "Senha")
            {
                txtPassword.Text = "";// Limpa o campo de texto
                txtPassword.ForeColor = System.Drawing.Color.Black;// Muda a cor do texto para preto (indica que é uma entrada válida)
                txtPassword.UseSystemPasswordChar = true;// Ativa o modo de ocultação de caracteres (para esconder a senha)
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            // Verifica se o campo de senha está vazio ou contém apenas espaços
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;// Desativa o modo de ocultação de caracteres (mostrando o texto normalmente)
                txtPassword.Text = "Senha";// Define o texto como "Senha" (o placeholder)
                txtPassword.ForeColor = System.Drawing.Color.Gray;// Muda a cor do texto para cinza (indicando que é um placeholder)
            }
        }

        private Label label1;
        private Label label2;
    }
}