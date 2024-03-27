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
    public partial class Form1 : Form
    {
        public static int[] weightPoints = new int[3];
        public static int coinPoints = 0;

        //Arm Area
        public static int armPoints = 0;
        public static int armIncreaseAmount = 1;
        public static bool chestUnlock = false;

        //Chest Area
        public static int chestPoints = 0;
        public static int chestIncreaseAmount = 1;
        public static bool legsUnlock = false;

        //Legs Area
        public static int legsPoints = 0;
        public static int legsIncreaseAmount = 1;
        public static bool backUnlock = false;

        //Back Area
        public static int backPoints = 0;
        public static int backIncreaseAmount = 1;

        //Skill Area
        public static bool healthButtonOn = false;
        public static bool speedButtonOn = false;
        public static bool laserButtonOn = false;




        public Form1()
        {
            InitializeComponent();

            ChangeScreen(this, new MenuScreen());

        }

        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f; // will either be the sender or parent of sender

            if (sender is Form)
            {
                f = (Form)sender;                          //f is sender
            }
            else
            {
                UserControl current = (UserControl)sender;  //create UserControl from sender
                f = current.FindForm();                     //find Form UserControl is on
                f.Controls.Remove(current);                 //remove current UserControl
            }

            // add the new UserControl to the middle of the screen and focus on it
            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
                (f.ClientSize.Height - next.Height) / 2);
            f.Controls.Add(next);
            next.Focus();
        }

    }

}
