using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.models
{
    internal class libro
    {
        public int id {  get; set; }

        public int idEditorial {  get; set; }

        public int idAutor {  get; set; }

        public string titulo { get; set; }

        public DateTime fechaPublicacion { get; set; }

        public string idioma {  get; set; }


    }
}
