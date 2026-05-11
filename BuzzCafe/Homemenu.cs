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
    public partial class Homemenu : Form
    {
        public Homemenu()
        {
            InitializeComponent();
            ShowCoffee();
        }
        private void btnlogo_Click(object sender, EventArgs e)
        {
            lbTopText.Text = "CAFE MENU";
        }
        private void btnCoffee_Click(object sender, EventArgs e)
        {
            lbTopText.Text = "COFFEE'zz";
            LoadProduct(1);
            Homemenu hmenuu = new Homemenu();
            hmenuu.Show();
            this.Hide();

        }

        private void btnbeverage_Click(object sender, EventArgs e)
        {
            lbTopText.Text = "BEVERAGE'zz";
            LoadProduct(2);
            Pasteries paster = new Pasteries();
            paster.Show();
            this.Hide();

        }

        private void btncake_Click(object sender, EventArgs e)
        {
            lbTopText.Text = "CAKE'zz";
            LoadProduct(3);
        }

        private void btnsnacks_Click(object sender, EventArgs e)
        {
            lbTopText.Text = "SNACK'zz";
            LoadProduct(4);

        }
        void ShowCoffee()
        {
            lbTopText.Text = "COFFEE'zz";
            LoadProduct(1);
        }

        void LoadProduct(int category_id)
        {
            flLayoutMain.Controls.Clear();
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Products WHERE category_id = @id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", category_id);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    flLayoutMain.Controls.Add(
                        CreateCard(
                            reader["name"].ToString(),
                            reader["price"].ToString(),
                            reader["product_image"].ToString()
                        )
                    );
                }

                con.Close();
            }
        }
        Panel CreateCard(string name, string price, string imageFile)
        {
            Panel card = new Panel();
            card.Width = 180;
            card.Height = 220;
            card.Margin = new Padding(15);
            card.BackColor = Color.White;

            PictureBox pic = new PictureBox();
            pic.Width = 160;
            pic.Height = 120;
            pic.Top = 10;
            pic.Left = 10;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;

            string path = Path.Combine(Application.StartupPath, "Images", "products", imageFile);
            if (File.Exists(path))
                pic.Image = Image.FromFile(path);

            Label lblName = new Label();
            lblName.Text = name;
            lblName.Top = 135;
            lblName.Left = 10;
            lblName.Width = 160;
            lblName.Font = new Font("Arial", 10, FontStyle.Bold);

            Label lblPrice = new Label();
            lblPrice.Text = "₱" + price;
            lblPrice.Top = 160;
            lblPrice.Left = 10;

            card.Controls.Add(pic);
            card.Controls.Add(lblName);
            card.Controls.Add(lblPrice);

            // CLICK 
            card.Click += (s, e) =>
            {
                MessageBox.Show(name + " selected");
            };

            return card;
        }

        private void lbTopText_Click(object sender, EventArgs e)
        {

        }
    }
}
