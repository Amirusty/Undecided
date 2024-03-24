namespace Undecided
{
    partial class Form4
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
            btnSearch = new Button();
            btnOpen = new Button();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.Location = new Point(63, 150);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(211, 53);
            btnShow.TabIndex = 0;
            btnShow.Text = "View all Lists";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(63, 359);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(211, 44);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(63, 259);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(211, 44);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(63, 50);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(211, 44);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create a New List";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(63, 209);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(211, 44);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search an item";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(63, 100);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(211, 44);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open a list";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(341, 464);
            Controls.Add(btnOpen);
            Controls.Add(btnSearch);
            Controls.Add(btnCreate);
            Controls.Add(btnHistory);
            Controls.Add(btnExit);
            Controls.Add(btnShow);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main menu";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnShow;
        private Button btnExit;
        private Button btnHistory;
        private Button btnCreate;
        private Button btnSearch;
        private Button btnOpen;
    }
}