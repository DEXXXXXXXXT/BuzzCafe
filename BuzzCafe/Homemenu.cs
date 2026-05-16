using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuzzCafe
{
    public partial class Homemenu : UserControl
    {
        public Homemenu()
        {
            InitializeComponent();
            ShowCoffee();


            //Home home = new Home();
            //this.Controls.Add(home);

            //home.Dock = DockStyle.Fill;
            //home.BringToFront();
        }

        Panel CreateCard(string name, string price, string imageFile)
        {
            Panel card = new Panel();
            card.Width = 190; card.Height = 280;
            card.Margin = new Padding(15); card.BackColor = Color.White;

            // Rounded Corners
            GraphicsPath pathCard = new GraphicsPath();
            pathCard.AddArc(0, 0, 20, 20, 180, 90);
            pathCard.AddArc(card.Width - 20, 0, 20, 20, 270, 90);
            pathCard.AddArc(card.Width - 20, card.Height - 20, 20, 20, 0, 90);
            pathCard.AddArc(0, card.Height - 20, 20, 20, 90, 90);
            pathCard.CloseAllFigures();
            card.Region = new Region(pathCard);

            PictureBox pic = new PictureBox();
            pic.Width = 150; pic.Height = 150; pic.Top = 10; pic.Left = 20;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.BackColor = Color.FromArgb(245, 245, 245);

            // --- THE FINAL IMAGE CHECKER ---
            if (!string.IsNullOrEmpty(imageFile))
            {
                string cleanPath = imageFile.Replace("\"", "").Trim();

                if (File.Exists(cleanPath))
                {
                    pic.Image = Image.FromFile(cleanPath);
                }
                else
                {
                    pic.BackColor = Color.LightGray;
                    // Malalaman mo dito kung anong path ang hinahanap ng code mo:
                    System.Diagnostics.Debug.WriteLine("MISSING FILE: " + cleanPath);
                }
            }

            Label lblName = new Label();
            lblName.Text = name; lblName.Top = 170; lblName.Left = 15; lblName.Width = 160;
            lblName.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            Label lblPrice = new Label();
            lblPrice.Text = "₱" + price; lblPrice.Top = 200; lblPrice.Left = 15;
            lblPrice.Font = new Font("Segoe UI", 10); lblPrice.ForeColor = Color.SaddleBrown;

            Button btnAdd = new Button();
            btnAdd.Text = "Add to Cart"; btnAdd.Width = 140; btnAdd.Height = 35; btnAdd.Top = 230; btnAdd.Left = 20;
            btnAdd.BackColor = Color.SaddleBrown; btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat; btnAdd.Font = new Font("Segoe UI", 9, FontStyle.Bold);


            btnAdd.Click += (s, e) =>
            {

                lblPrices.Top = lblProductname.Bottom + 10;
                panelPopup.Visible = true;

                lblProductname.Text = name;
                lblPrices.Text = "₱" + price;

                if (File.Exists(imageFile))
                {
                    pbProduct.Image = Image.FromFile(imageFile);
                }


            };

            card.Controls.Add(pic); card.Controls.Add(lblName); card.Controls.Add(lblPrice); card.Controls.Add(btnAdd);
            return card;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            panelPopup.Visible = false;

        }

        }
    }
}