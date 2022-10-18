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

    public class DepositoDAC
    {
        string conexion = "Data Source=DESKTOP-N6B6AO9;Initial Catalog=Quatrochi_Elio;Integrated Security=True";
        public DataTable GetAll()
        { 
        string sqlsentecia = "SP_GetAll";
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
        public int Deposito(DepositoBE obe)
        {

            string sqlsentecia = "SP_GetInsert";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexion;



            SqlCommand comm = new SqlCommand(sqlsentecia, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@Nombre_Articulo", SqlDbType.NChar).Value = obe.Nombre_Articulo;
            comm.Parameters.Add("@Stock", SqlDbType.Int).Value = obe.Stock;
            comm.Parameters.Add("@Precio", SqlDbType.Int).Value = obe.Precio;
            comm.Parameters.Add("@Estado", SqlDbType.Int).Value = obe.IdEstado;

            conn.Open();



            comm.ExecuteNonQuery();

            
            conn.Close();


            return 1;
        }
        public int DepositoUpdate(DepositoBE obe)
        {

            string sqlsentecia = "SP_GetUpdate";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexion;



            SqlCommand comm = new SqlCommand(sqlsentecia, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@Codigo_Articulo", SqlDbType.Int).Value = obe.Codigo_Articulo;
            comm.Parameters.Add("@Nombre_Articulo", SqlDbType.NChar).Value = obe.Nombre_Articulo;
            comm.Parameters.Add("@Stock", SqlDbType.Int).Value = obe.Stock;
            comm.Parameters.Add("@Precio", SqlDbType.Int).Value = obe.Precio;
            comm.Parameters.Add("@Estado", SqlDbType.Int).Value = obe.IdEstado;

            conn.Open();



            comm.ExecuteNonQuery();


            conn.Close();


            return 1;
        }
        public int DepositoDelete(DepositoBE obe)
        {

            string sqlsentecia = "SP_GetAllDelete";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexion;



            SqlCommand comm = new SqlCommand(sqlsentecia, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@Id", SqlDbType.Int).Value = obe.Codigo_Articulo;
           
            conn.Open();



            comm.ExecuteNonQuery();


            conn.Close();


            return 1;
        }
        

    }
    

}
