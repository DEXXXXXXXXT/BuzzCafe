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
            btnSnacks = new Button();
            btnDrinks = new Button();
            btnPaste = new Button();
            btnRicemeal = new Button();
            btnlogo = new Button();
            lbTopText = new Label();
            flLayoutMain = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnSnacks);
            panel1.Controls.Add(btnDrinks);
            panel1.Controls.Add(btnPaste);
            panel1.Controls.Add(btnRicemeal);
            panel1.Controls.Add(btnlogo);
            panel1.Location = new Point(6, 11);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 960);
            panel1.TabIndex = 12;
            // 
            // btnSnacks
            // 
            btnSnacks.BackColor = SystemColors.ControlLightLight;
            btnSnacks.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSnacks.Location = new Point(3, 283);
            btnSnacks.Margin = new Padding(3, 4, 3, 4);
            btnSnacks.Name = "btnSnacks";
            btnSnacks.Size = new Size(111, 88);
            btnSnacks.TabIndex = 18;
            btnSnacks.Text = "Snacks";
            btnSnacks.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSnacks.UseVisualStyleBackColor = false;
            btnSnacks.Click += btnSnacks_Click;
            // 
            // btnDrinks
            // 
            btnDrinks.BackColor = SystemColors.ControlLightLight;
            btnDrinks.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrinks.Location = new Point(0, 91);
            btnDrinks.Margin = new Padding(3, 4, 3, 4);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(120, 88);
            btnDrinks.TabIndex = 17;
            btnDrinks.Text = "Drinks";
            btnDrinks.UseVisualStyleBackColor = false;
            btnDrinks.Click += btnDrinks_Click;
            // 
            // btnPaste
            // 
            btnPaste.BackColor = SystemColors.ControlLightLight;
            btnPaste.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaste.Location = new Point(3, 187);
            btnPaste.Margin = new Padding(3, 4, 3, 4);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(111, 88);
            btnPaste.TabIndex = 17;
            btnPaste.Text = "Pastries";
            btnPaste.UseVisualStyleBackColor = false;
            btnPaste.Click += btnPaste_Click;
            // 
            // btnRicemeal
            // 
            btnRicemeal.BackColor = SystemColors.ControlLightLight;
            btnRicemeal.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRicemeal.Location = new Point(4, 379);
            btnRicemeal.Margin = new Padding(3, 4, 3, 4);
            btnRicemeal.Name = "btnRicemeal";
            btnRicemeal.Size = new Size(107, 88);
            btnRicemeal.TabIndex = 17;
            btnRicemeal.Text = "Rice Meal";
            btnRicemeal.UseVisualStyleBackColor = false;
            btnRicemeal.Click += btnRicemeal_Click;
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
            lbTopText.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTopText.ForeColor = Color.Black;
            lbTopText.Location = new Point(179, 28);
            lbTopText.Name = "lbTopText";
            lbTopText.Size = new Size(311, 46);
            lbTopText.TabIndex = 14;
            lbTopText.Text = "Category Type";
            lbTopText.Click += lbTopText_Click;
            // 
            // flLayoutMain
            // 
            flLayoutMain.AutoScroll = true;
            flLayoutMain.BackColor = Color.Gray;
            flLayoutMain.Location = new Point(126, 107);
            flLayoutMain.Name = "flLayoutMain";
            flLayoutMain.Size = new Size(480, 865);
            flLayoutMain.TabIndex = 15;
            // 
            // Homemenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Black_and_White_Simple_Modern_Background_Instagram_Story__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(610, 971);
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
        private Button btnDrinks;
        private Button btnPaste;
        private Button btnRicemeal;
        private Button btnlogo;
        private Label lbTopText;
        private FlowLayoutPanel flLayoutMain;
        private Button btnSnacks;
    }
}