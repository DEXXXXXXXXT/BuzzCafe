namespace BuzzCafe
{
    partial class Coffeemenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coffeemenu));
            lblCoffeemenu = new Label();
            panel1 = new Panel();
            btnCoffee = new Button();
            btnbeverage = new Button();
            btncake = new Button();
            btnlogo = new Button();
            panelcoffee = new Panel();
            btncappu = new Button();
            btnespresso = new Button();
            btnbreve = new Button();
            btnmocha = new Button();
            btnlatte = new Button();
            btnamericano = new Button();
            panel1.SuspendLayout();
            panelcoffee.SuspendLayout();
            SuspendLayout();
            // 
            // lblCoffeemenu
            // 
            lblCoffeemenu.AutoSize = true;
            lblCoffeemenu.BackColor = Color.Transparent;
            lblCoffeemenu.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoffeemenu.ForeColor = Color.Black;
            lblCoffeemenu.Location = new Point(210, 13);
            lblCoffeemenu.Name = "lblCoffeemenu";
            lblCoffeemenu.Size = new Size(181, 56);
            lblCoffeemenu.TabIndex = 9;
            lblCoffeemenu.Text = "Coffee";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnCoffee);
            panel1.Controls.Add(btnbeverage);
            panel1.Controls.Add(btncake);
            panel1.Controls.Add(btnlogo);
            panel1.Location = new Point(3, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 723);
            panel1.TabIndex = 10;
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
            // btnbeverage
            // 
            btnbeverage.BackColor = SystemColors.ControlLightLight;
            btnbeverage.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbeverage.Location = new Point(3, 140);
            btnbeverage.Name = "btnbeverage";
            btnbeverage.Size = new Size(94, 66);
            btnbeverage.TabIndex = 17;
            btnbeverage.Text = "Pasteries";
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
            btncake.Text = "Rice Meal";
            btncake.UseVisualStyleBackColor = false;
            // 
            // btnlogo
            // 
            btnlogo.BackColor = Color.Transparent;
            btnlogo.BackgroundImage = (Image)resources.GetObject("btnlogo.BackgroundImage");
            btnlogo.FlatAppearance.BorderSize = 0;
            btnlogo.FlatStyle = FlatStyle.Flat;
            btnlogo.ForeColor = Color.Black;
            btnlogo.Location = new Point(4, 6);
            btnlogo.Name = "btnlogo";
            btnlogo.Size = new Size(91, 60);
            btnlogo.TabIndex = 14;
            btnlogo.UseVisualStyleBackColor = false;
            // 
            // panelcoffee
            // 
            panelcoffee.BackColor = Color.Silver;
            panelcoffee.Controls.Add(btncappu);
            panelcoffee.Controls.Add(btnespresso);
            panelcoffee.Controls.Add(btnbreve);
            panelcoffee.Controls.Add(btnmocha);
            panelcoffee.Controls.Add(btnlatte);
            panelcoffee.Controls.Add(btnamericano);
            panelcoffee.Location = new Point(104, 77);
            panelcoffee.Name = "panelcoffee";
            panelcoffee.Size = new Size(403, 652);
            panelcoffee.TabIndex = 11;
            // 
            // btncappu
            // 
            btncappu.BackgroundImage = Properties.Resources.cappu;
            btncappu.BackgroundImageLayout = ImageLayout.Zoom;
            btncappu.Location = new Point(203, 417);
            btncappu.Name = "btncappu";
            btncappu.Size = new Size(158, 201);
            btncappu.TabIndex = 5;
            btncappu.UseVisualStyleBackColor = true;
            // 
            // btnespresso
            // 
            btnespresso.BackgroundImage = (Image)resources.GetObject("btnespresso.BackgroundImage");
            btnespresso.BackgroundImageLayout = ImageLayout.Stretch;
            btnespresso.Location = new Point(27, 417);
            btnespresso.Name = "btnespresso";
            btnespresso.Size = new Size(158, 201);
            btnespresso.TabIndex = 4;
            btnespresso.UseVisualStyleBackColor = true;
            // 
            // btnbreve
            // 
            btnbreve.BackgroundImage = Properties.Resources.breve;
            btnbreve.BackgroundImageLayout = ImageLayout.Zoom;
            btnbreve.Location = new Point(203, 210);
            btnbreve.Name = "btnbreve";
            btnbreve.Size = new Size(158, 201);
            btnbreve.TabIndex = 3;
            btnbreve.UseVisualStyleBackColor = true;
            // 
            // btnmocha
            // 
            btnmocha.BackgroundImage = Properties.Resources.mocha;
            btnmocha.BackgroundImageLayout = ImageLayout.Stretch;
            btnmocha.Location = new Point(27, 210);
            btnmocha.Name = "btnmocha";
            btnmocha.Size = new Size(158, 201);
            btnmocha.TabIndex = 2;
            btnmocha.UseVisualStyleBackColor = true;
            // 
            // btnlatte
            // 
            btnlatte.BackgroundImage = Properties.Resources.latterr;
            btnlatte.BackgroundImageLayout = ImageLayout.Stretch;
            btnlatte.Location = new Point(203, 3);
            btnlatte.Name = "btnlatte";
            btnlatte.Size = new Size(158, 201);
            btnlatte.TabIndex = 1;
            btnlatte.UseVisualStyleBackColor = true;
            // 
            // btnamericano
            // 
            btnamericano.BackgroundImage = Properties.Resources.ameri;
            btnamericano.BackgroundImageLayout = ImageLayout.Stretch;
            btnamericano.Location = new Point(27, 3);
            btnamericano.Name = "btnamericano";
            btnamericano.Size = new Size(158, 201);
            btnamericano.TabIndex = 0;
            btnamericano.UseVisualStyleBackColor = true;
            // 
            // Coffeemenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(512, 728);
            Controls.Add(panelcoffee);
            Controls.Add(panel1);
            Controls.Add(lblCoffeemenu);
            Name = "Coffeemenu";
            Text = "Coffeemenu";
            Load += Coffeemenu_Load;
            panel1.ResumeLayout(false);
            panelcoffee.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCoffeemenu;
        private Panel panel1;
        private Button btnCoffee;
        private Button btnbeverage;
        private Button btncake;
        private Button btnlogo;
        private Panel panelcoffee;
        private Button btnespresso;
        private Button btnbreve;
        private Button btnmocha;
        private Button btnlatte;
        private Button btnamericano;
        private Button btncappu;
    }
}