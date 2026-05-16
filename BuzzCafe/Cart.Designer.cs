namespace BuzzCafe
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            lblcart = new Label();
            panelmenus = new Panel();
            panelfortotals = new Panel();
            panelorders = new Panel();
            pictureBox1 = new PictureBox();
            lblPrices = new Label();
            lblProductname = new Label();
            lblSize = new Label();
            btnminus = new Button();
            btnadd = new Button();
            lblCupSize = new Label();
            btnremove = new Button();
            lbltotals = new Label();
            lbltotal = new Label();
            btnpay = new Button();
            label3 = new Label();
            button1 = new Button();
            panelmenus.SuspendLayout();
            panelfortotals.SuspendLayout();
            panelorders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblcart
            // 
            lblcart.AutoSize = true;
            lblcart.BackColor = Color.Transparent;
            lblcart.Font = new Font("Constantia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcart.ForeColor = Color.White;
            lblcart.Location = new Point(33, 0);
            lblcart.Name = "lblcart";
            lblcart.Size = new Size(449, 59);
            lblcart.TabIndex = 0;
            lblcart.Text = "Your Order Details";
            // 
            // panelmenus
            // 
            panelmenus.BackColor = Color.Transparent;
            panelmenus.Controls.Add(button1);
            panelmenus.Controls.Add(panelorders);
            panelmenus.Controls.Add(lblcart);
            panelmenus.Location = new Point(12, 12);
            panelmenus.Name = "panelmenus";
            panelmenus.Size = new Size(510, 621);
            panelmenus.TabIndex = 1;
            // 
            // panelfortotals
            // 
            panelfortotals.BackColor = Color.Transparent;
            panelfortotals.BackgroundImage = Properties.Resources.bg;
            panelfortotals.BackgroundImageLayout = ImageLayout.Center;
            panelfortotals.Controls.Add(btnpay);
            panelfortotals.Controls.Add(lbltotal);
            panelfortotals.Controls.Add(lbltotals);
            panelfortotals.Location = new Point(-1, 639);
            panelfortotals.Name = "panelfortotals";
            panelfortotals.Size = new Size(535, 87);
            panelfortotals.TabIndex = 2;
            // 
            // panelorders
            // 
            panelorders.Controls.Add(label3);
            panelorders.Controls.Add(btnremove);
            panelorders.Controls.Add(lblCupSize);
            panelorders.Controls.Add(btnminus);
            panelorders.Controls.Add(btnadd);
            panelorders.Controls.Add(lblSize);
            panelorders.Controls.Add(lblPrices);
            panelorders.Controls.Add(lblProductname);
            panelorders.Controls.Add(pictureBox1);
            panelorders.Location = new Point(16, 62);
            panelorders.Name = "panelorders";
            panelorders.Size = new Size(476, 90);
            panelorders.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(6, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 80);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblPrices
            // 
            lblPrices.AutoSize = true;
            lblPrices.BackColor = Color.Transparent;
            lblPrices.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrices.ForeColor = Color.Transparent;
            lblPrices.Location = new Point(367, 19);
            lblPrices.Name = "lblPrices";
            lblPrices.Size = new Size(82, 27);
            lblPrices.TabIndex = 4;
            lblPrices.Text = "₱149.50";
            // 
            // lblProductname
            // 
            lblProductname.AutoEllipsis = true;
            lblProductname.AutoSize = true;
            lblProductname.BackColor = Color.Transparent;
            lblProductname.Font = new Font("Constantia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductname.ForeColor = Color.Transparent;
            lblProductname.Location = new Point(95, 13);
            lblProductname.Name = "lblProductname";
            lblProductname.Size = new Size(154, 33);
            lblProductname.TabIndex = 3;
            lblProductname.Text = "Americano";
            lblProductname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.ForeColor = Color.Transparent;
            lblSize.Location = new Point(95, 49);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(53, 27);
            lblSize.TabIndex = 10;
            lblSize.Text = "Size:";
            // 
            // btnminus
            // 
            btnminus.BackColor = Color.White;
            btnminus.BackgroundImage = (Image)resources.GetObject("btnminus.BackgroundImage");
            btnminus.BackgroundImageLayout = ImageLayout.Zoom;
            btnminus.FlatStyle = FlatStyle.Flat;
            btnminus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnminus.ForeColor = Color.Black;
            btnminus.ImageAlign = ContentAlignment.MiddleLeft;
            btnminus.Location = new Point(367, 56);
            btnminus.Name = "btnminus";
            btnminus.RightToLeft = RightToLeft.Yes;
            btnminus.Size = new Size(20, 20);
            btnminus.TabIndex = 12;
            btnminus.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.White;
            btnadd.BackgroundImage = Properties.Resources.add;
            btnadd.BackgroundImageLayout = ImageLayout.Stretch;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.ForeColor = Color.Black;
            btnadd.ImageAlign = ContentAlignment.MiddleLeft;
            btnadd.Location = new Point(425, 56);
            btnadd.Name = "btnadd";
            btnadd.RightToLeft = RightToLeft.Yes;
            btnadd.Size = new Size(20, 20);
            btnadd.TabIndex = 11;
            btnadd.UseVisualStyleBackColor = false;
            // 
            // lblCupSize
            // 
            lblCupSize.AutoSize = true;
            lblCupSize.BackColor = Color.Transparent;
            lblCupSize.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCupSize.ForeColor = Color.Transparent;
            lblCupSize.Location = new Point(143, 49);
            lblCupSize.Name = "lblCupSize";
            lblCupSize.Size = new Size(78, 27);
            lblCupSize.TabIndex = 13;
            lblCupSize.Text = "SMALL";
            // 
            // btnremove
            // 
            btnremove.BackColor = Color.Gray;
            btnremove.BackgroundImage = (Image)resources.GetObject("btnremove.BackgroundImage");
            btnremove.BackgroundImageLayout = ImageLayout.Stretch;
            btnremove.FlatStyle = FlatStyle.Flat;
            btnremove.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnremove.ForeColor = Color.Black;
            btnremove.ImageAlign = ContentAlignment.MiddleLeft;
            btnremove.Location = new Point(460, 1);
            btnremove.Name = "btnremove";
            btnremove.RightToLeft = RightToLeft.Yes;
            btnremove.Size = new Size(15, 15);
            btnremove.TabIndex = 12;
            btnremove.UseVisualStyleBackColor = false;
            btnremove.Click += button1_Click;
            // 
            // lbltotals
            // 
            lbltotals.AutoSize = true;
            lbltotals.BackColor = Color.Transparent;
            lbltotals.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotals.ForeColor = Color.White;
            lbltotals.Location = new Point(23, 20);
            lbltotals.Name = "lbltotals";
            lbltotals.Size = new Size(62, 26);
            lbltotals.TabIndex = 1;
            lbltotals.Text = "Total";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.BackColor = Color.Transparent;
            lbltotal.FlatStyle = FlatStyle.Flat;
            lbltotal.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotal.ForeColor = Color.Transparent;
            lbltotal.Location = new Point(29, 46);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(108, 20);
            lbltotal.TabIndex = 5;
            lbltotal.Text = "Php ₱149.50";
            lbltotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnpay
            // 
            btnpay.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpay.Location = new Point(368, 27);
            btnpay.Name = "btnpay";
            btnpay.Size = new Size(155, 45);
            btnpay.TabIndex = 6;
            btnpay.Text = "Continue to pay";
            btnpay.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(393, 59);
            label3.Name = "label3";
            label3.Size = new Size(28, 17);
            label3.TabIndex = 14;
            label3.Text = "Qty";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(27, 27);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(534, 728);
            Controls.Add(panelfortotals);
            Controls.Add(panelmenus);
            Name = "Cart";
            Text = "Cart";
            panelmenus.ResumeLayout(false);
            panelmenus.PerformLayout();
            panelfortotals.ResumeLayout(false);
            panelfortotals.PerformLayout();
            panelorders.ResumeLayout(false);
            panelorders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblcart;
        private Panel panelmenus;
        private Panel panelfortotals;
        private Panel panelorders;
        private PictureBox pictureBox1;
        public Label lblPrices;
        public Label lblProductname;
        public Label lblSize;
        private Button btnminus;
        private Button btnadd;
        public Label lblCupSize;
        private Button btnremove;
        private Label lbltotals;
        public Label lbltotal;
        private Label label3;
        private Button btnpay;
        private Button button1;
    }
}