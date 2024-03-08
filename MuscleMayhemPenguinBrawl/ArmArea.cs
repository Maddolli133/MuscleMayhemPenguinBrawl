using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuscleMayhemPenguinBrawl
{
    public partial class ArmArea : UserControl
    {
        public static int armPoints = 0;
        int increaseAmount = 1;
        bool armWeightUpClicked = false;

        // Define arrays to store upgrade thresholds and increase amounts
        int[] upgradeThresholds = { 10, 50 }; // Add more thresholds as needed
        int[] upgradeIncreases = { 1, 4 }; // Corresponding increase amounts

        public ArmArea()
        {
            InitializeComponent();
        }
        private void armLiftButton_Click(object sender, EventArgs e)
        {
            armPoints+= increaseAmount;
            armPointsLabel.Text = $"{armPoints}";
        }
        private void armWeightUpButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < upgradeThresholds.Length; i++)
            {
                // Check if button hasn't been clicked for upgrade and armPoints meets the threshold
                if (!armWeightUpClicked && armPoints >= upgradeThresholds[i])
                {
                    increaseAmount += upgradeIncreases[i]; // Increase the increase amount
                    armWeightUpClicked = true; // Set buttonClicked to true to indicate upgrade
                    break; // Exit loop after first match
                }
            }
            armWeightUpClicked = false;
        }
        private void armEquipUpButton_Click(object sender, EventArgs e)
        {

        }
        private void skillButton_Click(object sender, EventArgs e)
        {

        }
        private void areaChestButton_Click(object sender, EventArgs e)
        {

        }
        private void armGameTimer_Tick(object sender, EventArgs e)
        {
           
            Refresh();
        }
    }
}
