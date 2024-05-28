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
            btnFindItem = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            label2 = new Label();
            cbxMarkets = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 62);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter item: ";
            // 
            // tbxItem
            // 
            tbxItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxItem.Location = new Point(147, 62);
            tbxItem.Name = "tbxItem";
            tbxItem.Size = new Size(228, 29);
            tbxItem.TabIndex = 1;
            // 
            // btnFindItem
            // 
            btnFindItem.BackgroundImage = Properties.Resources._99412011_2644547135774652_7049028762897219584_n;
            btnFindItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFindItem.Location = new Point(398, 27);
            btnFindItem.Name = "btnFindItem";
            btnFindItem.Size = new Size(119, 64);
            btnFindItem.TabIndex = 20;
            btnFindItem.Text = "Search Item";
            btnFindItem.UseVisualStyleBackColor = true;
            btnFindItem.Click += btnFindItem_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 109);
            webView21.Name = "webView21";
            webView21.Size = new Size(904, 477);
            webView21.TabIndex = 43;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 27);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 44;
            label2.Text = "Supermarket:";
            // 
            // cbxMarkets
            // 
            cbxMarkets.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxMarkets.FormattingEnabled = true;
            cbxMarkets.Items.AddRange(new object[] { "Landers", "Gaisano", "SM", "Metro Ayala", "Robinsons " });
            cbxMarkets.Location = new Point(147, 27);
            cbxMarkets.Name = "cbxMarkets";
            cbxMarkets.Size = new Size(228, 29);
            cbxMarkets.TabIndex = 45;
            cbxMarkets.SelectedIndexChanged += cbxMarkets_SelectedIndexChanged;
            // 
            // SearchItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(928, 598);
            Controls.Add(cbxMarkets);
            Controls.Add(label2);
            Controls.Add(webView21);
            Controls.Add(btnFindItem);
            Controls.Add(tbxItem);
            Controls.Add(label1);
            Name = "SearchItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchItem";
            Load += SearchItem_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxItem;
        private Button btnFindItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label label2;
        private ComboBox cbxMarkets;
    }
}