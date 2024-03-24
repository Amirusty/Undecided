namespace Undecided
{
    partial class Form2
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
            button1 = new Button();
            btnExit = new Button();
            dgvDatabase = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatabase).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(656, 534);
            button1.Name = "button1";
            button1.Size = new Size(127, 52);
            button1.TabIndex = 0;
            button1.Text = "Connection test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(789, 534);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(127, 52);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit ";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvDatabase
            // 
            dgvDatabase.BackgroundColor = Color.SeaGreen;
            dgvDatabase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatabase.Location = new Point(12, 12);
            dgvDatabase.Name = "dgvDatabase";
            dgvDatabase.Size = new Size(612, 574);
            dgvDatabase.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(928, 598);
            Controls.Add(dgvDatabase);
            Controls.Add(btnExit);
            Controls.Add(button1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Database";
            ((System.ComponentModel.ISupportInitialize)dgvDatabase).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnExit;
        private DataGridView dgvDatabase;
    }
}