namespace BuzzCafe
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            lbltext2 = new Label();
            lbldescript = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            btnStart = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbltext2
            // 
            lbltext2.AutoSize = true;
            lbltext2.BackColor = Color.Transparent;
            lbltext2.FlatStyle = FlatStyle.Flat;
            lbltext2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltext2.ForeColor = Color.Black;
            lbltext2.Location = new Point(157, 199);
            lbltext2.Name = "lbltext2";
            lbltext2.RightToLeft = RightToLeft.No;
            lbltext2.Size = new Size(0, 69);
            lbltext2.TabIndex = 3;
            lbltext2.TextAlign = ContentAlignment.MiddleLeft;
            lbltext2.UseMnemonic = false;
            // 
            // lbldescript
            // 
            lbldescript.AutoSize = true;
            lbldescript.BackColor = Color.Transparent;
            lbldescript.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldescript.Location = new Point(125, 272);
            lbldescript.Name = "lbldescript";
            lbldescript.Size = new Size(0, 18);
            lbldescript.TabIndex = 4;
            lbldescript.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Linen;
            label1.Location = new Point(98, 24);
            label1.Name = "label1";
            label1.Size = new Size(401, 69);
            label1.TabIndex = 0;
            label1.Text = "WELCOME!";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(62, 99);
            label2.Name = "label2";
            label2.Size = new Size(468, 138);
            label2.TabIndex = 7;
            label2.Text = "Start your day\r\n  with coffee";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnStart);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(19, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(549, 957);
            panel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(48, 803);
            label3.Name = "label3";
            label3.Size = new Size(461, 40);
            label3.TabIndex = 9;
            label3.Text = "    Buzz Coffee Shop—where every cup gives you a boost. \r\nBold brews, smooth vibes, and the perfect place to recharge.";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Gray;
            btnStart.FlatAppearance.BorderColor = Color.Black;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(0, 860);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(549, 97);
            btnStart.TabIndex = 8;
            btnStart.Text = "Touch to start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(585, 989);
            Controls.Add(panel2);
            Controls.Add(lbltext2);
            Controls.Add(lbldescript);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Buzz Coffee";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbltext2;
        private Label lbldescript;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Button btnStart;
    }
}
