namespace Undecided
{
    partial class ViewAccounts
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
            btnUpdate = new Button();
            btnDelete = new Button();
            tbxPass = new TextBox();
            label3 = new Label();
            tbxUser = new TextBox();
            label2 = new Label();
            dgvAccounts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(533, 177);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(180, 59);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Change Password";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(732, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 59);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete account";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tbxPass
            // 
            tbxPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPass.Location = new Point(692, 98);
            tbxPass.Name = "tbxPass";
            tbxPass.Size = new Size(181, 29);
            tbxPass.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(563, 101);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 19;
            label3.Text = "Password:";
            // 
            // tbxUser
            // 
            tbxUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUser.Location = new Point(692, 53);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(181, 29);
            tbxUser.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(563, 56);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 17;
            label2.Text = "User Name: ";
            // 
            // dgvAccounts
            // 
            dgvAccounts.BackgroundColor = Color.DarkSlateGray;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(12, 12);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.Size = new Size(498, 384);
            dgvAccounts.TabIndex = 26;
            dgvAccounts.CellClick += dgvAccounts_CellClick;
            // 
            // ViewAccounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(928, 598);
            Controls.Add(dgvAccounts);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(tbxPass);
            Controls.Add(label3);
            Controls.Add(tbxUser);
            Controls.Add(label2);
            Name = "ViewAccounts";
            Text = "ViewAccounts";
            FormClosing += ViewAccounts_FormClosing;
            Load += ViewAccounts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Button btnDelete;
        private TextBox tbxPass;
        private Label label3;
        private TextBox tbxUser;
        private Label label2;
        private DataGridView dgvAccounts;
    }
}