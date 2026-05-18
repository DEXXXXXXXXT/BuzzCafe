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
    public partial class CartItem : UserControl
    {

        public event EventHandler AddClicked;
        public event EventHandler RemoveClicked;
        public event EventHandler DeleteItem;
        public CartItem()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            RemoveClicked?.Invoke(this, EventArgs.Empty);
        }


        private void pbDelete_Click(object sender, EventArgs e)
        {
            DeleteItem?.Invoke(this, EventArgs.Empty);
        }
    }
}
