using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Logica;
using System.Windows.Forms;

namespace Datos
{
    public class DCanciones
    {
        public bool INSERTAR_CANCION(LCanciones parametros)
        {
            try
            {
                CONEXIONMAESTRA.AbrirBD();
                SqlCommand cmd = new SqlCommand("INSERTAR_CANCIONES",CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOMBRE",parametros.NOMBRE);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.CerrarBD();
            }
        }
        public bool ELIMINAR_CANCION(LCanciones parametros)
        {
            try
            {
                CONEXIONMAESTRA.AbrirBD();
                SqlCommand cmd = new SqlCommand("ELIMINAR_CANCIONES", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDCANCION", parametros.IDCANCION);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.CerrarBD();
            }
        }
        public void BUSAR_CANCIONES(ref DataTable dt, string Letra)
        {
            try
            {
                CONEXIONMAESTRA.AbrirBD();
                SqlDataAdapter adapter = new SqlDataAdapter("BUSCAR_CANCIONES", CONEXIONMAESTRA.conectar);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@LETRA", Letra);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.CerrarBD();
            }
        }
    }
}
