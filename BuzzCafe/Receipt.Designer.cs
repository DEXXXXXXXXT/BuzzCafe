namespace BuzzCafe
{
    partial class Receipt
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            lborderNum = new Label();
            label3 = new Label();
            lbDate = new Label();
            panelReciept = new Panel();
            flReceipt = new FlowLayoutPanel();
            panel7 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            lbSubtotal = new Label();
            label4 = new Label();
            lbVat = new Label();
            label7 = new Label();
            label9 = new Label();
            lbTotal = new Label();
            panel6 = new Panel();
            lbOrderType = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panelReciept.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.FromArgb(166, 94, 46);
            label1.Font = new Font("Georgia", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(54, 43, 36);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(562, 72);
            label1.TabIndex = 0;
            label1.Text = "Buzz Cafe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-2, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 2);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(80, 70, 65);
            label2.Location = new Point(39, 87);
            label2.Name = "label2";
            label2.Size = new Size(135, 29);
            label2.TabIndex = 2;
            label2.Text = "Order Number:";
            // 
            // lborderNum
            // 
            lborderNum.Anchor = AnchorStyles.Top;
            lborderNum.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lborderNum.Location = new Point(168, 87);
            lborderNum.Name = "lborderNum";
            lborderNum.Size = new Size(64, 29);
            lborderNum.TabIndex = 3;
            lborderNum.Text = "data";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(80, 70, 65);
            label3.Location = new Point(39, 116);
            label3.Name = "label3";
            label3.Size = new Size(55, 29);
            label3.TabIndex = 4;
            label3.Text = "Date:";
            // 
            // lbDate
            // 
            lbDate.Anchor = AnchorStyles.Top;
            lbDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(88, 116);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(159, 29);
            lbDate.TabIndex = 5;
            lbDate.Text = "data";
            // 
            // panelReciept
            // 
            panelReciept.BackColor = Color.Transparent;
            panelReciept.Controls.Add(flReceipt);
            panelReciept.Controls.Add(panel7);
            panelReciept.Controls.Add(panel6);
            panelReciept.Dock = DockStyle.Fill;
            panelReciept.Location = new Point(0, 0);
            panelReciept.Name = "panelReciept";
            panelReciept.Size = new Size(562, 993);
            panelReciept.TabIndex = 0;
            // 
            // flReceipt
            // 
            flReceipt.Anchor = AnchorStyles.Top;
            flReceipt.AutoScroll = true;
            flReceipt.BackColor = Color.FromArgb(249, 246, 240);
            flReceipt.FlowDirection = FlowDirection.TopDown;
            flReceipt.Location = new Point(10, 193);
            flReceipt.Margin = new Padding(10);
            flReceipt.Name = "flReceipt";
            flReceipt.Size = new Size(542, 526);
            flReceipt.TabIndex = 19;
            flReceipt.WrapContents = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Controls.Add(label5);
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(panel4);
            panel7.Controls.Add(panel5);
            panel7.Controls.Add(lbSubtotal);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(lbVat);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(lbTotal);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 732);
            panel7.Name = "panel7";
            panel7.Size = new Size(562, 261);
            panel7.TabIndex = 17;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Italic);
            label5.ForeColor = Color.FromArgb(140, 130, 122);
            label5.Location = new Point(140, 198);
            label5.Name = "label5";
            label5.Size = new Size(275, 39);
            label5.TabIndex = 24;
            label5.Text = "Thank you for visiting!";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(0, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(567, 2);
            panel3.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(0, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(567, 2);
            panel4.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(-2, 175);
            panel5.Name = "panel5";
            panel5.Size = new Size(567, 2);
            panel5.TabIndex = 21;
            // 
            // lbSubtotal
            // 
            lbSubtotal.Anchor = AnchorStyles.Top;
            lbSubtotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSubtotal.Location = new Point(423, 30);
            lbSubtotal.Name = "lbSubtotal";
            lbSubtotal.Size = new Size(144, 29);
            lbSubtotal.TabIndex = 20;
            lbSubtotal.Text = "data";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.FromArgb(80, 70, 65);
            label4.Location = new Point(39, 30);
            label4.Name = "label4";
            label4.Size = new Size(91, 29);
            label4.TabIndex = 19;
            label4.Text = "Subtotal:";
            // 
            // lbVat
            // 
            lbVat.Anchor = AnchorStyles.Top;
            lbVat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVat.Location = new Point(423, 59);
            lbVat.Name = "lbVat";
            lbVat.Size = new Size(142, 29);
            lbVat.TabIndex = 18;
            lbVat.Text = "data";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.FromArgb(80, 70, 65);
            label7.Location = new Point(39, 59);
            label7.Name = "label7";
            label7.Size = new Size(55, 29);
            label7.TabIndex = 17;
            label7.Text = "VAT:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(54, 43, 36);
            label9.Location = new Point(39, 121);
            label9.Name = "label9";
            label9.Size = new Size(73, 29);
            label9.TabIndex = 16;
            label9.Text = "Total:";
            // 
            // lbTotal
            // 
            lbTotal.Anchor = AnchorStyles.Top;
            lbTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotal.Location = new Point(423, 125);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(147, 29);
            lbTotal.TabIndex = 15;
            lbTotal.Text = "data";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(lbOrderType);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(lbDate);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(lborderNum);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(panel1);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(562, 193);
            panel6.TabIndex = 16;
            // 
            // lbOrderType
            // 
            lbOrderType.Anchor = AnchorStyles.Top;
            lbOrderType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbOrderType.Location = new Point(140, 145);
            lbOrderType.Name = "lbOrderType";
            lbOrderType.Size = new Size(159, 29);
            lbOrderType.TabIndex = 7;
            lbOrderType.Text = "data";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(80, 70, 65);
            label6.Location = new Point(39, 145);
            label6.Name = "label6";
            label6.Size = new Size(106, 29);
            label6.TabIndex = 6;
            label6.Text = "Order Type:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(166, 94, 46);
            pictureBox1.Image = Properties.Resources.back;
            pictureBox1.Location = new Point(3, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(3, 183);
            panel2.Name = "panel2";
            panel2.Size = new Size(567, 2);
            panel2.TabIndex = 2;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelReciept);
            Name = "Receipt";
            Size = new Size(562, 993);
            panelReciept.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        public Panel panelReciept;
        public Panel panel6;
        public Panel panel7;
        private Label label5;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Label label7;
        private Label label9;
        public FlowLayoutPanel flReceipt;
        public Label lborderNum;
        public Label lbDate;
        public Label lbSubtotal;
        public Label lbVat;
        public Label lbTotal;
        private Label label6;
        public Label lbOrderType;
        private PictureBox pictureBox1;
    }
}
