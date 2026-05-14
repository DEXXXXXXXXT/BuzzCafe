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
            btnminus = new Button();
            btnadd = new Button();
            btnBack = new Button();
            lblPrices = new Label();
            lblProductname = new Label();
            pbProduct = new PictureBox();
            panel1.SuspendLayout();
            panelPopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
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
            btnSnacks.Location = new Point(3, 283);
            btnSnacks.Margin = new Padding(3, 4, 3, 4);
            btnSnacks.Name = "btnSnacks";
            btnSnacks.Size = new Size(111, 88);
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
            btnDrinks.Location = new Point(0, 91);
            btnDrinks.Margin = new Padding(3, 4, 3, 4);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(120, 88);
            btnDrinks.TabIndex = 17;
            btnDrinks.Text = "Drinks";
            btnDrinks.UseVisualStyleBackColor = false;
            btnDrinks.Click += btnDrinks_Click;
            // 
            // btnPaste
            // 
            btnPaste.BackColor = SystemColors.ControlLightLight;
            btnPaste.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaste.Location = new Point(3, 187);
            btnPaste.Margin = new Padding(3, 4, 3, 4);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(111, 88);
            btnPaste.TabIndex = 17;
            btnPaste.Text = "Pastries";
            btnPaste.UseVisualStyleBackColor = false;
            btnPaste.Click += btnPaste_Click;
            // 
            // btnRicemeal
            // 
            btnRicemeal.BackColor = SystemColors.ControlLightLight;
            btnRicemeal.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRicemeal.Location = new Point(4, 379);
            btnRicemeal.Margin = new Padding(3, 4, 3, 4);
            btnRicemeal.Name = "btnRicemeal";
            btnRicemeal.Size = new Size(107, 88);
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
            btnlogo.Location = new Point(5, 8);
            btnlogo.Margin = new Padding(3, 4, 3, 4);
            btnlogo.Name = "btnlogo";
            btnlogo.Size = new Size(104, 80);
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
            lbTopText.Location = new Point(204, 21);
            lbTopText.Name = "lbTopText";
            lbTopText.Size = new Size(311, 46);
            lbTopText.TabIndex = 14;
            lbTopText.Text = "Category Type";
            // 
            // flLayoutMain
            // 
            flLayoutMain.AutoScroll = true;
            flLayoutMain.BackColor = Color.Gray;
            flLayoutMain.Location = new Point(123, 95);
            flLayoutMain.Name = "flLayoutMain";
            flLayoutMain.Size = new Size(483, 877);
            flLayoutMain.TabIndex = 15;
            // 
            // panelPopup
            // 
            panelPopup.BackColor = Color.LightSlateGray;
            panelPopup.Controls.Add(btnminus);
            panelPopup.Controls.Add(btnadd);
            panelPopup.Controls.Add(btnBack);
            panelPopup.Controls.Add(lblPrices);
            panelPopup.Controls.Add(lblProductname);
            panelPopup.Controls.Add(pbProduct);
            panelPopup.Location = new Point(6, 575);
            panelPopup.Name = "panelPopup";
            panelPopup.Size = new Size(600, 397);
            panelPopup.TabIndex = 0;
            panelPopup.Visible = false;
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
            btnminus.Location = new Point(495, 165);
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
            btnadd.Location = new Point(559, 165);
            btnadd.Margin = new Padding(3, 4, 3, 4);
            btnadd.Name = "btnadd";
            btnadd.RightToLeft = RightToLeft.Yes;
            btnadd.Size = new Size(23, 27);
            btnadd.TabIndex = 4;
            btnadd.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(495, 328);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblPrices
            // 
            lblPrices.AutoSize = true;
            lblPrices.BackColor = Color.Transparent;
            lblPrices.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrices.ForeColor = Color.Transparent;
            lblPrices.Location = new Point(224, 67);
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
            lblProductname.Location = new Point(215, 26);
            lblProductname.Name = "lblProductname";
            lblProductname.Size = new Size(193, 41);
            lblProductname.TabIndex = 1;
            lblProductname.Text = "Americano";
            lblProductname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbProduct
            // 
            pbProduct.Location = new Point(43, 26);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(166, 166);
            pbProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            // 
            // Homemenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(610, 971);
            Controls.Add(lbTopText);
            Controls.Add(panelPopup);
            Controls.Add(flLayoutMain);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Homemenu";
            Text = "Homemenu";
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
    }
}