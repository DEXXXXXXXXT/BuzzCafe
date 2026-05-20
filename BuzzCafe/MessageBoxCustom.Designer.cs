namespace BuzzCafe
{
    partial class MessageBoxCustom
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
            panelValidation = new Panel();
            button2 = new Button();
            lbMessageBox = new Label();
            panelValidation.SuspendLayout();
            SuspendLayout();
            // 
            // panelValidation
            // 
            panelValidation.BackColor = Color.FromArgb(245, 235, 220);
            panelValidation.Controls.Add(button2);
            panelValidation.Controls.Add(lbMessageBox);
            panelValidation.Dock = DockStyle.Fill;
            panelValidation.Location = new Point(0, 0);
            panelValidation.Name = "panelValidation";
            panelValidation.Size = new Size(407, 246);
            panelValidation.TabIndex = 15;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(358, -11);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(49, 67);
            button2.TabIndex = 14;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lbMessageBox
            // 
            lbMessageBox.Anchor = AnchorStyles.Top;
            lbMessageBox.AutoEllipsis = true;
            lbMessageBox.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMessageBox.ForeColor = Color.FromArgb(54, 38, 27);
            lbMessageBox.Location = new Point(39, 75);
            lbMessageBox.Name = "lbMessageBox";
            lbMessageBox.Size = new Size(341, 100);
            lbMessageBox.TabIndex = 2;
            lbMessageBox.Text = "Text";
            lbMessageBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MessageBoxCustom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelValidation);
            Name = "MessageBoxCustom";
            Size = new Size(407, 246);
            panelValidation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelValidation;
        public Label lbMessageBox;
        private Button button2;
    }
}
