using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicSlots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare each item of the photos
        public static int p1;
        public static int p2;
        public static int p3;
        public static int p4;
        public static int p5;

        // Declaring variables for display
        public static long credits = 100;
        public static long total = 0;
        public static int bet = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Assigns each indivdual boxes with the respective img files.
            pictureBox1.Image = Image.FromFile("1.png");
            pictureBox2.Image = Image.FromFile("1.png");
            pictureBox3.Image = Image.FromFile("1.png");
        }

        // Random Number Generator
        public static class IntUtil
        {
            private static Random random;

            private static void Init()
            {
                if (random == null) random = new Random();
            }

            public static int Random(int mix, int max)
            {
                Init();
                return random.Next(mix, max);
            }
        }

        //BET SIZE
        //Allows the user to set the bet size on click
        private void button2_Click(object sender, EventArgs e)
        {
            if (bet <= 0)
            {
                label2.Text = "Bet: " + bet.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Make sure that there are sufficient credits.
            if (credits >= bet)
            {
                // managing credits and updating the credits including the UI
                credits = credits - bet;
                label1.Text = "Credits: " + credits.ToString();

                // randomizing the picture generator
                for (int i = 0; i < 10; i++)
                {
                    p1 = IntUtil.Random(1, 6);
                    p2 = IntUtil.Random(1, 6);
                    p3 = IntUtil.Random(1, 6);
                }


                // Setting img in slots to match randomized number +  saved png image.
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = Image.FromFile(p1.ToString() + ".png");
                }

                if (pictureBox2.Image != null)
                {
                    pictureBox2.Image.Dispose();
                    pictureBox2.Image = Image.FromFile(p2.ToString() + ".png");
                }

                if (pictureBox3.Image != null)
                {
                    pictureBox3.Image.Dispose();
                    pictureBox3.Image = Image.FromFile(p3.ToString() + ".png");
                }

                total = 0;

                // Constructing the logic for paytable.
                // If first 2 slot matches, payout 3 creds.
                // need to figure out how to get the proper calculation for the odds in hitting certain symbols.
                if (p1 == 1 & p2 == 1 || p1 == 1 & p2 == 5)
                {
                    if (p1 == 1 & p2 == 1 & p3 == 1 || p1 == 1 & p2 == 5 & p3 == 1 || p1 == 1 & p2 == 5 & p3 == 5 || p1 == 1 & p2 == 1 & p3 == 5)
                    {
                        total += 10;
                    }
                    else
                    {
                        total += 5;
                    }
                }

                else if (p1 == 2 & p2 == 2 || p1 == 2 & p2 == 5)
                {
                    if (p1 == 2 & p2 == 2 & p3 == 2 || p1 == 2 & p2 == 5 & p3 == 2 || p1 == 2 & p2 == 5 & p3 == 5 || p1 == 2 & p2 == 2 & p3 == 5)
                    {
                        total += 20;
                    }
                    else
                    {
                        total += 7;
                    }
                }

                else if (p1 == 3 & p2 == 3 || p1 == 3 & p2 == 5)
                {
                    if (p1 == 3 & p2 == 3 & p3 == 3 || p1 == 3 & p2 == 5 & p3 == 3 || p1 == 3 & p2 == 5 & p3 == 5 || p1 == 3 & p2 == 3 & p3 == 5)
                    {
                        total += 70;
                    }
                    else
                    {
                        total += 15;
                    }
                }

                else if (p1 == 4 & p2 == 4 || p1 == 4 & p2 == 5)
                {
                    if (p1 == 4 & p2 == 4 & p3 == 4 || p1 == 4 & p2 == 5 & p3 == 4 || p1 == 4 & p2 == 5 & p3 == 5 || p1 == 4 & p2 == 4 & p3 == 5)
                    {
                        total += 30;
                    }
                    else
                    {
                        total += 7;
                    }
                }
                else if (p1 == 5)
                {
                    if (p1 == 5 & p2 == 1)
                    {
                        if (p1 == 5 & p2 == 1 & p3 == 1 || p1 == 5 & p2 == 1 & p3 == 5)
                        {
                            total += 10;
                        }
                        else
                        {
                            total += 7;
                        }
                    }
                    else if (p1 == 5 & p2 == 2)
                    {
                        if (p1 == 5 & p2 == 2 & p3 == 2 || p1 == 5 & p2 == 2 & p3 == 5)
                        {
                            total += 20;
                        }
                        else
                        {
                            total += 7;
                        }
                    }
                    else if (p1 == 5 & p2 == 3)
                    {
                        if (p1 == 5 & p2 == 3 & p3 == 3 || p1 == 5 & p2 == 3 & p3 == 5)
                        {
                            total += 70;
                        }
                        else
                        {
                            total += 15;
                        }
                    }
                    else if (p1 == 5 & p2 == 4)
                    {
                        if (p1 == 5 & p2 == 4 & p3 == 4 || p1 == 5 & p2 == 4 & p3 == 5)
                        {
                            total += 30;
                        }
                        else
                        {
                            total += 7;
                        }
                    }
                    else if (p1 == 5 & p2 == 5)
                    {
                        if (p3 == 1)
                        {
                            total += 10;
                        }
                        else if (p3 == 2)
                        {
                            total += 20;
                        }
                        else if (p3 == 3)
                        {
                            total += 70;
                        }
                        else if (p3 == 4)
                        {
                            total += 40;
                        }
                        else
                        {
                            total += 200;
                        }
                    }
                    else
                    {
                        total += 7;
                    }
                }
                else
                {
                    total += 0;
                }

                credits += total;
                label3.Text = "Win: " + total.ToString();
                label1.Text = "Credits: " + credits.ToString();
            }
            else
            {
                MessageBox.Show("Insufficient Credits.");
            }
        }
    }
}
