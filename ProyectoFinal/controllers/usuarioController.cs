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
    public class usuarioController
    {
        private claseCrud crud = new claseCrud();
        public DataTable ObtenerTodosUsuarios()
        {
            try
            {
                string query = @"SELECT u.Id, u.nombreUsuario, r.nombre as rol, u.nombre, u.apellido, u.sexo, u.estado FROM usuario u INNER JOIN Roles r ON u.idRol = r.id WHERE u.estado = 1";
                crud.ConsultarGral(query, "usuario");
                return crud.ds.Tables["usuario"];
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener usuarios: {ex.Message}");
            }
        }
        public bool CrearUsuario(usuario usuario)
        {
            try
            {
                string campos = "nombreUsuario, contra, idRol, nombre, apellido, Sexo";
                string valores = $"'{usuario.nombreUsuario}', '{usuario.contra}', { usuario.idRol}, " +$"'{usuario.nombre}', '{usuario.apellido}', '{usuario.sexo}' ";
                return crud.Insertar("usuario", campos, valores);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear usuario: {ex.Message}");
            }
        }
        //
    }
}
