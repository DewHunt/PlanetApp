using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetApp
{
    public partial class planetPositionUI : Form
    {
        public planetPositionUI()
        {
            InitializeComponent();
        }

        private void showPlanetButton_Click(object sender, EventArgs e)
        {
            if(planetNameComboBox.Text == "")
            {
                MessageBox.Show("Please enter planet name");
            }
            else
            {
                string position = "";
                string planetName = planetNameComboBox.Text;

                if (planetName == "Mercury")
                {
                    position = planetName + " is in the 3rd Position";
                }

                if (planetName == "Venus")
                {
                    position = planetName + " is in the 3rd Position";
                }

                if (planetName == "Earth")
                {
                    position = planetName + " is in the 3rd Position";
                }

                if (planetName == "Mars")
                {
                    position = planetName + " is in the 3rd Position";
                }

                if (planetName == "Jupiter")
                {
                    position = planetName + " is in the 3rd Position";

                    //MessageBox.Show("It is in the 3rd Position");
                }

                if (planetName == "Saturn")
                {
                    position = planetName + " is in the 6th Position";
                }

                if (planetName == "Uranus")
                {
                    position = planetName + " is in the 7th Position";
                }

                if (planetName == "Neptune")
                {
                    position = planetName + " is in the 8th Position";
                }

                if (planetName == "Pluto")
                {
                    position = planetName + " is in the 9th Position";
                }

                MessageBox.Show(position);
            }
        }

        private void planetPositionUI_Load(object sender, EventArgs e)
        {
            planetNameComboBox.Items.Add("Mercury");
            planetNameComboBox.Items.Add("Venus");
            planetNameComboBox.Items.Add("Earth");
            planetNameComboBox.Items.Add("Mars");
            planetNameComboBox.Items.Add("Jupiter");
            planetNameComboBox.Items.Add("Saturn");
            planetNameComboBox.Items.Add("Uranus");
            planetNameComboBox.Items.Add("Neptune");
            planetNameComboBox.Items.Add("Pluto");
            planetNameComboBox.SelectedItem = "Earth";
        }
    }
}
