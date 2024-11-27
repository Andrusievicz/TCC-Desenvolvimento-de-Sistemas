namespace SeuProjeto
{
    partial class LoginSucedidoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSucedidoForm));
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(59, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login bem-sucedido!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseWaitCursor = true;
            // 
            // LoginSucedidoForm
            // 
            this.BackgroundImage = global::SeuProjeto.Properties.Resources.LoginBemSucedido;
            this.ClientSize = new System.Drawing.Size(362, 152);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginSucedidoForm";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}