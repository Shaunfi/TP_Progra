using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPepas.Datos;
using TPPepas.Factory;
using TPPepas.Servicio;

namespace TPPepas.Presentaciones
{
    public partial class frmConsultarVentas : Form
    {
        IServicios servicio;

        public frmConsultarVentas(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
        }

        private void frmConsultarVEntas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int nroFactura = 0;
            if (int.TryParse(txtNroFactura.Text, out _))
            {
                nroFactura = Convert.ToInt32(txtNroFactura.Text);
            }

            //dgvConsultarVentas.DataSource = servicio.Facturas.ListarFacturaFiltros
            //                                (
            //                                    dtpDesde.Value,
            //                                    dtpHasta.Value,
            //                                    txtCliente.Text,
            //                                    nroFactura
            //                                );
            foreach (Facturas factura in servicio.Facturas.ListarFacturaFiltros(dtpDesde.Value, dtpHasta.Value, txtCliente.Text, nroFactura))
            {
                dgvConsultarVentas.Rows.Add(factura.NroFactura, factura.Fecha, factura.Empleado.CodEmpleado, factura.Cliente.CodCliente, factura.Sucursal.CodSucursal, factura.TipoPago);
            }
        }
    }
}
