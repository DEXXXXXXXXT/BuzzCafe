using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuzzCafe
{
    public partial class Cartt : UserControl
    {
        public Cartt()
        {
            InitializeComponent();
            LoadCart();

        }

        //back button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.ParentForm;
            Menu menu = new Menu();

            main.mainPanel.Controls.Clear();
            main.mainPanel.Controls.Add(menu);

            menu.Dock = DockStyle.Fill;
            menu.BringToFront();


        }
        void LoadCart()
        {
            flCart.Controls.Clear();
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "SELECT oi.order_item_id, oi.order_Id, p.Product_id, p.name, p.price, p.product_image, oi.quantity, s.size_id, s.size_name, s.price_to_add, oi.total_price_perItem FROM Order_Items oi INNER JOIN Products p ON oi.Product_id = p.Product_id INNER JOIN Sizes s ON oi.size_id = s.size_id WHERE oi.order_Id = @order_Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@order_Id", MainForm.CurrentOrderId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CartItem cart = new CartItem();

                 
                    cart.lbProdName.Text = reader["name"].ToString();
                    cart.lbSize.Text = reader["size_name"].ToString();
                    cart.lbqCount.Text = reader["quantity"].ToString();
                    cart.lbItemPrice.Text = "₱"+ reader["total_price_perItem"].ToString();
                    cart.lbProductPrice.Text = "₱" + reader["price"].ToString();
                    string imagePath = reader["product_image"].ToString();
                    cart.toAddPrice.Text = " +₱" + reader["price_to_add"].ToString();

                    if (File.Exists(imagePath))
                    {
                        cart.pbImage.Image = Image.FromFile(imagePath);
                    }

                    //to hide size
                    int sizeId = Convert.ToInt32(reader["size_id"]);
                    if (sizeId == 4)
                    {
                        cart.panelCartsize.Visible = false;
                    }
                    else
                    {
                        cart.panelCartsize.Visible = true;
                    }

                    //for add size
                    int priceAdd = Convert.ToInt32(reader["price_to_add"]);
                    if (sizeId == 1 || sizeId == 4)
                    {
                        cart.toAddPrice.Visible = false;
                    }
                    else
                    {
                        cart.toAddPrice.Visible = true;
                    }


                    flCart.Controls.Add(cart);
                }
                
            }
        
        }

        
    }
}
