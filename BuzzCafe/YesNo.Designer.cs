namespace BuzzCafe
{
    partial class YesNo
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
            btnNo = new Button();
            label1 = new Label();
            lbType = new Label();
            btnYes = new Button();
            panel1 = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(98, 73);
            label1.Name = "label1";
            label1.Size = new Size(302, 46);
            label1.TabIndex = 2;
            label1.Text = "Are you sure?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbType.ForeColor = Color.White;
            lbType.Location = new Point(191, 141);
            lbType.Name = "lbType";
            lbType.Size = new Size(100, 39);
            lbType.TabIndex = 3;
            lbType.Text = "Type";
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
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbType);
            panel1.Controls.Add(btnYes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 321);
            panel1.TabIndex = 5;
           
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // YesNo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "YesNo";
            Padding = new Padding(10);
            Size = new Size(487, 341);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        public Button btnNo;
        public Button btnYes;
        private Panel panel1;
        public Label lbType;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
