namespace Undecided
{
    partial class OpenList
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
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnReturn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(800, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(116, 69);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Return to Main Menu";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // OpenList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(928, 598);
            Controls.Add(btnReturn);
            Name = "OpenList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OpenList";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReturn;
    }
}