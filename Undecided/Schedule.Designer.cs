namespace Undecided
{
    partial class Schedule
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
            btnReturn = new Button();
            btnOpen = new Button();
            btnView = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnReturn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(12, 590);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(211, 50);
            btnReturn.TabIndex = 8;
            btnReturn.Text = "Return to Main Menu";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnOpen
            // 
            btnOpen.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnOpen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(12, 280);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(211, 50);
            btnOpen.TabIndex = 11;
            btnOpen.Text = "Open Schedule";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnView
            // 
            btnView.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnView.Location = new Point(12, 346);
            btnView.Name = "btnView";
            btnView.Size = new Size(211, 50);
            btnView.TabIndex = 12;
            btnView.Text = "View All Schedules";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.calendar;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(35, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 160);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(229, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 637);
            panel1.TabIndex = 14;
            // 
            // btnCreate
            // 
            btnCreate.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(12, 215);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(211, 50);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Calendar";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1183, 656);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnView);
            Controls.Add(btnOpen);
            Controls.Add(btnCreate);
            Controls.Add(btnReturn);
            Name = "Schedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule";
            FormClosing += Schedule_FormClosing;
            Load += Schedule_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReturn;
        private Button btnOpen;
        private Button btnView;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnCreate;
    }
}