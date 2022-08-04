using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class CONEXIONMAESTRA
    {
        public static string conexion = @"Data source=DESKTOP-BRSSJE8;Initial Catalogo=KARAOKE;Integrated Security=true;";
        public static SqlConnection conectar = new SqlConnection();
        public static void AbrirBD()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void CerrarBD()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Close();
            }
        }
    }
}
