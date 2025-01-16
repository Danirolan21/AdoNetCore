using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Models;
using AdoNetCore.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdoNetCore
{
    public partial class Form08CrudDepartamentos : Form
    {
        RepositoryDepartamentos repo;
        public Form08CrudDepartamentos()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.LoadDepartamentos();
        }

        private async void LoadDepartamentos()
        {
            this.lstDepartamentos.Items.Clear();
            List<Departamento> departamentos = await this.repo.GetDepartamentosAsync();
            foreach (Departamento dept in departamentos)
            {
                this.lstDepartamentos.Items.Add(dept.Id
                    + " - " + dept.nombre + " - " + dept.localidad);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repo.InsertDepartamentoAsync(id, nombre, localidad);
            this.LoadDepartamentos();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repo.UpdateDepartamentoAsync(id, nombre, localidad);
            this.LoadDepartamentos();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.repo.DeleteDepartamento(id);
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtLocalidad.Text = "";
            this.LoadDepartamentos();
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstDepartamentos.SelectedIndex;
            if (index != -1)
            {
                int id = int.Parse(this.lstDepartamentos.SelectedItem.ToString().Split('-')[0]);
                string nombre = this.lstDepartamentos.SelectedItem.ToString().Split('-')[1].Trim();
                string localidad = this.lstDepartamentos.SelectedItem.ToString().Split('-')[2].Trim();
                this.txtId.Text = id.ToString();
                this.txtNombre.Text = nombre;
                this.txtLocalidad.Text = localidad;
            }
        }
    }
}
