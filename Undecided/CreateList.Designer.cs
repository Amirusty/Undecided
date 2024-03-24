namespace Undecided
{
    partial class CreateList
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
            textBox1 = new TextBox();
            btnCreateList = new Button();
            btnReturn = new Button();
            dgvNewList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvNewList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 0;
            label1.Text = "Name of List: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MediumAquamarine;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(167, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 39);
            textBox1.TabIndex = 2;
            // 
            // btnCreateList
            // 
            btnCreateList.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnCreateList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateList.Location = new Point(454, 12);
            btnCreateList.Name = "btnCreateList";
            btnCreateList.Size = new Size(146, 69);
            btnCreateList.TabIndex = 4;
            btnCreateList.Text = "Create List";
            btnCreateList.UseVisualStyleBackColor = true;
            btnCreateList.Click += btnCreateList_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnReturn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(800, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(116, 69);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return to Main Menu";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dgvNewList
            // 
            dgvNewList.BackgroundColor = Color.SeaGreen;
            dgvNewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNewList.Location = new Point(12, 120);
            dgvNewList.Name = "dgvNewList";
            dgvNewList.Size = new Size(904, 466);
            dgvNewList.TabIndex = 7;
            // 
            // CreateList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(928, 598);
            Controls.Add(dgvNewList);
            Controls.Add(btnReturn);
            Controls.Add(btnCreateList);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CreateList";
            Text = "CreateList";
            ((System.ComponentModel.ISupportInitialize)dgvNewList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnCreateList;
        private Button btnReturn;
        private DataGridView dgvNewList;
    }
}