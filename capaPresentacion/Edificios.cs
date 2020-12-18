using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaNegocios;

namespace capaPresentacion
{
    public partial class Edificios : Form
    {
        caEntidad enti = new caEntidad();
        caNegocios neg = new caNegocios();

        public Edificios()
        {
            InitializeComponent();
           
            neg.seleccionarAula(cbAula);
            neg.seleccionarEdificio(cbEdificio);
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
         
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
                        
        }
        void edicifios()
        {
            
        }
        void buscar()
        {
           
        }

        private void Edificios_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            edicifios();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DATAedificio.Visible = true;
            cbEdificio.Visible = true;
            DATAaulas.Visible = false;
            cbAula.Visible = false;
            EdificioEditar.Visible = true;
            AulaEditar.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DATAedificio.Visible = false;
            cbEdificio.Visible = false;
            DATAaulas.Visible = true;
            cbAula.Visible = true;
            EdificioEditar.Visible = false;
            AulaEditar.Visible = true;
        }

        private void cbEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            enti.edificio = cbEdificio.Text;
            ver();
        }
        void ver()
        {
            DataTable dt = neg.dondeEdificio(enti);
            DATAedificio.DataSource = dt;
        }

        private void cbAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            enti.aula = cbAula.Text;
            klk();
        }
       void klk()
        {
            DataTable dt = neg.dondeAula(enti);
            DATAaulas.DataSource = dt;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            enti.edificio = txtEdificio.Text;
            enti.id = int.Parse(txtID.Text);
            neg.ModificarEdificio(enti);
            MessageBox.Show("Edificio Modificado");
            papi();
        }
        void papi()
        {
            DataTable dt = neg.VerEdificio();
            DATAedificio.DataSource = dt;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            enti.edificio = txtEdificio.Text;
           
            neg.insertarEdificio(enti);

            MessageBox.Show("Edificio Insertado");
            papi();
        }

        void mami()
        {
            DataTable dt = neg.verAulas();
            DATAaulas.DataSource = dt;
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
          
            enti.aula = txtAula.Text;
            
            neg.insertarAula(enti);
            MessageBox.Show("Aula Insertada");
            mami();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            enti.id = int.Parse(txtID.Text);
            enti.aula = txtAula.Text;
            neg.ModificarAulas(enti);
            MessageBox.Show("Aula Editada");
            mami();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if(txtID.Text == "ID")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                txtID.Text = "ID";
                txtID.ForeColor = Color.Black;
            }
        }
    }
}
