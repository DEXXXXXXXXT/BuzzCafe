namespace BuzzCafe
{
    partial class OrderSuccess
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            lborderData = new Label();
            btnView = new Button();
            btnOrderAgain = new Button();
            lblOrderNum = new Label();
            lblThanks = new Label();
            lblStatus = new Label();
            lblHeader = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 861);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(235, 225, 210);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lborderData);
            panel2.Controls.Add(btnView);
            panel2.Controls.Add(btnOrderAgain);
            panel2.Controls.Add(lblOrderNum);
            panel2.Controls.Add(lblThanks);
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(lblHeader);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.FromArgb(47, 36, 32);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 861);
            panel2.TabIndex = 1;
            // 
            // lborderData
            // 
            lborderData.Font = new Font("Courier New", 18F, FontStyle.Bold);
            lborderData.ForeColor = Color.FromArgb(184, 98, 48);
            lborderData.Location = new Point(369, 450);
            lborderData.Name = "lborderData";
            lborderData.Size = new Size(147, 43);
            lborderData.TabIndex = 6;
            lborderData.Text = "data";
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(166, 94, 46);
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(408, 509);
            btnView.Name = "btnView";
            btnView.Size = new Size(160, 45);
            btnView.TabIndex = 5;
            btnView.Text = "View Receipt";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnOrderAgain
            // 
            btnOrderAgain.BackColor = Color.FromArgb(166, 94, 46);
            btnOrderAgain.FlatAppearance.BorderSize = 0;
            btnOrderAgain.FlatStyle = FlatStyle.Flat;
            btnOrderAgain.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnOrderAgain.ForeColor = Color.White;
            btnOrderAgain.Location = new Point(153, 509);
            btnOrderAgain.Name = "btnOrderAgain";
            btnOrderAgain.Size = new Size(160, 45);
            btnOrderAgain.TabIndex = 4;
            btnOrderAgain.Text = "Order Again";
            btnOrderAgain.UseVisualStyleBackColor = false;
            btnOrderAgain.Click += btnOrderAgain_Click;
            // 
            // lblOrderNum
            // 
            lblOrderNum.Font = new Font("Courier New", 18F, FontStyle.Bold);
            lblOrderNum.ForeColor = Color.FromArgb(184, 98, 48);
            lblOrderNum.Location = new Point(223, 450);
            lblOrderNum.Name = "lblOrderNum";
            lblOrderNum.Size = new Size(164, 43);
            lblOrderNum.TabIndex = 3;
            lblOrderNum.Text = "Order #: ";
            // 
            // lblThanks
            // 
            lblThanks.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblThanks.ForeColor = SystemColors.WindowFrame;
            lblThanks.Location = new Point(223, 389);
            lblThanks.Name = "lblThanks";
            lblThanks.Size = new Size(271, 33);
            lblThanks.TabIndex = 2;
            lblThanks.Text = "Thank you for ordering";
            lblThanks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblStatus.ForeColor = Color.DimGray;
            lblStatus.Location = new Point(169, 328);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(364, 40);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "✔ Order Placed Successfully!";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Georgia", 24F, FontStyle.Bold);
            lblHeader.Location = new Point(153, 257);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(415, 51);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "ORDER SUCCESS";
            lblHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // OrderSuccess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "OrderSuccess";
            Size = new Size(729, 861);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnView;
        private Button btnOrderAgain;
        private Label lblOrderNum;
        private Label lblThanks;
        private Label lblStatus;
        private Label lblHeader;
        public Label lborderData;
    }
}
