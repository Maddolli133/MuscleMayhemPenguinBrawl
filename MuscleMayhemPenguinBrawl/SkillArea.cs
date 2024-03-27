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
    public partial class SkillArea : UserControl
    {
        int[] upgradeThresholds = { 10, 50, 100, 500, 1000, 2000, 5000, 10000 };
        int i = 0;

        int[] strenghtLevel = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int s = 0;

        int[] healthLevel = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int h = 0;

        int[] speedLevel = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int sp = 0;

        int[] laserLevel = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int l = 0;
        public SkillArea()
        {
            InitializeComponent();
            if (Form1.healthButtonOn == true)
            {
                healthLevelLabel.Text = "Health:";
                healthUpButton.Text = "Health";
            }
            if (Form1.speedButtonOn == true)
            {
                speedLevelLabel.Text = "Speed:";
                speedUpButton.Text = "Speed";
            }
            if (Form1.laserButtonOn == true)
            {
                laserLevelLabel.Text = "Laser:";
                laserUpButton.Text = "Laser";
            }
            Refresh();
        }

        private void strengthUpButton_Click(object sender, EventArgs e)
        {

            if (Form1.armPoints >= upgradeThresholds[i])
            {
                strenghtLevelLabel.Text = $"Strength:{strenghtLevel[s]}";
            }

        }

        private void healthUpButton_Click(object sender, EventArgs e)
        {
            if (Form1.chestPoints >= upgradeThresholds[i])
            {
                healthLevelLabel.Text = $"Health:{healthLevel[h]}";
            }
        }

        private void speedUpButton_Click(object sender, EventArgs e)
        {
            if (Form1.legsPoints >= upgradeThresholds[i])
            {
                speedLevelLabel.Text = $"Speed:{speedLevel[sp]}";
            }
        }

        private void laserUpButton_Click(object sender, EventArgs e)
        {
            if (Form1.backPoints >= upgradeThresholds[i])
            {
                laserLevelLabel.Text = $"Laser:{laserLevel[l]}";
            }
        }

        private void battleAreaButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen());
        }
    }
}
