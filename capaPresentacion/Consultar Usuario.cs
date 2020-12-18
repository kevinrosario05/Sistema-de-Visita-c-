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
    public partial class Consultar_Usuario : Form
    {
        caNegocios neg = new caNegocios();
        caEntidad enti = new caEntidad();
        
        public Consultar_Usuario()
        {
            InitializeComponent();
            neg.ConsultarUsuario(comboBox1);
        }

        private void Consultar_Usuario_Load(object sender, EventArgs e)
        {
            datos();
        }
        void usuarios()
        {
            DataTable dt = neg.BuscarUsuario(enti.user);
            dataGridView1.DataSource = dt;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            enti.user = comboBox1.Text;
            neg.EliminarUsuario(enti);
            MessageBox.Show("Datos Borrados");
            usuarios();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            enti.user = comboBox1.Text;
            neg.BuscarUsuario(enti.user);
            usuarios();
        }
        void datos()
        {
            DataTable dt = neg.usuarios();
            dataGridView1.DataSource = dt;

        }

    }
}
