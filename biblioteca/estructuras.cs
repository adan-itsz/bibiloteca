using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class estructuras
    {
        public struct usuarios
        {
            public int idUsuario;
            public string nombre;
            public string direccion;
            public int telefono;
        }
        public struct Libros
        {
            public int isbn;
            public string titulo;
            public string autor;
            public int existencias;

        }
        public struct prestamos
        {
            public int idPrestamos;
            public int IDUsuario;
            public int ISBN;
            //public string fechaPrestamo;
            //public DateTime fechaEntrega;
            public int cantidad;
            public string status;
        }
    }
}
