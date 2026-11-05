using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }
        private void ChooseForm_Load(object sender, EventArgs e)
        {

        }
        private void btnBicycle_Click(object sender, EventArgs e)
        {
            BicycleForm bicycle = new BicycleForm();
            bicycle.Show();
            this.Hide();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm();
            mushroom.Show();
            this.Hide();
        }
    }
}