namespace PICKTrainingInc
{
    partial class MainTrainingPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTrainingPage));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbl_answers = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_stats = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.currentUser = new System.Windows.Forms.Label();
            this.allUsers = new System.Windows.Forms.Label();
            this.totalAnswered = new System.Windows.Forms.Label();
            this.totalCorrect = new System.Windows.Forms.Label();
            this.totalWrong = new System.Windows.Forms.Label();
            this.currentUserCorrect = new System.Windows.Forms.Label();
            this.currentUserWrong = new System.Windows.Forms.Label();
            this.currentUserTotal = new System.Windows.Forms.Label();
            this.allUserCorrect = new System.Windows.Forms.Label();
            this.allUserWrong = new System.Windows.Forms.Label();
            this.allUserTotal = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PICKTrainingInc.DataSet1();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pb_question = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goback = new ePOSOne.btnProduct.Button_WOC();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.DashboardBut = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gitHubButton = new System.Windows.Forms.PictureBox();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbl_answers.SuspendLayout();
            this.gb_stats.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitHubButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(13, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(105, 85);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbl_answers);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(666, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 371);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Your Answer";
            // 
            // tbl_answers
            // 
            this.tbl_answers.ColumnCount = 3;
            this.tbl_answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_answers.Controls.Add(this.button1, 0, 0);
            this.tbl_answers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_answers.Location = new System.Drawing.Point(3, 22);
            this.tbl_answers.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbl_answers.Name = "tbl_answers";
            this.tbl_answers.RowCount = 5;
            this.tbl_answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_answers.Size = new System.Drawing.Size(322, 346);
            this.tbl_answers.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(8, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Andy Warhol";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gb_stats
            // 
            this.gb_stats.Controls.Add(this.tableLayoutPanel2);
            this.gb_stats.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_stats.Location = new System.Drawing.Point(198, 131);
            this.gb_stats.Name = "gb_stats";
            this.gb_stats.Size = new System.Drawing.Size(417, 75);
            this.gb_stats.TabIndex = 5;
            this.gb_stats.TabStop = false;
            this.gb_stats.Text = "Question Statistics";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel2.Controls.Add(this.currentUser, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.allUsers, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.totalAnswered, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.totalCorrect, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.totalWrong, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.currentUserCorrect, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.currentUserWrong, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.currentUserTotal, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.allUserCorrect, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.allUserWrong, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.allUserTotal, 2, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 18);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(407, 52);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // currentUser
            // 
            this.currentUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentUser.AutoSize = true;
            this.currentUser.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUser.Location = new System.Drawing.Point(177, 0);
            this.currentUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(77, 13);
            this.currentUser.TabIndex = 3;
            this.currentUser.Text = "Current User";
            // 
            // allUsers
            // 
            this.allUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allUsers.AutoSize = true;
            this.allUsers.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUsers.Location = new System.Drawing.Point(319, 0);
            this.allUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allUsers.Name = "allUsers";
            this.allUsers.Size = new System.Drawing.Size(56, 13);
            this.allUsers.TabIndex = 2;
            this.allUsers.Text = "All Users";
            // 
            // totalAnswered
            // 
            this.totalAnswered.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalAnswered.AutoSize = true;
            this.totalAnswered.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAnswered.Location = new System.Drawing.Point(57, 39);
            this.totalAnswered.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalAnswered.Name = "totalAnswered";
            this.totalAnswered.Size = new System.Drawing.Size(85, 13);
            this.totalAnswered.TabIndex = 1;
            this.totalAnswered.Text = "Total Answered";
            // 
            // totalCorrect
            // 
            this.totalCorrect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalCorrect.AutoSize = true;
            this.totalCorrect.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCorrect.Location = new System.Drawing.Point(69, 13);
            this.totalCorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCorrect.Name = "totalCorrect";
            this.totalCorrect.Size = new System.Drawing.Size(73, 13);
            this.totalCorrect.TabIndex = 5;
            this.totalCorrect.Text = "Total Correct";
            // 
            // totalWrong
            // 
            this.totalWrong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalWrong.AutoSize = true;
            this.totalWrong.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalWrong.Location = new System.Drawing.Point(73, 26);
            this.totalWrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalWrong.Name = "totalWrong";
            this.totalWrong.Size = new System.Drawing.Size(69, 13);
            this.totalWrong.TabIndex = 4;
            this.totalWrong.Text = "Total Wrong";
            // 
            // currentUserCorrect
            // 
            this.currentUserCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentUserCorrect.AutoSize = true;
            this.currentUserCorrect.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserCorrect.Location = new System.Drawing.Point(206, 13);
            this.currentUserCorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUserCorrect.Name = "currentUserCorrect";
            this.currentUserCorrect.Size = new System.Drawing.Size(19, 13);
            this.currentUserCorrect.TabIndex = 6;
            this.currentUserCorrect.Text = "50";
            // 
            // currentUserWrong
            // 
            this.currentUserWrong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentUserWrong.AutoSize = true;
            this.currentUserWrong.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserWrong.Location = new System.Drawing.Point(206, 26);
            this.currentUserWrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUserWrong.Name = "currentUserWrong";
            this.currentUserWrong.Size = new System.Drawing.Size(19, 13);
            this.currentUserWrong.TabIndex = 7;
            this.currentUserWrong.Text = "10";
            // 
            // currentUserTotal
            // 
            this.currentUserTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentUserTotal.AutoSize = true;
            this.currentUserTotal.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserTotal.Location = new System.Drawing.Point(206, 39);
            this.currentUserTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUserTotal.Name = "currentUserTotal";
            this.currentUserTotal.Size = new System.Drawing.Size(19, 13);
            this.currentUserTotal.TabIndex = 8;
            this.currentUserTotal.Text = "60";
            // 
            // allUserCorrect
            // 
            this.allUserCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allUserCorrect.AutoSize = true;
            this.allUserCorrect.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUserCorrect.Location = new System.Drawing.Point(335, 13);
            this.allUserCorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allUserCorrect.Name = "allUserCorrect";
            this.allUserCorrect.Size = new System.Drawing.Size(25, 13);
            this.allUserCorrect.TabIndex = 9;
            this.allUserCorrect.Text = "100";
            // 
            // allUserWrong
            // 
            this.allUserWrong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allUserWrong.AutoSize = true;
            this.allUserWrong.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUserWrong.Location = new System.Drawing.Point(338, 26);
            this.allUserWrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allUserWrong.Name = "allUserWrong";
            this.allUserWrong.Size = new System.Drawing.Size(19, 13);
            this.allUserWrong.TabIndex = 10;
            this.allUserWrong.Text = "45";
            // 
            // allUserTotal
            // 
            this.allUserTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allUserTotal.AutoSize = true;
            this.allUserTotal.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUserTotal.Location = new System.Drawing.Point(335, 39);
            this.allUserTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allUserTotal.Name = "allUserTotal";
            this.allUserTotal.Size = new System.Drawing.Size(25, 13);
            this.allUserTotal.TabIndex = 11;
            this.allUserTotal.Text = "145";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.pb_question);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(198, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 275);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Question";
            // 
            // pb_question
            // 
            this.pb_question.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_question.Image = ((System.Drawing.Image)(resources.GetObject("pb_question.Image")));
            this.pb_question.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_question.InitialImage")));
            this.pb_question.Location = new System.Drawing.Point(3, 22);
            this.pb_question.Name = "pb_question";
            this.pb_question.Size = new System.Drawing.Size(411, 250);
            this.pb_question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_question.TabIndex = 4;
            this.pb_question.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(262, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(160, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(143, 17);
            this.toolStripStatusLabel1.Text = "Welcome to Your Training";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.Coral;
            this.lbl_welcome.Location = new System.Drawing.Point(5, 45);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(420, 35);
            this.lbl_welcome.TabIndex = 8;
            this.lbl_welcome.Text = "Test Class Training For Test User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.goback);
            this.panel1.Controls.Add(this.bunifuTileButton3);
            this.panel1.Controls.Add(this.DashboardBut);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 517);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // goback
            // 
            this.goback.BackColor = System.Drawing.Color.Transparent;
            this.goback.BorderColor = System.Drawing.Color.Transparent;
            this.goback.ButtonColor = System.Drawing.Color.YellowGreen;
            this.goback.FlatAppearance.BorderSize = 0;
            this.goback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback.ForeColor = System.Drawing.Color.Transparent;
            this.goback.Location = new System.Drawing.Point(13, 230);
            this.goback.Margin = new System.Windows.Forms.Padding(2);
            this.goback.Name = "goback";
            this.goback.OnHoverBorderColor = System.Drawing.Color.DarkGreen;
            this.goback.OnHoverButtonColor = System.Drawing.Color.DarkGreen;
            this.goback.OnHoverTextColor = System.Drawing.Color.Black;
            this.goback.Size = new System.Drawing.Size(97, 35);
            this.goback.TabIndex = 17;
            this.goback.Text = "Go Back";
            this.goback.TextColor = System.Drawing.Color.Black;
            this.goback.UseVisualStyleBackColor = false;
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.bunifuTileButton3.color = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 14;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 29;
            this.bunifuTileButton3.LabelText = "Exit";
            this.bunifuTileButton3.Location = new System.Drawing.Point(13, 407);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(105, 97);
            this.bunifuTileButton3.TabIndex = 9;
            // 
            // DashboardBut
            // 
            this.DashboardBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.DashboardBut.color = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.DashboardBut.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DashboardBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBut.ForeColor = System.Drawing.Color.White;
            this.DashboardBut.Image = ((System.Drawing.Image)(resources.GetObject("DashboardBut.Image")));
            this.DashboardBut.ImagePosition = 14;
            this.DashboardBut.ImageZoom = 50;
            this.DashboardBut.LabelPosition = 29;
            this.DashboardBut.LabelText = "Dashboard";
            this.DashboardBut.Location = new System.Drawing.Point(13, 111);
            this.DashboardBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DashboardBut.Name = "DashboardBut";
            this.DashboardBut.Size = new System.Drawing.Size(105, 95);
            this.DashboardBut.TabIndex = 8;
            this.DashboardBut.Click += new System.EventHandler(this.DashboardBut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.gitHubButton);
            this.panel2.Controls.Add(this.userTypeLabel);
            this.panel2.Controls.Add(this.lbl_welcome);
            this.panel2.Controls.Add(this.usernameLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(155, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 104);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(568, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // gitHubButton
            // 
            this.gitHubButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gitHubButton.Image = ((System.Drawing.Image)(resources.GetObject("gitHubButton.Image")));
            this.gitHubButton.Location = new System.Drawing.Point(511, 31);
            this.gitHubButton.Name = "gitHubButton";
            this.gitHubButton.Size = new System.Drawing.Size(43, 37);
            this.gitHubButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gitHubButton.TabIndex = 4;
            this.gitHubButton.TabStop = false;
            this.gitHubButton.Click += new System.EventHandler(this.gitHubButton_Click);
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLabel.ForeColor = System.Drawing.Color.Silver;
            this.userTypeLabel.Location = new System.Drawing.Point(742, 63);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(94, 17);
            this.userTypeLabel.TabIndex = 3;
            this.userTypeLabel.Text = "Administrator";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Coral;
            this.usernameLabel.Location = new System.Drawing.Point(706, 31);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(133, 20);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Welcome, Candace";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(634, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainTrainingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_stats);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainTrainingPage";
            this.Text = "MainTrainingPage";
            this.Load += new System.EventHandler(this.MainTrainingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tbl_answers.ResumeLayout(false);
            this.gb_stats.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitHubButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_stats;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TableLayoutPanel tbl_answers;
        private System.Windows.Forms.PictureBox pb_question;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label totalWrong;
        private System.Windows.Forms.Label totalAnswered;
        private System.Windows.Forms.Label currentUser;
        private System.Windows.Forms.Label allUsers;
        private System.Windows.Forms.Label totalCorrect;
        private System.Windows.Forms.Label currentUserCorrect;
        private System.Windows.Forms.Label currentUserWrong;
        private System.Windows.Forms.Label currentUserTotal;
        private System.Windows.Forms.Label allUserCorrect;
        private System.Windows.Forms.Label allUserWrong;
        private System.Windows.Forms.Label allUserTotal;
        private System.Windows.Forms.Button button1;
        private ePOSOne.btnProduct.Button_WOC goback;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton DashboardBut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox gitHubButton;
        private System.Windows.Forms.Label userTypeLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
