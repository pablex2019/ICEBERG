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
    public partial class ProveedorIndice : Form
    {
        public ProveedorIndice()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new ProveedorNuevo().Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            new ProveedorEditar().Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
