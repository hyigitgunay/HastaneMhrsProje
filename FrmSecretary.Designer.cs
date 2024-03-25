namespace Project_Hospital
{
    partial class FrmSecretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretary));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linklblSignUp = new System.Windows.Forms.LinkLabel();
            this.MskdTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 62);
            this.label3.TabIndex = 14;
            this.label3.Text = "HYG HOSPITAL";
            // 
            // linklblSignUp
            // 
            this.linklblSignUp.AutoSize = true;
            this.linklblSignUp.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklblSignUp.Location = new System.Drawing.Point(208, 284);
            this.linklblSignUp.Name = "linklblSignUp";
            this.linklblSignUp.Size = new System.Drawing.Size(108, 34);
            this.linklblSignUp.TabIndex = 13;
            this.linklblSignUp.TabStop = true;
            this.linklblSignUp.Text = "SignUp";
            // 
            // MskdTC
            // 
            this.MskdTC.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskdTC.Location = new System.Drawing.Point(205, 164);
            this.MskdTC.Mask = "00000000000";
            this.MskdTC.Name = "MskdTC";
            this.MskdTC.Size = new System.Drawing.Size(358, 41);
            this.MskdTC.TabIndex = 12;
            this.MskdTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Secretary Tc :";
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPass.Location = new System.Drawing.Point(205, 221);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(358, 41);
            this.TxtPass.TabIndex = 10;
            this.TxtPass.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.Location = new System.Drawing.Point(322, 268);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(241, 60);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password :";
            // 
            // FrmSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(644, 372);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linklblSignUp);
            this.Controls.Add(this.MskdTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label1);
            this.Name = "FrmSecretary";
            this.Text = "Secretary Login Screen";
            this.Load += new System.EventHandler(this.FrmSecretary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linklblSignUp;
        private System.Windows.Forms.MaskedTextBox MskdTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label1;
    }
}