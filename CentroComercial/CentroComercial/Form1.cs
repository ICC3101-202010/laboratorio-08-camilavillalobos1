using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroComercial
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonAñadir_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl21.Hide();
        }

        private void botonVer_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Show();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
          
            userControl21.Show();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.Show();
           
            userControl21.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            
            userControl21.Hide();
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
