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
    public partial class MainForm : Form
    {
        public static int CurrentOrderId;

        public MainForm()
        {
            InitializeComponent();

            WelcomeHome home = new WelcomeHome();
            mainPanel.Controls.Add(home);

            home.Dock = DockStyle.Fill;
            home.BringToFront();

            
    }

        
    }
}
