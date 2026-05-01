namespace BuzzCafe
{
    partial class DineTakeout
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
            paneldinetake = new Panel();
            btnTake = new Button();
            btnDine = new Button();
            label1 = new Label();
            lblBuzz = new Label();
            pictureBox1 = new PictureBox();
            paneldinetake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // paneldinetake
            // 
            paneldinetake.BackColor = Color.Transparent;
            paneldinetake.Controls.Add(btnTake);
            paneldinetake.Controls.Add(btnDine);
            paneldinetake.Controls.Add(label1);
            paneldinetake.Controls.Add(lblBuzz);
            paneldinetake.Controls.Add(pictureBox1);
            paneldinetake.Location = new Point(12, 12);
            paneldinetake.Name = "paneldinetake";
            paneldinetake.Size = new Size(480, 721);
            paneldinetake.TabIndex = 0;
            // 
            // btnTake
            // 
            btnTake.BackColor = Color.Transparent;
            btnTake.BackgroundImage = Properties.Resources.Black_and_White_Simple_Modern_Background_Instagram_Story__4__removebg_preview;
            btnTake.BackgroundImageLayout = ImageLayout.Zoom;
            btnTake.FlatAppearance.BorderSize = 0;
            btnTake.FlatStyle = FlatStyle.Popup;
            btnTake.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTake.ForeColor = SystemColors.ActiveCaptionText;
            btnTake.Location = new Point(249, 549);
            btnTake.Name = "btnTake";
            btnTake.Size = new Size(153, 157);
            btnTake.TabIndex = 11;
            btnTake.UseVisualStyleBackColor = false;
            // 
            // btnDine
            // 
            btnDine.BackColor = Color.Transparent;
            btnDine.BackgroundImage = Properties.Resources.Black_and_White_Simple_Modern_Background_Instagram_Story__5__removebg_preview;
            btnDine.BackgroundImageLayout = ImageLayout.Stretch;
            btnDine.FlatAppearance.BorderSize = 0;
            btnDine.FlatStyle = FlatStyle.Popup;
            btnDine.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDine.ForeColor = SystemColors.ActiveCaptionText;
            btnDine.Location = new Point(67, 549);
            btnDine.Name = "btnDine";
            btnDine.Size = new Size(153, 157);
            btnDine.TabIndex = 10;
            btnDine.UseVisualStyleBackColor = false;
            btnDine.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 440);
            label1.Name = "label1";
            label1.Size = new Size(443, 86);
            label1.TabIndex = 9;
            label1.Text = "How would you like to\r\n       order today?";
            label1.Click += label1_Click;
            // 
            // lblBuzz
            // 
            lblBuzz.AutoSize = true;
            lblBuzz.BackColor = Color.Transparent;
            lblBuzz.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuzz.ForeColor = Color.White;
            lblBuzz.Location = new Point(91, 11);
            lblBuzz.Name = "lblBuzz";
            lblBuzz.Size = new Size(311, 56);
            lblBuzz.TabIndex = 8;
            lblBuzz.Text = "Buzz Coffee";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.coffe_removebg_preview;
            pictureBox1.Location = new Point(1, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(479, 426);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // DineTakeout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg7;
            ClientSize = new Size(512, 728);
            Controls.Add(paneldinetake);
            ForeColor = SystemColors.ControlDark;
            Name = "DineTakeout";
            Text = "DineTakeout";
            paneldinetake.ResumeLayout(false);
            paneldinetake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel paneldinetake;
        private PictureBox pictureBox1;
        private Label lblBuzz;
        private Label label1;
        private Button btnTake;
        private Button btnDine;
    }
}