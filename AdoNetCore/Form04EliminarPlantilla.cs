using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AdoNetCore
{
    public partial class Form04EliminarPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form04EliminarPlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;TrustServerCertificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.CargarPlantilla();
        }

        private void CargarPlantilla()
        {
            string sql = "SELECT * FROM PLANTILLA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstPlantilla.Items.Clear();
            while (this.reader.Read())
            {
                string empleado_no = this.reader["EMPLEADO_NO"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                string funcion = this.reader["FUNCION"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                string datos = empleado_no + ", " + apellido + ", " + funcion + ", " + salario;
                this.lstPlantilla.Items.Add(datos);
            }
            this.reader.Close();
            this.cn.Close();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql =
                "delete from plantilla where EMPLEADO_NO ="
                + this.txtIdEmpleado.Text;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.CargarPlantilla();
            MessageBox.Show("Empleados eliminados: " + eliminados);
        }

        private void lstEnfermos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
