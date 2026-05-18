namespace BuzzCafe
{
    partial class ItemLayout
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
            panelItem = new Panel();
            btnAddTocart = new Button();
            lbPrice = new Label();
            lbItemName = new Label();
            pbItem = new PictureBox();
            panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbItem).BeginInit();
            SuspendLayout();
            // 
            // panelItem
            // 
            panelItem.BackColor = Color.Transparent;
            panelItem.Controls.Add(btnAddTocart);
            panelItem.Controls.Add(lbPrice);
            panelItem.Controls.Add(lbItemName);
            panelItem.Controls.Add(pbItem);
            panelItem.Dock = DockStyle.Fill;
            panelItem.Location = new Point(0, 0);
            panelItem.Name = "panelItem";
            panelItem.Size = new Size(218, 311);
            panelItem.TabIndex = 0;
            // 
            // btnAddTocart
            // 
            btnAddTocart.BackColor = Color.SaddleBrown;
            btnAddTocart.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnAddTocart.FlatStyle = FlatStyle.Flat;
            btnAddTocart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTocart.ForeColor = Color.White;
            btnAddTocart.Location = new Point(33, 236);
            btnAddTocart.Margin = new Padding(3, 4, 3, 4);
            btnAddTocart.Name = "btnAddTocart";
            btnAddTocart.Size = new Size(147, 44);
            btnAddTocart.TabIndex = 12;
            btnAddTocart.Text = "Add to Cart";
            btnAddTocart.UseVisualStyleBackColor = false;
            btnAddTocart.Click += btnAddTocart_Click;
            // 
            // lbPrice
            // 
            lbPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbPrice.AutoEllipsis = true;
            lbPrice.BackColor = Color.Transparent;
            lbPrice.Font = new Font("Constantia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPrice.ForeColor = Color.Black;
            lbPrice.Location = new Point(33, 194);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(185, 26);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            lbPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbItemName
            // 
            lbItemName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbItemName.AutoEllipsis = true;
            lbItemName.BackColor = Color.Transparent;
            lbItemName.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbItemName.ForeColor = Color.Black;
            lbItemName.Location = new Point(33, 168);
            lbItemName.Name = "lbItemName";
            lbItemName.Size = new Size(185, 26);
            lbItemName.TabIndex = 2;
            lbItemName.Text = "Prod. Name";
            lbItemName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbItem
            // 
            pbItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbItem.BackColor = Color.White;
            pbItem.Location = new Point(33, 24);
            pbItem.Name = "pbItem";
            pbItem.Size = new Size(151, 141);
            pbItem.SizeMode = PictureBoxSizeMode.Zoom;
            pbItem.TabIndex = 0;
            pbItem.TabStop = false;
            // 
            // ItemLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelItem);
            Name = "ItemLayout";
            Size = new Size(218, 311);
            panelItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panelItem;
        public Label lbItemName;
        public PictureBox pbItem;
        public Label lbPrice;
        private Button btnAddTocart;
    }
}
