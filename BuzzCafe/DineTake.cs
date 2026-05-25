using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuzzCafe
{
    public partial class DineTake : UserControl
    {

        string order_type = "";
        public DineTake()
        {
            InitializeComponent();
            panelValidation.Visible = false;
        }




        private void btnDine_Click(object sender, EventArgs e)
        {

            lbType.Text = "Dine In";
            order_type = "Dine In";
            MainForm.CurrentOrderType = order_type;
            panelValidation.Visible = true;

        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            lbType.Text = "Take out";
            order_type = "Take out";
            MainForm.CurrentOrderType = order_type;
            panelValidation.Visible = true;

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {

                con.Open();

                string query = "INSERT INTO Orders(order_type, order_date) OUTPUT INSERTED.order_Id VALUES (@order_type, @order_date)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@order_type", order_type);
                cmd.Parameters.AddWithValue("@order_date", DateTime.Now);

                MainForm.CurrentOrderId = Convert.ToInt32(cmd.ExecuteScalar());

             //   MessageBox.Show("Order ID: "+ MainForm.CurrentOrderId.ToString() + "\nOrder Type: " + MainForm.CurrentOrderType.ToString());


            }
            Menu menu = new Menu();
            MainForm main = (MainForm)this.ParentForm;

            main.mainPanel.Controls.Clear();
            main.mainPanel.Controls.Add(menu);

            menu.Dock = DockStyle.Fill;
            menu.BringToFront();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            panelValidation.Visible = false;
        }

        
    }
}
