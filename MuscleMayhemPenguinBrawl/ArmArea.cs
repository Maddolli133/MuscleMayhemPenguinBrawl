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
        bool armWeightUpClicked = false;

        // Define arrays to store upgrade thresholds and increase amounts
        int[] upgradeThresholds = {10, 50, 100, 500, 1000, 2000, 5000, 10000}; // Add more thresholds as needed

        int i = 0;

        public ArmArea()
        {
            InitializeComponent();
            armPointsLabel.Text = $"{Form1.armPoints}";
            chestPointsLabel.Text = $"{Form1.chestPoints}";
            legPointsLabel.Text = $"{Form1.legsPoints}";
            backPointsLabel.Text = $"{Form1.backPoints}";
            coinLabel.Text = $"{Form1.coinPoints}";

            Refresh();

        }
        private void armLiftButton_Click(object sender, EventArgs e)
        {
            Form1.armPoints += Form1.armIncreaseAmount;
            armPointsLabel.Text = $"{Form1.armPoints}";
        }
        private void armWeightUpButton_Click(object sender, EventArgs e)
        {

            if (!armWeightUpClicked && Form1.armPoints >= upgradeThresholds[i])
            {
                Form1.armIncreaseAmount *= 2;// += upgradeIncreases[i]; // Increase the increase amount
                armWeightUpClicked = true; // Set buttonClicked to true to indicate upgrade
                Form1.armPoints -= upgradeThresholds[i];
                i++;
                armWeightUpButton.Text = $"Up Weight \n({upgradeThresholds[i]})";
            }

            armWeightUpClicked = false;
        }
        private void armEquipUpButton_Click(object sender, EventArgs e)
        {

        }
        private void skillButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new SkillArea());
        }
        private void areaChestButton_Click(object sender, EventArgs e)
        {
            if (Form1.armPoints >= 20 && Form1.chestUnlock == false/*MAKE SO WHEN BUTTON UNLOCKED NO MORE UNLOCKING NEEDED*/)
            {
                Form1.armPoints -= 20;
                Form1.chestUnlock = true;
                Form1.ChangeScreen(this, new ChestArea());
                Form1.healthButtonOn = true;
            }
            else if (Form1.chestUnlock == true)
            {
                Form1.ChangeScreen(this, new ChestArea());
            }
        }
        private void armGameTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ArmArea_Load(object sender, EventArgs e)
        {
            if (Form1.chestUnlock == true)
            {
                areaChestButton.Text = "Go to Chest";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
