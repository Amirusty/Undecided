namespace Undecided
{
    partial class Confirm
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
            btnYes = new Button();
            btnNo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnYes.Location = new Point(12, 57);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(75, 33);
            btnYes.TabIndex = 0;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnNo.Location = new Point(98, 57);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(75, 33);
            btnNo.TabIndex = 1;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 2;
            label1.Text = "Are you sure?";
            // 
            // Confirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(185, 102);
            Controls.Add(label1);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Name = "Confirm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirm";
            Load += Confirm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYes;
        private Button btnNo;
        private Label label1;
    }
}