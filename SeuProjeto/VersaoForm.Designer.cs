namespace SeuProjeto
{
    partial class VersaoForm
    {        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersaoForm));
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SeuProjeto.Properties.Resources.btnmnr;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(153, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 50);
            this.button3.TabIndex = 12;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnLGPDBack_Click);
            // 
            // VersaoForm
            // 
            this.BackgroundImage = global::SeuProjeto.Properties.Resources.back_versao;
            this.ClientSize = new System.Drawing.Size(498, 602);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VersaoForm";
            this.Text = "Versão";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button3;
    }
}