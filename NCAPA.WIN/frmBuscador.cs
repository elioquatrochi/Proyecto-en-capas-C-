using Ncapa.Entidad;
using Ncapa.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ncapa.Negocio;
using Ncapa.Entidad;

namespace NCAPA.WIN
{
    public partial class frmBuscador : Form
    {
        string conexion = "Data Source=DESKTOP-N6B6AO9;Initial Catalog=Quatrochi_Elio;Integrated Security=True";
        public frmBuscador()
        {
            InitializeComponent();
        }

        private void frmBuscador_Load(object sender, EventArgs e)
        {
       

        }
        public void buscador()
        {

            string sqlsentecia = "SP_Buscador";
            SqlConnection conn = new SqlConnection();


            conn.ConnectionString = conexion;

            SqlCommand comm = new SqlCommand(sqlsentecia, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@Codigo_Articulo", SqlDbType.Int).Value = txtId.Text;
            

            conn.Open();

            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            da.Fill(ds);
            dataGridView1.DataSource = ds;

            conn.Close();

        }

        public void buscadorN()
        {

            string sqlsentecia = "SP_BuscadorNombre";
            SqlConnection conn = new SqlConnection();


            conn.ConnectionString = conexion;

            SqlCommand comm = new SqlCommand(sqlsentecia, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtNombre.Text;
            conn.Open();

            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            da.Fill(ds);
            dataGridView1.DataSource = ds;

            conn.Close();

        }

        public DataTable getall()
        {

            DepositoBC odeposito = new DepositoBC();

            DataTable dt = odeposito.GetAll();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;


            return dt;
        }

      
        
        private void button3_Click_1(object sender, EventArgs e)
        {
           
           buscador();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getall();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscadorN();
        }
    }
}



