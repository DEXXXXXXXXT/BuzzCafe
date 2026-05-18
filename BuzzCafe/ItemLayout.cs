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
    public partial class ItemLayout : UserControl
    {
        public int ProductID;

        public event EventHandler AddToCartClicked;
        public ItemLayout()
        {
            InitializeComponent();
        }

        public void SetData(int product_id, string name, string price, string imageFile)
        {
            ProductID = product_id;

            lbItemName.Text = name;
            lbPrice.Text = "₱" + price;

            if (!string.IsNullOrEmpty(imageFile))
            {
                string cleanPath = imageFile.Replace("\"", "").Trim();

                if (File.Exists(cleanPath))
                {
                    pbItem.Image = Image.FromFile(cleanPath);
                }
            }
        }

        private void btnAddTocart_Click(object sender, EventArgs e)
        {
            AddToCartClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
