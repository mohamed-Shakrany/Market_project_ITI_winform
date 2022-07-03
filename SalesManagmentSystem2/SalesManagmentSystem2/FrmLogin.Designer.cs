namespace SalesManagmentSystem2
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnCancel);
            this.pnlContent.Controls.Add(this.pictureBox1);
            this.pnlContent.Controls.Add(this.btnLogin);
            this.pnlContent.Controls.Add(this.panel2);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.panel3);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContent.Location = new System.Drawing.Point(0, 101);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(604, 291);
            this.pnlContent.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(193, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(397, 49);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "الغاء";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnLogin.Location = new System.Drawing.Point(193, 176);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(397, 49);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "تسجيل الدخول";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(196, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 44);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(453, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "اسم المستخدم";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(196, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 44);
            this.panel3.TabIndex = 9;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(604, 100);
            this.pnlTop.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(198, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "تسجيل الدخول";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 392);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label3;
    }
}