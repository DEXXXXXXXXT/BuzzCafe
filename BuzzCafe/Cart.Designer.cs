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
            button1 = new Button();
            panelorders = new Panel();
            label3 = new Label();
            btnremove = new Button();
            lblCupSize = new Label();
            btnminus = new Button();
            btnadd = new Button();
            lblSize = new Label();
            lblPrices = new Label();
            lblProductname = new Label();
            pictureBox1 = new PictureBox();
            panelfortotals = new Panel();
            btnpay = new Button();
            lbltotal = new Label();
            lbltotals = new Label();
            panelmenus.SuspendLayout();
            panelorders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelfortotals.SuspendLayout();
            SuspendLayout();
            // 
            // lblcart
            // 
            lblcart.AutoSize = true;
            lblcart.BackColor = Color.Transparent;
            lblcart.Font = new Font("Constantia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcart.ForeColor = Color.White;
            lblcart.Location = new Point(38, 0);
            lblcart.Name = "lblcart";
            lblcart.Size = new Size(559, 73);
            lblcart.TabIndex = 0;
            lblcart.Text = "Your Order Details";
            // 
            // panelmenus
            // 
            panelmenus.BackColor = Color.Transparent;
            panelmenus.Controls.Add(button1);
            panelmenus.Controls.Add(panelorders);
            panelmenus.Controls.Add(lblcart);
            panelmenus.Location = new Point(14, 16);
            panelmenus.Margin = new Padding(3, 4, 3, 4);
            panelmenus.Name = "panelmenus";
            panelmenus.Size = new Size(515, 828);
            panelmenus.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(31, 36);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
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
            panelorders.Location = new Point(18, 83);
            panelorders.Margin = new Padding(3, 4, 3, 4);
            panelorders.Name = "panelorders";
            panelorders.Size = new Size(544, 120);
            panelorders.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(449, 79);
            label3.Name = "label3";
            label3.Size = new Size(37, 23);
            label3.TabIndex = 14;
            label3.Text = "Qty";
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
            btnremove.Location = new Point(526, 1);
            btnremove.Margin = new Padding(3, 4, 3, 4);
            btnremove.Name = "btnremove";
            btnremove.RightToLeft = RightToLeft.Yes;
            btnremove.Size = new Size(17, 20);
            btnremove.TabIndex = 12;
            btnremove.UseVisualStyleBackColor = false;
            btnremove.Click += button1_Click;
            // 
            // lblCupSize
            // 
            lblCupSize.AutoSize = true;
            lblCupSize.BackColor = Color.Transparent;
            lblCupSize.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCupSize.ForeColor = Color.Transparent;
            lblCupSize.Location = new Point(163, 65);
            lblCupSize.Name = "lblCupSize";
            lblCupSize.Size = new Size(97, 34);
            lblCupSize.TabIndex = 13;
            lblCupSize.Text = "SMALL";
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
            btnminus.Location = new Point(419, 75);
            btnminus.Margin = new Padding(3, 4, 3, 4);
            btnminus.Name = "btnminus";
            btnminus.RightToLeft = RightToLeft.Yes;
            btnminus.Size = new Size(23, 27);
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
            btnadd.Location = new Point(486, 75);
            btnadd.Margin = new Padding(3, 4, 3, 4);
            btnadd.Name = "btnadd";
            btnadd.RightToLeft = RightToLeft.Yes;
            btnadd.Size = new Size(23, 27);
            btnadd.TabIndex = 11;
            btnadd.UseVisualStyleBackColor = false;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.ForeColor = Color.Transparent;
            lblSize.Location = new Point(109, 65);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(65, 34);
            lblSize.TabIndex = 10;
            lblSize.Text = "Size:";
            // 
            // lblPrices
            // 
            lblPrices.AutoSize = true;
            lblPrices.BackColor = Color.Transparent;
            lblPrices.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrices.ForeColor = Color.Transparent;
            lblPrices.Location = new Point(419, 25);
            lblPrices.Name = "lblPrices";
            lblPrices.Size = new Size(100, 34);
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
            lblProductname.Location = new Point(109, 17);
            lblProductname.Name = "lblProductname";
            lblProductname.Size = new Size(193, 41);
            lblProductname.TabIndex = 3;
            lblProductname.Text = "Americano";
            lblProductname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(7, 5);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 107);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelfortotals
            // 
            panelfortotals.BackColor = Color.Transparent;
            panelfortotals.BackgroundImage = Properties.Resources.bg;
            panelfortotals.BackgroundImageLayout = ImageLayout.Center;
            panelfortotals.Controls.Add(btnpay);
            panelfortotals.Controls.Add(lbltotal);
            panelfortotals.Controls.Add(lbltotals);
            panelfortotals.Location = new Point(-1, 852);
            panelfortotals.Margin = new Padding(3, 4, 3, 4);
            panelfortotals.Name = "panelfortotals";
            panelfortotals.Size = new Size(611, 116);
            panelfortotals.TabIndex = 2;
            // 
            // btnpay
            // 
            btnpay.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpay.Location = new Point(421, 36);
            btnpay.Margin = new Padding(3, 4, 3, 4);
            btnpay.Name = "btnpay";
            btnpay.Size = new Size(177, 60);
            btnpay.TabIndex = 6;
            btnpay.Text = "Continue to pay";
            btnpay.UseVisualStyleBackColor = true;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.BackColor = Color.Transparent;
            lbltotal.FlatStyle = FlatStyle.Flat;
            lbltotal.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotal.ForeColor = Color.Transparent;
            lbltotal.Location = new Point(33, 61);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(130, 24);
            lbltotal.TabIndex = 5;
            lbltotal.Text = "Php ₱149.50";
            lbltotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltotals
            // 
            lbltotals.AutoSize = true;
            lbltotals.BackColor = Color.Transparent;
            lbltotals.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotals.ForeColor = Color.White;
            lbltotals.Location = new Point(26, 27);
            lbltotals.Name = "lbltotals";
            lbltotals.Size = new Size(80, 33);
            lbltotals.TabIndex = 1;
            lbltotals.Text = "Total";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(610, 971);
            Controls.Add(panelfortotals);
            Controls.Add(panelmenus);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cart";
            Text = "Cart";
            panelmenus.ResumeLayout(false);
            panelmenus.PerformLayout();
            panelorders.ResumeLayout(false);
            panelorders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelfortotals.ResumeLayout(false);
            panelfortotals.PerformLayout();
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