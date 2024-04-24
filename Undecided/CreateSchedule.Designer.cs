namespace Undecided
{
    partial class CreateSchedule
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
            tbxName = new TextBox();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            cbxListNames = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            btnCreateSched = new Button();
            btnReturn = new Button();
            cbxLocation = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(39, 52);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 0;
            label1.Text = "Schedule name:";
            // 
            // tbxName
            // 
            tbxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxName.Location = new Point(194, 49);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(273, 29);
            tbxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(39, 111);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 2;
            label2.Text = "Select List:";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.Location = new Point(194, 169);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(273, 29);
            dtpDate.TabIndex = 4;
            // 
            // cbxListNames
            // 
            cbxListNames.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxListNames.FormattingEnabled = true;
            cbxListNames.Location = new Point(194, 108);
            cbxListNames.Name = "cbxListNames";
            cbxListNames.Size = new Size(273, 29);
            cbxListNames.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(39, 175);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 6;
            label3.Text = "Select Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(39, 227);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 7;
            label4.Text = "Select Location:";
            // 
            // btnCreateSched
            // 
            btnCreateSched.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnCreateSched.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateSched.Location = new Point(321, 553);
            btnCreateSched.Name = "btnCreateSched";
            btnCreateSched.Size = new Size(146, 69);
            btnCreateSched.TabIndex = 8;
            btnCreateSched.Text = "Create Schedule";
            btnCreateSched.UseVisualStyleBackColor = true;
            btnCreateSched.Click += btnCreateSched_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnReturn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(12, 558);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(146, 69);
            btnReturn.TabIndex = 9;
            btnReturn.Text = "Return ";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // cbxLocation
            // 
            cbxLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxLocation.FormattingEnabled = true;
            cbxLocation.Location = new Point(194, 224);
            cbxLocation.Name = "cbxLocation";
            cbxLocation.Size = new Size(273, 29);
            cbxLocation.TabIndex = 10;
            cbxLocation.SelectedIndexChanged += cbxLocation_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(501, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(472, 615);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // CreateSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(982, 634);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(cbxLocation);
            Controls.Add(btnReturn);
            Controls.Add(btnCreateSched);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbxListNames);
            Controls.Add(dtpDate);
            Controls.Add(label2);
            Controls.Add(tbxName);
            Controls.Add(label1);
            Name = "CreateSchedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateSchedule";
            Load += CreateSchedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxName;
        private Label label2;
        private DateTimePicker dtpDate;
        private ComboBox cbxListNames;
        private Label label3;
        private Label label4;
        private Button btnCreateSched;
        private Button btnReturn;
        private ComboBox cbxLocation;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}