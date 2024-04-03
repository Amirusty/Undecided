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
            btnUpdate = new Button();
            btnAdd = new Button();
            tbxPrice = new TextBox();
            label4 = new Label();
            tbxQuantity = new TextBox();
            label3 = new Label();
            tbxItem = new TextBox();
            label2 = new Label();
            dgvList = new DataGridView();
            btnOpen = new Button();
            tbxList = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
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
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(709, 282);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 42);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update item";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(606, 282);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 42);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxPrice
            // 
            tbxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPrice.Location = new Point(735, 239);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(181, 29);
            tbxPrice.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(606, 242);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 26;
            label4.Text = "Item Price:";
            // 
            // tbxQuantity
            // 
            tbxQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxQuantity.Location = new Point(735, 194);
            tbxQuantity.Name = "tbxQuantity";
            tbxQuantity.Size = new Size(181, 29);
            tbxQuantity.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(606, 197);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 24;
            label3.Text = "Item Quantity";
            // 
            // tbxItem
            // 
            tbxItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxItem.Location = new Point(735, 149);
            tbxItem.Name = "tbxItem";
            tbxItem.Size = new Size(181, 29);
            tbxItem.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(606, 152);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 22;
            label2.Text = "Item Name:";
            // 
            // dgvList
            // 
            dgvList.BackgroundColor = Color.SeaGreen;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(12, 120);
            dgvList.Name = "dgvList";
            dgvList.Size = new Size(588, 466);
            dgvList.TabIndex = 21;
            dgvList.CellClick += dgvList_CellClick;
            // 
            // btnOpen
            // 
            btnOpen.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnOpen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(454, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(146, 69);
            btnOpen.TabIndex = 19;
            btnOpen.Text = "Open List";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // tbxList
            // 
            tbxList.BackColor = Color.MediumAquamarine;
            tbxList.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxList.Location = new Point(167, 12);
            tbxList.Name = "tbxList";
            tbxList.Size = new Size(260, 39);
            tbxList.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 17;
            label1.Text = "Name of List: ";
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(819, 282);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 42);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Delete item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // OpenList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(928, 598);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(tbxPrice);
            Controls.Add(label4);
            Controls.Add(tbxQuantity);
            Controls.Add(label3);
            Controls.Add(tbxItem);
            Controls.Add(label2);
            Controls.Add(dgvList);
            Controls.Add(btnOpen);
            Controls.Add(tbxList);
            Controls.Add(label1);
            Controls.Add(btnReturn);
            Name = "OpenList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OpenList";
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReturn;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox tbxPrice;
        private Label label4;
        private TextBox tbxQuantity;
        private Label label3;
        private TextBox tbxItem;
        private Label label2;
        private DataGridView dgvList;
        private Button btnOpen;
        private TextBox tbxList;
        private Label label1;
        private Button btnDelete;
    }
}