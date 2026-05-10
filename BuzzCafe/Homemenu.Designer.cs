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
            btnCoffee = new Button();
            btnbeverage = new Button();
            btncake = new Button();
            btnlogo = new Button();
            lbTopText = new Label();
            flLayoutMain = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnCoffee);
            panel1.Controls.Add(btnbeverage);
            panel1.Controls.Add(btncake);
            panel1.Controls.Add(btnlogo);
            panel1.Location = new Point(6, 11);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 960);
            panel1.TabIndex = 12;
            // 

            // btnCoffee
            // 
            btnCoffee.BackColor = SystemColors.ControlLightLight;
            btnCoffee.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCoffee.Location = new Point(3, 95);
            btnCoffee.Margin = new Padding(3, 4, 3, 4);
            btnCoffee.Name = "btnCoffee";
            btnCoffee.Size = new Size(107, 88);
            btnCoffee.TabIndex = 17;
            btnCoffee.Text = "Coffee";
            btnCoffee.UseVisualStyleBackColor = false;
            btnCoffee.Click += btnCoffee_Click;
            // 
            // btnbeverage
            // 
            btnbeverage.BackColor = SystemColors.ControlLightLight;
            btnbeverage.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbeverage.Location = new Point(3, 187);
            btnbeverage.Margin = new Padding(3, 4, 3, 4);
            btnbeverage.Name = "btnbeverage";
            btnbeverage.Size = new Size(107, 88);
            btnbeverage.TabIndex = 17;
            btnbeverage.Text = "Pasteries";
            btnbeverage.UseVisualStyleBackColor = false;
            btnbeverage.Click += btnbeverage_Click;
            // 
            // btncake
            // 
            btncake.BackColor = SystemColors.ControlLightLight;
            btncake.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncake.Location = new Point(2, 279);
            btncake.Margin = new Padding(3, 4, 3, 4);
            btncake.Name = "btncake";
            btncake.Size = new Size(107, 88);
            btncake.TabIndex = 17;
            btncake.Text = "Rice Meal";
            btncake.UseVisualStyleBackColor = false;
            btncake.Click += btncake_Click;
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
            lbTopText.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTopText.ForeColor = Color.Black;
            lbTopText.Location = new Point(177, 19);
            lbTopText.Name = "lbTopText";
            lbTopText.Size = new Size(372, 69);
            lbTopText.TabIndex = 14;
            lbTopText.Text = "Buzz Menu";
            // 
            // flLayoutMain
            // 
            flLayoutMain.AutoScroll = true;
            flLayoutMain.BackColor = Color.Gray;
            flLayoutMain.Location = new Point(126, 106);
            flLayoutMain.Name = "flLayoutMain";
            flLayoutMain.Size = new Size(456, 865);
            flLayoutMain.TabIndex = 15;
            // 
            // Homemenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(585, 971);
            Controls.Add(flLayoutMain);
            Controls.Add(lbTopText);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Homemenu";
            Text = "Homemenu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnCoffee;
        private Button btnbeverage;
        private Button btncake;
        private Button btnlogo;
        private Label lbTopText;
        private FlowLayoutPanel flLayoutMain;
    }
}