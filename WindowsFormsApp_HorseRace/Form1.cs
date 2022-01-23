using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_HorseRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciAtSolaUzaklık, ikinciAtSolaUzaklık, ucuncuAtSolaUzaklık;
        Random rastgele = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciAtinGenisligi = pictureBox1.Width;
            int ikinciAtinGenisligi = pictureBox2.Width;
            int ucuncuAtinGenisligi = pictureBox3.Width;
            int bitisUzakligi = label5.Left;


            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5,15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left +5)
            {
                label6.Text="Bir numaralı at yarışı önde götürüyor.";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "İki numaralı at yarışı önde götürüyor.";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label6.Text = "Üç numaralı at yarışı önde götürüyor.";
            }

            if (birinciAtinGenisligi + pictureBox1.Left >= bitisUzakligi)
            {
                timer1.Enabled=false;   
                label6.Text ="Bir numaralı at yarışı kazanmıştır. Tebrikler!";

            }
            if (ikinciAtinGenisligi + pictureBox2.Left >= bitisUzakligi)
            {
                timer1.Enabled = false;
                label6.Text= "İki numaralı at yarışı kazanmıştır. Tebrikler!";

            }
            if (ucuncuAtinGenisligi + pictureBox3.Left >= bitisUzakligi)
            {
                timer1.Enabled = false;
                label6.Text ="Üç numaralı at yarışı kazanmıştır. Tebrikler!";

            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            pictureBox1.BackColor = Color.Green;
            birinciAtSolaUzaklık = pictureBox1.Left;
            ikinciAtSolaUzaklık = pictureBox2.Left;
            ucuncuAtSolaUzaklık= pictureBox3.Left;  
        }
    }
}
