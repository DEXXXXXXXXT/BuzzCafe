using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace BuzzCafe
{
    public partial class Menu : UserControl
    {

        // instance
        int quan = 1;
        string drinkSize = "";
        double productPrice;
        double sizePrice;
        int selectedProductId;
        int selectedSize;
        double total_perItem;
        int orderId = MainForm.CurrentOrderId;
        Boolean isDrink;

        public Menu()
        {

            InitializeComponent();

            ShowCoffee();


        }


        private void btnDrinks_Click_1(object sender, EventArgs e)
        {
            ShowCoffee();
        }

        private void btnPaste_Click_1(object sender, EventArgs e)
        {
            isDrink = false;
            selectedSize = 4;
            lbTopText.Text = "Pastries";
            panelSizes.Visible = false;
            panelPopup.Visible = false;
            resetQuan();
            LoadProduct(2);
        }

        private void btnSnacks_Click_1(object sender, EventArgs e)
        {
            isDrink = false;
            selectedSize = 4;
            lbTopText.Text = "Snacks";
            panelSizes.Visible = false;
            panelPopup.Visible = false;
            resetQuan();
            LoadProduct(3);
        }

        private void btnRicemeal_Click_1(object sender, EventArgs e)
        {
            isDrink = false;
            selectedSize = 4;
            lbTopText.Text = "Rice Meals";
            panelSizes.Visible = false;
            panelPopup.Visible = false;
            resetQuan();
            LoadProduct(4);
        }



        //to display first product
        void ShowCoffee()
        {
            isDrink = true;
            lbTopText.Text = "Drinks";
            panelSizes.Visible = true;
            panelPopup.Visible = false;
            panelOrderAdded.Visible = false;
            resetQuan();
            LoadProduct(1);
        }

        //to get data from db
        void LoadProduct(int category_id)
        {
            flPanel.Controls.Clear();
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Products WHERE category_id = @id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", category_id);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int product_id = Convert.ToInt32(reader["Product_id"]);
                    string name = reader["name"].ToString();
                    string price = reader["price"].ToString();
                    string imageFile = reader["product_image"].ToString();

                    ItemLayout productItem = new ItemLayout();

                    productItem.SetData(product_id, name, price, imageFile);

                    productItem.AddToCartClicked += (s, e) =>
                    {
                        panelPopup.BringToFront();

                        selectedProductId = product_id;

                        resetColor();
                        resetQuan();

                        panelPopup.Visible = true;

                        if (isDrink)
                        {
                            drinkSize = "Small";

                            btnS.BackColor = Color.DarkGray;

                            selectedSize = 1;

                            sizePrice = getSizePrice("Small");

                            panelSizes.Visible = true;
                        }
                        else
                        {
                            selectedSize = 4;

                            panelSizes.Visible = false;
                        }

                        lblProductname.Text = name;

                        lblPrices.Text = "₱" + price;

                        if (File.Exists(imageFile))
                        {
                            pbProduct.Image = Image.FromFile(imageFile);
                        }

                        productPrice = Convert.ToDouble(price);

                        lbtoAddPrice.Visible = false;

                        updateTotalPrice();
                    };

                    flPanel.Controls.Add(productItem);
                }

                con.Close();

            }
        }



        //cancel
        private void button2_Click(object sender, EventArgs e)
        {
            panelPopup.Visible = false;
        }

        //for quanti
        void resetQuan()
        {
            quan = 1;
            lbquanCount.Text = quan.ToString();
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            quan++;
            lbquanCount.Text = quan.ToString();
            updateTotalPrice();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (quan > 1)
            {
                quan--;
            }
            lbquanCount.Text = quan.ToString();
            updateTotalPrice();
        }



        //for button(sizes, color)
        private void btnS_Click(object sender, EventArgs e)
        {
            selectedSize = 1;
            resetColor();
            btnS.BackColor = Color.DarkGray;
            size("Small");

            sizePrice = getSizePrice("Small");
            lbtoAddPrice.Visible = false;
            updateTotalPrice();

        }
        private void btnM_Click(object sender, EventArgs e)
        {
            selectedSize = 2;
            resetColor();
            btnM.BackColor = Color.DarkGray;
            size("Medium");


            sizePrice = getSizePrice("Medium");

            lbtoAddPrice.Visible = true;
            lbtoAddPrice.Text = "+₱" + Convert.ToString(sizePrice);

            updateTotalPrice();
        }
        private void btnL_Click(object sender, EventArgs e)
        {
            selectedSize = 3;
            resetColor();
            btnL.BackColor = Color.DarkGray;
            size("Large");

            sizePrice = getSizePrice("Large");

            lbtoAddPrice.Visible = true;
            lbtoAddPrice.Text = "+₱" + Convert.ToString(sizePrice);

            updateTotalPrice();
        }
        void resetColor()
        {
            btnS.BackColor = Color.Transparent;
            btnM.BackColor = Color.Transparent;
            btnL.BackColor = Color.Transparent;

        }
        void size(string size)
        {
            this.drinkSize = size;
        }
      



        //for price
        void updateTotalPrice()
        {

            total_perItem = (productPrice + sizePrice) * quan;
            lbTotalPrice.Text = "₱" + total_perItem.ToString();

        }
        //will get data from db
        double getSizePrice(string size)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "SELECT price_to_add  FROM Sizes WHERE size_name = @size";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@size", drinkSize);

                con.Open();

                return Convert.ToDouble(cmd.ExecuteScalar());
            }
        }



        // add to cart
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string check = "SELECT quantity FROM Order_Items WHERE order_Id = @order_Id AND Product_id = @product_id AND size_id = @size_id AND is_archived = 0";

                SqlCommand checkCmd = new SqlCommand(check, con);

                checkCmd.Parameters.AddWithValue("@order_Id", MainForm.CurrentOrderId);
                checkCmd.Parameters.AddWithValue("@product_id", selectedProductId);
                checkCmd.Parameters.AddWithValue("@size_id", selectedSize);

                object result = checkCmd.ExecuteScalar();


                // the product is existing
                if (result != null)
                {
                    int quantity = Convert.ToInt32(result);
                    quantity = quantity + quan;

                    double total = (productPrice + sizePrice) * quantity;

                    string updateQuery = @"UPDATE Order_Items SET quantity = @quantity,total_price_perItem = @total_price_perItem WHERE order_Id = @order_Id AND Product_id = @product_id AND size_id = @size_id";

                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);

                    updateCmd.Parameters.AddWithValue("@quantity", quantity);
                    updateCmd.Parameters.AddWithValue("@total_price_perItem", total);
                    updateCmd.Parameters.AddWithValue("@order_Id", MainForm.CurrentOrderId);
                    updateCmd.Parameters.AddWithValue("@product_id", selectedProductId);
                    updateCmd.Parameters.AddWithValue("@size_id", selectedSize);

                    //MessageBox.Show("Order id: " + orderId + "\nSelected Product Id: " + selectedProductId + "\nQuantity: " + quan + "\nSize Id: " + selectedSize + "\nPrice: " + productPrice + "\nItem total: " + total);

                    updateCmd.ExecuteNonQuery();
                }

                // if not
                else
                {
                    double total = (productPrice + sizePrice) * quan;

                    string insertQuery = @"INSERT INTO Order_Items (order_Id, Product_id, size_id, quantity, total_price_perItem)VALUES (@order_Id, @product_id, @size_id, @quantity, @total_price_perItem)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@order_Id", MainForm.CurrentOrderId);
                    insertCmd.Parameters.AddWithValue("@product_id", selectedProductId);
                    insertCmd.Parameters.AddWithValue("@size_id", selectedSize);
                    insertCmd.Parameters.AddWithValue("@total_price_perItem", total);
                    insertCmd.Parameters.AddWithValue("@quantity", quan);

                    //MessageBox.Show("Order id: " + orderId + "\nSelected Product Id: " + selectedProductId + "\nQuantity: " + quan + "\nSize Id: " + selectedSize + "\nPrice: " + productPrice + "\nItem total: " + total);

                    insertCmd.ExecuteNonQuery();
                }


                resetOrder();




            }
            void resetOrder()
            {
                selectedProductId = 0;
                selectedSize = 0;
                quan = 0;
                total_perItem = 0;
                lbquanCount.Text = "0";
                lbTotalPrice.Text = "₱0";
                sizePrice = 0;

                panelPopup.Visible = true;
                panelOrderAdded.Visible = true;

            }
        }

     

        private void btnVewCart_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.ParentForm;
            Cartt cart = new Cartt();

            main.mainPanel.Controls.Clear();
            main.mainPanel.Controls.Add(cart);

            cart.Dock = DockStyle.Fill;
            cart.BringToFront();

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            panelPopup.Visible = false;
            panelOrderAdded.Visible = false;
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.ParentForm;
            Cartt cart = new Cartt();

            main.mainPanel.Controls.Clear();
            main.mainPanel.Controls.Add(cart);

            cart.Dock = DockStyle.Fill;
            cart.BringToFront();
        }
    }
}

