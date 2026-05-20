namespace BuzzCafe
{
    partial class OrderSuccessForm
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
            panel1 = new Panel();
            lblHeader = new Label();
            lblStatus = new Label();
            lblThanks = new Label();
            lblOrderNum = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblOrderNum);
            panel1.Controls.Add(lblThanks);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblHeader);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(47, 36, 32);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 380);
            panel1.TabIndex = 0;

            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Georgia", 24F, FontStyle.Bold);
            lblHeader.Location = new Point(54, 28);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(415, 51);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "ORDER SUCCESS";
            lblHeader.TextAlign = ContentAlignment.TopCenter;
            
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblStatus.ForeColor = Color.DimGray;
            lblStatus.Location = new Point(70, 99);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(364, 40);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "✔ Order Placed Successfully!";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
  
            // 
            // lblThanks
            // 
            lblThanks.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblThanks.ForeColor = SystemColors.WindowFrame;
            lblThanks.Location = new Point(124, 160);
            lblThanks.Name = "lblThanks";
            lblThanks.Size = new Size(271, 33);
            lblThanks.TabIndex = 2;
            lblThanks.Text = "Thank you for ordering";
            lblThanks.TextAlign = ContentAlignment.MiddleCenter;
            
            // 
            // lblOrderNum
            // 
            lblOrderNum.Font = new Font("Courier New", 18F, FontStyle.Bold);
            lblOrderNum.ForeColor = Color.FromArgb(184, 98, 48);
            lblOrderNum.Location = new Point(124, 221);
            lblOrderNum.Name = "lblOrderNum";
            lblOrderNum.Size = new Size(271, 43);
            lblOrderNum.TabIndex = 3;
            lblOrderNum.Text = "Order #: 00015";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(166, 94, 46);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(54, 280);
            button1.Name = "button1";
            button1.Size = new Size(160, 45);
            button1.TabIndex = 4;
            button1.Text = "Order Again";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(166, 94, 46);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(292, 280);
            button2.Name = "button2";
            button2.Size = new Size(160, 45);
            button2.TabIndex = 5;
            button2.Text = "View Receipt";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 225, 210);
            ClientSize = new Size(529, 386);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Padding = new Padding(3);
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblHeader;
        private Label lblOrderNum;
        private Label lblThanks;
        private Label lblStatus;
        private Button button2;
        private Button button1;
    }
}