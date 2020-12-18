using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            agregar ve = new agregar();
            addFormulario(ve);
        }

        public void addFormulario(Form f)
        {
            if (panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }

            f.TopLevel = false;
            this.panel2.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           Consultar_Visitas ve = new Consultar_Visitas();
            addFormulario(ve);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           Edificios ve = new Edificios();
            addFormulario(ve);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ve = new Login();
            ve.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form ve = new admin();
            ve.Show();
            this.Hide();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Consultar_Usuario ve = new Consultar_Usuario();
            addFormulario(ve);
        }
    }
}
