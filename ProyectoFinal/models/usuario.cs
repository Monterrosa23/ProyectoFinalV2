using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.models
{
    public class usuario
    {
        public int id {  get; set; }

        public string password { get; set; }

        public int idRol {  get; set; }

        public string nombreRol {  get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string sexo { get; set; }

        public int estado { get; set; }
    }
}
