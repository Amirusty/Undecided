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
            tbxNewList = new TextBox();
            btnCreateList = new Button();
            btnReturn = new Button();
            dgvNewList = new DataGridView();
            tbxItem = new TextBox();
            label2 = new Label();
            tbxQuantity = new TextBox();
            label3 = new Label();
            tbxPrice = new TextBox();
            label4 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
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
            // tbxNewList
            // 
            tbxNewList.BackColor = Color.MediumAquamarine;
            tbxNewList.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNewList.Location = new Point(167, 12);
            tbxNewList.Name = "tbxNewList";
            tbxNewList.Size = new Size(260, 39);
            tbxNewList.TabIndex = 2;
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
            dgvNewList.Size = new Size(588, 466);
            dgvNewList.TabIndex = 7;
            dgvNewList.CellClick += dgvNewList_CellClick;
            // 
            // tbxItem
            // 
            tbxItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxItem.Location = new Point(735, 149);
            tbxItem.Name = "tbxItem";
            tbxItem.Size = new Size(181, 29);
            tbxItem.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(606, 152);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 8;
            label2.Text = "Item Name:";
            // 
            // tbxQuantity
            // 
            tbxQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxQuantity.Location = new Point(735, 194);
            tbxQuantity.Name = "tbxQuantity";
            tbxQuantity.Size = new Size(181, 29);
            tbxQuantity.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(606, 197);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 10;
            label3.Text = "Item Quantity";
            // 
            // tbxPrice
            // 
            tbxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPrice.Location = new Point(735, 239);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(181, 29);
            tbxPrice.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(606, 242);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 12;
            label4.Text = "Item Price:";
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(606, 282);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 42);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(819, 282);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 42);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(709, 282);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 42);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update item";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // CreateList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(928, 598);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(tbxPrice);
            Controls.Add(label4);
            Controls.Add(tbxQuantity);
            Controls.Add(label3);
            Controls.Add(tbxItem);
            Controls.Add(label2);
            Controls.Add(dgvNewList);
            Controls.Add(btnReturn);
            Controls.Add(btnCreateList);
            Controls.Add(tbxNewList);
            Controls.Add(label1);
            Name = "CreateList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateList";
            ((System.ComponentModel.ISupportInitialize)dgvNewList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxNewList;
        private Button btnCreateList;
        private Button btnReturn;
        private DataGridView dgvNewList;
        private TextBox tbxItem;
        private Label label2;
        private TextBox tbxQuantity;
        private Label label3;
        private TextBox tbxPrice;
        private Label label4;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
    }
}