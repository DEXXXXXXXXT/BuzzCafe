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
            btnLarge = new Button();
            btnMed = new Button();
            label1 = new Label();
            btnsmall = new Button();
            btnminus = new Button();
            btnadd = new Button();
            btnBack = new Button();
            lblPrices = new Label();
            lblProductname = new Label();
            pbProduct = new PictureBox();
            lblSize = new Label();
            panel1.SuspendLayout();
            panelPopup.SuspendLayout();
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
            panel1.Location = new Point(6, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 967);
            panel1.TabIndex = 12;
            // 
            // btnSnacks
            // 
            btnSnacks.BackColor = SystemColors.ControlLightLight;
            btnSnacks.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSnacks.Location = new Point(0, 283);
            btnSnacks.Margin = new Padding(3, 4, 3, 4);
            btnSnacks.Name = "btnSnacks";
            btnSnacks.Size = new Size(114, 88);
            btnSnacks.TabIndex = 18;
            btnSnacks.Text = "Snacks";
            btnSnacks.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSnacks.UseVisualStyleBackColor = false;
            // 
            // btnDrinks
            // 
            btnDrinks.BackColor = SystemColors.ControlLightLight;
            btnDrinks.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrinks.Location = new Point(0, 91);
            btnDrinks.Margin = new Padding(3, 4, 3, 4);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(120, 88);
            btnDrinks.TabIndex = 17;
            btnDrinks.Text = "Drinks";
            btnDrinks.UseVisualStyleBackColor = false;
            // 
            // btnPaste
            // 
            btnPaste.BackColor = SystemColors.ControlLightLight;
            btnPaste.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaste.Location = new Point(0, 187);
            btnPaste.Margin = new Padding(3, 4, 3, 4);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(114, 88);
            btnPaste.TabIndex = 17;
            btnPaste.Text = "Pastries";
            btnPaste.UseVisualStyleBackColor = false;
            // 
            // btnRicemeal
            // 
            btnRicemeal.BackColor = SystemColors.ControlLightLight;
            btnRicemeal.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRicemeal.Location = new Point(0, 379);
            btnRicemeal.Margin = new Padding(3, 4, 3, 4);
            btnRicemeal.Name = "btnRicemeal";
            btnRicemeal.Size = new Size(114, 88);
            btnRicemeal.TabIndex = 17;
            btnRicemeal.Text = "Rice Meal";
            btnRicemeal.UseVisualStyleBackColor = false;
            // 
            // btnlogo
            // 
            btnlogo.BackColor = Color.Transparent;
            btnlogo.BackgroundImage = (Image)resources.GetObject("btnlogo.BackgroundImage");
            btnlogo.FlatAppearance.BorderSize = 0;
            btnlogo.FlatStyle = FlatStyle.Flat;
            btnlogo.ForeColor = Color.Black;
            btnlogo.Location = new Point(7, 4);
            btnlogo.Margin = new Padding(3, 4, 3, 4);
            btnlogo.Name = "btnlogo";
            btnlogo.Size = new Size(104, 80);
            btnlogo.TabIndex = 14;
            btnlogo.UseVisualStyleBackColor = false;
            // 
            // lbTopText
            // 
            lbTopText.AutoSize = true;
            lbTopText.BackColor = Color.Transparent;
            lbTopText.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTopText.ForeColor = Color.Black;
            lbTopText.Location = new Point(203, 21);
            lbTopText.Name = "lbTopText";
            lbTopText.Size = new Size(311, 46);
            lbTopText.TabIndex = 14;
            lbTopText.Text = "Category Type";
            // 
            // flLayoutMain
            // 
            flLayoutMain.AutoScroll = true;
            flLayoutMain.BackColor = Color.Gray;
            flLayoutMain.BackgroundImage = Properties.Resources.bg7;
            flLayoutMain.Location = new Point(123, 95);
            flLayoutMain.Name = "flLayoutMain";
            flLayoutMain.Size = new Size(483, 877);
            flLayoutMain.TabIndex = 15;
            // 
            // panelPopup
            // 
            panelPopup.BackColor = Color.LightSlateGray;
            panelPopup.BackgroundImage = (Image)resources.GetObject("panelPopup.BackgroundImage");
            panelPopup.BackgroundImageLayout = ImageLayout.Stretch;
            panelPopup.Controls.Add(btnLarge);
            panelPopup.Controls.Add(btnMed);
            panelPopup.Controls.Add(label1);
            panelPopup.Controls.Add(btnsmall);
            panelPopup.Controls.Add(btnminus);
            panelPopup.Controls.Add(btnadd);
            panelPopup.Controls.Add(btnBack);
            panelPopup.Controls.Add(lblPrices);
            panelPopup.Controls.Add(lblProductname);
            panelPopup.Controls.Add(pbProduct);
            panelPopup.Controls.Add(lblSize);
            panelPopup.Location = new Point(6, 633);
            panelPopup.Name = "panelPopup";
            panelPopup.Size = new Size(600, 339);
            panelPopup.TabIndex = 0;
            panelPopup.Visible = false;
            // 
            // btnLarge
            // 
            btnLarge.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLarge.Location = new Point(390, 129);
            btnLarge.Margin = new Padding(3, 4, 3, 4);
            btnLarge.Name = "btnLarge";
            btnLarge.Size = new Size(81, 35);
            btnLarge.TabIndex = 10;
            btnLarge.Text = "LARGE";
            btnLarge.UseVisualStyleBackColor = true;
            // 
            // btnMed
            // 
            btnMed.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMed.Location = new Point(298, 129);
            btnMed.Margin = new Padding(3, 4, 3, 4);
            btnMed.Name = "btnMed";
            btnMed.Size = new Size(89, 35);
            btnMed.TabIndex = 9;
            btnMed.Text = "MEDIUM";
            btnMed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 121);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 7;
            // 
            // btnsmall
            // 
            btnsmall.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsmall.Location = new Point(216, 129);
            btnsmall.Margin = new Padding(3, 4, 3, 4);
            btnsmall.Name = "btnsmall";
            btnsmall.Size = new Size(79, 35);
            btnsmall.TabIndex = 6;
            btnsmall.Text = "SMALL";
            btnsmall.UseVisualStyleBackColor = true;
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
            btnminus.Location = new Point(495, 185);
            btnminus.Margin = new Padding(3, 4, 3, 4);
            btnminus.Name = "btnminus";
            btnminus.RightToLeft = RightToLeft.Yes;
            btnminus.Size = new Size(23, 27);
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
            btnadd.Location = new Point(566, 185);
            btnadd.Margin = new Padding(3, 4, 3, 4);
            btnadd.Name = "btnadd";
            btnadd.RightToLeft = RightToLeft.Yes;
            btnadd.Size = new Size(23, 27);
            btnadd.TabIndex = 4;
            btnadd.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(495, 285);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 37);
            btnBack.TabIndex = 3;
            btnBack.Text = "Cancel";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // lblPrices
            // 
            lblPrices.AutoSize = true;
            lblPrices.BackColor = Color.Transparent;
            lblPrices.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrices.ForeColor = Color.Transparent;
            lblPrices.Location = new Point(230, 67);
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
            lblProductname.Location = new Point(215, 27);
            lblProductname.Name = "lblProductname";
            lblProductname.Size = new Size(193, 41);
            lblProductname.TabIndex = 1;
            lblProductname.Text = "Americano";
            lblProductname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbProduct
            // 
            pbProduct.Location = new Point(43, 27);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(166, 165);
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
            lblSize.Location = new Point(216, 103);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(65, 34);
            lblSize.TabIndex = 8;
            lblSize.Text = "Size:";
            // 
            // Homemenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panelPopup);
            Controls.Add(lbTopText);
            Controls.Add(flLayoutMain);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Homemenu";
            Size = new Size(610, 971);
            panel1.ResumeLayout(false);
            panelPopup.ResumeLayout(false);
            panelPopup.PerformLayout();
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
    }
}