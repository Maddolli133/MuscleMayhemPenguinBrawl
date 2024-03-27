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
    public partial class BackArea : UserControl
    {
        bool backWeightUpClicked = false;

        // Define arrays to store upgrade thresholds and increase amounts
        int[] upgradeThresholds = { 10, 50, 100, 500, 1000, 2000, 5000, 10000 }; // Add more thresholds as needed

        int i = 0;
        public BackArea()
        {
            InitializeComponent();
            armPointsLabel.Text = $"{Form1.armPoints}";
            chestPointsLabel.Text = $"{Form1.chestPoints}";
            legPointsLabel.Text = $"{Form1.legsPoints}";
            backPointsLabel.Text = $"{Form1.backPoints}";
            coinLabel.Text = $"{Form1.coinPoints}";

            Refresh();
        }

        private void backLiftButton_Click(object sender, EventArgs e)
        {
            Form1.backPoints += Form1.backIncreaseAmount;
            backPointsLabel.Text = $"{Form1.backPoints}";
        }
       
        private void backWeightUpButton_Click(object sender, EventArgs e)
        {
            if (!backWeightUpClicked && Form1.backPoints >= upgradeThresholds[i])
            {
                Form1.backIncreaseAmount *= 2;// += upgradeIncreases[i]; // Increase the increase amount
                backWeightUpClicked = true; // Set buttonClicked to true to indicate upgrade
                Form1.backPoints -= upgradeThresholds[i];
                i++;
                backWeightUpButton.Text = $"Up Weight \n({upgradeThresholds[i]})";
            }

            backWeightUpClicked = false;
        }

        private void backEquipUpButton_Click(object sender, EventArgs e)
        {

        }

        private void skillButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new SkillArea());
        }
        private void legsAreaButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new LegsArea());
        }
        private void legsGameTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void BackArea_Load(object sender, EventArgs e)
        {
        }
    }
}
