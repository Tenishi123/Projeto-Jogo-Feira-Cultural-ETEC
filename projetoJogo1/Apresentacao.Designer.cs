namespace projetoJogo1
{
    partial class Apresentacao
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
            this.btnProApresentacao = new System.Windows.Forms.Button();
            this.btnAnApresentacao = new System.Windows.Forms.Button();
            this.lblMengsApresentacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProApresentacao
            // 
            this.btnProApresentacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProApresentacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProApresentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProApresentacao.Location = new System.Drawing.Point(661, 426);
            this.btnProApresentacao.Name = "btnProApresentacao";
            this.btnProApresentacao.Size = new System.Drawing.Size(232, 56);
            this.btnProApresentacao.TabIndex = 0;
            this.btnProApresentacao.Text = "Proximo";
            this.btnProApresentacao.UseVisualStyleBackColor = true;
            this.btnProApresentacao.Click += new System.EventHandler(this.BtnProApresentacao_Click);
            // 
            // btnAnApresentacao
            // 
            this.btnAnApresentacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnApresentacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnApresentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnApresentacao.Location = new System.Drawing.Point(12, 426);
            this.btnAnApresentacao.Name = "btnAnApresentacao";
            this.btnAnApresentacao.Size = new System.Drawing.Size(232, 56);
            this.btnAnApresentacao.TabIndex = 1;
            this.btnAnApresentacao.Text = "Anterior";
            this.btnAnApresentacao.UseVisualStyleBackColor = true;
            this.btnAnApresentacao.Visible = false;
            this.btnAnApresentacao.Click += new System.EventHandler(this.BtnAnApresentacao_Click);
            // 
            // lblMengsApresentacao
            // 
            this.lblMengsApresentacao.AutoSize = true;
            this.lblMengsApresentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMengsApresentacao.Location = new System.Drawing.Point(12, 47);
            this.lblMengsApresentacao.Name = "lblMengsApresentacao";
            this.lblMengsApresentacao.Size = new System.Drawing.Size(546, 51);
            this.lblMengsApresentacao.TabIndex = 2;
            this.lblMengsApresentacao.Text = "Bem vindo ao Jogo da NET";
            // 
            // Apresentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 516);
            this.Controls.Add(this.lblMengsApresentacao);
            this.Controls.Add(this.btnAnApresentacao);
            this.Controls.Add(this.btnProApresentacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Apresentacao";
            this.Text = "Apresentacao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProApresentacao;
        private System.Windows.Forms.Button btnAnApresentacao;
        private System.Windows.Forms.Label lblMengsApresentacao;
    }
}