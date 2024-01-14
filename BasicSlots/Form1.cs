﻿using System;
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
         
        // Declaring variables for display
        public static long credits = 100;
        public static long total = 0;
        public static int bet = 5;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Assigns each indivdual boxes with the respective img files.
            pictureBox1.Image = Image.FromFile("1.png");
            pictureBox2.Image = Image.FromFile("2.png");
            pictureBox3.Image = Image.FromFile("3.png");
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Make sure that there are sufficient credits.
            if (credits >= bet)
            {
                // managing credits and updating the credits including the UI
                credits  =  credits - bet;
                label1.Text = "Credits: " + credits.ToString();

                // randomizing the picture generator
                for (int i = 0; i < 10; i++)
                {
                    p1 = IntUtil.Random(1, 4);
                    p2 = IntUtil.Random(1, 4);
                    p3 = IntUtil.Random(1, 4);
                }


                // Setting img in slots to match randomized number +  saved png image.
                if(pictureBox1.Image != null)
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

                //
            }
            else
            {

            }
        }
    }
}
