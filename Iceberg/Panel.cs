using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iceberg
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void mnuArticulo_Click(object sender, EventArgs e)
        {
            new ArticuloIndice().Show();
        }

        private void mnuCliente_Click(object sender, EventArgs e)
        {
            new ClienteIndice().Show();
        }

        private void mnuEmpleado_Click(object sender, EventArgs e)
        {
            new EmpleadoIndice().Show();
        }

        private void mnuProveedor_Click(object sender, EventArgs e)
        {
            new ProveedorIndice().Show();
        }

        private void mnuNovedad_Click(object sender, EventArgs e)
        {
            new NovedadIndice().Show();
        }

        private void mnuVenta_Click(object sender, EventArgs e)
        {
            new Venta().Show();
        }

        private void mnuCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿ Esta seguro de cerrar sesión ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            switch(respuesta)
            {
                case DialogResult.Yes:
                    this.Close();
                    new frmIniciarSesion().Show();
                    break;
            }
        }

        private void mnuCambiarClave_Click(object sender, EventArgs e)
        {
            new CambiarClave().Show();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿ Esta seguro de salir ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            switch (respuesta)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }

        private void mnuRubro_Click(object sender, EventArgs e)
        {
            new RubroIndice().Show();
        }

        private void mnuCategoria_Click(object sender, EventArgs e)
        {
            new CategoriaIndice().Show();
        }
    }
}
