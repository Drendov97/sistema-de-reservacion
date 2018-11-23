using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SiVeBo
{
    public class Usuario
    {
        public string nombreUsusario { get; set; }
        public string contraseña { get; set; }
        public int permisos { get; set; }
        private MySqlDataReader reader;

        MySqlDataAdapter DA;
        int precio;
        private int index;

        public Usuario()
        {

        }

        public bool Registrar(DBconnection conexionBD)
        {
            string commandtxt = "INSERT INTO usuario (usuario, contrasena, permisos) VALUES ('" + nombreUsusario + "','" + contraseña + "'," + permisos + ")";
            MySqlCommand command = new MySqlCommand(commandtxt, conexionBD.Connection);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                reader.Close();
            }
            catch (Exception exception)
            {
                //reader.Close();
                return false;
            }
            return true;
        }

        public bool Eliminar(DBconnection conexionBD, string id)
        {
            string commandtxt = "DELETE FROM usuario WHERE usuario='" + id + "'";
            MySqlCommand command = new MySqlCommand(commandtxt, conexionBD.Connection);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                reader.Close();
            }
            catch (Exception exception)
            {
                return false;
            }
            return true;
        }
    }
}
