using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  

namespace Mecatena.Clases
{
    class ConexionBD
    {
        public MySqlConnection conexion; 

        public ConexionBD()
        {
            conexion = new MySqlConnection("server=" + Properties.Settings.Default.BDservidor + "; port=" + Properties.Settings.Default.BDpuerto + "; database=" + Properties.Settings.Default.BDnombre + "; Uid=" + Properties.Settings.Default.BDusuario +"; pwd=" + Properties.Settings.Default.BDcontra);
        }

        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;

            }catch(MySqlException ex)
            {
                return false;
                throw ex;
            }
        }

        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;

            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }

    }
}
