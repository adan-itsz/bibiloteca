﻿using System;
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
    public partial class prestamos : Form
    {
        public prestamos()
        {
            InitializeComponent();
        }
        ArrayList usuarios = new ArrayList();
        ArrayList libros = new ArrayList();
        ArrayList prestamo = new ArrayList();
        Usuarios usrs = new Usuarios();
        RegistroLibros rl = new RegistroLibros();
        estructuras.prestamos estructura = new estructuras.prestamos();
        DateTime fechaPrestamo;
        DateTime fechaEntrega;
        int ban = 0;
        int idPrestamos = 000;
        
        
        //prestamos(ArrayList usuarios1, ArrayList libros1 )
        //{
        //    usuarios = usuarios1;
        //    libros = libros1;

        //}
        public void tomarListas()
        {
            usuarios = usrs.users;
            libros = rl.rLibros;
        }
        public void GuardarDatos()
        {
            estructura.idPrestamos = idPrestamos;
            //falta status
            txtIDPrestamo.Text= Convert.ToString(estructura.idPrestamos++);
            estructura.IDUsuario = Convert.ToInt32(txtIDUsuario.Text);
            estructura.ISBN = Convert.ToInt32(txtISBN.Text);
            fechaEntrega = dateTimePicker2.Value;
            fechaPrestamo = dateTimePicker1.Value;
            estructura.cantidad = Convert.ToInt32(txtCantidad.Text);
            prestamo.Add(estructura);
            dataGridView1.Rows.Add(estructura.idPrestamos,estructura.IDUsuario, estructura.ISBN,fechaPrestamo, fechaEntrega,estructura.cantidad );
            MessageBox.Show("prestamo guardado correctamente", "Prestamos actuales ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void prestamos_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "ID prestamo");
            dataGridView1.Columns.Add("", "ID usuario");
            dataGridView1.Columns.Add("", "ISBN");
            dataGridView1.Columns.Add("", "Fecha prestamo");
            dataGridView1.Columns.Add("", "Fecha entrega");
            dataGridView1.Columns.Add("", "Cantidad");
            dataGridView1.Columns.Add("", "Status");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }
    }
}
