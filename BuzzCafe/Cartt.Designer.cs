namespace BuzzCafe
{
    partial class Cartt
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
            panelCart = new Panel();
            flCart = new FlowLayoutPanel();
            panelfortotals = new Panel();
            lbTotalPrice = new Label();
            btnPlace = new Button();
            lbltotals = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lblcart = new Label();
            pictureBox1 = new PictureBox();
            panelCart.SuspendLayout();
            panelfortotals.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelCart
            // 
            panelCart.BackColor = Color.Transparent;
            panelCart.Controls.Add(flCart);
            panelCart.Controls.Add(panelfortotals);
            panelCart.Controls.Add(panel2);
            panelCart.Dock = DockStyle.Fill;
            panelCart.Location = new Point(0, 0);
            panelCart.Name = "panelCart";
            panelCart.Size = new Size(733, 888);
            panelCart.TabIndex = 0;
            // 
            // flCart
            // 
            flCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flCart.AutoScroll = true;
            flCart.BorderStyle = BorderStyle.Fixed3D;
            flCart.FlowDirection = FlowDirection.TopDown;
            flCart.Location = new Point(3, 98);
            flCart.Name = "flCart";
            flCart.Padding = new Padding(30);
            flCart.Size = new Size(724, 672);
            flCart.TabIndex = 4;
            flCart.WrapContents = false;
            // 
            // panelfortotals
            // 
            panelfortotals.Anchor = AnchorStyles.Bottom;
            panelfortotals.BackColor = Color.FromArgb(30, 24, 20);
            panelfortotals.BackgroundImageLayout = ImageLayout.Center;
            panelfortotals.Controls.Add(lbTotalPrice);
            panelfortotals.Controls.Add(btnPlace);
            panelfortotals.Controls.Add(lbltotals);
            panelfortotals.Location = new Point(3, 764);
            panelfortotals.Margin = new Padding(3, 4, 3, 4);
            panelfortotals.Name = "panelfortotals";
            panelfortotals.Size = new Size(727, 120);
            panelfortotals.TabIndex = 3;
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.Anchor = AnchorStyles.None;
            lbTotalPrice.BackColor = Color.Transparent;
            lbTotalPrice.FlatStyle = FlatStyle.Flat;
            lbTotalPrice.Font = new Font("Arial", 18F, FontStyle.Bold);
            lbTotalPrice.ForeColor = Color.FromArgb(212, 143, 56);
            lbTotalPrice.Location = new Point(14, 63);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(195, 35);
            lbTotalPrice.TabIndex = 7;
            lbTotalPrice.Text = "price";
            lbTotalPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPlace
            // 
            btnPlace.Anchor = AnchorStyles.None;
            btnPlace.BackColor = Color.FromArgb(153, 102, 51);
            btnPlace.FlatAppearance.BorderSize = 0;
            btnPlace.FlatStyle = FlatStyle.Flat;
            btnPlace.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPlace.ForeColor = Color.White;
            btnPlace.Location = new Point(509, 27);
            btnPlace.Margin = new Padding(3, 4, 3, 4);
            btnPlace.Name = "btnPlace";
            btnPlace.Size = new Size(198, 71);
            btnPlace.TabIndex = 6;
            btnPlace.Text = "Place Order";
            btnPlace.UseVisualStyleBackColor = false;
            btnPlace.Click += btnPlace_Click;
            // 
            // lbltotals
            // 
            lbltotals.Anchor = AnchorStyles.None;
            lbltotals.AutoSize = true;
            lbltotals.BackColor = Color.Transparent;
            lbltotals.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lbltotals.ForeColor = Color.FromArgb(210, 205, 200);
            lbltotals.Location = new Point(14, 26);
            lbltotals.Name = "lbltotals";
            lbltotals.Size = new Size(82, 37);
            lbltotals.TabIndex = 1;
            lbltotals.Text = "Total";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.FromArgb(32, 20, 15);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblcart);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(733, 104);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.LogoCafe;
            pictureBox2.Location = new Point(541, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // lblcart
            // 
            lblcart.Anchor = AnchorStyles.Top;
            lblcart.BackColor = Color.Transparent;
            lblcart.Font = new Font("Constantia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcart.ForeColor = Color.Transparent;
            lblcart.Location = new Point(81, 19);
            lblcart.Name = "lblcart";
            lblcart.Size = new Size(348, 65);
            lblcart.TabIndex = 1;
            lblcart.Text = "Your Order Details";
            lblcart.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.back;
            pictureBox1.Location = new Point(26, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Cartt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__1_;
            Controls.Add(panelCart);
            Name = "Cartt";
            Size = new Size(733, 888);
            panelCart.ResumeLayout(false);
            panelfortotals.ResumeLayout(false);
            panelfortotals.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panelfortotals;
        private Label lbltotals;
        public Label label3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label lblcart;
        private PictureBox pictureBox1;
        private Panel panel4;
        private PictureBox pictureBox3;
        public Label label8;
        public Label label4;
        private Panel panel5;
        private Button button1;
        private Button button6;
        public FlowLayoutPanel flCart;
        public Button btnPlace;
        public Label lbTotalPrice;
        public Panel panelCart;
    }
}
