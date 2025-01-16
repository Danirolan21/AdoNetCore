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

namespace AdoNetCore
{
    public partial class Form10UpdateEmpleadosOficios : Form
    {
        RepositoryUpdateEmpleados repo;
        public Form10UpdateEmpleadosOficios()
        {
            InitializeComponent();
            this.repo = new RepositoryUpdateEmpleados();
            this.LoadOficios();
        }

        private async Task LoadOficios()
        {
            List<string> oficios = await this.repo.getOficiosAsync();
            this.lstOficios.Items.Clear();
            foreach (string oficio in oficios)
            {
                this.lstOficios.Items.Add(oficio);
            }
        }

        private async void btnIncrementarSalarios_Click(object sender, EventArgs e)
        {
            string oficioNuevo = this.txtOficio.Text;
            int incremento = int.Parse(this.txtIncremento.Text);
            string oficio = this.lstOficios.SelectedItem.ToString();
            int modificados =
                await this.repo.UpdateSalarioEmpleadosOficioAsync(oficio, incremento, oficioNuevo);
            await this.LoadOficios();
            DatosEmpleadosOficio datos = await this.repo.GetDatosEmpleadosOficioAsync(oficioNuevo);
            this.lblSumaSalarial.Text = "Suma Salarial: " + datos.SumaSalarial;
            this.lblMediaSalarial.Text = "Media Salarial: " + datos.MediaSalarial;
            this.lblMaximoSalarial.Text = "Maximo Salarial: " + datos.MaximoSalarial;
            await this.LoadEmpleados(oficioNuevo);
            this.txtOficio.Clear();
            this.txtIncremento.Clear();
            MessageBox.Show("Salarios modificados " + modificados);
        }

        private async Task LoadEmpleados(string oficio)
        {
            List<string> empleados = await this.repo.getEmpleadosOficioAsync(oficio);
            this.lstEmpleados.Items.Clear();
            foreach(string empleado in empleados)
            {
                this.lstEmpleados.Items.Add(empleado);
            }
        }

        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstOficios.SelectedIndex != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                await this.LoadEmpleados(oficio);
                DatosEmpleadosOficio datos = await this.repo.GetDatosEmpleadosOficioAsync(oficio);
                this.lblSumaSalarial.Text = "Suma Salarial: " + datos.SumaSalarial;
                this.lblMediaSalarial.Text = "Media Salarial: " + datos.MediaSalarial;
                this.lblMaximoSalarial.Text = "Maximo Salarial: " + datos.MaximoSalarial;
            }
        }
    }
}
