namespace TAILORING
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.picIMGPass = new System.Windows.Forms.PictureBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.gGlowGroupBox1 = new gGlowBox.gGlowGroupBox();
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.gGlowGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(299, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(299, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(132, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 104);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.gGlowGroupBox1.SetEffectType(this.txtPassword, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(98, 67);
            this.txtPassword.Name = "txtPassword";
            this.gGlowGroupBox1.SetsGlowColor(this.txtPassword, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtPassword.sGlowColor"))));
            this.txtPassword.Size = new System.Drawing.Size(201, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.gGlowGroupBox1.SetEffectType(this.txtUserName, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(98, 13);
            this.txtUserName.Name = "txtUserName";
            this.gGlowGroupBox1.SetsGlowColor(this.txtUserName, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtUserName.sGlowColor"))));
            this.txtUserName.Size = new System.Drawing.Size(201, 26);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Passowrd :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "User Name :";
            // 
            // linkForgotPassword
            // 
            this.linkForgotPassword.AutoSize = true;
            this.linkForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.linkForgotPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgotPassword.Location = new System.Drawing.Point(128, 396);
            this.linkForgotPassword.Name = "linkForgotPassword";
            this.linkForgotPassword.Size = new System.Drawing.Size(121, 19);
            this.linkForgotPassword.TabIndex = 3;
            this.linkForgotPassword.TabStop = true;
            this.linkForgotPassword.Text = "Forgot Password?";
            this.linkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPassword_LinkClicked);
            // 
            // picIMGPass
            // 
            this.picIMGPass.BackColor = System.Drawing.Color.Transparent;
            this.picIMGPass.Image = ((System.Drawing.Image)(resources.GetObject("picIMGPass.Image")));
            this.picIMGPass.Location = new System.Drawing.Point(313, 67);
            this.picIMGPass.Name = "picIMGPass";
            this.picIMGPass.Size = new System.Drawing.Size(31, 25);
            this.picIMGPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIMGPass.TabIndex = 215;
            this.picIMGPass.TabStop = false;
            this.picIMGPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIMGPass_MouseDown);
            this.picIMGPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picIMGPass_MouseUp);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label3);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.kryptonPanel1.Size = new System.Drawing.Size(363, 42);
            this.kryptonPanel1.TabIndex = 216;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 22);
            this.label3.TabIndex = 217;
            this.label3.Text = "Enter Your Login Details :";
            // 
            // gGlowGroupBox1
            // 
            this.gGlowGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gGlowGroupBox1.Controls.Add(this.txtUserName);
            this.gGlowGroupBox1.Controls.Add(this.label2);
            this.gGlowGroupBox1.Controls.Add(this.picIMGPass);
            this.gGlowGroupBox1.Controls.Add(this.label1);
            this.gGlowGroupBox1.Controls.Add(this.txtPassword);
            this.gGlowGroupBox1.Controls.Add(this.label5);
            this.gGlowGroupBox1.Controls.Add(this.label4);
            this.gGlowGroupBox1.GlowAmount = 20;
            this.gGlowGroupBox1.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gGlowGroupBox1.GlowFeather = 50;
            this.gGlowGroupBox1.GlowOn = true;
            this.gGlowGroupBox1.Location = new System.Drawing.Point(8, 205);
            this.gGlowGroupBox1.Name = "gGlowGroupBox1";
            this.gGlowGroupBox1.Size = new System.Drawing.Size(347, 112);
            this.gGlowGroupBox1.TabIndex = 217;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(149, 323);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnLogin.Size = new System.Drawing.Size(100, 36);
            this.btnLogin.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.TabIndex = 218;
            this.btnLogin.Values.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(363, 455);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.gGlowGroupBox1);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.linkForgotPassword);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.gGlowGroupBox1.ResumeLayout(false);
            this.gGlowGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkForgotPassword;
        private System.Windows.Forms.PictureBox picIMGPass;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label3;
        private gGlowBox.gGlowGroupBox gGlowGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
    }
}