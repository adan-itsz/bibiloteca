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

    public partial class RegistroLibros : Form
    {
        public RegistroLibros()
        {
            InitializeComponent();
            
        }
        ArrayList rLibros = new ArrayList();
       estructuras.Libros infoLibros = new estructuras.Libros();
        int renglon;
        int bandera=0;
        
        private void RegistroLibros_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Columns.Add("", "ISBN");
            dataGridView1.Columns.Add("", "Titulo");
            dataGridView1.Columns.Add("", "Autor");
            dataGridView1.Columns.Add("", "Existencias");

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            infoLibros.isbn = Convert.ToInt32(txtBoxISBN.Text);
            infoLibros.titulo = txtBoxTitulo.Text;
            infoLibros.autor = txtBoxAutor.Text;
            infoLibros.existencias = Convert.ToInt32(txtBoxExistencias.Text);

           
            if (bandera == 1)
            {
                rLibros.Add(infoLibros);
                dataGridView1.Rows.Add(infoLibros.isbn, infoLibros.titulo, infoLibros.autor, infoLibros.existencias);
                MessageBox.Show("Registro guardado correctamente", "Registro Libros ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridView1[0, renglon].Value = infoLibros.isbn;
                dataGridView1[1, renglon].Value = infoLibros.titulo;
                dataGridView1[2, renglon].Value = infoLibros.autor;
                dataGridView1[3, renglon].Value = infoLibros.existencias;
            }
            txtBoxISBN.Clear();
            txtBoxTitulo.Clear();
            txtBoxAutor.Clear();
            txtBoxExistencias.Clear();
            panel1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)//nuevo
        {
            panel1.Enabled = true;
            txtBoxISBN.Focus();
            bandera = 1;
        }

        private void button3_Click(object sender, EventArgs e)// modificar
        {
            panel1.Enabled = true;
            txtBoxISBN.Focus();
            bandera = 2;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = dataGridView1.CurrentRow.Index;
            txtBoxISBN.Text = dataGridView1[0, renglon].Value.ToString();
            txtBoxTitulo.Text = dataGridView1[1, renglon].Value.ToString();
            txtBoxAutor.Text = dataGridView1[2, renglon].Value.ToString();
            txtBoxExistencias.Text = dataGridView1[3, renglon].Value.ToString();

            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
    }
}
