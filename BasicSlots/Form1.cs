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
    }
}
