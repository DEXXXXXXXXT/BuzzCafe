namespace BuzzCafe
{
    partial class DineTake
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
            dineTakepanel = new Panel();
            panelValidation = new Panel();
            btnNo = new Button();
            label2 = new Label();
            lbType = new Label();
            btnYes = new Button();
            panel1 = new Panel();
            btnDine = new Button();
            btnTake = new Button();
            label1 = new Label();
            lblBuzz = new Label();
            pictureBox1 = new PictureBox();
            dineTakepanel.SuspendLayout();
            panelValidation.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dineTakepanel
            // 
            dineTakepanel.BackColor = Color.Transparent;
            dineTakepanel.Controls.Add(panelValidation);
            dineTakepanel.Controls.Add(panel1);
            dineTakepanel.Controls.Add(label1);
            dineTakepanel.Controls.Add(lblBuzz);
            dineTakepanel.Controls.Add(pictureBox1);
            dineTakepanel.Dock = DockStyle.Fill;
            dineTakepanel.Location = new Point(0, 0);
            dineTakepanel.Name = "dineTakepanel";
            dineTakepanel.Size = new Size(648, 899);
            dineTakepanel.TabIndex = 0;
            // 
            // panelValidation
            // 
            panelValidation.BackColor = Color.Chocolate;
            panelValidation.Controls.Add(btnNo);
            panelValidation.Controls.Add(label2);
            panelValidation.Controls.Add(lbType);
            panelValidation.Controls.Add(btnYes);
            panelValidation.Location = new Point(107, 306);
            panelValidation.Name = "panelValidation";
            panelValidation.Size = new Size(467, 321);
            panelValidation.TabIndex = 14;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.Red;
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNo.Location = new Point(85, 208);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(138, 55);
            btnNo.TabIndex = 0;
            btnNo.Text = "No!";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(98, 73);
            label2.Name = "label2";
            label2.Size = new Size(302, 46);
            label2.TabIndex = 2;
            label2.Text = "Are you sure?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbType
            // 
            lbType.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbType.ForeColor = Color.White;
            lbType.Location = new Point(160, 119);
            lbType.Name = "lbType";
            lbType.Size = new Size(178, 85);
            lbType.TabIndex = 3;
            lbType.Text = "Type";
            lbType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.Lime;
            btnYes.FlatAppearance.BorderSize = 0;
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYes.Location = new Point(262, 208);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(138, 55);
            btnYes.TabIndex = 4;
            btnYes.Text = "Yes!";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnDine);
            panel1.Controls.Add(btnTake);
            panel1.Location = new Point(136, 674);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 162);
            panel1.TabIndex = 13;
            // 
            // btnDine
            // 
            btnDine.Anchor = AnchorStyles.None;
            btnDine.BackColor = Color.Transparent;
            btnDine.BackgroundImage = Properties.Resources.background2;
            btnDine.BackgroundImageLayout = ImageLayout.Stretch;
            btnDine.FlatAppearance.BorderSize = 0;
            btnDine.FlatStyle = FlatStyle.Popup;
            btnDine.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDine.ForeColor = SystemColors.ActiveCaptionText;
            btnDine.Location = new Point(39, 4);
            btnDine.Margin = new Padding(3, 4, 3, 4);
            btnDine.Name = "btnDine";
            btnDine.Size = new Size(139, 136);
            btnDine.TabIndex = 11;
            btnDine.UseVisualStyleBackColor = false;
            btnDine.Click += btnDine_Click;
            // 
            // btnTake
            // 
            btnTake.Anchor = AnchorStyles.None;
            btnTake.BackColor = Color.Transparent;
            btnTake.BackgroundImage = Properties.Resources.background1;
            btnTake.BackgroundImageLayout = ImageLayout.Stretch;
            btnTake.FlatAppearance.BorderSize = 0;
            btnTake.FlatStyle = FlatStyle.Flat;
            btnTake.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTake.ForeColor = SystemColors.ActiveCaptionText;
            btnTake.Location = new Point(203, 4);
            btnTake.Margin = new Padding(3, 4, 3, 4);
            btnTake.Name = "btnTake";
            btnTake.Size = new Size(137, 136);
            btnTake.TabIndex = 12;
            btnTake.UseVisualStyleBackColor = false;
            btnTake.Click += btnTake_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 487);
            label1.Name = "label1";
            label1.Size = new Size(624, 184);
            label1.TabIndex = 10;
            label1.Text = "How would you like to\r\n order today?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBuzz
            // 
            lblBuzz.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBuzz.BackColor = Color.Transparent;
            lblBuzz.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuzz.ForeColor = Color.White;
            lblBuzz.Location = new Point(102, 38);
            lblBuzz.Name = "lblBuzz";
            lblBuzz.Size = new Size(462, 88);
            lblBuzz.TabIndex = 9;
            lblBuzz.Text = "Buzz Coffee";
            lblBuzz.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.dinetakecoffee;
            pictureBox1.Location = new Point(110, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 536);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // DineTake
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dinetakebg;
            Controls.Add(dineTakepanel);
            Name = "DineTake";
            Size = new Size(648, 899);
            dineTakepanel.ResumeLayout(false);
            panelValidation.ResumeLayout(false);
            panelValidation.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel dineTakepanel;
        private PictureBox pictureBox1;
        private Label lblBuzz;
        private Label label1;
        private Button btnDine;
        private Button btnTake;
        private Panel panel1;
        private Panel panelValidation;
        public Button btnNo;
        private Label label2;
        public Label lbType;
        public Button btnYes;
    }
}
