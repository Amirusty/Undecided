namespace Undecided
{
    partial class Form2
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
            button1 = new Button();
            btnReturn = new Button();
            label1 = new Label();
            tbxListName = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnLoad = new Button();
            btnDelete = new Button();
            dgvLists = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLists).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.wallhaven_5g6mg1_1920x1080;
            button1.Location = new Point(789, 556);
            button1.Name = "button1";
            button1.Size = new Size(127, 30);
            button1.TabIndex = 0;
            button1.Text = "Connection test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnReturn
            // 
            btnReturn.BackgroundImage = Properties.Resources.wallhaven_5g6mg1_1920x1080;
            btnReturn.Location = new Point(789, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(127, 52);
            btnReturn.TabIndex = 3;
            btnReturn.Text = "Return to menu";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(657, 184);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 4;
            label1.Text = "List name:";
            // 
            // tbxListName
            // 
            tbxListName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxListName.Location = new Point(735, 181);
            tbxListName.Name = "tbxListName";
            tbxListName.Size = new Size(181, 29);
            tbxListName.TabIndex = 6;
            // 
            // btnCreate
            // 
            btnCreate.BackgroundImage = Properties.Resources.wallhaven_5g6mg1_1920x1080;
            btnCreate.Location = new Point(657, 75);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(79, 48);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Create List";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = Properties.Resources.wallhaven_5g6mg1_1920x1080;
            btnUpdate.Location = new Point(742, 75);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 48);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update List";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.BackgroundImage = Properties.Resources.wallhaven_5g6mg1_1920x1080;
            btnLoad.Location = new Point(657, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(127, 52);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "Load All lists";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.wallhaven_5g6mg1_1920x1080;
            btnDelete.Location = new Point(832, 75);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 48);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete List";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvLists
            // 
            dgvLists.BackgroundColor = Color.SeaGreen;
            dgvLists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLists.Location = new Point(12, 12);
            dgvLists.Name = "dgvLists";
            dgvLists.Size = new Size(639, 574);
            dgvLists.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(928, 598);
            Controls.Add(dgvLists);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(tbxListName);
            Controls.Add(label1);
            Controls.Add(btnReturn);
            Controls.Add(button1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewLists";
            ((System.ComponentModel.ISupportInitialize)dgvLists).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnReturn;
        private Label label1;
        private TextBox tbxListName;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnLoad;
        private Button btnDelete;
        private DataGridView dgvLists;
    }
}