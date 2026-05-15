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
            btnRicemeal = new Button();
            btnSnacks = new Button();
            btnPaste = new Button();
            btnDrinks = new Button();
            pictureBox1 = new PictureBox();
            panelPopup = new Panel();
            button2 = new Button();
            btnAddOrder = new Button();
            lbTotalPrice = new Label();
            label3 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            lbquantityCount = new Label();
            btnAdd = new Button();
            label2 = new Label();
            panelSizes = new Panel();
            button6 = new Button();
            btnM = new Button();
            btnS = new Button();
            lblSize = new Label();
            label1 = new Label();
            lblPrices = new Label();
            lblProductname = new Label();
            pbProduct = new PictureBox();
            panel2 = new Panel();
            lbTopText = new Label();
            flPanel = new FlowLayoutPanel();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPopup.SuspendLayout();
            panel3.SuspendLayout();
            panelSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnRicemeal);
            panel1.Controls.Add(btnSnacks);
            panel1.Controls.Add(btnPaste);
            panel1.Controls.Add(btnDrinks);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 878);
            panel1.TabIndex = 0;
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
            panelPopup.Anchor = AnchorStyles.Bottom;
            panelPopup.BackColor = Color.LightSlateGray;
            panelPopup.BackgroundImage = (Image)resources.GetObject("panelPopup.BackgroundImage");
            panelPopup.BackgroundImageLayout = ImageLayout.Stretch;
            panelPopup.Controls.Add(button2);
            panelPopup.Controls.Add(btnAddOrder);
            panelPopup.Controls.Add(lbTotalPrice);
            panelPopup.Controls.Add(label3);
            panelPopup.Controls.Add(panel3);
            panelPopup.Controls.Add(panelSizes);
            panelPopup.Controls.Add(label1);
            panelPopup.Controls.Add(lblPrices);
            panelPopup.Controls.Add(lblProductname);
            panelPopup.Controls.Add(pbProduct);
            panelPopup.Location = new Point(25, 573);
            panelPopup.Name = "panelPopup";
            panelPopup.Size = new Size(656, 305);
            panelPopup.TabIndex = 1;
            panelPopup.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Constantia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(595, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(49, 46);
            button2.TabIndex = 13;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = Color.Transparent;
            btnAddOrder.FlatAppearance.BorderSize = 5;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.Font = new Font("Constantia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddOrder.ForeColor = Color.Transparent;
            btnAddOrder.Location = new Point(355, 219);
            btnAddOrder.Margin = new Padding(3, 4, 3, 4);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(179, 65);
            btnAddOrder.TabIndex = 16;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.BackColor = Color.Transparent;
            lbTotalPrice.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalPrice.ForeColor = Color.Transparent;
            lbTotalPrice.Location = new Point(232, 237);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(65, 34);
            lbTotalPrice.TabIndex = 15;
            lbTotalPrice.Text = "price";
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(29, 230);
            label3.Name = "label3";
            label3.Size = new Size(197, 41);
            label3.TabIndex = 14;
            label3.Text = "Total Price:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(lbquantityCount);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(448, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(173, 70);
            panel3.TabIndex = 12;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 25);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(45, 31);
            button1.TabIndex = 14;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbquantityCount
            // 
            lbquantityCount.BackColor = Color.Transparent;
            lbquantityCount.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbquantityCount.ForeColor = Color.Transparent;
            lbquantityCount.Location = new Point(70, 20);
            lbquantityCount.Name = "lbquantityCount";
            lbquantityCount.Size = new Size(33, 45);
            lbquantityCount.TabIndex = 13;
            lbquantityCount.Text = "A";
            lbquantityCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(109, 25);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(45, 31);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Himalaya", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 30);
            label2.TabIndex = 9;
            label2.Text = "Quantity";
            // 
            // panelSizes
            // 
            panelSizes.BackColor = Color.Transparent;
            panelSizes.Controls.Add(button6);
            panelSizes.Controls.Add(btnM);
            panelSizes.Controls.Add(btnS);
            panelSizes.Controls.Add(lblSize);
            panelSizes.Location = new Point(192, 111);
            panelSizes.Name = "panelSizes";
            panelSizes.Size = new Size(250, 72);
            panelSizes.TabIndex = 11;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(163, 34);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(74, 31);
            button6.TabIndex = 12;
            button6.Text = "Large";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            btnM.FlatStyle = FlatStyle.Flat;
            btnM.Font = new Font("Constantia", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnM.ForeColor = Color.White;
            btnM.Location = new Point(83, 34);
            btnM.Margin = new Padding(3, 4, 3, 4);
            btnM.Name = "btnM";
            btnM.Size = new Size(74, 31);
            btnM.TabIndex = 11;
            btnM.Text = "Medium";
            btnM.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            btnS.FlatStyle = FlatStyle.Flat;
            btnS.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnS.ForeColor = Color.White;
            btnS.Location = new Point(3, 34);
            btnS.Margin = new Padding(3, 4, 3, 4);
            btnS.Name = "btnS";
            btnS.Size = new Size(74, 31);
            btnS.TabIndex = 10;
            btnS.Text = "Small";
            btnS.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.ForeColor = Color.Transparent;
            lblSize.Location = new Point(3, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(88, 30);
            lblSize.TabIndex = 8;
            lblSize.Text = "Size:";
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
            panel2.Size = new Size(523, 141);
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
            lbTopText.Size = new Size(509, 87);
            lbTopText.TabIndex = 15;
            lbTopText.Text = "Category Type";
            lbTopText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flPanel
            // 
            flPanel.AutoScroll = true;
            flPanel.BackColor = Color.Transparent;
            flPanel.BackgroundImage = Properties.Resources.dinetakebg;
            flPanel.Dock = DockStyle.Fill;
            flPanel.Location = new Point(184, 141);
            flPanel.Name = "flPanel";
            flPanel.Size = new Size(523, 737);
            flPanel.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(panelPopup);
            Controls.Add(flPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Menu";
            Size = new Size(707, 878);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPopup.ResumeLayout(false);
            panelPopup.PerformLayout();
            panel3.ResumeLayout(false);
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
        public Button button3;
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
        private Button button6;
        private Button btnM;
        private Button btnS;
        private Panel panel3;
        public Label label2;
        public Label lblSize;
        public Label lbquantityCount;
        private Button btnAdd;
        private Button button1;
        private Button btnAddOrder;
        public Label lbTotalPrice;
        public Label label3;
        private Button button2;
    }
}
