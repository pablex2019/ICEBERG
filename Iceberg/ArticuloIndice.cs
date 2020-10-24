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
    public partial class ArticuloIndice : Form
    {
        public ArticuloIndice()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new ArticuloNuevo().Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            new ArticuloEditar().Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
