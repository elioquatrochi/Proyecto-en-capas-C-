using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ncapa.Entidad;

namespace Ncapa.Datos
{
  public  class EstadoDAC
    {

        string conexion = "Data Source=DESKTOP-N6B6AO9;Initial Catalog=Quatrochi_Elio;Integrated Security=True";
        public DataTable combo()
        {


            string sqlsentecia = "SP_EstadoGetAll";
            SqlConnection conn = new SqlConnection();


            conn.ConnectionString = conexion;

            SqlCommand comm = new SqlCommand(sqlsentecia, conn);
            comm.CommandType = CommandType.StoredProcedure;


            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            da.Fill(ds);

            conn.Close();

            return ds.Tables[0];


        }
    }
}
