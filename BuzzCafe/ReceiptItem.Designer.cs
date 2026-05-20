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
            panelReceiptItem = new Panel();
            lbPricetoadd = new Label();
            panel2 = new Panel();
            lbSize = new Label();
            lbItemTotalPrice = new Label();
            label3 = new Label();
            lbItemPrice = new Label();
            lbQuantity = new Label();
            lbItemName = new Label();
            panelReceiptItem.SuspendLayout();
            SuspendLayout();
            // 
            // panelReceiptItem
            // 
            panelReceiptItem.Controls.Add(lbPricetoadd);
            panelReceiptItem.Controls.Add(panel2);
            panelReceiptItem.Controls.Add(lbSize);
            panelReceiptItem.Controls.Add(lbItemTotalPrice);
            panelReceiptItem.Controls.Add(label3);
            panelReceiptItem.Controls.Add(lbItemPrice);
            panelReceiptItem.Controls.Add(lbQuantity);
            panelReceiptItem.Controls.Add(lbItemName);
            panelReceiptItem.Dock = DockStyle.Fill;
            panelReceiptItem.Location = new Point(0, 0);
            panelReceiptItem.Name = "panelReceiptItem";
            panelReceiptItem.Size = new Size(542, 78);
            panelReceiptItem.TabIndex = 0;
            // 
            // lbPricetoadd
            // 
            lbPricetoadd.Anchor = AnchorStyles.Top;
            lbPricetoadd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPricetoadd.Location = new Point(201, 42);
            lbPricetoadd.Name = "lbPricetoadd";
            lbPricetoadd.Size = new Size(60, 22);
            lbPricetoadd.TabIndex = 11;
            lbPricetoadd.Text = "add";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 1);
            panel2.TabIndex = 10;
            // 
            // lbSize
            // 
            lbSize.Anchor = AnchorStyles.Top;
            lbSize.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSize.Location = new Point(368, 12);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(81, 22);
            lbSize.TabIndex = 9;
            lbSize.Text = "Size";
            // 
            // lbItemTotalPrice
            // 
            lbItemTotalPrice.Anchor = AnchorStyles.Top;
            lbItemTotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbItemTotalPrice.Location = new Point(368, 42);
            lbItemTotalPrice.Margin = new Padding(0, 0, 0, 5);
            lbItemTotalPrice.Name = "lbItemTotalPrice";
            lbItemTotalPrice.Size = new Size(94, 22);
            lbItemTotalPrice.TabIndex = 8;
            lbItemTotalPrice.Text = "TotalPrice";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(131, 42);
            label3.Name = "label3";
            label3.Size = new Size(18, 22);
            label3.TabIndex = 7;
            label3.Text = "x";
            // 
            // lbItemPrice
            // 
            lbItemPrice.Anchor = AnchorStyles.Top;
            lbItemPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbItemPrice.Location = new Point(148, 42);
            lbItemPrice.Name = "lbItemPrice";
            lbItemPrice.Size = new Size(60, 22);
            lbItemPrice.TabIndex = 6;
            lbItemPrice.Text = "Price";
            lbItemPrice.Click += label2_Click;
            // 
            // lbQuantity
            // 
            lbQuantity.Anchor = AnchorStyles.Top;
            lbQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQuantity.Location = new Point(100, 42);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(34, 22);
            lbQuantity.TabIndex = 5;
            lbQuantity.Text = "Quan";
            // 
            // lbItemName
            // 
            lbItemName.Anchor = AnchorStyles.Top;
            lbItemName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbItemName.Location = new Point(100, 12);
            lbItemName.Name = "lbItemName";
            lbItemName.Size = new Size(266, 21);
            lbItemName.TabIndex = 4;
            lbItemName.Text = "Item name";
            // 
            // ReceiptItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelReceiptItem);
            DoubleBuffered = true;
            Name = "ReceiptItem";
            Size = new Size(542, 78);
            panelReceiptItem.ResumeLayout(false);
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
        public Panel panelReceiptItem;
        public Label lbPricetoadd;
    }
}
