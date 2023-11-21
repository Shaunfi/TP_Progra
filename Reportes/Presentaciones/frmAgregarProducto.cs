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
    public partial class frmAgregarProducto : Form
    {
        IServicios servicio;
        public frmAgregarProducto(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            LimpiarForm();
            CargarComboBox(cboTipoProducto, "Valor", "Display", servicio.TablasAuxiliares.ListarTiposProductos());
            CargarComboBox(cboTipoPresentacion, "Valor", "Display", servicio.TablasAuxiliares.ListarTiposPresentacion());
            // ver si esta buena esta forma, porque no hay sp para consultar las ventas libres, cree una lista en tablas auxiliares
            CargarComboBox(cboVentalibre, "Valor", "Display", servicio.TablasAuxiliares.ListarTiposVentas());
        }

        private void LimpiarForm()
        {
            txtDescripcion.Text = "";
            nudPrecioUnitario.Value = 0;
            nudStock.Value = 0;
            nudStockminimo.Value = 0;
            cboTipoPresentacion.SelectedIndex = -1;
            cboTipoProducto.SelectedIndex = -1;
            cboVentalibre.SelectedIndex = -1;
        }
        // aca modifique que el metodo cargaCombo necesita una lista de objetos como parametro
        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // validar campos

            // agregar
            // si se agrega el producto, reiniciamos el form
            LimpiarForm();
        }
    }
}
