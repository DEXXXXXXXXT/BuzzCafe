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
    public partial class MessageBoxCustom : UserControl
    {
        public MessageBoxCustom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panelValidation.Visible = false;
            this.Hide();

        }
    }
}
