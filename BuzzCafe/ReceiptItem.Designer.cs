namespace BuzzCafe
{
    partial class ReceiptItem
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
            lbItemName = new Label();
            lbQuantity = new Label();
            lbItemPrice = new Label();
            label3 = new Label();
            lbItemTotalPrice = new Label();
            lbSize = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbSize);
            panel1.Controls.Add(lbItemTotalPrice);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbItemPrice);
            panel1.Controls.Add(lbQuantity);
            panel1.Controls.Add(lbItemName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 85);
            panel1.TabIndex = 0;
            // 
            // lbItemName
            // 
            lbItemName.Anchor = AnchorStyles.Top;
            lbItemName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbItemName.Location = new Point(20, 12);
            lbItemName.Name = "lbItemName";
            lbItemName.Size = new Size(266, 21);
            lbItemName.TabIndex = 4;
            lbItemName.Text = "Item name";
            // 
            // lbQuantity
            // 
            lbQuantity.Anchor = AnchorStyles.Top;
            lbQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQuantity.Location = new Point(20, 42);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(46, 22);
            lbQuantity.TabIndex = 5;
            lbQuantity.Text = "Quan";
            // 
            // lbItemPrice
            // 
            lbItemPrice.Anchor = AnchorStyles.Top;
            lbItemPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbItemPrice.Location = new Point(101, 42);
            lbItemPrice.Name = "lbItemPrice";
            lbItemPrice.Size = new Size(81, 22);
            lbItemPrice.TabIndex = 6;
            lbItemPrice.Text = "Price";
            lbItemPrice.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 42);
            label3.Name = "label3";
            label3.Size = new Size(18, 22);
            label3.TabIndex = 7;
            label3.Text = "x";
            // 
            // lbItemTotalPrice
            // 
            lbItemTotalPrice.Anchor = AnchorStyles.Top;
            lbItemTotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbItemTotalPrice.Location = new Point(288, 42);
            lbItemTotalPrice.Name = "lbItemTotalPrice";
            lbItemTotalPrice.Size = new Size(94, 22);
            lbItemTotalPrice.TabIndex = 8;
            lbItemTotalPrice.Text = "TotalPrice";
            // 
            // lbSize
            // 
            lbSize.Anchor = AnchorStyles.Top;
            lbSize.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSize.Location = new Point(288, 12);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(81, 22);
            lbSize.TabIndex = 9;
            lbSize.Text = "Size";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 3);
            panel2.TabIndex = 10;
            // 
            // ReceiptItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ReceiptItem";
            Size = new Size(382, 85);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Label lbItemName;
        private Label label3;
        public Label lbItemPrice;
        public Label lbQuantity;
        public Label lbSize;
        public Label lbItemTotalPrice;
        private Panel panel2;
        private Label label2;
    }
}
