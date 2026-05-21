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
    public partial class OrderSuccess : UserControl
    {
        public event EventHandler ViewReceiptClicked;
        public event EventHandler OrderAgainClicked;
        public OrderSuccess()
        {
            InitializeComponent();
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            ViewReceiptClicked?.Invoke(this, EventArgs.Empty);
        }

       
    }
}
