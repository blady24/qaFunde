/*
name                : cls_dbctl.cs
author              : eliseOS
creation date       : 104320241117
last update date    : 110020241117
last update author  : eliseOS
purpose             : cls_ctl_contacto
*/

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace qa_funde.Controllers
{
    class cls_ctl_contacto
    {
        private qa_funde.Models.cls_dbctl db_controller = new qa_funde.Models.cls_dbctl();
        public void CrearContacto(string nombreContacto, string email, int idPersona)
        {
            db_controller.ExecuteNonQuery("registrar_contacto",
                new MySql.Data.MySqlClient.MySqlParameter("p_nombre_contacto", nombreContacto),
                new MySql.Data.MySqlClient.MySqlParameter("p_email", email),
                new MySql.Data.MySqlClient.MySqlParameter("p_id_persona", idPersona));
        }
        public void ActualizarContacto(int idContacto, string nombreContacto, string email, int idPersona)
        {
            db_controller.ExecuteNonQuery("actualizar_contacto",
                new MySql.Data.MySqlClient.MySqlParameter("p_id_contacto", idContacto),
                new MySql.Data.MySqlClient.MySqlParameter("p_nombre_contacto", nombreContacto),
                new MySql.Data.MySqlClient.MySqlParameter("p_email", email),
                new MySql.Data.MySqlClient.MySqlParameter("p_id_persona", idPersona));
        }
        public DataTable ListarContactos()
        {
            return db_controller.ExecuteQuery("listar_contactos");
        }
    }
}
