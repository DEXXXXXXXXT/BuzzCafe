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
    public partial class Homemenu : Form
    {
        public Homemenu()
        {
            InitializeComponent();
            ShowCoffee();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            lbTopText.Text = "Drink'zz";
            LoadProduct(1);
        }
        private void btnlogo_Click(object sender, EventArgs e)
        {
            lbTopText.Text = "CAFE MENU";
        }
        private void btnPaste_Click(object sender, EventArgs e)
        {
            lbTopText.Text = "Pastrie'zz";
            LoadProduct(2);
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            lbTopText.Text = "Snack'zz";
            LoadProduct(3);
        }

        private void btnRicemeal_Click(object sender, EventArgs e)
        {
            lbTopText.Text = "Rice Meal'zz";
            LoadProduct(4);
        }







        void ShowCoffee()
        {
            lbTopText.Text = "Drink'zz";
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
            card.Width = 190;
            card.Height = 280;
            card.Margin = new Padding(15);
            card.BackColor = Color.White;

            // Rounded Corners
            GraphicsPath pathCard = new GraphicsPath();
            pathCard.AddArc(0, 0, 20, 20, 180, 90);
            pathCard.AddArc(card.Width - 20, 0, 20, 20, 270, 90);
            pathCard.AddArc(card.Width - 20, card.Height - 20, 20, 20, 0, 90);
            pathCard.AddArc(0, card.Height - 20, 20, 20, 90, 90);
            pathCard.CloseAllFigures();

            card.Region = new Region(pathCard);

            // Product Image
            PictureBox pic = new PictureBox();
            pic.Width = 150;
            pic.Height = 150;
            pic.Top = 10;
            pic.Left = 20;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.BackColor = Color.FromArgb(245, 245, 245);

            string imgPath = Path.Combine(Application.StartupPath, "Images", "products", imageFile);

            if (File.Exists(imgPath))
                pic.Image = Image.FromFile(imgPath);

            // Product Name
            Label lblName = new Label();
            lblName.Text = name;
            lblName.Top = 170;
            lblName.Left = 15;
            lblName.Width = 160;
            lblName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(40, 40, 40);

            // Price
            Label lblPrice = new Label();
            lblPrice.Text = "₱" + price;
            lblPrice.Top = 200;
            lblPrice.Left = 15;
            lblPrice.Font = new Font("Segoe UI", 10);
            lblPrice.ForeColor = Color.SaddleBrown;

            // Add Button
            Button btnAdd = new Button();
            btnAdd.Text = "Add to Cart";
            btnAdd.Width = 140;
            btnAdd.Height = 35;
            btnAdd.Top = 230;
            btnAdd.Left = 20;
            btnAdd.BackColor = Color.SaddleBrown;
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            // Rounded button
            GraphicsPath btnPath = new GraphicsPath();
            btnPath.AddArc(0, 0, 15, 15, 180, 90);
            btnPath.AddArc(btnAdd.Width - 15, 0, 15, 15, 270, 90);
            btnPath.AddArc(btnAdd.Width - 15, btnAdd.Height - 15, 15, 15, 0, 90);
            btnPath.AddArc(0, btnAdd.Height - 15, 15, 15, 90, 90);
            btnPath.CloseAllFigures();

            btnAdd.Region = new Region(btnPath);

            // Hover Effect
            card.MouseEnter += (s, e) =>
            {
                card.BackColor = Color.FromArgb(250, 245, 240);
            };

            card.MouseLeave += (s, e) =>
            {
                card.BackColor = Color.White;
            };

            card.Controls.Add(pic);
            card.Controls.Add(lblName);
            card.Controls.Add(lblPrice);
            card.Controls.Add(btnAdd);

            return card;
        }


    }
}
