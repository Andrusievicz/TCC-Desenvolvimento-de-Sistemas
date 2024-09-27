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
            this.txtCpf = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnBack = new Button();

            // txtCpf
            this.txtCpf.Location = new System.Drawing.Point(20, 20);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(250, 22);
            this.txtCpf.Text = "CPF";
            this.txtCpf.ForeColor = System.Drawing.Color.Gray;
            this.txtCpf.Enter += new System.EventHandler(this.txtCpf_Enter);
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(20, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 22);
            this.txtPassword.Text = "Senha";
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(20, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 30);
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);

            // btnBack
            this.btnBack.Location = new System.Drawing.Point(150, 100);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 30);
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnBack);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // txtCpf placeholder behavior
        private void txtCpf_Enter(object sender, EventArgs e)
        {
            if (txtCpf.Text == "CPF")
            {
                txtCpf.Text = "";
                txtCpf.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                txtCpf.Text = "CPF";
                txtCpf.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // txtPassword placeholder behavior
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Senha")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = System.Drawing.Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Senha";
                txtPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}