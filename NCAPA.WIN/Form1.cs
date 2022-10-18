using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ncapa.Entidad;
using Ncapa.Negocio;
using System.Data.SqlClient;

namespace NCAPA.WIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getall();
            getallCombo();
        }
        public DataTable getall()
        {

            DepositoBC odeposito = new DepositoBC();

            DataTable dt = odeposito.GetAll();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;


            return dt;
        }

        private void insert()
        {

            DepositoBE obe = new DepositoBE();

            obe.Stock = int.Parse(txtStock.Text);
            obe.Precio = int.Parse(txtPrecio.Text);
            obe.Nombre_Articulo = txtNombre.Text;
            obe.IdEstado = int.Parse(cboEstado.SelectedValue.ToString());

            DepositoBC obc = new DepositoBC();
            var res = obc.Insert(obe);
            getall();

        }
        public DataTable getallCombo()
        {
            EstadoBC oEstado = new EstadoBC();


            DataTable dt = oEstado.GetAllEstado();

            cboEstado.DataSource = null;

            cboEstado.DataSource = dt;
            cboEstado.DisplayMember = "Nombre";
            cboEstado.ValueMember = "IdEstado";


            return dt;
        }
        private void Updatee()
        {

            DepositoBE obe = new DepositoBE();
            obe.Codigo_Articulo= int.Parse(txtId.Text);
            obe.Stock = int.Parse(txtStock.Text);
            obe.Precio = int.Parse(txtPrecio.Text);
            obe.Nombre_Articulo = txtNombre.Text;
            obe.IdEstado = int.Parse(cboEstado.SelectedValue.ToString());

            DepositoBC obc = new DepositoBC();
            var res = obc.Update(obe);
            getall();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            insert();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Updatee();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtStock.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cboEstado.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            

        }
        private void Delete()
        {


            DepositoBE obe = new DepositoBE();
            obe.Codigo_Articulo = int.Parse(txtId.Text);
        
            DepositoBC obc = new DepositoBC();
            var res = obc.Delete(obe);
            getall();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete();
        }
      

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }


}
