using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start, end;
            int total = 0;

            if (!int.TryParse(txtStart.Text, out start) ||
                !int.TryParse(txtEnd.Text, out end))
            {
                MessageBox.Show("Please enter valid whole numbers.");
                return;
            }

            if (start < 0 || start > 23 || end < 1 || end > 24 || start >= end)
            {
                MessageBox.Show("Invalid starting or ending hour.");
                return;
            }

            for (int hour = start; hour < end; hour++)
            {
                if (hour < 7 || hour >= 21)
                {
                    total += 500;
                }
                else if (hour < 14 || hour >= 19)
                {
                    total += 1000;
                }
                else
                {
                    total += 1500;
                }
            }

            txtTotal.Text = total.ToString() + " RWF";

            MessageBox.Show("Total rental cost: " + total + " RWF");
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            ChooseForm choose = new ChooseForm();
            choose.Show();
            this.Close();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
    
    

