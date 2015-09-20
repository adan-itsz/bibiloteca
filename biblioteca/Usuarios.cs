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
        estructuras.usuarios struc = new estructuras.usuarios();
         Dictionary<int, estructuras.usuarios> users = new Dictionary<int, estructuras.usuarios>();
        int ban = 0;
        int renglon;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            struc.nombre = txtBoxNombre.Text;
            struc.idUsuario = Convert.ToInt32 (txtBoxUsuario.Text);
            struc.direccion = txtBoxDireccion.Text;
            struc.telefono = Convert.ToInt32(txtBoxTelefono.Text);
            if (ban == 1)
            {
                users.Add(struc.idUsuario,struc);
                dataGridView1.Rows.Add(struc.idUsuario, struc.nombre, struc.direccion, struc.telefono);
                MessageBox.Show("Registro guardado correctamente", "Registro usuarios ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridView1[0, renglon].Value = struc.idUsuario;
                dataGridView1[1, renglon].Value = struc.nombre;
                dataGridView1[2, renglon].Value = struc.direccion;
                dataGridView1[3, renglon].Value = struc.telefono;
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
