namespace Undecided
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            tbxUser = new TextBox();
            tbxPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            btnCreateAcc = new Button();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(32, 295);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 55);
            btnExit.TabIndex = 0;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tbxUser
            // 
            tbxUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUser.Location = new Point(126, 166);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(151, 33);
            tbxUser.TabIndex = 2;
            // 
            // tbxPass
            // 
            tbxPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPass.Location = new Point(126, 215);
            tbxPass.Name = "tbxPass";
            tbxPass.Size = new Size(151, 33);
            tbxPass.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(22, 174);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(22, 218);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(156, 295);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 55);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCreateAcc
            // 
            btnCreateAcc.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnCreateAcc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAcc.Location = new Point(32, 356);
            btnCreateAcc.Name = "btnCreateAcc";
            btnCreateAcc.Size = new Size(229, 25);
            btnCreateAcc.TabIndex = 7;
            btnCreateAcc.Text = "CREATE ACCOUNT";
            btnCreateAcc.UseVisualStyleBackColor = true;
            btnCreateAcc.Click += btnNewAcc_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.shoppa_high_resolution_logo_transparent__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(32, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 123);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(109, 138);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 9;
            label3.Text = "Welcome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(310, 426);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnCreateAcc);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxPass);
            Controls.Add(tbxUser);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private TextBox tbxUser;
        private TextBox tbxPass;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Button btnCreateAcc;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
    }
}
