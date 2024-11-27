using System.Windows.Forms;

namespace SeuProjeto
{
    partial class AtividadeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAtividadeBack;
        private Button button1;
        private Button button2;
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtividadeForm));
            this.btnAtividadeBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtividadeBack
            // 
            this.btnAtividadeBack.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.btnAtividadeBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtividadeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtividadeBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtividadeBack.Location = new System.Drawing.Point(976, 572);
            this.btnAtividadeBack.Name = "btnAtividadeBack";
            this.btnAtividadeBack.Size = new System.Drawing.Size(218, 64);
            this.btnAtividadeBack.TabIndex = 0;
            this.btnAtividadeBack.Text = "Voltar";
            this.btnAtividadeBack.UseVisualStyleBackColor = true;
            this.btnAtividadeBack.Click += new System.EventHandler(this.BtnAtividadeBack_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(131, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cross Fit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnCrossFit_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(131, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Muay Thai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnMuayThai_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(131, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "Spinning";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnSpinning_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(493, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 64);
            this.button4.TabIndex = 3;
            this.button4.Text = "Yoga";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnYoga_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(493, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(218, 64);
            this.button5.TabIndex = 4;
            this.button5.Text = "Pilates";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BtnPilates_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button6.Location = new System.Drawing.Point(493, 473);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(218, 64);
            this.button6.TabIndex = 5;
            this.button6.Text = "Musculação";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BtnMusculacao_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button7.Location = new System.Drawing.Point(854, 149);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(218, 64);
            this.button7.TabIndex = 6;
            this.button7.Text = "Boxe";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.BtnBoxe_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button8.Location = new System.Drawing.Point(854, 316);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(218, 64);
            this.button8.TabIndex = 7;
            this.button8.Text = "Capoeira";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BtnCapoeira_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::SeuProjeto.Properties.Resources.Alecrim;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button9.Location = new System.Drawing.Point(854, 475);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(218, 64);
            this.button9.TabIndex = 8;
            this.button9.Text = "Zumba";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.BtnZumba_Click);
            // 
            // AtividadeForm
            // 
            this.BackgroundImage = global::SeuProjeto.Properties.Resources.FormAtividade;
            this.ClientSize = new System.Drawing.Size(1199, 649);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAtividadeBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtividadeForm";
            this.Text = "Atividades";
            this.ResumeLayout(false);

        }

        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}