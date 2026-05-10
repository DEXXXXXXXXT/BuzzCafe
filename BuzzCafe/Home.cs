using System.Windows.Forms;

namespace BuzzCafe
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DineTakeout dineTakepage = new DineTakeout();
            dineTakepage.Show();
            this.Hide();
        }
    }
}
