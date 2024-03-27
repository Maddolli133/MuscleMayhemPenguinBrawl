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
    public partial class LegsArea : UserControl
    {
        bool legsWeightUpClicked = false;

        // Define arrays to store upgrade thresholds and increase amounts
        int[] upgradeThresholds = { 10, 50, 100, 500, 1000, 2000, 5000, 10000 }; // Add more thresholds as needed

        int i = 0;
        public LegsArea()
        {
            InitializeComponent();
            armPointsLabel.Text = $"{Form1.armPoints}";
            chestPointsLabel.Text = $"{Form1.chestPoints}";
            legPointsLabel.Text = $"{Form1.legsPoints}";
            backPointsLabel.Text = $"{Form1.backPoints}";
            coinLabel.Text = $"{Form1.coinPoints}";
        }
        private void legsLiftButton_Click(object sender, EventArgs e)
        {
            Form1.legsPoints += Form1.legsIncreaseAmount;
            legPointsLabel.Text = $"{Form1.legsPoints}";
        }
        private void legsWeightUpButton_Click(object sender, EventArgs e)
        {
            if (!legsWeightUpClicked && Form1.legsPoints >= upgradeThresholds[i])
            {
                Form1.legsIncreaseAmount *= 2;// += upgradeIncreases[i]; // Increase the increase amount
                legsWeightUpClicked = true; // Set buttonClicked to true to indicate upgrade
                Form1.legsPoints -= upgradeThresholds[i];
                i++;
                legsWeightUpButton.Text = $"Up Weight \n({upgradeThresholds[i]})";
            }

            legsWeightUpClicked = false;
        }
        private void legsEquipUpButton_Click(object sender, EventArgs e)
        {

        }
        private void skillButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new SkillArea());
        }
        private void areaBackButton_Click(object sender, EventArgs e)
        {
            if (Form1.legsPoints >= 60 && Form1.backUnlock == false/*MAKE SO WHEN BUTTON UNLOCKED NO MORE UNLOCKING NEEDED*/)
            {
                Form1.legsPoints -= 60;
                Form1.backUnlock = true;
                Form1.ChangeScreen(this, new BackArea());
                Form1.laserButtonOn = true;
            }
            else if (Form1.backUnlock == true)
            {
                Form1.ChangeScreen(this, new BackArea());
            }
        }
        private void chestAreaButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new ChestArea());
        }

        private void legGameTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void LegsArea_Load(object sender, EventArgs e)
        {
            if (Form1.backUnlock == true)
            {
                areaBackButton.Text = "Go to Back";
            }
        }
    }

     
}
