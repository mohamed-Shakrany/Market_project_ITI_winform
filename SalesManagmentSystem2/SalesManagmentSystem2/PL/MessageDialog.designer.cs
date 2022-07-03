namespace SalesManagmentSystem2.PL
{
    partial class MessageDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageDialog));
            this.MessageDialogPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.OkBtn = new DevExpress.XtraEditors.SimpleButton();
            this.MessageLabel = new System.Windows.Forms.TextBox();
            this.MessageDialogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageDialogPanel
            // 
            this.MessageDialogPanel.Controls.Add(this.MessageLabel);
            this.MessageDialogPanel.Controls.Add(this.panel1);
            this.MessageDialogPanel.Controls.Add(this.cancelBtn);
            this.MessageDialogPanel.Controls.Add(this.OkBtn);
            this.MessageDialogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageDialogPanel.Location = new System.Drawing.Point(0, 0);
            this.MessageDialogPanel.Name = "MessageDialogPanel";
            this.MessageDialogPanel.Size = new System.Drawing.Size(438, 161);
            this.MessageDialogPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 10);
            this.panel1.TabIndex = 2;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Appearance.Options.UseFont = true;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cancelBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.ImageOptions.Image")));
            this.cancelBtn.Location = new System.Drawing.Point(12, 113);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.cancelBtn.Size = new System.Drawing.Size(36, 36);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.Appearance.Options.UseFont = true;
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.OkBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("OkBtn.ImageOptions.Image")));
            this.OkBtn.Location = new System.Drawing.Point(389, 113);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.OkBtn.Size = new System.Drawing.Size(37, 36);
            this.OkBtn.TabIndex = 0;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.HideSelection = false;
            this.MessageLabel.Location = new System.Drawing.Point(12, 44);
            this.MessageLabel.Multiline = true;
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.ReadOnly = true;
            this.MessageLabel.Size = new System.Drawing.Size(414, 54);
            this.MessageLabel.TabIndex = 3;
            this.MessageLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MessageDialog
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(438, 161);
            this.ControlBox = false;
            this.Controls.Add(this.MessageDialogPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageDialog";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageDialog";
            this.MessageDialogPanel.ResumeLayout(false);
            this.MessageDialogPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MessageDialogPanel;
        private DevExpress.XtraEditors.SimpleButton OkBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox MessageLabel;
    }
}