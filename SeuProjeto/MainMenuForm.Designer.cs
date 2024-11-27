using System.Drawing;
using System.Windows.Forms;

namespace SeuProjeto
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnCronograma;
        private Button btnAtividade;
        private Button btnInfoUsuario;
        private Button btnSobre;
        private Button btnLogout;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.btnCronograma = new System.Windows.Forms.Button();
            this.btnAtividade = new System.Windows.Forms.Button();
            this.btnInfoUsuario = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCronograma
            // 
            this.btnCronograma.BackColor = System.Drawing.SystemColors.Control;
            this.btnCronograma.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.btnCronograma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCronograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCronograma.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCronograma.Location = new System.Drawing.Point(112, 102);
            this.btnCronograma.Name = "btnCronograma";
            this.btnCronograma.Size = new System.Drawing.Size(218, 64);
            this.btnCronograma.TabIndex = 0;
            this.btnCronograma.Text = "Cronograma";
            this.btnCronograma.UseVisualStyleBackColor = false;
            this.btnCronograma.Click += new System.EventHandler(this.BtnCronograma_Click);
            // 
            // btnAtividade
            // 
            this.btnAtividade.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtividade.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.btnAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtividade.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtividade.Location = new System.Drawing.Point(112, 184);
            this.btnAtividade.Name = "btnAtividade";
            this.btnAtividade.Size = new System.Drawing.Size(218, 64);
            this.btnAtividade.TabIndex = 1;
            this.btnAtividade.Text = "Atividade";
            this.btnAtividade.UseVisualStyleBackColor = false;
            this.btnAtividade.Click += new System.EventHandler(this.BtnAtividade_Click);
            // 
            // btnInfoUsuario
            // 
            this.btnInfoUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.btnInfoUsuario.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.btnInfoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnInfoUsuario.Location = new System.Drawing.Point(112, 263);
            this.btnInfoUsuario.Name = "btnInfoUsuario";
            this.btnInfoUsuario.Size = new System.Drawing.Size(218, 64);
            this.btnInfoUsuario.TabIndex = 3;
            this.btnInfoUsuario.Text = "Área do cliente";
            this.btnInfoUsuario.UseVisualStyleBackColor = false;
            this.btnInfoUsuario.Click += new System.EventHandler(this.BtnInfoUsuario_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.SystemColors.Control;
            this.btnSobre.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSobre.Location = new System.Drawing.Point(112, 345);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(218, 64);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogout.Location = new System.Drawing.Point(112, 428);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(218, 64);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Deslogar";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // MainMenuForm
            // 
            this.BackgroundImage = global::SeuProjeto.Properties.Resources.Menu_shape_atualizado;
            this.ClientSize = new System.Drawing.Size(448, 579);
            this.Controls.Add(this.btnCronograma);
            this.Controls.Add(this.btnAtividade);
            this.Controls.Add(this.btnInfoUsuario);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }
    }
}
