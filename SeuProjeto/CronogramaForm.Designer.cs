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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CronogramaForm));
            this.btnCronoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCronoBack
            // 
            this.btnCronoBack.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.btnCronoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCronoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCronoBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCronoBack.Location = new System.Drawing.Point(903, 583);
            this.btnCronoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnCronoBack.Name = "btnCronoBack";
            this.btnCronoBack.Size = new System.Drawing.Size(218, 64);
            this.btnCronoBack.TabIndex = 0;
            this.btnCronoBack.Text = "Voltar";
            this.btnCronoBack.UseVisualStyleBackColor = true;
            this.btnCronoBack.Click += new System.EventHandler(this.BtnCronoBack_Click);
            // 
            // CronogramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SeuProjeto.Properties.Resources.backcronograma;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.btnCronoBack);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CronogramaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cronograma";
            this.ResumeLayout(false);

        }
    }
}