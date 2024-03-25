namespace Project_Hospital
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnPatient = new System.Windows.Forms.Button();
            this.BtnDoc = new System.Windows.Forms.Button();
            this.BtnSecretary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPatient
            // 
            this.BtnPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPatient.BackgroundImage")));
            this.BtnPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPatient.Location = new System.Drawing.Point(30, 276);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Size = new System.Drawing.Size(247, 237);
            this.BtnPatient.TabIndex = 1;
            this.BtnPatient.UseVisualStyleBackColor = true;
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // BtnDoc
            // 
            this.BtnDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoc.BackgroundImage")));
            this.BtnDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoc.Location = new System.Drawing.Point(301, 280);
            this.BtnDoc.Name = "BtnDoc";
            this.BtnDoc.Size = new System.Drawing.Size(247, 237);
            this.BtnDoc.TabIndex = 2;
            this.BtnDoc.UseVisualStyleBackColor = true;
            this.BtnDoc.Click += new System.EventHandler(this.BtnDoc_Click);
            // 
            // BtnSecretary
            // 
            this.BtnSecretary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSecretary.BackgroundImage")));
            this.BtnSecretary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSecretary.Location = new System.Drawing.Point(580, 276);
            this.BtnSecretary.Name = "BtnSecretary";
            this.BtnSecretary.Size = new System.Drawing.Size(247, 237);
            this.BtnSecretary.TabIndex = 3;
            this.BtnSecretary.UseVisualStyleBackColor = true;
            this.BtnSecretary.Click += new System.EventHandler(this.BtnSecretary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "HYG HOSPITAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(594, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 52);
            this.label3.TabIndex = 7;
            this.label3.Text = "Patient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 52);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doctor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(610, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 52);
            this.label6.TabIndex = 10;
            this.label6.Text = "Secretary";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 529);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSecretary);
            this.Controls.Add(this.BtnDoc);
            this.Controls.Add(this.BtnPatient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.Button BtnDoc;
        private System.Windows.Forms.Button BtnSecretary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

