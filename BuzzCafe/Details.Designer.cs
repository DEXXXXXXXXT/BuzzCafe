namespace BuzzCafe
{
    partial class Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnminus = new Button();
            btnadd = new Button();
            lblPrices = new Label();
            lblProductname = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Location = new Point(157, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 205);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnminus);
            panel1.Controls.Add(btnadd);
            panel1.Controls.Add(lblPrices);
            panel1.Controls.Add(lblProductname);
            panel1.Location = new Point(56, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 87);
            panel1.TabIndex = 1;
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
            btnminus.Location = new Point(324, 10);
            btnminus.Name = "btnminus";
            btnminus.RightToLeft = RightToLeft.Yes;
            btnminus.Size = new Size(20, 20);
            btnminus.TabIndex = 3;
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
            btnadd.Location = new Point(380, 10);
            btnadd.Name = "btnadd";
            btnadd.RightToLeft = RightToLeft.Yes;
            btnadd.Size = new Size(20, 20);
            btnadd.TabIndex = 2;
            btnadd.UseVisualStyleBackColor = false;
            // 
            // lblPrices
            // 
            lblPrices.AutoSize = true;
            lblPrices.BackColor = Color.Transparent;
            lblPrices.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrices.ForeColor = Color.Transparent;
            lblPrices.Location = new Point(3, 43);
            lblPrices.Name = "lblPrices";
            lblPrices.Size = new Size(82, 27);
            lblPrices.TabIndex = 1;
            lblPrices.Text = "₱149.50";
            // 
            // lblProductname
            // 
            lblProductname.AutoSize = true;
            lblProductname.BackColor = Color.Transparent;
            lblProductname.Font = new Font("Constantia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductname.ForeColor = Color.Transparent;
            lblProductname.Location = new Point(0, 0);
            lblProductname.Name = "lblProductname";
            lblProductname.Size = new Size(154, 33);
            lblProductname.TabIndex = 0;
            lblProductname.Text = "Americano";
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(534, 728);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Details";
            Text = "Details";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblProductname;
        private Label lblPrices;
        private Button btnadd;
        private Button btnminus;
    }
}