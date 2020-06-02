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


    public partial class UserControl1 : UserControl
    {
        public string Nombre_local;
        public string Nombre_dueño;
        public string ID;
        public string Horario;
        public string Tipo_local;
        public string Categoria;
        public List<string> Tienda = new List<string>();
        public List<string> Restaurante = new List<string>();
        public List<string> Cine = new List<string>();
        public List<string> Recreacional = new List<string>();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (Tipo_local == "tienda")
            {
                Tienda.Add(Nombre_local);
                Tienda.Add(Nombre_dueño);
                Tienda.Add(ID);
                Tienda.Add(Horario);
                Tienda.Add(Categoria);
            }
            if (Tipo_local == "restaurante")
            {
                Restaurante.Add(Nombre_local);
                Restaurante.Add(Nombre_dueño);
                Restaurante.Add(ID);
                Restaurante.Add(Horario);
                Restaurante.Add(Categoria);
            }
            if (Tipo_local == "cine")
            {
                Cine.Add(Nombre_local);
                Cine.Add(Nombre_dueño);
                Cine.Add(ID);
                Cine.Add(Horario);
                Cine.Add(Categoria);
            }
            if (Tipo_local == "restaurante")
            {
                Recreacional.Add(Nombre_local);
                Recreacional.Add(Nombre_dueño);
                Recreacional.Add(ID);
                Recreacional.Add(Horario);
                Recreacional.Add(Categoria);
            }
            Hide();


        }

        private void NombreLocal_TextChanged(object sender, EventArgs e)
        {
            Nombre_local = NombreLocal.Text;
        }

        private void NombreDueño_TextChanged(object sender, EventArgs e)
        {
            Nombre_dueño = NombreDueño.Text;
        }

        private void IDlocal_TextChanged(object sender, EventArgs e)
        {
            ID = IDlocal.Text;
        }

        private void HorarioLocal_TextChanged(object sender, EventArgs e)
        {
            Horario = HorarioLocal.Text;
            
        }

        private void CategoriaLocal_TextChanged(object sender, EventArgs e)
        {
            Categoria = CategoriaLocal.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
