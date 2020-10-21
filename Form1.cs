using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        //public int x = 21;
        //public int y = 0;
        public Point p = new Point(2,2);
        public int kX = 1;
        public int kY = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (panel1.Location.X >= Width - 25 || panel1.Location.X < 1)
            { kX *= -1;
                if (kX > 0) BackColor = Color.Red; 
                else BackColor = Color.Magenta;
            }
            if (panel1.Location.Y >= Height - 50 || panel1.Location.Y < 1) 
            { kY *= -1;
                if (kY > 0) BackColor = Color.White;
                else BackColor = Color.Yellow;
            }

                p.X += 1 * kX;
            p.Y += 1 * kY;

            panel1.Location = p;
        }
    }
}
