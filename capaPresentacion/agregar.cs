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
    public partial class agregar : Form
    {
        caEntidad enti = new caEntidad();
        caNegocios neg = new caNegocios();

        public agregar()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            enti.user = txtUser.Text;
            enti.contrasena = txtContra.Text;
            enti.Nombre = txtNombre.Text;
            enti.Apellido = txtapellido.Text;
            enti.Fecha = dateTimePicker1.Text;
            enti.tipo_usuario = comboBox1.Text;
            neg.insertar(enti);
            MessageBox.Show("Usuario Creado");
            usuarios();
        }

        void usuarios()
        {
            DataTable dt = neg.usuarios();
            dataGridView1.DataSource = dt;
        }

        private void agregar_Load(object sender, EventArgs e)
        {
            usuarios();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            enti.id = int.Parse(txtID.Text);
            enti.user = txtUser.Text;
            enti.contrasena = txtContra.Text;
            enti.Nombre = txtNombre.Text;
            enti.Apellido = txtapellido.Text;
            enti.Fecha = dateTimePicker1.Text;
            enti.tipo_usuario = comboBox1.Text;
            neg.editarUsuario(enti);
            MessageBox.Show("Datos Editados");
            usuarios();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.txtapellido.Text = "Apellido";
            this.txtNombre.Text = "Nombre";
            this.txtUser.Text = "Usuario";
            this.txtContra.Text = "Contrasena";
            this.txtID.Text = "ID";
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if(txtContra.Text == "Contrasena")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Black;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contrasena";
                txtContra.ForeColor = Color.Black;
            }
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
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtapellido_Enter(object sender, EventArgs e)
        {
            if(txtapellido.Text == "Apellido")
            {
                txtapellido.Text = "";
                txtapellido.ForeColor = Color.Black;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "ID")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }

        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "ID";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellido_Leave(object sender, EventArgs e)
        {
            if (txtapellido.Text == "")
            {
                txtapellido.Text = "Apellido";
                txtapellido.ForeColor = Color.Black;
            }
        }
    }
}
