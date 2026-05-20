namespace BuzzCafe
{
    partial class OrderSuccess
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
            panelOrderSucess = new Panel();
            SuspendLayout();
            // 
            // panelOrderSucess
            // 
            panelOrderSucess.BackColor = Color.Transparent;
            panelOrderSucess.Dock = DockStyle.Fill;
            panelOrderSucess.Location = new Point(0, 0);
            panelOrderSucess.Name = "panelOrderSucess";
            panelOrderSucess.Size = new Size(605, 818);
            panelOrderSucess.TabIndex = 0;
            // 
            // OrderSuccess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelOrderSucess);
            Name = "OrderSuccess";
            Size = new Size(605, 818);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOrderSucess;
    }
}
