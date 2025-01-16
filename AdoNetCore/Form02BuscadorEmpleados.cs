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
    public partial class Form02BuscadorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;
        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;TrustServerCertificate=True";
            this.cn = new SqlConnection(connectionString);
            this.cmd = new SqlCommand();
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            string salario = txtSalario.Text;
            string sql =
                "SELECT * FROM EMP WHERE SALARIO >= " + salario;
            //CONEXION
            this.cmd.Connection = this.cn;
            //TIPO DE CONSULTA
            this.cmd.CommandType = CommandType.Text;
            //CONSULTA
            this.cmd.CommandText = sql;
            //ABRIR CONEXION
            //ENTRAR Y SALIR
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            //DIBUJAMOS LOS DATOS
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salarioEmpleado = this.reader["SALARIO"].ToString();
                string deptNo = this.reader["DEPT_NO"].ToString();
                string oficio = this.reader["OFICIO"].ToString();
                string empNo = this.reader["EMP_NO"].ToString();
                string datos = apellido + ", " + salarioEmpleado + ", " + deptNo + ", " + oficio + ", " + empNo;
                lstEmpleados.Items.Add(datos);
            }
            //LIBERAMOS TODOS LOS RECURSOS UTILIZADOS
            this.reader.Close();
            this.cn.Close();
        }

        private void btnOficio_Click(object sender, EventArgs e)
        {
            string oficio = txtOficio.Text;
            string sql =
                "SELECT * FROM EMP WHERE OFICIO = '" + oficio + "'";
            //CONEXION
            this.cmd.Connection = this.cn;
            //TIPO DE CONSULTA
            this.cmd.CommandType = CommandType.Text;
            //CONSULTA
            this.cmd.CommandText = sql;
            //ABRIR CONEXION
            //ENTRAR Y SALIR
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            //DIBUJAMOS LOS DATOS
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salarioEmpleado = this.reader["SALARIO"].ToString();
                string oficioEmpleado = this.reader["OFICIO"].ToString();
                string datos = apellido + ", " + salarioEmpleado + ", " + oficioEmpleado;
                lstEmpleados.Items.Add(datos);
            }
            //LIBERAMOS TODOS LOS RECURSOS UTILIZADOS
            this.reader.Close();
            this.cn.Close();
        }
    }
}
