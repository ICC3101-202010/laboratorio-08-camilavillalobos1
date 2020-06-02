using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroComercial
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Show();
            panel3.Show();
            panel4.Show();
            
        }

        private void botonCines_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Show();
            panel3.Show();
            panel4.Hide();
            panel3.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nombre: Zara Dueño: Camila  Horario: 10am - 9pm");
            listBox1.Items.Add("Nombre: Foster Dueño: Camila  Horario: 10am - 9pm");
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
            panel4.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Show();
            panel4.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Show();
        }

        private void botonTienda_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel1.BringToFront();
            
        }

        private void botonRestaurant_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel1.Show();
            panel2.Show();

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // panel1.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Show();
        }

        public void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
