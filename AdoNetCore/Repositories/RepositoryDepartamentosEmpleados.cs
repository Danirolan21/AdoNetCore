using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;TrustServerCertificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        public async Task<List<string>> GetNombresDepartamentosAsync()
        {
            string sql = "SELECT DNOMBRE FROM DEPT";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            //CREAMOS LA LISTA DE NOMBRES DE DEPARTAMENTOS
            List<string> departamentos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<List<string>> GetNombresEmpleadosXDepartamentoAsync(string departamentoseleccionado)
        {
            string sql = "Select APELLIDO " +
                "from EMP WHERE DEPT_NO = " +
                "(SELECT DEPT_NO " +
                "FROM dept " +
                "WHERE DNOMBRE=@departamentoseleccionado)";
            SqlParameter pamDept = 
                new SqlParameter("@departamentoseleccionado", departamentoseleccionado);
            this.com.Parameters.Add(pamDept);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            //CREAMOS LA LISTA QUE CONTENDRA LOS EMPLEADOS POR DEPARTAMENTO
            List<string> empleados = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                empleados.Add(apellido);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }

        public async Task DeleteEmpleado(string empleadoseleccionado)
        {
            string sql = "delete EMP where APELLIDO=@empleadoseleccionado";
            SqlParameter pamEmp =
                new SqlParameter("@empleadoseleccionado", empleadoseleccionado);
            this.com.Parameters.Add(pamEmp);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
