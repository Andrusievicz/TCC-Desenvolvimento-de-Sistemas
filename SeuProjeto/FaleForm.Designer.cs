namespace SeuProjeto
{
    partial class FaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaleForm));
            this.button3 = new System.Windows.Forms.Button();
            this.txtFaleConosco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SeuProjeto.Properties.Resources.btnmnr;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(144, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnLGPDBack_Click);
            // 
            // txtFaleConosco
            // 
            this.txtFaleConosco.Location = new System.Drawing.Point(87, 139);
            this.txtFaleConosco.Multiline = true;
            this.txtFaleConosco.Name = "txtFaleConosco";
            this.txtFaleConosco.Size = new System.Drawing.Size(300, 150);
            this.txtFaleConosco.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SeuProjeto.Properties.Resources.btnmnr;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalvar.Location = new System.Drawing.Point(140, 304);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(182, 50);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // FaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SeuProjeto.Properties.Resources.back_ctt;
            this.ClientSize = new System.Drawing.Size(482, 591);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtFaleConosco);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FaleForm";
            this.Text = "Fale Conosco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtFaleConosco;
        private System.Windows.Forms.Button btnSalvar;
    }
}