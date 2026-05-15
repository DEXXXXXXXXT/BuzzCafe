using System;
using System.Drawing;
using System.Windows.Forms;

namespace BuzzCafe
{
    partial class Homemenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homemenu));
            panel1 = new Panel();
            btnSnacks = new Button();
            btnDrinks = new Button();
            btnPaste = new Button();
            btnRicemeal = new Button();
            btnlogo = new Button();
            lbTopText = new Label();
            flLayoutMain = new FlowLayoutPanel();
            panelPopup = new Panel();
            btnaddcart = new Button();
            panel2 = new Panel();
            lbltotalprice = new Label();
            lblsizes = new Label();
            lbltotalqty = new Label();
            panelsize = new Panel();
            btnsmall = new Button();
            btnMed = new Button();
            btnLarge = new Button();
            lblquantity = new Label();
            label1 = new Label();
            btnminus = new Button();
            btnadd = new Button();
            btnBack = new Button();
            lblPrices = new Label();
            lblProductname = new Label();
            pbProduct = new PictureBox();
            lblSize = new Label();
            panel1.SuspendLayout();
            panelPopup.SuspendLayout();
            panel2.SuspendLayout();
            panelsize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btnSnacks);
            panel1.Controls.Add(btnDrinks);
            panel1.Controls.Add(btnPaste);
            panel1.Controls.Add(btnRicemeal);
            panel1.Controls.Add(btnlogo);
            panel1.Location = new Point(5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 725);
            panel1.TabIndex = 12;
            // 
            // btnSnacks
            // 
            btnSnacks.BackColor = SystemColors.ControlLightLight;
            btnSnacks.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSnacks.Location = new Point(0, 212);
            btnSnacks.Name = "btnSnacks";
            btnSnacks.Size = new Size(100, 66);
            btnSnacks.TabIndex = 18;
            btnSnacks.Text = "Snacks";
            btnSnacks.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSnacks.UseVisualStyleBackColor = false;
            btnSnacks.Click += btnSnacks_Click;
            // 
            // btnDrinks
            // 
            btnDrinks.BackColor = SystemColors.ControlLightLight;
            btnDrinks.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrinks.Location = new Point(0, 68);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(105, 66);
            btnDrinks.TabIndex = 17;
            btnDrinks.Text = "Drinks";
            btnDrinks.UseVisualStyleBackColor = false;
            btnDrinks.Click += btnDrinks_Click;
            // 
            // btnPaste
            // 
            btnPaste.BackColor = SystemColors.ControlLightLight;
            btnPaste.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaste.Location = new Point(0, 140);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(100, 66);
            btnPaste.TabIndex = 17;
            btnPaste.Text = "Pastries";
            btnPaste.UseVisualStyleBackColor = false;
            btnPaste.Click += btnPaste_Click;
            // 
            // btnRicemeal
            // 
            btnRicemeal.BackColor = SystemColors.ControlLightLight;
            btnRicemeal.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRicemeal.Location = new Point(0, 284);
            btnRicemeal.Name = "btnRicemeal";
            btnRicemeal.Size = new Size(100, 66);
            btnRicemeal.TabIndex = 17;
            btnRicemeal.Text = "Rice Meal";
            btnRicemeal.UseVisualStyleBackColor = false;
            btnRicemeal.Click += btnRicemeal_Click;
            // 
            // btnlogo
            // 
            btnlogo.BackColor = Color.Transparent;
            btnlogo.BackgroundImage = (Image)resources.GetObject("btnlogo.BackgroundImage");
            btnlogo.FlatAppearance.BorderSize = 0;
            btnlogo.FlatStyle = FlatStyle.Flat;
            btnlogo.ForeColor = Color.Black;
            btnlogo.Location = new Point(4, 6);
            btnlogo.Name = "btnlogo";
            btnlogo.Size = new Size(91, 60);
            btnlogo.TabIndex = 14;
            btnlogo.UseVisualStyleBackColor = false;
            btnlogo.Click += btnlogo_Click;
            // 
            // lbTopText
            // 
            lbTopText.AutoSize = true;
            lbTopText.BackColor = Color.Transparent;
            lbTopText.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTopText.ForeColor = Color.Black;
            lbTopText.Location = new Point(178, 16);
            lbTopText.Name = "lbTopText";
            lbTopText.Size = new Size(250, 38);
            lbTopText.TabIndex = 14;
            lbTopText.Text = "Category Type";
            // 
            // flLayoutMain
            // 
            flLayoutMain.AutoScroll = true;
            flLayoutMain.BackColor = Color.Gray;
            flLayoutMain.BackgroundImage = Properties.Resources.bg7;
            flLayoutMain.Location = new Point(108, 71);
            flLayoutMain.Margin = new Padding(3, 2, 3, 2);
            flLayoutMain.Name = "flLayoutMain";
            flLayoutMain.Size = new Size(423, 658);
            flLayoutMain.TabIndex = 15;
            // 
            // panelPopup
            // 
            panelPopup.BackColor = Color.LightSlateGray;
            panelPopup.BackgroundImage = (Image)resources.GetObject("panelPopup.BackgroundImage");
            panelPopup.BackgroundImageLayout = ImageLayout.Stretch;
            panelPopup.Controls.Add(btnaddcart);
            panelPopup.Controls.Add(panel2);
            panelPopup.Controls.Add(panelsize);
            panelPopup.Controls.Add(lblquantity);
            panelPopup.Controls.Add(label1);
            panelPopup.Controls.Add(btnminus);
            panelPopup.Controls.Add(btnadd);
            panelPopup.Controls.Add(btnBack);
            panelPopup.Controls.Add(lblPrices);
            panelPopup.Controls.Add(lblProductname);
            panelPopup.Controls.Add(pbProduct);
            panelPopup.Controls.Add(lblSize);
            panelPopup.Location = new Point(5, 475);
            panelPopup.Margin = new Padding(3, 2, 3, 2);
            panelPopup.Name = "panelPopup";
            panelPopup.Size = new Size(525, 254);
            panelPopup.TabIndex = 0;
            panelPopup.Visible = false;
            // 
            // btnaddcart
            // 
            btnaddcart.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddcart.Location = new Point(330, 211);
            btnaddcart.Name = "btnaddcart";
            btnaddcart.Size = new Size(99, 28);
            btnaddcart.TabIndex = 15;
            btnaddcart.Text = "Add to cart";
            btnaddcart.UseVisualStyleBackColor = true;
            btnaddcart.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lbltotalprice);
            panel2.Controls.Add(lblsizes);
            panel2.Controls.Add(lbltotalqty);
            panel2.Location = new Point(18, 199);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 42);
            panel2.TabIndex = 14;
            // 
            // lbltotalprice
            // 
            lbltotalprice.AutoSize = true;
            lbltotalprice.BackColor = Color.DimGray;
            lbltotalprice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalprice.Location = new Point(176, 6);
            lbltotalprice.Name = "lbltotalprice";
            lbltotalprice.Size = new Size(115, 30);
            lbltotalprice.TabIndex = 17;
            lbltotalprice.Text = "Total Price";
            // 
            // lblsizes
            // 
            lblsizes.AutoSize = true;
            lblsizes.BackColor = Color.DimGray;
            lblsizes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsizes.Location = new Point(109, 6);
            lblsizes.Name = "lblsizes";
            lblsizes.Size = new Size(61, 30);
            lblsizes.TabIndex = 16;
            lblsizes.Text = "Sizes";
            // 
            // lbltotalqty
            // 
            lbltotalqty.AutoSize = true;
            lbltotalqty.BackColor = Color.DimGray;
            lbltotalqty.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalqty.Location = new Point(4, 6);
            lbltotalqty.Name = "lbltotalqty";
            lbltotalqty.Size = new Size(99, 30);
            lbltotalqty.TabIndex = 15;
            lbltotalqty.Text = "Quantity";
            // 
            // panelsize
            // 
            panelsize.BackColor = Color.Transparent;
            panelsize.Controls.Add(btnsmall);
            panelsize.Controls.Add(btnMed);
            panelsize.Controls.Add(btnLarge);
            panelsize.Location = new Point(176, 96);
            panelsize.Name = "panelsize";
            panelsize.Size = new Size(222, 33);
            panelsize.TabIndex = 13;
            // 
            // btnsmall
            // 
            btnsmall.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsmall.Location = new Point(0, 3);
            btnsmall.Name = "btnsmall";
            btnsmall.Size = new Size(69, 26);
            btnsmall.TabIndex = 6;
            btnsmall.Text = "SMALL";
            btnsmall.UseVisualStyleBackColor = true;
            // 
            // btnMed
            // 
            btnMed.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMed.Location = new Point(70, 3);
            btnMed.Name = "btnMed";
            btnMed.Size = new Size(78, 26);
            btnMed.TabIndex = 9;
            btnMed.Text = "MEDIUM";
            btnMed.UseVisualStyleBackColor = true;
            // 
            // btnLarge
            // 
            btnLarge.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLarge.Location = new Point(148, 3);
            btnLarge.Name = "btnLarge";
            btnLarge.Size = new Size(71, 26);
            btnLarge.TabIndex = 10;
            btnLarge.Text = "LARGE";
            btnLarge.UseVisualStyleBackColor = true;
            // 
            // lblquantity
            // 
            lblquantity.AutoSize = true;
            lblquantity.Location = new Point(459, 54);
            lblquantity.Name = "lblquantity";
            lblquantity.Size = new Size(26, 15);
            lblquantity.TabIndex = 12;
            lblquantity.Text = "Qty";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 91);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
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
            btnminus.Location = new Point(429, 50);
            btnminus.Name = "btnminus";
            btnminus.RightToLeft = RightToLeft.Yes;
            btnminus.Size = new Size(20, 20);
            btnminus.TabIndex = 5;
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
            btnadd.Location = new Point(491, 50);
            btnadd.Name = "btnadd";
            btnadd.RightToLeft = RightToLeft.Yes;
            btnadd.Size = new Size(20, 20);
            btnadd.TabIndex = 4;
            btnadd.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(435, 211);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 28);
            btnBack.TabIndex = 3;
            btnBack.Text = "Cancel";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblPrices
            // 
            lblPrices.AutoSize = true;
            lblPrices.BackColor = Color.Transparent;
            lblPrices.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrices.ForeColor = Color.Transparent;
            lblPrices.Location = new Point(176, 50);
            lblPrices.Name = "lblPrices";
            lblPrices.Size = new Size(82, 27);
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
            lblProductname.Location = new Point(173, 20);
            lblProductname.Name = "lblProductname";
            lblProductname.Size = new Size(154, 33);
            lblProductname.TabIndex = 1;
            lblProductname.Text = "Americano";
            lblProductname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbProduct
            // 
            pbProduct.Location = new Point(22, 20);
            pbProduct.Margin = new Padding(3, 2, 3, 2);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(145, 124);
            pbProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.ForeColor = Color.Transparent;
            lblSize.Location = new Point(173, 77);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(53, 27);
            lblSize.TabIndex = 8;
            lblSize.Text = "Size:";
            // 
            // Homemenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(534, 728);
            Controls.Add(lbTopText);
            Controls.Add(panelPopup);
            Controls.Add(flLayoutMain);
            Controls.Add(panel1);
            Name = "Homemenu";
            Text = "Homemenu";
            panel1.ResumeLayout(false);
            panelPopup.ResumeLayout(false);
            panelPopup.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelsize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnDrinks;
        private Button btnPaste;
        private Button btnRicemeal;
        private Button btnlogo;
        private Label lbTopText;
        private FlowLayoutPanel flLayoutMain;
        private Button btnSnacks;
        private Panel panelPopup;
        public PictureBox pbProduct;
        public Label lblProductname;
        public Button btnBack;
        public Label lblPrices;
        private Button btnminus;
        private Button btnadd;
        private Label label1;
        private Button btnsmall;
        public Label lblSize;
        private Button btnMed;
        private Button btnLarge;
        private Panel panelsize;
        private Label lblquantity;
        private Panel panel2;
        private Label lbltotalprice;
        private Label lblsizes;
        private Label lbltotalqty;
        private Button btnaddcart;
    }
}