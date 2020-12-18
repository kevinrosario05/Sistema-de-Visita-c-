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
    public partial class Login : Form
    {

        caEntidad enti = new caEntidad();
        caNegocios neg = new caNegocios();
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            enti.user = txtUser.Text;
            enti.contrasena = txtContra.Text;
            dt = neg.login(enti);

            if(dt.Rows.Count > 0)
            {
                if(dt.Rows[0][3].ToString() == "admin")
                {
                    MessageBox.Show("Bienvenido " + enti.user);
                    this.Hide();
                    new admin().Show();
                }
                else if (dt.Rows[0][3].ToString() == "usuario")
                {
                    MessageBox.Show("Bienvenido " + enti.user);
                    this.Hide();
                    new recep().Show();
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contrasena")
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
    }
}
