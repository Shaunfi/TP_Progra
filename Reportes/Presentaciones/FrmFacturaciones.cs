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
using TPPepas.Factory;
using TPPepas.Servicio;

namespace TPPepas.Presentaciones
{
    public partial class FrmFacturaciones : Form
    {
        // Queria hacer que al encontrar el cliente se muestre su mutual en caso de ser equivocas.

        // El DataGrid tiene un elemento oculto que es el ID para hacer futuras comprobaciones. Por las dudas lo puse ahi despues vemos si lo sacamos.

        // El tipo producto se tiene que carga y habilitara la lista de productos. Pienso en agregar en el combo un onda "Desconocido" asi trae toda la lista.

        IServicios servicio;
        FactoryAbs fabrica;
        Facturas factura;

        public FrmFacturaciones(FactoryAbs fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            servicio = fabrica.CrearServicio();
            factura = new Facturas();
        }

        private void FrmFacturaciones_Load(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("dd / MM / yyyy | HH : mm");
            CargarComboBox(cboBoxProducto, "CodProducto", "Descripcion", servicio.Productos.Listar());
            CargarComboBox(cboBoxTipoProducto, "Valor", "Display", servicio.TablasAuxiliares.ListarTiposProductos());
        }

        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmFacturacionesBusqueda clienteSeleccionado = new frmFacturacionesBusqueda(fabrica, txtBoxCliente.Text);
            clienteSeleccionado.ShowDialog();
            if (clienteSeleccionado.resultado)
            {
                btnBuscar.Enabled = false;
                factura.Cliente = clienteSeleccionado.cliente;
                txtBoxCliente.Text = clienteSeleccionado.cliente.Nombre + ' ' + clienteSeleccionado.cliente.Apellido;
                txtBoxCliente.ReadOnly = true;
            }
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Al hacer confirmar le sale un form preguntandole por el metodo de pago elegido por el cliente.
        }
    }
}
