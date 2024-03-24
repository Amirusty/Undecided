namespace Undecided
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxNewPass = new TextBox();
            tbxNewUser = new TextBox();
            btnCreateNewAcc = new Button();
            btnReturn = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 39);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 150);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 9;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 106);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 8;
            label3.Text = "Username:";
            // 
            // tbxNewPass
            // 
            tbxNewPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNewPass.Location = new Point(132, 147);
            tbxNewPass.Name = "tbxNewPass";
            tbxNewPass.Size = new Size(151, 33);
            tbxNewPass.TabIndex = 7;
            // 
            // tbxNewUser
            // 
            tbxNewUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNewUser.Location = new Point(132, 98);
            tbxNewUser.Name = "tbxNewUser";
            tbxNewUser.Size = new Size(151, 33);
            tbxNewUser.TabIndex = 6;
            // 
            // btnCreateNewAcc
            // 
            btnCreateNewAcc.BackColor = Color.LightSeaGreen;
            btnCreateNewAcc.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnCreateNewAcc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateNewAcc.Location = new Point(28, 321);
            btnCreateNewAcc.Name = "btnCreateNewAcc";
            btnCreateNewAcc.Size = new Size(255, 46);
            btnCreateNewAcc.TabIndex = 10;
            btnCreateNewAcc.Text = "CREATE ACCOUNT";
            btnCreateNewAcc.UseVisualStyleBackColor = false;
            btnCreateNewAcc.Click += btnCreateNewAcc_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(29, 373);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(121, 41);
            btnReturn.TabIndex = 11;
            btnReturn.Text = "Go back";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(156, 373);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(127, 41);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(310, 426);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(btnCreateNewAcc);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(tbxNewPass);
            Controls.Add(tbxNewUser);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxNewPass;
        private TextBox tbxNewUser;
        private Button btnCreateNewAcc;
        private Button btnReturn;
        private Button btnExit;
    }
}