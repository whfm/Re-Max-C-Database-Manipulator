namespace prjCSWinRemax.GUI
{
    partial class frmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfo));
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.txtAbout = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_delete_35;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(234, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseStyleColors = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAbout
            // 
            // 
            // 
            // 
            this.txtAbout.CustomButton.Image = null;
            this.txtAbout.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.txtAbout.CustomButton.Name = "";
            this.txtAbout.CustomButton.Size = new System.Drawing.Size(127, 127);
            this.txtAbout.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAbout.CustomButton.TabIndex = 1;
            this.txtAbout.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAbout.CustomButton.UseSelectable = true;
            this.txtAbout.CustomButton.Visible = false;
            this.txtAbout.Enabled = false;
            this.txtAbout.Lines = new string[0];
            this.txtAbout.Location = new System.Drawing.Point(23, 116);
            this.txtAbout.MaxLength = 32767;
            this.txtAbout.Multiline = true;
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.PasswordChar = '\0';
            this.txtAbout.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAbout.SelectedText = "";
            this.txtAbout.SelectionLength = 0;
            this.txtAbout.SelectionStart = 0;
            this.txtAbout.ShortcutsEnabled = true;
            this.txtAbout.Size = new System.Drawing.Size(286, 129);
            this.txtAbout.TabIndex = 30;
            this.txtAbout.UseSelectable = true;
            this.txtAbout.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAbout.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjCSWinRemax.Properties.Resources.remax;
            this.pictureBox1.Location = new System.Drawing.Point(23, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 295);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInfo";
            this.Resizable = false;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroTextBox txtAbout;
    }
}