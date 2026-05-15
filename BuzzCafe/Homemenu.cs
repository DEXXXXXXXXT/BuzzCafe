using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuzzCafe
{
    public partial class Homemenu : UserControl
    {
        public Homemenu()
        {
            InitializeComponent();
            ShowCoffee();


            //Home home = new Home();
            //this.Controls.Add(home);

            //home.Dock = DockStyle.Fill;
            //home.BringToFront();
        }

       
    }
