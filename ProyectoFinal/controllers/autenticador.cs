using ProyectoFinal.data;
using ProyectoFinal.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.controllers
{
    public class autenticador
    {
        //
        private claseCrud crud = new claseCrud();

        public bool autenticarUsuario(string usuario, string contrasena)
        {
            try
            {
                string condicion = $"nombreUsuario = '{usuario}' AND contra = '{contrasena}' AND estado = 1";
                DataTable dt = crud.ConsultarCondicion("u.id, u.nombreUsuario, u.idRol, r.nombreRol, u.nombre, u.apellido", "usuario u INNER JOIN Rol r ON u.idRol = r.id", condicion);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    sesion.userId = Convert.ToInt32(row["Id"]);
                    sesion.name = row["Usuario"].ToString();
                    sesion.rolId = Convert.ToInt32(row["IdRol"]);
                    sesion.rolName = row["RolNombre"].ToString();
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw new Exception($"Error en autenticación: {ex.Message}");

            }




            //aqui tendria que haber un harsh pero de momento no lo implementare
        }
    }
}
