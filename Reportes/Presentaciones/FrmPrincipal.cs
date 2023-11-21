using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPepas.Factory;
using TPPepas.RAMI;
using TPPepas.Reportes;

namespace TPPepas.Presentaciones
{
    public partial class FrmPrincipal : Form
    {
        FactoryAbs fabrica;
        public FrmPrincipal(FactoryAbs fabric)
        {
            InitializeComponent();
            fabrica = fabric;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new FrmFacturaciones(fabrica).Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultarVentas(fabrica).Show();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAgregarProducto(fabrica).Show();
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultarProductos().Show();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAgregarCliente().Show();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultarClientes(fabrica).Show();
        }

        private void agregarProvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAgregarProveedor().Show();
        }

        private void consultarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultarProvedor().Show();
        }

        private void verInformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReporteVentas().Show();
        }
    }
}
