namespace Undecided
{
    partial class UserInfo
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
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 56);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Image = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(95, 17);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 0;
            label1.Text = "Report / Suggestions";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 273);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 56);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Image = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(95, 17);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 1;
            label2.Text = "Analytics";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.shoppa_high_resolution_logo_transparent__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 255);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 397);
            panel3.Name = "panel3";
            panel3.Size = new Size(285, 56);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Image = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(95, 17);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 1;
            label3.Text = "Analytics";
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(307, 462);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Name = "UserInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserInfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label3;
    }
}