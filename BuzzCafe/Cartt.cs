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

        double totalPrice = 0.00;
        double pricePerItem = 0.00;


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
            totalPrice = 0;

            flCart.Controls.Clear();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "SELECT oi.order_item_id, oi.order_Id, p.Product_id, p.name, p.price, p.product_image, oi.quantity, s.size_id, s.size_name, s.price_to_add, oi.total_price_perItem FROM Order_Items oi INNER JOIN Products p ON oi.Product_id = p.Product_id INNER JOIN Sizes s ON oi.size_id = s.size_id WHERE oi.order_Id = @order_Id AND oi.is_archived = 0";

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
                    cart.lbItemPrice.Text = "₱" + reader["total_price_perItem"].ToString();
                    cart.lbProductPrice.Text = "₱" + reader["price"].ToString();
                    string imagePath = reader["product_image"].ToString();
                    cart.toAddPrice.Text = " +₱" + reader["price_to_add"].ToString();


                    int orderItemId = Convert.ToInt32(reader["order_item_id"]);
                    double basePrice = Convert.ToDouble(reader["price"]);
                    double addPrice = Convert.ToDouble(reader["price_to_add"]);




                    cart.AddClicked += (s, e) =>
                    {
                        int quantity = Convert.ToInt32(cart.lbqCount.Text);
                        quantity++;

                        cart.lbqCount.Text = quantity.ToString();


                        using (SqlConnection con = DBConnection.GetConnection())
                        {
                            string query = "UPDATE Order_Items SET quantity = @quantity , total_price_perItem = @total_price_perItem WHERE order_item_id = @order_item_id ";


                            SqlCommand cmd = new SqlCommand(query, con);

                            double itemTotal = (basePrice + addPrice) * quantity;
                            cmd.Parameters.AddWithValue("@quantity", quantity);

                            cmd.Parameters.AddWithValue("@order_item_id", orderItemId);
                            cmd.Parameters.AddWithValue("@total_price_perItem", itemTotal);


                            con.Open();
                            cmd.ExecuteNonQuery();

                        }
                        LoadCart();
                    };


                    cart.RemoveClicked += (s, e) =>
                    {
                        int quantity = Convert.ToInt32(cart.lbqCount.Text);

                        if (quantity > 1)
                        {
                            quantity--;

                            cart.lbqCount.Text = quantity.ToString();

                        }



                        using (SqlConnection con = DBConnection.GetConnection())
                        {
                            string query = "UPDATE Order_Items SET quantity = @quantity , total_price_perItem = @total_price_perItem WHERE order_item_id = @order_item_id ";


                            SqlCommand cmd = new SqlCommand(query, con);

                            double itemTotal = (basePrice + addPrice) * quantity;
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.Parameters.AddWithValue("@order_item_id", orderItemId);
                            cmd.Parameters.AddWithValue("@total_price_perItem", itemTotal);

                            con.Open();
                            cmd.ExecuteNonQuery();

                        }
                        LoadCart();

                    };

                    cart.DeleteItem += (s, e) =>
                    {
                        using (SqlConnection con = DBConnection.GetConnection())
                        {
                            string query = "UPDATE Order_Items SET is_archived = 1 WHERE order_item_id = @id";

                            SqlCommand cmd = new SqlCommand(query, con);

                            cmd.Parameters.AddWithValue("@id", orderItemId);

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }

                        LoadCart();

                    };


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

                    //for add size display
                    int priceAdd = Convert.ToInt32(reader["price_to_add"]);


                    //for price to add(size)
                    if (priceAdd > 0)
                    {
                        cart.toAddPrice.Text = "+₱" + priceAdd.ToString();
                        cart.toAddPrice.Visible = true;
                    }
                    else
                    {
                        cart.toAddPrice.Visible = false;
                    }


                    flCart.Controls.Add(cart);

                    computeTotalPrice();
                }

                //if one product is left to be delete
                lbTotalPrice.Text = "₱" + totalPrice.ToString("0.00");

                void computeTotalPrice()
                {
                    pricePerItem = Convert.ToDouble(reader["total_price_perItem"]);
                    totalPrice = totalPrice + pricePerItem;
                    lbTotalPrice.Text = "₱" + totalPrice.ToString("0.00");

                }

            }

        }


        //nag auto 
        //private void Cart_AddClicked(object? sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void btnPlace_Click(object sender, EventArgs e)
        {
            Reciept rec = new Reciept();
            MainForm main = (MainForm)this.ParentForm;

            main.mainPanel.Controls.Clear();
            main.mainPanel.Controls.Add(rec);

            rec.Dock = DockStyle.Fill;
            rec.BringToFront();
            
        }
    }
}
