namespace Undecided
{
    partial class CreateSched
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbMonth = new Label();
            btnPrev = new PictureBox();
            btnNext = new PictureBox();
            btnCreateSched = new Button();
            ((System.ComponentModel.ISupportInitialize)btnPrev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 97);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(904, 485);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(45, 67);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 1;
            label1.Text = "Sunday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Azure;
            label2.Location = new Point(167, 67);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 2;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Azure;
            label3.Location = new Point(421, 67);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 3;
            label3.Text = "Wednesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Azure;
            label4.Location = new Point(298, 67);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 3;
            label4.Text = "Tuesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Azure;
            label5.Location = new Point(558, 67);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 4;
            label5.Text = "Thursday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Azure;
            label6.Location = new Point(695, 67);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 5;
            label6.Text = "Friday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Azure;
            label7.Location = new Point(816, 67);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 6;
            label7.Text = "Saturday";
            // 
            // lbMonth
            // 
            lbMonth.AutoSize = true;
            lbMonth.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMonth.ForeColor = Color.Azure;
            lbMonth.Location = new Point(19, 12);
            lbMonth.Name = "lbMonth";
            lbMonth.Size = new Size(106, 32);
            lbMonth.TabIndex = 7;
            lbMonth.Text = "MONTH";
            // 
            // btnPrev
            // 
            btnPrev.BackgroundImage = Properties.Resources.left_arrow;
            btnPrev.Location = new Point(298, 12);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(32, 32);
            btnPrev.TabIndex = 8;
            btnPrev.TabStop = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackgroundImage = Properties.Resources.right_arrow;
            btnNext.Location = new Point(336, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(32, 32);
            btnNext.TabIndex = 9;
            btnNext.TabStop = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnCreateSched
            // 
            btnCreateSched.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateSched.ForeColor = SystemColors.ControlText;
            btnCreateSched.Image = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnCreateSched.ImageAlign = ContentAlignment.TopLeft;
            btnCreateSched.Location = new Point(420, 9);
            btnCreateSched.Name = "btnCreateSched";
            btnCreateSched.Size = new Size(196, 35);
            btnCreateSched.TabIndex = 10;
            btnCreateSched.Text = "Create New Schedule";
            btnCreateSched.UseVisualStyleBackColor = true;
            btnCreateSched.Click += btnCreateSched_Click;
            // 
            // CreateSched
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(928, 598);
            Controls.Add(btnCreateSched);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(lbMonth);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "CreateSched";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateSched";
            Load += CreateSched_Load;
            ((System.ComponentModel.ISupportInitialize)btnPrev).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbMonth;
        private PictureBox btnPrev;
        private PictureBox btnNext;
        private Button btnCreateSched;
    }
}