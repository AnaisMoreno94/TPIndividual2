using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPLibreria.Entidades;

namespace TPIWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarAvionComercial_Click(object sender, EventArgs e)
        {
            AvionComercial avionComercial= new AvionComercial("Chelsey Sullenberger", "Jeffrey Skiles","Dona Dent", 220, "US Airways" );
            MessageBox.Show(avionComercial.ToString());
        }

        private void btnMostrarAvionCarga_Click(object sender, EventArgs e)
        {
            AvionCarga avionCarga = new AvionCarga("Juan Perez", "Pedro Castillo", "Ninguna",174000, "Indumentaria" );
            MessageBox.Show(avionCarga.ToString());

        }
    }
}
