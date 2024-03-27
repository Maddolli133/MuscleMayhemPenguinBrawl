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
    public partial class ChestArea : UserControl
    {
        bool chestWeightUpClicked = false;

        // Define arrays to store upgrade thresholds and increase amounts
        int[] upgradeThresholds = { 10, 50, 100, 500, 1000, 2000, 5000, 10000 }; // Add more thresholds as needed

        int i = 0;
        public ChestArea()
        {
            InitializeComponent();
            armPointsLabel.Text = $"{Form1.armPoints}";
            chestPointsLabel.Text = $"{Form1.chestPoints}";
            legPointsLabel.Text = $"{Form1.legsPoints}";
            backPointsLabel.Text = $"{Form1.backPoints}";
            coinLabel.Text = $"{Form1.coinPoints}";
        }

        private void chestLiftButton_Click(object sender, EventArgs e)
        {
            Form1.chestPoints += Form1.chestIncreaseAmount;
            chestPointsLabel.Text = $"{Form1.chestPoints}";
        }
           private void chestWeightUpButton_Click(object sender, EventArgs e)
        {
            if (!chestWeightUpClicked && Form1.chestPoints >= upgradeThresholds[i])
            {
                Form1.chestIncreaseAmount *= 2;// += upgradeIncreases[i]; // Increase the increase amount
                chestWeightUpClicked = true; // Set buttonClicked to true to indicate upgrade
                Form1.chestPoints -= upgradeThresholds[i];
                i++;
                chestWeightUpButton.Text = $"Up Weight \n({upgradeThresholds[i]})";
            }

            chestWeightUpClicked = false;
        }
        private void chestEquipUpButton_Click(object sender, EventArgs e)
        {

        }
        private void skillButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new SkillArea());
        }
        private void areaLegsButton_Click(object sender, EventArgs e)
        {
            if (Form1.chestPoints >= 40 && Form1.legsUnlock == false/*MAKE SO WHEN BUTTON UNLOCKED NO MORE UNLOCKING NEEDED*/)
            {
                Form1.chestPoints -= 40;
                Form1.legsUnlock = true;
                Form1.ChangeScreen(this, new LegsArea());
                Form1.speedButtonOn = true;
            }
            else if (Form1.legsUnlock == true)
            {
                Form1.ChangeScreen(this, new LegsArea());
            }
        }
        private void armAreaButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new ArmArea());
        }
        private void chestGameTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
        private void ChestArea_Load(object sender, EventArgs e)
        {
            if (Form1.legsUnlock == true)
            {
                areaLegsButton.Text = "Go to Legs";
            }
        }
    }
}
