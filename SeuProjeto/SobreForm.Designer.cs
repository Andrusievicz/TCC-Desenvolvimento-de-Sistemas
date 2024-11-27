namespace SeuProjeto
{
    partial class SobreForm
    {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SobreForm));
            this.btnLGPD = new System.Windows.Forms.Button();
            this.btnversao = new System.Windows.Forms.Button();
            this.btnfale = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLGPD
            // 
            this.btnLGPD.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.btnLGPD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLGPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLGPD.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLGPD.Location = new System.Drawing.Point(133, 124);
            this.btnLGPD.Name = "btnLGPD";
            this.btnLGPD.Size = new System.Drawing.Size(218, 64);
            this.btnLGPD.TabIndex = 2;
            this.btnLGPD.Text = "LGPD";
            this.btnLGPD.UseVisualStyleBackColor = true;
            this.btnLGPD.Click += new System.EventHandler(this.BtnLGPD_Click);
            // 
            // btnversao
            // 
            this.btnversao.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.btnversao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnversao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnversao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnversao.Location = new System.Drawing.Point(133, 262);
            this.btnversao.Name = "btnversao";
            this.btnversao.Size = new System.Drawing.Size(218, 64);
            this.btnversao.TabIndex = 3;
            this.btnversao.Text = "Versão";
            this.btnversao.UseVisualStyleBackColor = true;
            this.btnversao.Click += new System.EventHandler(this.BtnVersao_Click);
            // 
            // btnfale
            // 
            this.btnfale.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.btnfale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfale.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnfale.Location = new System.Drawing.Point(133, 412);
            this.btnfale.Name = "btnfale";
            this.btnfale.Size = new System.Drawing.Size(218, 64);
            this.btnfale.TabIndex = 4;
            this.btnfale.Text = "Fale Conosco";
            this.btnfale.UseVisualStyleBackColor = true;
            this.btnfale.Click += new System.EventHandler(this.BtnFale_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SeuProjeto.Properties.Resources.btnmnr;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(269, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 50);
            this.button3.TabIndex = 10;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // SobreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SeuProjeto.Properties.Resources.back_sobre1;
            this.ClientSize = new System.Drawing.Size(491, 598);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnfale);
            this.Controls.Add(this.btnversao);
            this.Controls.Add(this.btnLGPD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SobreForm";
            this.Text = "Sobre";
            this.ResumeLayout(false);

        }      
        private System.Windows.Forms.Button btnLGPD;
        private System.Windows.Forms.Button btnversao;
        private System.Windows.Forms.Button btnfale;
        private System.Windows.Forms.Button button3;
    }
}