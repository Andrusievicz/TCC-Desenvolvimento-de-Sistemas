namespace SeuProjeto
{
    partial class CrossFitForm
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

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Button btnAtividadeBack;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrossFitForm));
            this.btnAtividadeBack = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtividadeBack
            // 
            this.btnAtividadeBack.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.btnAtividadeBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtividadeBack.Location = new System.Drawing.Point(481, 445);
            this.btnAtividadeBack.Name = "btnAtividadeBack";
            this.btnAtividadeBack.Size = new System.Drawing.Size(218, 64);
            this.btnAtividadeBack.TabIndex = 1;
            this.btnAtividadeBack.Text = "Voltar";
            this.btnAtividadeBack.UseVisualStyleBackColor = true;
            this.btnAtividadeBack.Click += new System.EventHandler(this.BtnAtividadeBack_Click);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(12, 173);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(320, 180);
            this.axWindowsMediaPlayer.TabIndex = 0;
            // 
            // CrossFitForm
            // 
            this.BackgroundImage = global::SeuProjeto.Properties.Resources.BackCross;
            this.ClientSize = new System.Drawing.Size(711, 536);
            this.Controls.Add(this.btnAtividadeBack);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrossFitForm";
            this.Text = "Cross Fit";
            this.Load += new System.EventHandler(this.btnPlayVideo_Click);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }        
    }
}