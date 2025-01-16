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
    public partial class Form05UpdateSalas : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form05UpdateSalas()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;TrustServerCertificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.LoadSalas();
        }

        private async void LoadSalas()
        {
            string sql = "select distinct NOMBRE from sala";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = 
                await this.com.ExecuteReaderAsync();
            this.lstSalas.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                string datos = nombre;
                this.lstSalas.Items.Add(datos);
            }
            await this.reader.CloseAsync();                                                                                                                                                                                                                                                                                                                 
            this.cn.Close();
        }

        private async void btnModificarSalas_Click(object sender, EventArgs e)
        {
            int index = this.lstSalas.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Debes seleccionar una sala");
                return;
            }
            string nombre = this.lstSalas.Items[index].ToString();
            string nuevaSala = this.txtNuevaSala.Text;
            string sql = "update sala set NOMBRE=@nuevaSala where NOMBRE=@nombre";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamNuevaSala = new SqlParameter("@nuevaSala", nuevaSala);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamNuevaSala);
            int modificadas = 
                await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.LoadSalas();
            MessageBox.Show("Salas modificadas: " + modificadas);
        }

        private void lstSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstSalas.SelectedIndex;
            if (index != -1)
            {
                this.txtNuevaSala.Text = this.lstSalas.Items[index].ToString();
            }
        }
    }
}
