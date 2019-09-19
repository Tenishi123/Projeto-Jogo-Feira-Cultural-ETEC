namespace projetoJogo1
{
    partial class MensagemBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensagemBox));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.pctUsuario1 = new System.Windows.Forms.PictureBox();
            this.pctPonto2 = new System.Windows.Forms.PictureBox();
            this.pctPonto1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPonto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPonto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblMensagem.Location = new System.Drawing.Point(22, 119);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 25);
            this.lblMensagem.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Red;
            this.btnFechar.Location = new System.Drawing.Point(691, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(39, 43);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJogar.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnJogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.Color.Lime;
            this.btnJogar.Location = new System.Drawing.Point(222, 383);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(232, 56);
            this.btnJogar.TabIndex = 20;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            // 
            // pctUsuario1
            // 
            this.pctUsuario1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctUsuario1.Image = global::projetoJogo1.Properties.Resources._2019_09_19_17_08_59;
            this.pctUsuario1.Location = new System.Drawing.Point(537, 286);
            this.pctUsuario1.Name = "pctUsuario1";
            this.pctUsuario1.Size = new System.Drawing.Size(64, 67);
            this.pctUsuario1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUsuario1.TabIndex = 26;
            this.pctUsuario1.TabStop = false;
            this.pctUsuario1.Click += new System.EventHandler(this.PctUsuario1_Click);
            // 
            // pctPonto2
            // 
            this.pctPonto2.Image = global::projetoJogo1.Properties.Resources.pontoNetIcone2;
            this.pctPonto2.Location = new System.Drawing.Point(377, 286);
            this.pctPonto2.Name = "pctPonto2";
            this.pctPonto2.Size = new System.Drawing.Size(68, 67);
            this.pctPonto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPonto2.TabIndex = 25;
            this.pctPonto2.TabStop = false;
            this.pctPonto2.Click += new System.EventHandler(this.PctPonto2_Click);
            // 
            // pctPonto1
            // 
            this.pctPonto1.Image = global::projetoJogo1.Properties.Resources.pontoNetIcone2;
            this.pctPonto1.Location = new System.Drawing.Point(222, 286);
            this.pctPonto1.Name = "pctPonto1";
            this.pctPonto1.Size = new System.Drawing.Size(68, 67);
            this.pctPonto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPonto1.TabIndex = 22;
            this.pctPonto1.TabStop = false;
            this.pctPonto1.Click += new System.EventHandler(this.PctPonto1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // MensagemBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(742, 460);
            this.Controls.Add(this.pctUsuario1);
            this.Controls.Add(this.pctPonto2);
            this.Controls.Add(this.pctPonto1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MensagemBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MensagemBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPonto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPonto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctPonto1;
        private System.Windows.Forms.PictureBox pctPonto2;
        private System.Windows.Forms.PictureBox pctUsuario1;
    }
}