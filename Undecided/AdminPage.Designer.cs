namespace Undecided
{
    partial class AdminPage
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnSched = new Button();
            btnAccounts = new Button();
            btnHistory = new Button();
            btnExit = new Button();
            btnLists = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(232, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 637);
            panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.shoppa_high_resolution_logo_transparent__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(7, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 217);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnSched
            // 
            btnSched.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnSched.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSched.Location = new Point(8, 383);
            btnSched.Name = "btnSched";
            btnSched.Size = new Size(211, 44);
            btnSched.TabIndex = 14;
            btnSched.Text = "View Schedules";
            btnSched.UseVisualStyleBackColor = true;
            btnSched.Click += btnSched_Click;
            // 
            // btnAccounts
            // 
            btnAccounts.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnAccounts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccounts.Location = new Point(7, 283);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Size = new Size(211, 44);
            btnAccounts.TabIndex = 12;
            btnAccounts.Text = "Manage Accounts";
            btnAccounts.UseVisualStyleBackColor = true;
            btnAccounts.Click += btnAccounts_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnHistory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistory.Location = new Point(7, 433);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(211, 44);
            btnHistory.TabIndex = 11;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(7, 533);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(211, 44);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLists
            // 
            btnLists.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnLists.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLists.Location = new Point(7, 333);
            btnLists.Name = "btnLists";
            btnLists.Size = new Size(211, 44);
            btnLists.TabIndex = 9;
            btnLists.Text = "View all Lists";
            btnLists.UseVisualStyleBackColor = true;
            btnLists.Click += btnLists_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(7, 483);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(211, 44);
            btnLogout.TabIndex = 17;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1183, 656);
            Controls.Add(btnLogout);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSched);
            Controls.Add(btnAccounts);
            Controls.Add(btnHistory);
            Controls.Add(btnExit);
            Controls.Add(btnLists);
            Name = "AdminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnSched;
        private Button btnAccounts;
        private Button btnHistory;
        private Button btnExit;
        private Button btnLists;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnLogout;
    }
}