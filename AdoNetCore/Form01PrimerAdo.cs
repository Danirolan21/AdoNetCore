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
    public partial class Form01PrimerAdo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string connectionString;
        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;TrustServerCertificate=True";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "La conexion esta pasando de "
                + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                    this.lblMensaje.BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("The connection is already open.");
                }
            }
            catch (SqlException ex)
            {
                this.lblMensaje.Text = ex.ToString();
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lstApellidos.Items.Clear();
            this.lstColumnas.Items.Clear();
            this.lstTiposDato.Items.Clear();
            this.lblMensaje.BackColor = Color.Red;
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            //LIMPIAR LOS REGISTROS ANTERIORES
            this.lstApellidos.Items.Clear();
            this.lstColumnas.Items.Clear();
            this.lstTiposDato.Items.Clear();
            //CONSULTA A REALIZAR
            string sql = "SELECT * FROM EMP";
            //CONFIGURAMOS NUESTRO COMMAND
            //INDICAMOS LA CONEXION DEL COMMAND
            this.com.Connection = this.cn;
            //TIPO DE CONSULTA A REALIZAR
            this.com.CommandType = CommandType.Text;
            //LA PROPIA CONSULTA
            this.com.CommandText = sql;
            //AQUI DEBERIAMOS ABRIR LA CONEXION
            //ES UNA CONSULTA DE SELECCION POR LO QUE DEBEMOS
            //UTILIZAR EL METODO ExecuteReader() QUE NOS DEVUELVE
            //UN DataReader
            this.reader = this.com.ExecuteReader();
            //YA PODEMOS LEER DATOS
            //LEEMOS LA PRIMERA COLUMNA
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                string columna = this.reader.GetName(i);
                string tipoDato = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTiposDato.Items.Add(tipoDato);
            }

            //LEEMOS EL PRIMER REGISTRO
            //PARA LEER DATOS DEBEMOS UTILIZAR EL METODO Read()
            //DEL LECTOR
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }
            //SIEMPRE DEBEMOS CERRAR TODO PARA PODER REUTILIZARLO
            this.reader.Close();
        }
    }
}
