namespace Undecided
{
    partial class SearchItem
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
            tbxItem = new TextBox();
            dgvList = new DataGridView();
            btnFindItem = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            tbxPrice = new TextBox();
            label4 = new Label();
            tbxQuantity = new TextBox();
            label3 = new Label();
            tbxName = new TextBox();
            label2 = new Label();
            cbxListNames = new ComboBox();
            btnOpen = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 33);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter item: ";
            // 
            // tbxItem
            // 
            tbxItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxItem.Location = new Point(146, 33);
            tbxItem.Name = "tbxItem";
            tbxItem.Size = new Size(228, 29);
            tbxItem.TabIndex = 1;
            // 
            // dgvList
            // 
            dgvList.BackgroundColor = Color.DarkSlateGray;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(12, 103);
            dgvList.Name = "dgvList";
            dgvList.Size = new Size(578, 483);
            dgvList.TabIndex = 2;
            dgvList.CellClick += dgvList_CellClick;
            // 
            // btnFindItem
            // 
            btnFindItem.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnFindItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFindItem.Location = new Point(405, 12);
            btnFindItem.Name = "btnFindItem";
            btnFindItem.Size = new Size(119, 69);
            btnFindItem.TabIndex = 20;
            btnFindItem.Text = "Search Item";
            btnFindItem.UseVisualStyleBackColor = true;
            btnFindItem.Click += btnFindItem_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(819, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 42);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Delete item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(709, 314);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 42);
            btnUpdate.TabIndex = 38;
            btnUpdate.Text = "Update item";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(606, 314);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 42);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxPrice
            // 
            tbxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPrice.Location = new Point(735, 271);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(181, 29);
            tbxPrice.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(606, 274);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 35;
            label4.Text = "Item Price:";
            // 
            // tbxQuantity
            // 
            tbxQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxQuantity.Location = new Point(735, 226);
            tbxQuantity.Name = "tbxQuantity";
            tbxQuantity.Size = new Size(181, 29);
            tbxQuantity.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(606, 229);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 33;
            label3.Text = "Item Quantity";
            // 
            // tbxName
            // 
            tbxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxName.Location = new Point(735, 181);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(181, 29);
            tbxName.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(606, 184);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 31;
            label2.Text = "Item Name:";
            // 
            // cbxListNames
            // 
            cbxListNames.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxListNames.FormattingEnabled = true;
            cbxListNames.Location = new Point(606, 40);
            cbxListNames.Name = "cbxListNames";
            cbxListNames.Size = new Size(310, 29);
            cbxListNames.TabIndex = 40;
            // 
            // btnOpen
            // 
            btnOpen.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnOpen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(809, 75);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(107, 49);
            btnOpen.TabIndex = 41;
            btnOpen.Text = "Open List";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(606, 12);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 42;
            label5.Text = "List names:";
            // 
            // SearchItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(928, 598);
            Controls.Add(label5);
            Controls.Add(btnOpen);
            Controls.Add(cbxListNames);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(tbxPrice);
            Controls.Add(label4);
            Controls.Add(tbxQuantity);
            Controls.Add(label3);
            Controls.Add(tbxName);
            Controls.Add(label2);
            Controls.Add(btnFindItem);
            Controls.Add(dgvList);
            Controls.Add(tbxItem);
            Controls.Add(label1);
            Name = "SearchItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchItem";
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxItem;
        private DataGridView dgvList;
        private Button btnFindItem;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox tbxPrice;
        private Label label4;
        private TextBox tbxQuantity;
        private Label label3;
        private TextBox tbxName;
        private Label label2;
        private ComboBox cbxListNames;
        private Button btnOpen;
        private Label label5;
    }
}