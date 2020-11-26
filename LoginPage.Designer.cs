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
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.goback_btn1 = new ePOSOne.btnProduct.Button_WOC();
            this.register_button = new ePOSOne.btnProduct.Button_WOC();
            this.submit_button = new ePOSOne.btnProduct.Button_WOC();
            this.SignIn.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Coral;
            this.UsernameLabel.Location = new System.Drawing.Point(3, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(111, 30);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username";
            // 
            // SignIn
            // 
            this.SignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignIn.Controls.Add(this.submit_button);
            this.SignIn.Controls.Add(this.showPassword);
            this.SignIn.Controls.Add(this.tableLayoutPanel1);
            this.SignIn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.Color.Coral;
            this.SignIn.Location = new System.Drawing.Point(431, 119);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(468, 193);
            this.SignIn.TabIndex = 3;
            this.SignIn.TabStop = false;
            this.SignIn.Text = "Sign-In";
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.ForeColor = System.Drawing.Color.Coral;
            this.showPassword.Location = new System.Drawing.Point(6, 143);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(123, 23);
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
            this.tb_password.Size = new System.Drawing.Size(220, 26);
            this.tb_password.TabIndex = 5;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(231, 5);
            this.tb_userName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(220, 26);
            this.tb_userName.TabIndex = 4;
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(210, 119);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(215, 193);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // button_WOC1
            // 
            this.button_WOC1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_WOC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button_WOC1.BorderColor = System.Drawing.Color.Turquoise;
            this.button_WOC1.ButtonColor = System.Drawing.Color.YellowGreen;
            this.button_WOC1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button_WOC1.Location = new System.Drawing.Point(108, 277);
            this.button_WOC1.Margin = new System.Windows.Forms.Padding(2);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Coral;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Coral;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC1.Size = new System.Drawing.Size(97, 35);
            this.button_WOC1.TabIndex = 18;
            this.button_WOC1.Text = "Exit";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.UseVisualStyleBackColor = false;
            // 
            // goback_btn1
            // 
            this.goback_btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goback_btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.BorderColor = System.Drawing.Color.Turquoise;
            this.goback_btn1.ButtonColor = System.Drawing.Color.YellowGreen;
            this.goback_btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.FlatAppearance.BorderSize = 0;
            this.goback_btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback_btn1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback_btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.Location = new System.Drawing.Point(108, 119);
            this.goback_btn1.Margin = new System.Windows.Forms.Padding(2);
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
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.register_button.BorderColor = System.Drawing.Color.Turquoise;
            this.register_button.ButtonColor = System.Drawing.Color.Yellow;
            this.register_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.register_button.FlatAppearance.BorderSize = 0;
            this.register_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.register_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_button.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.Color.Transparent;
            this.register_button.Location = new System.Drawing.Point(108, 204);
            this.register_button.Margin = new System.Windows.Forms.Padding(2);
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
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.submit_button.BorderColor = System.Drawing.Color.Turquoise;
            this.submit_button.ButtonColor = System.Drawing.Color.Chartreuse;
            this.submit_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.submit_button.FlatAppearance.BorderSize = 0;
            this.submit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.submit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.submit_button.Location = new System.Drawing.Point(364, 147);
            this.submit_button.Margin = new System.Windows.Forms.Padding(2);
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
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1108, 486);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.goback_btn1);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.Text = "User Login Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeForm);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.SignIn.ResumeLayout(false);
            this.SignIn.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.GroupBox SignIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox showPassword;
        private ePOSOne.btnProduct.Button_WOC goback_btn1;
        private ePOSOne.btnProduct.Button_WOC submit_button;
        private ePOSOne.btnProduct.Button_WOC register_button;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}
