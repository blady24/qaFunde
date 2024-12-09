/*
name                : cls_dbctl.cs
author              : eliseOS
creation date       : 104320241117
last update date    : 110020241117
last update author  : eliseOS
purpose             : cls_ctl_proyecto
*/

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace qa_funde.Controllers
{
    class cls_ctl_proyecto
    {
        private qa_funde.Models.cls_dbctl db_controller = new qa_funde.Models.cls_dbctl();
        public void CrearProyecto(string nombre, string descripcion, string fechaInicio, string fechaFin, int idPersona)
        {
            db_controller.ExecuteNonQuery("registrar_proyecto",
                new MySql.Data.MySqlClient.MySqlParameter("p_nombre", nombre),
                new MySql.Data.MySqlClient.MySqlParameter("p_descripcion", descripcion),
                new MySql.Data.MySqlClient.MySqlParameter("p_fecha_inicio", fechaInicio),
                new MySql.Data.MySqlClient.MySqlParameter("p_fecha_fin", fechaFin),
                new MySql.Data.MySqlClient.MySqlParameter("p_id_persona", idPersona));
        }
        public void ActualizarProyecto(int idProyecto, string nombre, string descripcion, string fechaInicio, string fechaFin, int idPersona)
        {
            db_controller.ExecuteNonQuery("actualizar_proyecto",
                new MySql.Data.MySqlClient.MySqlParameter("p_id_proyecto", idProyecto),
                new MySql.Data.MySqlClient.MySqlParameter("p_nombre", nombre),
                new MySql.Data.MySqlClient.MySqlParameter("p_descripcion", descripcion),
                new MySql.Data.MySqlClient.MySqlParameter("p_fecha_inicio", fechaInicio),
                new MySql.Data.MySqlClient.MySqlParameter("p_fecha_fin", fechaFin),
                new MySql.Data.MySqlClient.MySqlParameter("p_id_persona", idPersona));
        }
        public DataTable ListarProyectos()
        {
            return db_controller.ExecuteQuery("listar_proyectos");
        }
    }
}
