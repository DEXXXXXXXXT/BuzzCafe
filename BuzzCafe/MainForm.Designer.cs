namespace BuzzCafe
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainPanel = new Panel();
            buttonPic1 = new BuzzCafe.Resources.Toolbox.ButtonPic();
            cartItem1 = new CartItem();
            welcomeHome1 = new WelcomeHome();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(welcomeHome1);
            mainPanel.Controls.Add(cartItem1);
            mainPanel.Controls.Add(buttonPic1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(632, 728);
            mainPanel.TabIndex = 0;
            // 
            // buttonPic1
            // 
            buttonPic1.Location = new Point(43, 46);
            buttonPic1.Margin = new Padding(3, 2, 3, 2);
            buttonPic1.Name = "buttonPic1";
            buttonPic1.Size = new Size(202, 56);
            buttonPic1.TabIndex = 0;
            // 
            // cartItem1
            // 
            cartItem1.Location = new Point(99, 126);
            cartItem1.Margin = new Padding(3, 2, 3, 2);
            cartItem1.Name = "cartItem1";
            cartItem1.Size = new Size(8, 8);
            cartItem1.TabIndex = 1;
            // 
            // welcomeHome1
            // 
            welcomeHome1.BackgroundImage = (Image)resources.GetObject("welcomeHome1.BackgroundImage");
            welcomeHome1.Location = new Point(0, 0);
            welcomeHome1.Margin = new Padding(3, 2, 3, 2);
            welcomeHome1.Name = "welcomeHome1";
            welcomeHome1.Size = new Size(616, 646);
            welcomeHome1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 728);
            Controls.Add(mainPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel mainPanel;
        private WelcomeHome welcomeHome1;
        private CartItem cartItem1;
        private Resources.Toolbox.ButtonPic buttonPic1;
    }
}