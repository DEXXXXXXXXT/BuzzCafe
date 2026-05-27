namespace BuzzCafe
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnVewCart = new Button();
            btnRicemeal = new Button();
            btnSnacks = new Button();
            btnPaste = new Button();
            btnDrinks = new Button();
            pictureBox1 = new PictureBox();
            panelPopup = new Panel();
            panelOrderAdded = new Panel();
            label5 = new Label();
            label4 = new Label();
            btnContinue = new Button();
            btnViewCart = new Button();
            button2 = new Button();
            btnAddOrder = new Button();
            lbTotalPrice = new Label();
            label3 = new Label();
            panelQuantity = new Panel();
            button1 = new Button();
            btnAdd = new Button();
            lbquanCount = new Label();
            label2 = new Label();
            panelSizes = new Panel();
            btnL = new Button();
            btnM = new Button();
            btnS = new Button();
            lblSize = new Label();
            lbtoAddPrice = new Label();
            label1 = new Label();
            lblPrices = new Label();
            lblProductname = new Label();
            pbProduct = new PictureBox();
            panel2 = new Panel();
            lbTopText = new Label();
            flPanel = new FlowLayoutPanel();
            bindingSource1 = new BindingSource(components);
            btnCancelOrder = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPopup.SuspendLayout();
            panelOrderAdded.SuspendLayout();
            panelQuantity.SuspendLayout();
            panelSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnCancelOrder);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnVewCart);
            panel1.Controls.Add(btnRicemeal);
            panel1.Controls.Add(btnSnacks);
            panel1.Controls.Add(btnPaste);
            panel1.Controls.Add(btnDrinks);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 924);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cartDesign;
            pictureBox2.Location = new Point(3, 695);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnVewCart
            // 
            btnVewCart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnVewCart.FlatStyle = FlatStyle.Flat;
            btnVewCart.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVewCart.Location = new Point(0, 685);
            btnVewCart.Name = "btnVewCart";
            btnVewCart.Size = new Size(184, 102);
            btnVewCart.TabIndex = 21;
            btnVewCart.Text = "          Cart";
            btnVewCart.UseVisualStyleBackColor = true;
            btnVewCart.Click += btnVewCart_Click;
            // 
            // btnRicemeal
            // 
            btnRicemeal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRicemeal.FlatStyle = FlatStyle.Flat;
            btnRicemeal.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRicemeal.Location = new Point(0, 474);
            btnRicemeal.Name = "btnRicemeal";
            btnRicemeal.Size = new Size(184, 102);
            btnRicemeal.TabIndex = 20;
            btnRicemeal.Text = "Meal";
            btnRicemeal.UseVisualStyleBackColor = true;
            btnRicemeal.Click += btnRicemeal_Click_1;
            // 
            // btnSnacks
            // 
            btnSnacks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSnacks.FlatStyle = FlatStyle.Flat;
            btnSnacks.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSnacks.Location = new Point(0, 363);
            btnSnacks.Name = "btnSnacks";
            btnSnacks.Size = new Size(184, 102);
            btnSnacks.TabIndex = 19;
            btnSnacks.Text = "Snacks";
            btnSnacks.UseVisualStyleBackColor = true;
            btnSnacks.Click += btnSnacks_Click_1;
            // 
            // btnPaste
            // 
            btnPaste.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPaste.FlatStyle = FlatStyle.Flat;
            btnPaste.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaste.Location = new Point(0, 252);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(184, 102);
            btnPaste.TabIndex = 18;
            btnPaste.Text = "Pastries";
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click_1;
            // 
            // btnDrinks
            // 
            btnDrinks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDrinks.FlatStyle = FlatStyle.Flat;
            btnDrinks.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrinks.Location = new Point(0, 141);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(184, 102);
            btnDrinks.TabIndex = 17;
            btnDrinks.Text = "Drinks";
            btnDrinks.UseVisualStyleBackColor = true;
            btnDrinks.Click += btnDrinks_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.LOGO1;
            pictureBox1.Location = new Point(25, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panelPopup
            // 
            panelPopup.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelPopup.BackColor = Color.LightSteelBlue;
            panelPopup.BackgroundImage = (Image)resources.GetObject("panelPopup.BackgroundImage");
            panelPopup.BackgroundImageLayout = ImageLayout.Stretch;
            panelPopup.Controls.Add(panelOrderAdded);
            panelPopup.Controls.Add(button2);
            panelPopup.Controls.Add(btnAddOrder);
            panelPopup.Controls.Add(lbTotalPrice);
            panelPopup.Controls.Add(label3);
            panelPopup.Controls.Add(panelQuantity);
            panelPopup.Controls.Add(panelSizes);
            panelPopup.Controls.Add(label1);
            panelPopup.Controls.Add(lblPrices);
            panelPopup.Controls.Add(lblProductname);
            panelPopup.Controls.Add(pbProduct);
            panelPopup.Location = new Point(28, 499);
            panelPopup.Name = "panelPopup";
            panelPopup.Size = new Size(666, 404);
            panelPopup.TabIndex = 1;
            panelPopup.Visible = false;
            // 
            // panelOrderAdded
            // 
            panelOrderAdded.BackColor = Color.Transparent;
            panelOrderAdded.Controls.Add(label5);
            panelOrderAdded.Controls.Add(label4);
            panelOrderAdded.Controls.Add(btnContinue);
            panelOrderAdded.Controls.Add(btnViewCart);
            panelOrderAdded.Location = new Point(21, 18);
            panelOrderAdded.Name = "panelOrderAdded";
            panelOrderAdded.Size = new Size(624, 360);
            panelOrderAdded.TabIndex = 18;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(212, 143, 56);
            label5.Location = new Point(142, 168);
            label5.Name = "label5";
            label5.Size = new Size(383, 46);
            label5.TabIndex = 20;
            label5.Text = "Your item added to cart.";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Himalaya", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(212, 143, 56);
            label4.Location = new Point(70, 82);
            label4.Name = "label4";
            label4.Size = new Size(526, 69);
            label4.TabIndex = 19;
            label4.Text = "Order Added Successfully!";
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.FromArgb(153, 102, 51);
            btnContinue.FlatAppearance.BorderSize = 0;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(95, 242);
            btnContinue.Margin = new Padding(3, 4, 3, 4);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(179, 65);
            btnContinue.TabIndex = 19;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.BackColor = Color.FromArgb(153, 102, 51);
            btnViewCart.FlatAppearance.BorderSize = 0;
            btnViewCart.FlatStyle = FlatStyle.Flat;
            btnViewCart.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btnViewCart.ForeColor = Color.White;
            btnViewCart.Location = new Point(356, 242);
            btnViewCart.Margin = new Padding(3, 4, 3, 4);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(179, 65);
            btnViewCart.TabIndex = 18;
            btnViewCart.Text = "View Cart";
            btnViewCart.UseVisualStyleBackColor = false;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(212, 143, 56);
            button2.Location = new Point(617, 0);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(49, 66);
            button2.TabIndex = 13;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = Color.FromArgb(153, 102, 51);
            btnAddOrder.FlatAppearance.BorderSize = 0;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btnAddOrder.ForeColor = Color.White;
            btnAddOrder.Location = new Point(448, 241);
            btnAddOrder.Margin = new Padding(3, 4, 3, 4);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(179, 65);
            btnAddOrder.TabIndex = 16;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.BackColor = Color.Transparent;
            lbTotalPrice.Font = new Font("Microsoft Himalaya", 26F, FontStyle.Bold);
            lbTotalPrice.ForeColor = Color.FromArgb(212, 143, 56);
            lbTotalPrice.Location = new Point(248, 265);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(83, 44);
            lbTotalPrice.TabIndex = 15;
            lbTotalPrice.Text = "price";
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 260);
            label3.Name = "label3";
            label3.Size = new Size(220, 39);
            label3.TabIndex = 14;
            label3.Text = "Total Price:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelQuantity
            // 
            panelQuantity.BackColor = Color.Transparent;
            panelQuantity.Controls.Add(button1);
            panelQuantity.Controls.Add(btnAdd);
            panelQuantity.Controls.Add(lbquanCount);
            panelQuantity.Controls.Add(label2);
            panelQuantity.Location = new Point(448, 101);
            panelQuantity.Name = "panelQuantity";
            panelQuantity.Size = new Size(173, 80);
            panelQuantity.TabIndex = 12;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(120, 80, 40);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 35);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(45, 31);
            button1.TabIndex = 14;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(120, 80, 40);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(113, 35);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(45, 31);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // lbquanCount
            // 
            lbquanCount.BackColor = Color.Transparent;
            lbquanCount.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbquanCount.ForeColor = Color.FromArgb(212, 143, 56);
            lbquanCount.Location = new Point(75, 37);
            lbquanCount.Name = "lbquanCount";
            lbquanCount.Size = new Size(44, 31);
            lbquanCount.TabIndex = 13;
            lbquanCount.Text = "1";
            lbquanCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Himalaya", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(19, 6);
            label2.Name = "label2";
            label2.Size = new Size(88, 30);
            label2.TabIndex = 9;
            label2.Text = "Quantity";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelSizes
            // 
            panelSizes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSizes.BackColor = Color.Transparent;
            panelSizes.Controls.Add(btnL);
            panelSizes.Controls.Add(btnM);
            panelSizes.Controls.Add(btnS);
            panelSizes.Controls.Add(lblSize);
            panelSizes.Controls.Add(lbtoAddPrice);
            panelSizes.Location = new Point(192, 101);
            panelSizes.Name = "panelSizes";
            panelSizes.Size = new Size(260, 82);
            panelSizes.TabIndex = 11;
            // 
            // btnL
            // 
            btnL.BackColor = Color.FromArgb(40, 30, 25);
            btnL.FlatAppearance.BorderColor = Color.FromArgb(120, 80, 40);
            btnL.FlatStyle = FlatStyle.Flat;
            btnL.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnL.ForeColor = Color.White;
            btnL.Location = new Point(163, 34);
            btnL.Margin = new Padding(3, 4, 3, 4);
            btnL.Name = "btnL";
            btnL.Size = new Size(74, 31);
            btnL.TabIndex = 12;
            btnL.Text = "Large";
            btnL.UseVisualStyleBackColor = false;
            btnL.Click += btnL_Click;
            // 
            // btnM
            // 
            btnM.BackColor = Color.FromArgb(40, 30, 25);
            btnM.FlatAppearance.BorderColor = Color.FromArgb(120, 80, 40);
            btnM.FlatStyle = FlatStyle.Flat;
            btnM.Font = new Font("Segoe UI", 8.3F, FontStyle.Bold);
            btnM.ForeColor = Color.White;
            btnM.Location = new Point(83, 34);
            btnM.Margin = new Padding(3, 4, 3, 4);
            btnM.Name = "btnM";
            btnM.Size = new Size(74, 31);
            btnM.TabIndex = 11;
            btnM.Text = "Medium";
            btnM.UseVisualStyleBackColor = false;
            btnM.Click += btnM_Click;
            // 
            // btnS
            // 
            btnS.BackColor = Color.FromArgb(40, 30, 25);
            btnS.FlatAppearance.BorderColor = Color.FromArgb(120, 80, 40);
            btnS.FlatStyle = FlatStyle.Flat;
            btnS.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnS.ForeColor = Color.White;
            btnS.Location = new Point(3, 34);
            btnS.Margin = new Padding(3, 4, 3, 4);
            btnS.Name = "btnS";
            btnS.Size = new Size(74, 31);
            btnS.TabIndex = 10;
            btnS.Text = "Small";
            btnS.UseVisualStyleBackColor = false;
            btnS.Click += btnS_Click;
            // 
            // lblSize
            // 
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSize.ForeColor = Color.Transparent;
            lblSize.Location = new Point(3, 9);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(53, 30);
            lblSize.TabIndex = 8;
            lblSize.Text = "Size:";
            // 
            // lbtoAddPrice
            // 
            lbtoAddPrice.BackColor = Color.Transparent;
            lbtoAddPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbtoAddPrice.ForeColor = Color.Transparent;
            lbtoAddPrice.Location = new Point(83, 5);
            lbtoAddPrice.Name = "lbtoAddPrice";
            lbtoAddPrice.Size = new Size(70, 34);
            lbtoAddPrice.TabIndex = 13;
            lbtoAddPrice.Text = "add";
            lbtoAddPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 121);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 7;
            // 
            // lblPrices
            // 
            lblPrices.AutoSize = true;
            lblPrices.BackColor = Color.Transparent;
            lblPrices.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrices.ForeColor = Color.Transparent;
            lblPrices.Location = new Point(195, 73);
            lblPrices.Name = "lblPrices";
            lblPrices.Size = new Size(100, 34);
            lblPrices.TabIndex = 2;
            lblPrices.Text = "₱149.50";
            // 
            // lblProductname
            // 
            lblProductname.AutoEllipsis = true;
            lblProductname.AutoSize = true;
            lblProductname.BackColor = Color.Transparent;
            lblProductname.Font = new Font("Constantia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductname.ForeColor = Color.Transparent;
            lblProductname.Location = new Point(192, 25);
            lblProductname.Name = "lblProductname";
            lblProductname.Size = new Size(193, 41);
            lblProductname.TabIndex = 1;
            lblProductname.Text = "Americano";
            lblProductname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbProduct
            // 
            pbProduct.Location = new Point(20, 23);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(166, 165);
            pbProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 138, 93);
            panel2.Controls.Add(lbTopText);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(184, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 141);
            panel2.TabIndex = 1;
            // 
            // lbTopText
            // 
            lbTopText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTopText.BackColor = Color.Transparent;
            lbTopText.Font = new Font("Georgia", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTopText.ForeColor = Color.Black;
            lbTopText.Location = new Point(11, 34);
            lbTopText.Name = "lbTopText";
            lbTopText.Size = new Size(512, 87);
            lbTopText.TabIndex = 15;
            lbTopText.Text = "Category Type";
            lbTopText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flPanel
            // 
            flPanel.AutoScroll = true;
            flPanel.BackColor = Color.DimGray;
            flPanel.BackgroundImage = Properties.Resources.dinetakebg;
            flPanel.Dock = DockStyle.Fill;
            flPanel.Location = new Point(184, 141);
            flPanel.Name = "flPanel";
            flPanel.Padding = new Padding(20);
            flPanel.Size = new Size(526, 783);
            flPanel.TabIndex = 2;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelOrder.FlatStyle = FlatStyle.Flat;
            btnCancelOrder.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelOrder.Location = new Point(0, 793);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(184, 52);
            btnCancelOrder.TabIndex = 22;
            btnCancelOrder.Text = "Cancel Order";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(flPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelPopup);
            Name = "Menu";
            Size = new Size(710, 924);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPopup.ResumeLayout(false);
            panelPopup.PerformLayout();
            panelOrderAdded.ResumeLayout(false);
            panelQuantity.ResumeLayout(false);
            panelSizes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flPanel;
        private Label lbTopText;
        private PictureBox pictureBox1;
        private BindingSource bindingSource1;
        public Button button4;
        public Button btnPaste;
        public Button btnDrinks;
        public Button btnSnacks;
        public Button btnRicemeal;
        private Panel panelPopup;
        private Label label1;
        public Label lblPrices;
        public Label lblProductname;
        public PictureBox pbProduct;
        private Panel panelSizes;
        private Button btnL;
        private Button btnM;
        private Button btnS;
        public Label label2;
        public Label lblSize;
        public Label lbquanCount;
        private Button btnAdd;
        private Button button1;
        private Button btnAddOrder;
        public Label lbTotalPrice;
        public Label label3;
        private Button button2;
        public Panel panelQuantity;
        public Label lbtoAddPrice;
        private PictureBox pictureBox2;
        public Button btnCart;
        public Button btnVewCart;
        public Panel panelOrderAdded;
        public Label label5;
        public Label label4;
        public Button btnContinue;
        public Button btnViewCart;
        private Button button3;
        public Button btnCancelOrder;
    }
}
