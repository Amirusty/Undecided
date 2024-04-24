namespace Undecided
{
    partial class MainMenu
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
            btnShow = new Button();
            btnExit = new Button();
            btnHistory = new Button();
            btnCreate = new Button();
            btnOpen = new Button();
            btnSched = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnLogout = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnShow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(12, 338);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(211, 44);
            btnShow.TabIndex = 0;
            btnShow.Text = "View all Lists";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(12, 588);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(211, 44);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnHistory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistory.Location = new Point(12, 488);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(211, 44);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(12, 238);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(211, 44);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create a New List";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnOpen
            // 
            btnOpen.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnOpen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(12, 288);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(211, 44);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open a list";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSched
            // 
            btnSched.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnSched.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSched.Location = new Point(12, 438);
            btnSched.Name = "btnSched";
            btnSched.Size = new Size(211, 44);
            btnSched.TabIndex = 6;
            btnSched.Text = "Schedules";
            btnSched.UseVisualStyleBackColor = true;
            btnSched.Click += btnSched_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.shoppa_high_resolution_logo_transparent__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 217);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(237, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 637);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(12, 538);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(211, 44);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(12, 388);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(211, 44);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search Item";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1183, 656);
            Controls.Add(btnSearch);
            Controls.Add(btnLogout);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSched);
            Controls.Add(btnOpen);
            Controls.Add(btnCreate);
            Controls.Add(btnHistory);
            Controls.Add(btnExit);
            Controls.Add(btnShow);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main menu";
            FormClosing += MainMenu_FormClosing;
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnShow;
        private Button btnExit;
        private Button btnHistory;
        private Button btnCreate;
        private Button btnOpen;
        private Button btnSched;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Button btnSearch;
        public Panel panel1;
    }
}