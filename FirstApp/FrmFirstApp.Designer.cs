namespace FirstApp
{
    partial class FrmFirstApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirstApp));
            this.lblTitle = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.PicTitle = new System.Windows.Forms.PictureBox();
            this.BtnWelcome = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(223, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(339, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome To My Program";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(229, 114);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(333, 20);
            this.TxtUserName.TabIndex = 1;
            this.TxtUserName.Text = "Default Text";
            // 
            // PicTitle
            // 
            this.PicTitle.Image = ((System.Drawing.Image)(resources.GetObject("PicTitle.Image")));
            this.PicTitle.Location = new System.Drawing.Point(230, 168);
            this.PicTitle.Name = "PicTitle";
            this.PicTitle.Size = new System.Drawing.Size(331, 187);
            this.PicTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTitle.TabIndex = 2;
            this.PicTitle.TabStop = false;
            this.PicTitle.Click += new System.EventHandler(this.PicTitle_Click);
            // 
            // BtnWelcome
            // 
            this.BtnWelcome.Location = new System.Drawing.Point(233, 413);
            this.BtnWelcome.Name = "BtnWelcome";
            this.BtnWelcome.Size = new System.Drawing.Size(139, 55);
            this.BtnWelcome.TabIndex = 3;
            this.BtnWelcome.Text = "Welcome";
            this.BtnWelcome.UseVisualStyleBackColor = true;
            this.BtnWelcome.Click += new System.EventHandler(this.BtnWelcome_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(425, 413);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(137, 55);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmFirstApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(805, 680);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnWelcome);
            this.Controls.Add(this.PicTitle);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmFirstApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstApp";
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.PictureBox PicTitle;
        private System.Windows.Forms.Button BtnWelcome;
        private System.Windows.Forms.Button BtnExit;
    }
}

