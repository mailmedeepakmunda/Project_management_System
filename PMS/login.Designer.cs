
namespace PMS
{
    partial class login
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
            this.mlblUsrNm = new MetroFramework.Controls.MetroLabel();
            this.mtxtUsr = new MetroFramework.Controls.MetroTextBox();
            this.mlblPwd = new MetroFramework.Controls.MetroLabel();
            this.mtxtPwd = new MetroFramework.Controls.MetroTextBox();
            this.mbtnLgn = new MetroFramework.Controls.MetroButton();
            this.mbtnCncl = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mlblStatus = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mlblUsrNm
            // 
            this.mlblUsrNm.AutoSize = true;
            this.mlblUsrNm.Location = new System.Drawing.Point(22, 20);
            this.mlblUsrNm.Name = "mlblUsrNm";
            this.mlblUsrNm.Size = new System.Drawing.Size(71, 19);
            this.mlblUsrNm.TabIndex = 0;
            this.mlblUsrNm.Text = "UserName";
            // 
            // mtxtUsr
            // 
            // 
            // 
            // 
            this.mtxtUsr.CustomButton.Image = null;
            this.mtxtUsr.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.mtxtUsr.CustomButton.Name = "";
            this.mtxtUsr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtUsr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsr.CustomButton.TabIndex = 1;
            this.mtxtUsr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsr.CustomButton.UseSelectable = true;
            this.mtxtUsr.CustomButton.Visible = false;
            this.mtxtUsr.Lines = new string[0];
            this.mtxtUsr.Location = new System.Drawing.Point(164, 16);
            this.mtxtUsr.MaxLength = 32767;
            this.mtxtUsr.Name = "mtxtUsr";
            this.mtxtUsr.PasswordChar = '\0';
            this.mtxtUsr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsr.SelectedText = "";
            this.mtxtUsr.SelectionLength = 0;
            this.mtxtUsr.SelectionStart = 0;
            this.mtxtUsr.ShortcutsEnabled = true;
            this.mtxtUsr.Size = new System.Drawing.Size(190, 23);
            this.mtxtUsr.TabIndex = 1;
            this.mtxtUsr.UseSelectable = true;
            this.mtxtUsr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblPwd
            // 
            this.mlblPwd.AutoSize = true;
            this.mlblPwd.Location = new System.Drawing.Point(22, 81);
            this.mlblPwd.Name = "mlblPwd";
            this.mlblPwd.Size = new System.Drawing.Size(63, 19);
            this.mlblPwd.TabIndex = 0;
            this.mlblPwd.Text = "Password";
            // 
            // mtxtPwd
            // 
            // 
            // 
            // 
            this.mtxtPwd.CustomButton.Image = null;
            this.mtxtPwd.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.mtxtPwd.CustomButton.Name = "";
            this.mtxtPwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPwd.CustomButton.TabIndex = 1;
            this.mtxtPwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPwd.CustomButton.UseSelectable = true;
            this.mtxtPwd.CustomButton.Visible = false;
            this.mtxtPwd.Lines = new string[0];
            this.mtxtPwd.Location = new System.Drawing.Point(164, 77);
            this.mtxtPwd.MaxLength = 32767;
            this.mtxtPwd.Name = "mtxtPwd";
            this.mtxtPwd.PasswordChar = '●';
            this.mtxtPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPwd.SelectedText = "";
            this.mtxtPwd.SelectionLength = 0;
            this.mtxtPwd.SelectionStart = 0;
            this.mtxtPwd.ShortcutsEnabled = true;
            this.mtxtPwd.Size = new System.Drawing.Size(190, 23);
            this.mtxtPwd.TabIndex = 2;
            this.mtxtPwd.UseSelectable = true;
            this.mtxtPwd.UseSystemPasswordChar = true;
            this.mtxtPwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnLgn
            // 
            this.mbtnLgn.Location = new System.Drawing.Point(166, 134);
            this.mbtnLgn.Name = "mbtnLgn";
            this.mbtnLgn.Size = new System.Drawing.Size(75, 23);
            this.mbtnLgn.TabIndex = 3;
            this.mbtnLgn.Text = "LOGIN";
            this.mbtnLgn.UseSelectable = true;
            this.mbtnLgn.Click += new System.EventHandler(this.mbtnLgn_Click);
            // 
            // mbtnCncl
            // 
            this.mbtnCncl.Location = new System.Drawing.Point(279, 134);
            this.mbtnCncl.Name = "mbtnCncl";
            this.mbtnCncl.Size = new System.Drawing.Size(75, 23);
            this.mbtnCncl.TabIndex = 4;
            this.mbtnCncl.Text = "CANCEL";
            this.mbtnCncl.UseSelectable = true;
            this.mbtnCncl.Click += new System.EventHandler(this.mbtnCncl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mbtnCncl);
            this.groupBox1.Controls.Add(this.mbtnLgn);
            this.groupBox1.Controls.Add(this.mtxtPwd);
            this.groupBox1.Controls.Add(this.mtxtUsr);
            this.groupBox1.Controls.Add(this.mlblPwd);
            this.groupBox1.Controls.Add(this.mlblUsrNm);
            this.groupBox1.Location = new System.Drawing.Point(319, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 174);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PMS.Properties.Resources.admin_settings_male;
            this.pictureBox1.Location = new System.Drawing.Point(29, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // mlblStatus
            // 
            this.mlblStatus.AutoSize = true;
            this.mlblStatus.Location = new System.Drawing.Point(598, 286);
            this.mlblStatus.Name = "mlblStatus";
            this.mlblStatus.Size = new System.Drawing.Size(0, 0);
            this.mlblStatus.TabIndex = 6;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 335);
            this.Controls.Add(this.mlblStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Movable = false;
            this.Name = "login";
            this.Resizable = false;
            this.Text = "PMS";
            this.Load += new System.EventHandler(this.login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlblUsrNm;
        private MetroFramework.Controls.MetroTextBox mtxtUsr;
        private MetroFramework.Controls.MetroLabel mlblPwd;
        private MetroFramework.Controls.MetroTextBox mtxtPwd;
        private MetroFramework.Controls.MetroButton mbtnLgn;
        private MetroFramework.Controls.MetroButton mbtnCncl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel mlblStatus;
    }
}

