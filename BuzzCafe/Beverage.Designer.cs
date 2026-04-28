namespace BuzzCafe
{
    partial class Beverage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beverage));
            panel1 = new Panel();
            btnsnacks = new Button();
            btnbeverage = new Button();
            btncake = new Button();
            btnCoffee = new Button();
            btnlogo = new Button();
            lblBeverage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnsnacks);
            panel1.Controls.Add(btnCoffee);
            panel1.Controls.Add(btnbeverage);
            panel1.Controls.Add(btncake);
            panel1.Controls.Add(btnlogo);
            panel1.Location = new Point(3, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 723);
            panel1.TabIndex = 1;
            // 
            // btnsnacks
            // 
            btnsnacks.BackColor = SystemColors.ControlLightLight;
            btnsnacks.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsnacks.Location = new Point(2, 278);
            btnsnacks.Name = "btnsnacks";
            btnsnacks.Size = new Size(94, 66);
            btnsnacks.TabIndex = 17;
            btnsnacks.Text = "Snacks";
            btnsnacks.UseVisualStyleBackColor = false;
            btnsnacks.Click += button2_Click;
            // 
            // btnbeverage
            // 
            btnbeverage.BackColor = SystemColors.ControlLightLight;
            btnbeverage.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbeverage.Location = new Point(3, 140);
            btnbeverage.Name = "btnbeverage";
            btnbeverage.Size = new Size(94, 66);
            btnbeverage.TabIndex = 17;
            btnbeverage.Text = "Beverage";
            btnbeverage.UseVisualStyleBackColor = false;
            // 
            // btncake
            // 
            btncake.BackColor = SystemColors.ControlLightLight;
            btncake.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncake.Location = new Point(2, 209);
            btncake.Name = "btncake";
            btncake.Size = new Size(94, 66);
            btncake.TabIndex = 17;
            btncake.Text = "Cakes";
            btncake.UseVisualStyleBackColor = false;
            // 
            // btnCoffee
            // 
            btnCoffee.BackColor = SystemColors.ControlLightLight;
            btnCoffee.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCoffee.Location = new Point(3, 71);
            btnCoffee.Name = "btnCoffee";
            btnCoffee.Size = new Size(94, 66);
            btnCoffee.TabIndex = 17;
            btnCoffee.Text = "Coffee";
            btnCoffee.UseVisualStyleBackColor = false;
            // 
            // btnlogo
            // 
            btnlogo.BackColor = Color.Transparent;
            btnlogo.BackgroundImage = (Image)resources.GetObject("btnlogo.BackgroundImage");
            btnlogo.FlatAppearance.BorderSize = 0;
            btnlogo.FlatStyle = FlatStyle.Flat;
            btnlogo.ForeColor = Color.Black;
            btnlogo.Location = new Point(4, 7);
            btnlogo.Name = "btnlogo";
            btnlogo.Size = new Size(91, 60);
            btnlogo.TabIndex = 14;
            btnlogo.UseVisualStyleBackColor = false;
            // 
            // lblBeverage
            // 
            lblBeverage.AutoSize = true;
            lblBeverage.BackColor = Color.Transparent;
            lblBeverage.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBeverage.ForeColor = Color.Black;
            lblBeverage.Location = new Point(168, 14);
            lblBeverage.Name = "lblBeverage";
            lblBeverage.Size = new Size(250, 56);
            lblBeverage.TabIndex = 10;
            lblBeverage.Text = "Beverage";
            // 
            // BreadMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(512, 742);
            Controls.Add(lblBeverage);
            Controls.Add(panel1);
            Name = "BreadMenu";
            Text = "Beverage";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnsnacks;
        private Button btnbeverage;
        private Button btncake;
        private Button btnCoffee;
        private Button btnlogo;
        private Label lblBeverage;
    }
}