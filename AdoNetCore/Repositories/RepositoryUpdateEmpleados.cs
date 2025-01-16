using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryUpdateEmpleados
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryUpdateEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;TrustServerCertificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> getOficiosAsync()
        {
            string sql =
                "select distinct OFICIO from EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> oficios = new List<string>();
            while(await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return oficios;
        }

        public async Task<List<string>> getEmpleadosOficioAsync(string oficio)
        {
            string sql =
                "select * from EMP where OFICIO=@oficio";
            SqlParameter pamOficio = 
                new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamOficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> empleados = new List<string>();
            while( await this.reader.ReadAsync() )
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string emp_no = this.reader["EMP_NO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                string empleado = emp_no + " - " + apellido + " - " + salario;
                empleados.Add(empleado);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }

        public async Task<int> UpdateSalarioEmpleadosOficioAsync
            (string oficio, int incremento, string oficioNuevo)
        {
            string sql =
                "update EMP set SALARIO=SALARIO+@incremento, OFICIO=@oficioNuevo" +
                " where OFICIO=@oficio";
            SqlParameter pamIncremento = new SqlParameter("@incremento", incremento);
            this.com.Parameters.Add(pamIncremento);
            this.com.Parameters.AddWithValue("@oficioNuevo", oficioNuevo);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int afectados = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return afectados;
        }

        public async Task<DatosEmpleadosOficio> GetDatosEmpleadosOficioAsync(string oficio)
        {
            string sql =
                "select SUM(SALARIO) as SUMASALARIAL, AVG(SALARIO) as MEDIASALARIAL, MAX(SALARIO) as MAXIMOSALARIAL from emp where oficio=@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            DatosEmpleadosOficio deo = new DatosEmpleadosOficio();
            await this.reader.ReadAsync();
            deo.SumaSalarial = 
                int.Parse(this.reader["SUMASALARIAL"].ToString());
            deo.MediaSalarial = 
                int.Parse(this.reader["MEDIASALARIAL"].ToString());
            deo.MaximoSalarial = 
                int.Parse(this.reader["MAXIMOSALARIAL"].ToString());
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return deo;
        }
    }
}
