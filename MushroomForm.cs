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
    public partial class MushroomForm : Form
    {
        int step = 0;
        bool growsForest = false;
        bool askingRing = false;

        public MushroomForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmbAnswer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Yes or No.");
                return;
            }

            string answer = cmbAnswer.SelectedItem.ToString();

            if (step == 0)
            {
                growsForest = (answer == "Yes");

                step = 1;
                lblQuestion.Text = "Does your mushroom have a convex cup?";
            }
            else if (step == 1)
            {
                bool hasConvexCup = (answer == "Yes");

                if (!growsForest)
                {
                    if (hasConvexCup)
                        Identify("Agaric Jaunissant");
                    else
                        Identify("Coprin chevelu");
                }
                else if (hasConvexCup)
                {
                    askingRing = true;
                    step = 2;
                    lblQuestion.Text = "Does your mushroom have a ring?";
                }
                else
                {
                    askingRing = false;
                    step = 2;
                    lblQuestion.Text = "Does your mushroom have gills?";
                }
            }
            else if (step == 2)
            {
                if (askingRing)
                {
                    if (answer == "Yes")
                        Identify("Amanite tue-mouche");
                    else
                        Identify("Pied bleu");
                }
                else
                {
                    if (answer == "No")
                        Identify("Cepe de Bordeaux");
                    else
                        Identify("Girolle");
                }
            }

            cmbAnswer.SelectedIndex = -1;
        }
        private void Identify(string mushroom)
        {
            MessageBox.Show("Your mushroom is: " + mushroom);

            step = 0;
            growsForest = false;
            askingRing = false;

            lblQuestion.Text = "Does your mushroom grow in a forest?";
            cmbAnswer.SelectedIndex = -1;
        }
        private void lblQuestion_Click(object sender, EventArgs e)
        {

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
