/*
name                : cls_dbctl.cs
author              : eliseOS
creation date       : 104320241117
last update date    : 110020241117
last update author  : eliseOS
purpose             : cls_ctl_persona
*/

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace qa_funde.Controllers
{
    public class cls_ctl_persona
    {

        private qa_funde.Models.cls_dbctl db_controller = new qa_funde.Models.cls_dbctl();
        public void CrearPersona(string nombre, string apellido, string telefono)
        {
            db_controller.ExecuteNonQuery("registrar_persona",
                new MySql.Data.MySqlClient.MySqlParameter("p_nombre", nombre),
                new MySql.Data.MySqlClient.MySqlParameter("p_apellido", apellido),
                new MySql.Data.MySqlClient.MySqlParameter("p_telefono", telefono));
        }
        public void ActualizarPersona(int idPersona, string nombre, string apellido, string telefono)
        {
            db_controller.ExecuteNonQuery("actualizar_persona",
                new MySql.Data.MySqlClient.MySqlParameter("p_id_persona", idPersona),
                new MySql.Data.MySqlClient.MySqlParameter("p_nombre", nombre),
                new MySql.Data.MySqlClient.MySqlParameter("p_apellido", apellido),
                new MySql.Data.MySqlClient.MySqlParameter("p_telefono", telefono));
        }
        public DataTable ListarPersonas()
        {
            return db_controller.ExecuteQuery("listar_personas");
        }

    }
}
