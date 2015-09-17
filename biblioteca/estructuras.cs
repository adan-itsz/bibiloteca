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
            public string usuario;
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
    }
}
