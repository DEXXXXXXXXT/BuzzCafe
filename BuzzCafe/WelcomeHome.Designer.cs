namespace BuzzCafe
{
    partial class WelcomeHome
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
            panel1 = new Panel();
            btnStart = new Button();
            label3 = new Label();
            label2 = new Label();
            lblwelcome = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblwelcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 862);
            panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Bottom;
            btnStart.BackColor = Color.Gray;
            btnStart.FlatAppearance.BorderColor = Color.Black;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(61, 733);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(549, 93);
            btnStart.TabIndex = 11;
            btnStart.Text = "Touch to start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 650);
            label3.Name = "label3";
            label3.Size = new Size(566, 117);
            label3.TabIndex = 10;
            label3.Text = "    Buzz Coffee Shop—where every cup gives you a boost. \r\nBold brews, smooth vibes, and the perfect place to recharge.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 103);
            label2.Name = "label2";
            label2.Size = new Size(468, 138);
            label2.TabIndex = 8;
            label2.Text = "Start your day\r\n  with coffee";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblwelcome
            // 
            lblwelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblwelcome.BackColor = Color.Transparent;
            lblwelcome.Font = new Font("Georgia", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcome.ForeColor = Color.Linen;
            lblwelcome.Location = new Point(122, 13);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(427, 109);
            lblwelcome.TabIndex = 1;
            lblwelcome.Text = "WELCOME!";
            lblwelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.coffeeIntro;
            pictureBox1.Location = new Point(81, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 599);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // WelcomeHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_1478760329108_5c3ed9d495a0;
            Controls.Add(panel1);
            Name = "WelcomeHome";
            Size = new Size(704, 862);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private PictureBox pictureBox1;
        private Label lblwelcome;
        private Label label2;
        private Label label3;
        private Button btnStart;
    }
}
