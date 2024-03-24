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
            tbxUser.Location = new Point(125, 90);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(151, 33);
            tbxUser.TabIndex = 2;
            // 
            // tbxPass
            // 
            tbxPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPass.Location = new Point(125, 139);
            tbxPass.Name = "tbxPass";
            tbxPass.Size = new Size(151, 33);
            tbxPass.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 98);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 142);
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
            btnCreateAcc.BackgroundImage = Properties.Resources.wallhaven_3lg6ld_1920x1080;
            btnCreateAcc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAcc.Location = new Point(32, 356);
            btnCreateAcc.Name = "btnCreateAcc";
            btnCreateAcc.Size = new Size(229, 21);
            btnCreateAcc.TabIndex = 7;
            btnCreateAcc.Text = "CREATE ACCOUNT";
            btnCreateAcc.UseVisualStyleBackColor = true;
            btnCreateAcc.Click += btnNewAcc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(310, 426);
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
    }
}
