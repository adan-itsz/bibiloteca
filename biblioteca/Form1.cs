﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroLibros r = new RegistroLibros();
            r.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.ShowDialog();
            
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            prestamos p = new prestamos();
            p.ShowDialog();
        }
    }
}
