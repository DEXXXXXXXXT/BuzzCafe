namespace BuzzCafe
{
    partial class Pasteries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pasteries));
            panel1 = new Panel();
            btnCoffee = new Button();
            btnbeverage = new Button();
            btncake = new Button();
            btnlogo = new Button();
            lblBeverage = new Label();
            panel2 = new Panel();
            btncappu = new Button();
            btnespresso = new Button();
            btnbreve = new Button();
            btnmocha = new Button();
            btnlatte = new Button();
            btnamericano = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel1.TabIndex = 1;
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
            btncake.Location = new Point(2, 212);
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
            lblBeverage.Size = new Size(252, 56);
            lblBeverage.TabIndex = 10;
            lblBeverage.Text = "Pasteries";
            lblBeverage.Click += lblBeverage_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btncappu);
            panel2.Controls.Add(btnespresso);
            panel2.Controls.Add(btnbreve);
            panel2.Controls.Add(btnmocha);
            panel2.Controls.Add(btnlatte);
            panel2.Controls.Add(btnamericano);
            panel2.Location = new Point(105, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 652);
            panel2.TabIndex = 12;
            // 
            // btncappu
            // 
            btncappu.BackgroundImageLayout = ImageLayout.Zoom;
            btncappu.Location = new Point(203, 417);
            btncappu.Name = "btncappu";
            btncappu.Size = new Size(158, 201);
            btncappu.TabIndex = 5;
            btncappu.UseVisualStyleBackColor = true;
            // 
            // btnespresso
            // 
            btnespresso.BackgroundImageLayout = ImageLayout.Stretch;
            btnespresso.Location = new Point(27, 417);
            btnespresso.Name = "btnespresso";
            btnespresso.Size = new Size(158, 201);
            btnespresso.TabIndex = 4;
            btnespresso.UseVisualStyleBackColor = true;
            // 
            // btnbreve
            // 
            btnbreve.BackgroundImageLayout = ImageLayout.Zoom;
            btnbreve.Location = new Point(203, 210);
            btnbreve.Name = "btnbreve";
            btnbreve.Size = new Size(158, 201);
            btnbreve.TabIndex = 3;
            btnbreve.UseVisualStyleBackColor = true;
            // 
            // btnmocha
            // 
            btnmocha.BackgroundImageLayout = ImageLayout.Stretch;
            btnmocha.Location = new Point(27, 210);
            btnmocha.Name = "btnmocha";
            btnmocha.Size = new Size(158, 201);
            btnmocha.TabIndex = 2;
            btnmocha.UseVisualStyleBackColor = true;
            // 
            // btnlatte
            // 
            btnlatte.BackgroundImageLayout = ImageLayout.Stretch;
            btnlatte.Location = new Point(203, 3);
            btnlatte.Name = "btnlatte";
            btnlatte.Size = new Size(158, 201);
            btnlatte.TabIndex = 1;
            btnlatte.UseVisualStyleBackColor = true;
            // 
            // btnamericano
            // 
            btnamericano.BackgroundImageLayout = ImageLayout.Stretch;
            btnamericano.Location = new Point(27, 3);
            btnamericano.Name = "btnamericano";
            btnamericano.Size = new Size(158, 201);
            btnamericano.TabIndex = 0;
            btnamericano.UseVisualStyleBackColor = true;
            // 
            // Pasteries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(512, 728);
            Controls.Add(panel2);
            Controls.Add(lblBeverage);
            Controls.Add(panel1);
            Name = "Pasteries";
            Text = "Beverage";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnbeverage;
        private Button btncake;
        private Button btnCoffee;
        private Button btnlogo;
        private Label lblBeverage;
        private Panel panel2;
        private Button btncappu;
        private Button btnespresso;
        private Button btnbreve;
        private Button btnmocha;
        private Button btnlatte;
        private Button btnamericano;
    }
}