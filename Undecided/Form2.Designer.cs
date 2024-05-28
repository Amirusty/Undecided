namespace Undecided
{
    partial class ViewLists
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
            label1 = new Label();
            tbxListName = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnLoad = new Button();
            btnDelete = new Button();
            dgvLists = new DataGridView();
            cbxListNames = new ComboBox();
            label2 = new Label();
            btnLoadList = new Button();
            label3 = new Label();
            cbxSort = new ComboBox();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(657, 293);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 4;
            label1.Text = "List name:";
            // 
            // tbxListName
            // 
            tbxListName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxListName.Location = new Point(735, 290);
            tbxListName.Name = "tbxListName";
            tbxListName.Size = new Size(181, 29);
            tbxListName.TabIndex = 6;
            // 
            // btnCreate
            // 
            btnCreate.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
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
            btnUpdate.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnUpdate.Location = new Point(742, 75);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 48);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update List";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnLoad.Location = new Point(657, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(259, 52);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "Refresh Lists";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
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
            dgvLists.BackgroundColor = Color.DarkSlateGray;
            dgvLists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLists.Location = new Point(12, 12);
            dgvLists.Name = "dgvLists";
            dgvLists.Size = new Size(639, 574);
            dgvLists.TabIndex = 18;
            // 
            // cbxListNames
            // 
            cbxListNames.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxListNames.FormattingEnabled = true;
            cbxListNames.Location = new Point(671, 167);
            cbxListNames.Name = "cbxListNames";
            cbxListNames.Size = new Size(245, 29);
            cbxListNames.TabIndex = 19;
            cbxListNames.SelectedIndexChanged += cbxListNames_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(671, 143);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 20;
            label2.Text = "List names:";
            // 
            // btnLoadList
            // 
            btnLoadList.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnLoadList.Location = new Point(832, 325);
            btnLoadList.Name = "btnLoadList";
            btnLoadList.Size = new Size(84, 48);
            btnLoadList.TabIndex = 21;
            btnLoadList.Text = "Load List";
            btnLoadList.UseVisualStyleBackColor = true;
            btnLoadList.Click += btnLoadList_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(671, 205);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 23;
            label3.Text = "Sort by:";
            // 
            // cbxSort
            // 
            cbxSort.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxSort.FormattingEnabled = true;
            cbxSort.Items.AddRange(new object[] { "Name - Ascending", "Name - Descending", "Size - Ascending", "Size - Descending", "Total Amount - Ascending", "Total Amount - Descending" });
            cbxSort.Location = new Point(762, 202);
            cbxSort.Name = "cbxSort";
            cbxSort.Size = new Size(154, 23);
            cbxSort.TabIndex = 22;
            cbxSort.SelectedIndexChanged += cbxSort_SelectedIndexChanged;
            // 
            // ViewLists
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(928, 598);
            Controls.Add(label3);
            Controls.Add(cbxSort);
            Controls.Add(btnLoadList);
            Controls.Add(label2);
            Controls.Add(cbxListNames);
            Controls.Add(dgvLists);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(tbxListName);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ViewLists";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewLists";
            FormClosing += ViewLists_FormClosing;
            Load += ViewLists_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLists).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox tbxListName;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnLoad;
        private Button btnDelete;
        private DataGridView dgvLists;
        private ComboBox cbxListNames;
        private Label label2;
        private Button btnLoadList;
        private Label label3;
        private ComboBox cbxSort;
    }
}