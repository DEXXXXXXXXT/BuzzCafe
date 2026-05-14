using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace BuzzCafe
{
    public partial class DineTakeout : Form
    {
        public DineTakeout()
        {
            InitializeComponent();
        }



        //dine in button
        private void button1_Click(object sender, EventArgs e)
        {


            //eto dex kita ba?
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "INSERT INTO Orders(order_type, order_date) VALUES (@order_type, @order_date)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@order_type", "Dine In");
                cmd.Parameters.AddWithValue("@order_date" , DateTime.Now);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                Homemenu homepage = new Homemenu();
                homepage.Show();
                this.Hide();
                MessageBox.Show("Dine In");
                
            }
        }

        //takeout
        private void btnTake_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "INSERT INTO Orders(order_type, order_date) VALUES (@order_type, @order_date)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@order_type", "Take out");
                cmd.Parameters.AddWithValue("@order_date", DateTime.Now);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                Homemenu homepage = new Homemenu();
                homepage.Show();
                this.Hide();
                MessageBox.Show("Take Out");
                
               
            }
        }
    }
}
