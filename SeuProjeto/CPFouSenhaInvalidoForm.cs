using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeuProjeto
{
    public partial class CPFouSenhaInvalidoForm : Form
    {
        private Timer timer; //variavel do timer
        public CPFouSenhaInvalidoForm()
        {
            InitializeComponent();
            //criação do timer
            timer = new Timer();
            timer.Interval = 1500;//timer pra 1,5s
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        //evento do timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPFouSenhaInvalidoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(73, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF ou Senha invalidos!";
            // 
            // CPFouSenhaInvalidoForm
            // 
            this.BackgroundImage = global::SeuProjeto.Properties.Resources.LoginBemSucedido;
            this.ClientSize = new System.Drawing.Size(362, 152);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CPFouSenhaInvalidoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
