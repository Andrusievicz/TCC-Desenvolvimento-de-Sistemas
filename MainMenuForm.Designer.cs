using System.Drawing;
using System.Windows.Forms;

namespace SeuProjeto
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnCronograma;
        private Button btnRegistrarAula;
        private Button btnAgenda;
        private Button btnInfoUsuario;
        private Button btnSobre;
        private Button btnLogout;

        private void InitializeComponent()
        {
            btnCronograma = new Button();
            btnRegistrarAula = new Button();
            btnAgenda = new Button();
            btnInfoUsuario = new Button();
            btnSobre = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnCronograma
            // 
            btnCronograma.Location = new Point(20, 25);
            btnCronograma.Margin = new Padding(3, 4, 3, 4);
            btnCronograma.Name = "btnCronograma";
            btnCronograma.Size = new Size(250, 38);
            btnCronograma.TabIndex = 0;
            btnCronograma.Text = "Cronograma";
            btnCronograma.UseVisualStyleBackColor = true;
            btnCronograma.Click += BtnCronograma_Click;
            // 
            // btnRegistrarAula
            // 
            btnRegistrarAula.Location = new Point(20, 75);
            btnRegistrarAula.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarAula.Name = "btnRegistrarAula";
            btnRegistrarAula.Size = new Size(250, 38);
            btnRegistrarAula.TabIndex = 1;
            btnRegistrarAula.Text = "Registrar Aula";
            btnRegistrarAula.UseVisualStyleBackColor = true;
            btnRegistrarAula.Click += BtnRegistrarAula_Click;
            // 
            // btnAgenda
            // 
            btnAgenda.Location = new Point(20, 125);
            btnAgenda.Margin = new Padding(3, 4, 3, 4);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(250, 38);
            btnAgenda.TabIndex = 2;
            btnAgenda.Text = "Agenda";
            btnAgenda.UseVisualStyleBackColor = true;
            btnAgenda.Click += BtnAgenda_Click;
            // 
            // btnInfoUsuario
            // 
            btnInfoUsuario.Location = new Point(20, 175);
            btnInfoUsuario.Margin = new Padding(3, 4, 3, 4);
            btnInfoUsuario.Name = "btnInfoUsuario";
            btnInfoUsuario.Size = new Size(250, 38);
            btnInfoUsuario.TabIndex = 3;
            btnInfoUsuario.Text = "Informações do Usuário";
            btnInfoUsuario.UseVisualStyleBackColor = true;
            btnInfoUsuario.Click += BtnInfoUsuario_Click;
            // 
            // btnSobre
            // 
            btnSobre.Location = new Point(20, 225);
            btnSobre.Margin = new Padding(3, 4, 3, 4);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(250, 38);
            btnSobre.TabIndex = 4;
            btnSobre.Text = "Sobre";
            btnSobre.UseVisualStyleBackColor = true;
            btnSobre.Click += BtnSobre_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(104, 271);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 29);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Deslogar";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += BtnLogout_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 344);
            Controls.Add(btnCronograma);
            Controls.Add(btnRegistrarAula);
            Controls.Add(btnAgenda);
            Controls.Add(btnInfoUsuario);
            Controls.Add(btnSobre);
            Controls.Add(btnLogout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenuForm";
            Text = "Menu Principal";
            ResumeLayout(false);
        }
    }
}
