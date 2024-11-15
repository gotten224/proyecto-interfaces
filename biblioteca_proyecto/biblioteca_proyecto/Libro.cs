using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    internal class Libro
    {
        String tipo;
        String titulo;
        int id;

        public Libro(string tipo, string titulo, int id)
        {
            this.tipo = tipo;
            this.titulo = titulo;
            this.id = id;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Id { get => id; set => id = value; }
    }
}
