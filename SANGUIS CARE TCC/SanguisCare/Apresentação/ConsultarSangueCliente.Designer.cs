namespace Login
{
    partial class ConsultarSangueCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarSangueCliente));
            this.lblTipoSangueConsulta = new System.Windows.Forms.Label();
            this.lblRhSangueConsulta = new System.Windows.Forms.Label();
            this.lblTotalSangueConsulta = new System.Windows.Forms.Label();
            this.txbTotalSangueConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultarSangue = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cboxTipoSangueConsulta = new System.Windows.Forms.ComboBox();
            this.cboxRhSangueConsulta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoSangueConsulta
            // 
            this.lblTipoSangueConsulta.AutoSize = true;
            this.lblTipoSangueConsulta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipoSangueConsulta.Font = new System.Drawing.Font("GinW00-Round", 18F, System.Drawing.FontStyle.Bold);
            this.lblTipoSangueConsulta.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTipoSangueConsulta.Location = new System.Drawing.Point(37, 157);
            this.lblTipoSangueConsulta.Name = "lblTipoSangueConsulta";
            this.lblTipoSangueConsulta.Size = new System.Drawing.Size(56, 30);
            this.lblTipoSangueConsulta.TabIndex = 1;
            this.lblTipoSangueConsulta.Text = "Tipo";
            this.lblTipoSangueConsulta.Click += new System.EventHandler(this.lblTipoSangueConsulta_Click);
            // 
            // lblRhSangueConsulta
            // 
            this.lblRhSangueConsulta.AutoSize = true;
            this.lblRhSangueConsulta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRhSangueConsulta.Font = new System.Drawing.Font("GinW00-Round", 18F, System.Drawing.FontStyle.Bold);
            this.lblRhSangueConsulta.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRhSangueConsulta.Location = new System.Drawing.Point(37, 210);
            this.lblRhSangueConsulta.Name = "lblRhSangueConsulta";
            this.lblRhSangueConsulta.Size = new System.Drawing.Size(39, 30);
            this.lblRhSangueConsulta.TabIndex = 2;
            this.lblRhSangueConsulta.Text = "RH";
            // 
            // lblTotalSangueConsulta
            // 
            this.lblTotalSangueConsulta.AutoSize = true;
            this.lblTotalSangueConsulta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalSangueConsulta.Font = new System.Drawing.Font("GinW00-Round", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalSangueConsulta.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTotalSangueConsulta.Location = new System.Drawing.Point(37, 296);
            this.lblTotalSangueConsulta.Name = "lblTotalSangueConsulta";
            this.lblTotalSangueConsulta.Size = new System.Drawing.Size(73, 30);
            this.lblTotalSangueConsulta.TabIndex = 4;
            this.lblTotalSangueConsulta.Text = "Total";
            // 
            // txbTotalSangueConsulta
            // 
            this.txbTotalSangueConsulta.Enabled = false;
            this.txbTotalSangueConsulta.Location = new System.Drawing.Point(123, 306);
            this.txbTotalSangueConsulta.Name = "txbTotalSangueConsulta";
            this.txbTotalSangueConsulta.Size = new System.Drawing.Size(81, 20);
            this.txbTotalSangueConsulta.TabIndex = 7;
            // 
            // btnConsultarSangue
            // 
            this.btnConsultarSangue.BackColor = System.Drawing.Color.IndianRed;
            this.btnConsultarSangue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarSangue.Font = new System.Drawing.Font("GinW00-Round", 18F, System.Drawing.FontStyle.Bold);
            this.btnConsultarSangue.ForeColor = System.Drawing.Color.White;
            this.btnConsultarSangue.Location = new System.Drawing.Point(42, 431);
            this.btnConsultarSangue.Name = "btnConsultarSangue";
            this.btnConsultarSangue.Size = new System.Drawing.Size(143, 39);
            this.btnConsultarSangue.TabIndex = 8;
            this.btnConsultarSangue.Text = "Consultar";
            this.btnConsultarSangue.UseVisualStyleBackColor = false;
            this.btnConsultarSangue.Click += new System.EventHandler(this.btnConsultarSangue_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("GinW00-Round", 18F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSair.Location = new System.Drawing.Point(663, 431);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 40);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(543, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(126, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // cboxTipoSangueConsulta
            // 
            this.cboxTipoSangueConsulta.FormattingEnabled = true;
            this.cboxTipoSangueConsulta.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.cboxTipoSangueConsulta.Location = new System.Drawing.Point(123, 166);
            this.cboxTipoSangueConsulta.Name = "cboxTipoSangueConsulta";
            this.cboxTipoSangueConsulta.Size = new System.Drawing.Size(121, 21);
            this.cboxTipoSangueConsulta.TabIndex = 12;
            // 
            // cboxRhSangueConsulta
            // 
            this.cboxRhSangueConsulta.FormattingEnabled = true;
            this.cboxRhSangueConsulta.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cboxRhSangueConsulta.Location = new System.Drawing.Point(123, 219);
            this.cboxRhSangueConsulta.Name = "cboxRhSangueConsulta";
            this.cboxRhSangueConsulta.Size = new System.Drawing.Size(121, 21);
            this.cboxRhSangueConsulta.TabIndex = 13;
            // 
            // ConsultarSangueCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(814, 518);
            this.Controls.Add(this.cboxRhSangueConsulta);
            this.Controls.Add(this.cboxTipoSangueConsulta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConsultarSangue);
            this.Controls.Add(this.txbTotalSangueConsulta);
            this.Controls.Add(this.lblTotalSangueConsulta);
            this.Controls.Add(this.lblRhSangueConsulta);
            this.Controls.Add(this.lblTipoSangueConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarSangueCliente";
            this.Text = "ConsultarSangueCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoSangueConsulta;
        private System.Windows.Forms.Label lblRhSangueConsulta;
        private System.Windows.Forms.Label lblTotalSangueConsulta;
        private System.Windows.Forms.TextBox txbTotalSangueConsulta;
        private System.Windows.Forms.Button btnConsultarSangue;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cboxTipoSangueConsulta;
        private System.Windows.Forms.ComboBox cboxRhSangueConsulta;
    }
}