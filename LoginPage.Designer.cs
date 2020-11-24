using System;

namespace PICKTrainingInc
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.GroupBox();
            this.submit_button = new ePOSOne.btnProduct.Button_WOC();
            this.register_button = new ePOSOne.btnProduct.Button_WOC();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.goback_btn1 = new ePOSOne.btnProduct.Button_WOC();
            this.SignIn.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(130)))), ((int)(((byte)(19)))));
            this.UsernameLabel.Location = new System.Drawing.Point(3, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(116, 25);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username";
            // 
            // SignIn
            // 
            this.SignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignIn.Controls.Add(this.submit_button);
            this.SignIn.Controls.Add(this.register_button);
            this.SignIn.Controls.Add(this.showPassword);
            this.SignIn.Controls.Add(this.tableLayoutPanel1);
            this.SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.Color.Coral;
            this.SignIn.Location = new System.Drawing.Point(233, 79);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(467, 208);
            this.SignIn.TabIndex = 3;
            this.SignIn.TabStop = false;
            this.SignIn.Text = "Sign-In";
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.submit_button.BorderColor = System.Drawing.Color.Turquoise;
            this.submit_button.ButtonColor = System.Drawing.Color.Chartreuse;
            this.submit_button.FlatAppearance.BorderSize = 0;
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.submit_button.Location = new System.Drawing.Point(365, 143);
            this.submit_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submit_button.Name = "submit_button";
            this.submit_button.OnHoverBorderColor = System.Drawing.Color.Crimson;
            this.submit_button.OnHoverButtonColor = System.Drawing.Color.Chartreuse;
            this.submit_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.submit_button.Size = new System.Drawing.Size(97, 35);
            this.submit_button.TabIndex = 18;
            this.submit_button.Text = "Submit";
            this.submit_button.TextColor = System.Drawing.Color.Black;
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.register_button.BorderColor = System.Drawing.Color.Turquoise;
            this.register_button.ButtonColor = System.Drawing.Color.Yellow;
            this.register_button.FlatAppearance.BorderSize = 0;
            this.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_button.ForeColor = System.Drawing.Color.Transparent;
            this.register_button.Location = new System.Drawing.Point(6, 143);
            this.register_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.register_button.Name = "register_button";
            this.register_button.OnHoverBorderColor = System.Drawing.Color.Coral;
            this.register_button.OnHoverButtonColor = System.Drawing.Color.Coral;
            this.register_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.register_button.Size = new System.Drawing.Size(97, 35);
            this.register_button.TabIndex = 17;
            this.register_button.Text = "Register";
            this.register_button.TextColor = System.Drawing.Color.Black;
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(130)))), ((int)(((byte)(19)))));
            this.showPassword.Location = new System.Drawing.Point(167, 143);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(136, 20);
            this.showPassword.TabIndex = 6;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tb_password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UsernameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_userName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 40);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(231, 55);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(220, 22);
            this.tb_password.TabIndex = 5;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(130)))), ((int)(((byte)(19)))));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(231, 5);
            this.tb_userName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(220, 22);
            this.tb_userName.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(712, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "Login Please";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusStrip.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(75, 17);
            this.statusStrip.Text = "Login Please";
            this.statusStrip.Click += new System.EventHandler(this.statusStrip_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.userOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // userOptionsToolStripMenuItem
            // 
            this.userOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.userOptionsToolStripMenuItem.Name = "userOptionsToolStripMenuItem";
            this.userOptionsToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.userOptionsToolStripMenuItem.Text = "User Options";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(12, 79);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(215, 207);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // goback_btn1
            // 
            this.goback_btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goback_btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.BorderColor = System.Drawing.Color.Turquoise;
            this.goback_btn1.ButtonColor = System.Drawing.Color.YellowGreen;
            this.goback_btn1.FlatAppearance.BorderSize = 0;
            this.goback_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback_btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback_btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.Location = new System.Drawing.Point(604, 49);
            this.goback_btn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goback_btn1.Name = "goback_btn1";
            this.goback_btn1.OnHoverBorderColor = System.Drawing.Color.Coral;
            this.goback_btn1.OnHoverButtonColor = System.Drawing.Color.Coral;
            this.goback_btn1.OnHoverTextColor = System.Drawing.Color.Black;
            this.goback_btn1.Size = new System.Drawing.Size(97, 35);
            this.goback_btn1.TabIndex = 16;
            this.goback_btn1.Text = "Go Back";
            this.goback_btn1.TextColor = System.Drawing.Color.Black;
            this.goback_btn1.UseVisualStyleBackColor = false;
            this.goback_btn1.Click += new System.EventHandler(this.goback_btn1_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(712, 406);
            this.Controls.Add(this.goback_btn1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginPage";
            this.Text = "User Login Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeForm);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.SignIn.ResumeLayout(false);
            this.SignIn.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.GroupBox SignIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private ePOSOne.btnProduct.Button_WOC goback_btn1;
        private ePOSOne.btnProduct.Button_WOC submit_button;
        private ePOSOne.btnProduct.Button_WOC register_button;
    }
}
