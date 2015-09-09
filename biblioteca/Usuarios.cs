using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace biblioteca
{
    public struct usuarios
    {
       public string usuario;
       public string nombre;
       public string direccion;
       public int telefono;
    }
    public partial class Usuarios : Form
    {
        

        public Usuarios()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "Usuario");
            dataGridView1.Columns.Add("", "Nombre");
            dataGridView1.Columns.Add("", "Direccion");
            dataGridView1.Columns.Add("", "Telefono");
        }
        ArrayList users = new ArrayList();
        usuarios usu = new usuarios();
        int ban = 0;
        int renglon;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usu.nombre = txtBoxNombre.Text;
            usu.usuario = txtBoxUsuario.Text;
            usu.direccion = txtBoxDireccion.Text;
            usu.telefono = Convert.ToInt32(txtBoxTelefono.Text);
            if (ban == 1)
            {
                users.Add(usu);
                dataGridView1.Rows.Add(usu.usuario, usu.nombre, usu.direccion, usu.telefono);
                MessageBox.Show("Registro guardado correctamente", "Registro usuarios ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridView1[0, renglon].Value = usu.usuario;
                dataGridView1[1, renglon].Value = usu.nombre;
                dataGridView1[2, renglon].Value = usu.direccion;
                dataGridView1[3, renglon].Value = usu.telefono;
            }
            txtBoxUsuario.Clear();
            txtBoxNombre.Clear();
            txtBoxDireccion.Clear();
            txtBoxTelefono.Clear();
            panel1.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtBoxUsuario.Focus();
            ban = 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtBoxUsuario.Focus();
            ban = 2;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = dataGridView1.CurrentRow.Index;
            txtBoxUsuario.Text = dataGridView1[0, renglon].Value.ToString();
            txtBoxNombre.Text = dataGridView1[1, renglon].Value.ToString();
            txtBoxDireccion.Text = dataGridView1[2, renglon].Value.ToString();
            txtBoxTelefono.Text = dataGridView1[3, renglon].Value.ToString();

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

    }
}
