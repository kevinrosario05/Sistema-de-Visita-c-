using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocios;
using capaEntidad;

namespace capaPresentacion
{
    public partial class Consultar_Visitas : Form
    {
        caNegocios neg = new caNegocios();
        caEntidad enti = new caEntidad();

        public Consultar_Visitas()
        {
            InitializeComponent();
            neg.seleccionarConsulta(comboBox1);
        }

        private void Consultar_Visitas_Load(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            enti.edificio = comboBox1.Text;
            buscar();
        }
        void buscar()
        {
            DataTable dt = neg.consultarVisitas(enti);
            dataGridView1.DataSource = dt;

        }
    }
}
