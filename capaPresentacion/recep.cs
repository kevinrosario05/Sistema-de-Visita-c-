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
    public partial class recep : Form
    {
        caEntidad enti = new caEntidad();
        caNegocios neg = new caNegocios();
        public recep()
        {
            InitializeComponent();
            neg.seleccionarEdificio(cbEdificio);
            neg.seleccionarAula(cbAula);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void recep_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           this.txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCorreo.Enabled = true;
            txtMotivo.Enabled = true;
            cbCarrera.Enabled = true;
            cbEdificio.Enabled = true;
            cbAula.Enabled = true;
            cbCarrera.Text = "Carrera";
            txtMatricula.Text = "Matricula";
            dateTimePicker1.Enabled = true;
            txtMatricula.Enabled = true;
            dateTimePicker2.Enabled = true;
            txtVisitante.Text = "Estudiante";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCorreo.Enabled = true;
            txtMotivo.Enabled = true;
            pictureBox1.Enabled = true;
            cbEdificio.Enabled = true;
            cbAula.Enabled = true;
            cbCarrera.Enabled = false;
            dateTimePicker1.Enabled = true;
            cbCarrera.Text = "";
            txtMatricula.Text = "";
            txtMatricula.Enabled = false;
            dateTimePicker2.Enabled = true;
            txtVisitante.Text = "Visitante";
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            enti.Nombre = txtNombre.Text;
            enti.Apellido = txtApellido.Text;
            enti.correo = txtCorreo.Text;
            enti.matricula = txtMatricula.Text;
            enti.motivo = txtMotivo.Text;
            enti.carrera = cbCarrera.Text;
            enti.edificio = cbEdificio.Text;
            enti.aula = cbAula.Text;
            enti.Fecha = dateTimePicker1.Text;
            enti.hora = dateTimePicker2.Text;

            enti.tipo_usuario = txtVisitante.Text;
            neg.InsertarVisitas(enti);
            MessageBox.Show("Datos Insertados");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form ve = new Login();
            ve.Show();
            this.Hide();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if(txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if(txtApellido.Text == "Apellidos")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellidos";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {

            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtMotivo_Enter(object sender, EventArgs e)
        {
            if(txtMotivo.Text == "Motivo de la Visita")
            {
                txtMotivo.Text = "";
                txtMotivo.ForeColor = Color.Black;
            }
        }

        private void txtMatricula_Enter(object sender, EventArgs e)
        {
            if(txtMatricula.Text == "Matricula")
            {
                txtMatricula.Text = "";
                txtMatricula.ForeColor = Color.Black;
            }
        }

        private void txtMotivo_Leave(object sender, EventArgs e)
        {
            if (txtMotivo.Text == "")
            {
                txtMotivo.Text = "Motivo de la Visita";
                txtMotivo.ForeColor = Color.Black;
            }
        }

        private void txtMatricula_Leave(object sender, EventArgs e)
        {
            if (txtMatricula.Text == "")
            {
                txtMatricula.Text = "Matricula";
                txtMatricula.ForeColor = Color.Black;
            }
        }
    }
}
