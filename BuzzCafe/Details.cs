using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuzzCafe
{
    public partial class Details : Form
    {

        public Details()
        {
            InitializeComponent();
        }

        private void btnadd_Click(Button btnadd)
        {
            btnadd.Size = new Size(60, 60);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btnadd.Width, btnadd.Height);
            btnadd.Region = new Region(path);
        }
    }
}
