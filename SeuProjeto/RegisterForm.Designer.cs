using System;
using System.Windows.Forms;

namespace SeuProjeto
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName;
        private TextBox txtCpf;
        private TextBox txtRg;
        private TextBox txtAddress;
        private TextBox txtCreditCard;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private Button btnSubmit;
        private Button btnBack;

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.txtCpf = new TextBox();
            this.txtRg = new TextBox();
            this.txtAddress = new TextBox();
            this.txtCreditCard = new TextBox();
            this.txtPhone = new TextBox();
            this.txtPassword = new TextBox();
            this.btnSubmit = new Button();
            this.btnBack = new Button();

            // txtName
            this.txtName.Location = new System.Drawing.Point(20, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 22);
            this.txtName.Text = "Nome";
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);

            // txtCpf
            this.txtCpf.Location = new System.Drawing.Point(20, 60);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(250, 22);
            this.txtCpf.Text = "CPF";
            this.txtCpf.ForeColor = System.Drawing.Color.Gray;
            this.txtCpf.Enter += new System.EventHandler(this.txtCpf_Enter);
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);

            // txtRg
            this.txtRg.Location = new System.Drawing.Point(20, 100);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(250, 22);
            this.txtRg.Text = "RG";
            this.txtRg.ForeColor = System.Drawing.Color.Gray;
            this.txtRg.Enter += new System.EventHandler(this.txtRg_Enter);
            this.txtRg.Leave += new System.EventHandler(this.txtRg_Leave);

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(20, 140);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 22);
            this.txtAddress.Text = "Endereço";
            this.txtAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);

            // txtCreditCard
            this.txtCreditCard.Location = new System.Drawing.Point(20, 180);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(250, 22);
            this.txtCreditCard.Text = "Cartão de Crédito";
            this.txtCreditCard.ForeColor = System.Drawing.Color.Gray;
            this.txtCreditCard.Enter += new System.EventHandler(this.txtCreditCard_Enter);
            this.txtCreditCard.Leave += new System.EventHandler(this.txtCreditCard_Leave);

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(20, 220);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 22);
            this.txtPhone.Text = "Telefone";
            this.txtPhone.ForeColor = System.Drawing.Color.Gray;
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(20, 260);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 22);
            this.txtPassword.Text = "Senha";
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(20, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 30);
            this.btnSubmit.Text = "Registrar";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);

            // btnBack
            this.btnBack.Location = new System.Drawing.Point(150, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 30);
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            // RegisterForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Name = "RegisterForm";
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Event handlers for placeholders
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Nome")
            {
                txtName.Text = "";
                txtName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Text = "Nome";
                txtName.ForeColor = System.Drawing.Color.Gray;
            }
        }

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

        private void txtRg_Enter(object sender, EventArgs e)
        {
            if (txtRg.Text == "RG")
            {
                txtRg.Text = "";
                txtRg.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtRg_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRg.Text))
            {
                txtRg.Text = "RG";
                txtRg.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Endereço")
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                txtAddress.Text = "Endereço";
                txtAddress.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtCreditCard_Enter(object sender, EventArgs e)
        {
            if (txtCreditCard.Text == "Cartão de Crédito")
            {
                txtCreditCard.Text = "";
                txtCreditCard.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtCreditCard_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCreditCard.Text))
            {
                txtCreditCard.Text = "Cartão de Crédito";
                txtCreditCard.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Telefone")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPhone.Text = "Telefone";
                txtPhone.ForeColor = System.Drawing.Color.Gray;
            }
        }

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