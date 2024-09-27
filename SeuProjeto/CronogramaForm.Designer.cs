using System.Drawing;
using System.Windows.Forms;

namespace SeuProjeto
{
    partial class CronogramaForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnCronoBack;
        private void InitializeComponent()
        {
            this.btnCronoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCronoBack
            // 
            this.btnCronoBack.Location = new System.Drawing.Point(20, 20);
            this.btnCronoBack.Name = "btnCronoBack";
            this.btnCronoBack.Size = new System.Drawing.Size(250, 30);
            this.btnCronoBack.TabIndex = 0;
            this.btnCronoBack.Text = "Voltar";
            this.btnCronoBack.UseVisualStyleBackColor = true;
            this.btnCronoBack.Click += new System.EventHandler(this.BtnCronoBack_Click);
            // 
            // CronogramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SeuProjeto.Properties.Resources.Cronograma;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 995);
            this.Controls.Add(this.btnCronoBack);
            this.Name = "CronogramaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(0, 0);
            this.Text = "Cronograma";
            this.ResumeLayout(false);

        }
    }
}