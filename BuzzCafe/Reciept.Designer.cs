namespace BuzzCafe
{
    partial class Reciept
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
            panel2 = new Panel();
            flReceipt = new FlowLayoutPanel();
            panel3 = new Panel();
            label4 = new Label();
            label7 = new Label();
            lbVat = new Label();
            panel5 = new Panel();
            panelReciept = new Panel();
            label5 = new Label();
            lbTotal = new Label();
            panel4 = new Panel();
            label9 = new Label();
            lbSubtotal = new Label();
            panelReciept.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 17);
            label1.Name = "label1";
            label1.Size = new Size(181, 50);
            label1.TabIndex = 0;
            label1.Text = "Buzz Cafe";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-3, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 2);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 87);
            label2.Name = "label2";
            label2.Size = new Size(135, 29);
            label2.TabIndex = 2;
            label2.Text = "Order Number:";
            // 
            // lborderNum
            // 
            lborderNum.Anchor = AnchorStyles.Top;
            lborderNum.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lborderNum.Location = new Point(202, 87);
            lborderNum.Name = "lborderNum";
            lborderNum.Size = new Size(181, 29);
            lborderNum.TabIndex = 3;
            lborderNum.Text = "data";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 116);
            label3.Name = "label3";
            label3.Size = new Size(55, 29);
            label3.TabIndex = 4;
            label3.Text = "Date:";
            label3.Click += label3_Click;
            // 
            // lbDate
            // 
            lbDate.Anchor = AnchorStyles.Top;
            lbDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(107, 116);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(159, 29);
            lbDate.TabIndex = 5;
            lbDate.Text = "data";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(-3, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(567, 2);
            panel2.TabIndex = 2;
            // 
            // flReceipt
            // 
            flReceipt.AutoScroll = true;
            flReceipt.FlowDirection = FlowDirection.TopDown;
            flReceipt.Location = new Point(3, 167);
            flReceipt.Name = "flReceipt";
            flReceipt.Padding = new Padding(30, 10, 0, 0);
            flReceipt.Size = new Size(558, 366);
            flReceipt.TabIndex = 6;
            flReceipt.WrapContents = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(0, 539);
            panel3.Name = "panel3";
            panel3.Size = new Size(567, 2);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 557);
            label4.Name = "label4";
            label4.Size = new Size(91, 29);
            label4.TabIndex = 7;
            label4.Text = "Subtotal:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 586);
            label7.Name = "label7";
            label7.Size = new Size(55, 29);
            label7.TabIndex = 7;
            label7.Text = "VAT:";
            // 
            // lbVat
            // 
            lbVat.Anchor = AnchorStyles.Top;
            lbVat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVat.Location = new Point(143, 586);
            lbVat.Name = "lbVat";
            lbVat.Size = new Size(159, 29);
            lbVat.TabIndex = 8;
            lbVat.Text = "data";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(-2, 629);
            panel5.Name = "panel5";
            panel5.Size = new Size(567, 2);
            panel5.TabIndex = 6;
            // 
            // panelReciept
            // 
            panelReciept.Controls.Add(label5);
            panelReciept.Controls.Add(lbTotal);
            panelReciept.Controls.Add(panel4);
            panelReciept.Controls.Add(label9);
            panelReciept.Controls.Add(lbSubtotal);
            panelReciept.Controls.Add(panel5);
            panelReciept.Controls.Add(lbVat);
            panelReciept.Controls.Add(label7);
            panelReciept.Controls.Add(label4);
            panelReciept.Controls.Add(panel3);
            panelReciept.Controls.Add(flReceipt);
            panelReciept.Controls.Add(panel2);
            panelReciept.Controls.Add(lbDate);
            panelReciept.Controls.Add(label3);
            panelReciept.Controls.Add(lborderNum);
            panelReciept.Controls.Add(label2);
            panelReciept.Controls.Add(panel1);
            panelReciept.Controls.Add(label1);
            panelReciept.Dock = DockStyle.Fill;
            panelReciept.Location = new Point(0, 0);
            panelReciept.Name = "panelReciept";
            panelReciept.Size = new Size(561, 838);
            panelReciept.TabIndex = 0;
            panelReciept.Paint += panelReciept_Paint;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(190, 748);
            label5.Name = "label5";
            label5.Size = new Size(211, 29);
            label5.TabIndex = 15;
            label5.Text = "Thank you for visiting!";
            // 
            // lbTotal
            // 
            lbTotal.Anchor = AnchorStyles.Top;
            lbTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotal.Location = new Point(143, 663);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(159, 29);
            lbTotal.TabIndex = 14;
            lbTotal.Text = "data";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(2, 718);
            panel4.Name = "panel4";
            panel4.Size = new Size(557, 2);
            panel4.TabIndex = 10;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(46, 663);
            label9.Name = "label9";
            label9.Size = new Size(63, 29);
            label9.TabIndex = 12;
            label9.Text = "Total:";
            // 
            // lbSubtotal
            // 
            lbSubtotal.Anchor = AnchorStyles.Top;
            lbSubtotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSubtotal.Location = new Point(143, 557);
            lbSubtotal.Name = "lbSubtotal";
            lbSubtotal.Size = new Size(159, 29);
            lbSubtotal.TabIndex = 9;
            lbSubtotal.Text = "data";
            // 
            // Reciept
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelReciept);
            Name = "Reciept";
            Size = new Size(561, 838);
            panelReciept.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label lborderNum;
        private Label label3;
        private Label lbDate;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Label label4;
        private Label label7;
        private Label lbVat;
        private Panel panel5;
        public Panel panelReciept;
        private Label lbTotal;
        private Panel panel4;
        private Label label9;
        private Label lbSubtotal;
        private Label label5;
        public FlowLayoutPanel flReceipt;
    }
}
