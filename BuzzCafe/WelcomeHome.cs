using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuzzCafe
{
    public partial class WelcomeHome : UserControl
    {
        public WelcomeHome()
        {
            InitializeComponent();
        }



        private void btnStart_Click_1(object sender, EventArgs e)
        {
            DineTake dine = new DineTake();
            MainForm main = (MainForm)this.ParentForm;

            main.mainPanel.Controls.Clear();
            main.mainPanel.Controls.Add(dine);

            dine.Dock = DockStyle.Fill;
            dine.BringToFront();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
