namespace BuzzCafe
{
    partial class CartItem
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
            ItemCart = new Panel();
            toAddPrice = new Label();
            panelCartsize = new Panel();
            lbSize = new Label();
            lblSize = new Label();
            lbProductPrice = new Label();
            lbItemPrice = new Label();
            panelQuantity = new Panel();
            btnReduce = new Button();
            btnAdd = new Button();
            lbqCount = new Label();
            lbProdName = new Label();
            pbImage = new PictureBox();
            ItemCart.SuspendLayout();
            panelCartsize.SuspendLayout();
            panelQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // ItemCart
            // 
            ItemCart.BackColor = Color.FromArgb(64, 64, 64);
            ItemCart.BorderStyle = BorderStyle.FixedSingle;
            ItemCart.Controls.Add(toAddPrice);
            ItemCart.Controls.Add(panelCartsize);
            ItemCart.Controls.Add(lbProductPrice);
            ItemCart.Controls.Add(lbItemPrice);
            ItemCart.Controls.Add(panelQuantity);
            ItemCart.Controls.Add(lbProdName);
            ItemCart.Controls.Add(pbImage);
            ItemCart.Dock = DockStyle.Fill;
            ItemCart.Location = new Point(0, 0);
            ItemCart.Name = "ItemCart";
            ItemCart.Size = new Size(610, 168);
            ItemCart.TabIndex = 1;
            // 
            // toAddPrice
            // 
            toAddPrice.BackColor = Color.Transparent;
            toAddPrice.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toAddPrice.ForeColor = Color.Transparent;
            toAddPrice.Location = new Point(233, 59);
            toAddPrice.Name = "toAddPrice";
            toAddPrice.Size = new Size(70, 34);
            toAddPrice.TabIndex = 17;
            toAddPrice.Text = "add";
            toAddPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCartsize
            // 
            panelCartsize.Controls.Add(lbSize);
            panelCartsize.Controls.Add(lblSize);
            panelCartsize.Location = new Point(175, 97);
            panelCartsize.Name = "panelCartsize";
            panelCartsize.Size = new Size(182, 49);
            panelCartsize.TabIndex = 16;
            // 
            // lbSize
            // 
            lbSize.BackColor = Color.Transparent;
            lbSize.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSize.ForeColor = Color.Transparent;
            lbSize.Location = new Point(67, 12);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(115, 34);
            lbSize.TabIndex = 12;
            lbSize.Text = "sizeData";
            // 
            // lblSize
            // 
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.ForeColor = Color.Transparent;
            lblSize.Location = new Point(12, 12);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(75, 34);
            lblSize.TabIndex = 11;
            lblSize.Text = "Size:";
            // 
            // lbProductPrice
            // 
            lbProductPrice.BackColor = Color.Transparent;
            lbProductPrice.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProductPrice.ForeColor = Color.Transparent;
            lbProductPrice.Location = new Point(175, 60);
            lbProductPrice.Name = "lbProductPrice";
            lbProductPrice.Size = new Size(75, 34);
            lbProductPrice.TabIndex = 15;
            lbProductPrice.Text = "price";
            // 
            // lbItemPrice
            // 
            lbItemPrice.BackColor = Color.Transparent;
            lbItemPrice.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbItemPrice.ForeColor = Color.Transparent;
            lbItemPrice.Location = new Point(472, 30);
            lbItemPrice.Name = "lbItemPrice";
            lbItemPrice.Size = new Size(115, 34);
            lbItemPrice.TabIndex = 14;
            lbItemPrice.Text = "Item per price";
            // 
            // panelQuantity
            // 
            panelQuantity.BackColor = Color.Transparent;
            panelQuantity.Controls.Add(btnReduce);
            panelQuantity.Controls.Add(btnAdd);
            panelQuantity.Controls.Add(lbqCount);
            panelQuantity.Location = new Point(411, 63);
            panelQuantity.Name = "panelQuantity";
            panelQuantity.Size = new Size(176, 64);
            panelQuantity.TabIndex = 13;
            // 
            // btnReduce
            // 
            btnReduce.Anchor = AnchorStyles.Top;
            btnReduce.FlatStyle = FlatStyle.Flat;
            btnReduce.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReduce.ForeColor = Color.White;
            btnReduce.Location = new Point(7, 18);
            btnReduce.Margin = new Padding(3, 4, 3, 4);
            btnReduce.Name = "btnReduce";
            btnReduce.Size = new Size(45, 31);
            btnReduce.TabIndex = 14;
            btnReduce.Text = "-";
            btnReduce.UseVisualStyleBackColor = true;
            btnReduce.Click += btnReduce_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(97, 18);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(45, 31);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbqCount
            // 
            lbqCount.Anchor = AnchorStyles.Top;
            lbqCount.BackColor = Color.Transparent;
            lbqCount.Font = new Font("Microsoft Himalaya", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbqCount.ForeColor = Color.Transparent;
            lbqCount.Location = new Point(51, 15);
            lbqCount.Name = "lbqCount";
            lbqCount.Size = new Size(52, 45);
            lbqCount.TabIndex = 13;
            lbqCount.Text = "1";
            lbqCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbProdName
            // 
            lbProdName.AutoEllipsis = true;
            lbProdName.BackColor = Color.Transparent;
            lbProdName.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProdName.ForeColor = Color.Transparent;
            lbProdName.Location = new Point(175, 19);
            lbProdName.Name = "lbProdName";
            lbProdName.Size = new Size(365, 41);
            lbProdName.TabIndex = 4;
            lbProdName.Text = "Name";
            lbProdName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbImage
            // 
            pbImage.BackColor = Color.Transparent;
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Location = new Point(32, 19);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(128, 127);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // CartItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemCart);
            Name = "CartItem";
            Size = new Size(610, 168);
            ItemCart.ResumeLayout(false);
            panelCartsize.ResumeLayout(false);
            panelQuantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public Label lbItemPrice;
        public Panel panelQuantity;
        public Button btnReduce;
        private Button btnAdd;
        public Label lbqCount;
        public Label lbSize;
        public Label lblSize;
        public Label lbProdName;
        public PictureBox pbImage;
        public Label lbProductPrice;
        public Panel panelCartsize;
        public Label toAddPrice;
        public Panel ItemCart;
    }
}
