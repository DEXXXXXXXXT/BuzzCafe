namespace BuzzCafe
{
    partial class Validation
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
            lbMessage = new Label();
            btnNo = new Button();
            lbQuestion = new Label();
            lbAction = new Label();
            btnYes = new Button();
            panelValidation.SuspendLayout();
            SuspendLayout();
            // 
            // panelValidation
            // 
            panelValidation.BackColor = Color.FromArgb(245, 235, 220);
            panelValidation.Controls.Add(lbMessage);
            panelValidation.Controls.Add(btnNo);
            panelValidation.Controls.Add(lbQuestion);
            panelValidation.Controls.Add(lbAction);
            panelValidation.Controls.Add(btnYes);
            panelValidation.Dock = DockStyle.Fill;
            panelValidation.Location = new Point(0, 0);
            panelValidation.Name = "panelValidation";
            panelValidation.Size = new Size(471, 322);
            panelValidation.TabIndex = 15;
            // 
            // lbMessage
            // 
            lbMessage.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMessage.ForeColor = Color.FromArgb(54, 38, 27);
            lbMessage.Location = new Point(34, 165);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(402, 29);
            lbMessage.TabIndex = 5;
            lbMessage.Text = "Message";
            lbMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.Tan;
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNo.ForeColor = Color.Black;
            btnNo.Location = new Point(49, 207);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(138, 55);
            btnNo.TabIndex = 0;
            btnNo.Text = "No!";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // lbQuestion
            // 
            lbQuestion.AutoSize = true;
            lbQuestion.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbQuestion.ForeColor = Color.FromArgb(54, 38, 27);
            lbQuestion.Location = new Point(84, 57);
            lbQuestion.Name = "lbQuestion";
            lbQuestion.Size = new Size(302, 46);
            lbQuestion.TabIndex = 2;
            lbQuestion.Text = "Are you sure?";
            lbQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbAction
            // 
            lbAction.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAction.ForeColor = Color.FromArgb(54, 38, 27);
            lbAction.Location = new Point(57, 103);
            lbAction.Name = "lbAction";
            lbAction.Size = new Size(366, 53);
            lbAction.TabIndex = 3;
            lbAction.Text = "Action";
            lbAction.TextAlign = ContentAlignment.MiddleCenter;
            lbAction.Click += lbAction_Click;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(101, 67, 33);
            btnYes.FlatAppearance.BorderSize = 0;
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYes.ForeColor = Color.White;
            btnYes.Location = new Point(277, 207);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(138, 55);
            btnYes.TabIndex = 4;
            btnYes.Text = "Yes!";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // Validation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelValidation);
            Name = "Validation";
            Size = new Size(471, 322);
            panelValidation.ResumeLayout(false);
            panelValidation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel panelValidation;
        public Button btnNo;
        public Label lbAction;
        public Button btnYes;
        public Label lbMessage;
        public Label lbQuestion;
    }
}
