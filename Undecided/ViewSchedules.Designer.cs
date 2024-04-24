namespace Undecided
{
    partial class ViewSchedules
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
            btnCreate = new Button();
            btnDelete = new Button();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(12, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(211, 50);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create Schedule";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(229, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(211, 50);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete Schedule";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(12, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 518);
            panel1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(904, 518);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // ViewSchedules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(928, 598);
            Controls.Add(panel1);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Name = "ViewSchedules";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewSchedules";
            Load += ViewSchedules_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreate;
        private Button btnDelete;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}