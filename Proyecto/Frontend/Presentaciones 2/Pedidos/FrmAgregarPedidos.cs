﻿using System.Runtime.InteropServices;
using Backend.Entidades;
using Backend.Factory;
using Backend.Servicio;
using Frontend.Presentaciones_2.Avisos;

namespace Frontend.Presentaciones_2.PPedidos
{
    public partial class FrmAgregarPedidos : Form
    {
        IServicios servicios;
        Pedidos nuevoPedido = new Pedidos();


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        public FrmAgregarPedidos(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicios = fabrica.CrearServicio();
        }

        private void frmPed_Load(object sender, EventArgs e)
        {
            lblAviso.Visible = false;
            btnConfirmar.Enabled = false;
            CargarComboBox(cboProducto, "codProducto", "descripcion", servicios.Productos.Listar());
            CargarComboBox(cboTipoProducto, "Valor", "Display", servicios.TablasAuxiliares.ListarTiposProductos());
            CargarComboBox(cboSucursales, "codSucursal", "usuario", servicios.Sucursales.Listar());
            CargarComboBox(cboProveedores, "codProveedor", "NombreProveedor", servicios.Proveedores.Listar());
            CargarComboBox(cboFormaPago, "Valor", "Display", servicios.TablasAuxiliares.ListarFormasDePago());
            Limpiar(true);
        }

        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Limpiar(bool confirmar = false)
        {
            if (confirmar)
            {
                cboFormaPago.SelectedIndex = -1;
                cboSucursales.SelectedIndex = -1;
            }
            cboProducto.SelectedIndex = -1;
            cboTipoProducto.SelectedIndex = -1;
            cboProveedores.SelectedIndex = -1;
            nudCantidad.Value = 1;
        }

        private bool ValidarAgregar()
        {
            if (cboProducto.SelectedIndex == -1)
            {
                lblAviso.Visible = true;
                return false;
            }
            if (cboProducto.SelectedIndex == -1)
            {
                lblAviso.Visible = true;
                return false;
            }
            if (cboProveedores.SelectedIndex == -1)
            {
                lblAviso.Visible = true;
                return false;
            }
            lblAviso.Visible = false;
            return true;
        }
        
        private bool ValidarConfirmar()
        {
            if (cboFormaPago.SelectedIndex == -1)
            {
                lblAviso.Visible = true;
                return false;
            }
            if (cboSucursales.SelectedIndex == -1)
            {
                lblAviso.Visible = true;
                return false;
            }
            lblAviso.Visible = false;
            return true;
        }

        private void CalcularTotal()
        {
            double total = 0;
            foreach (Lotes lt in nuevoPedido.LLotes)
            {
                total += lt.CalcularSubTotal();
            }
            txtTotal.Text = $"$ {total.ToString("F2")}";
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            FrmSalir2 salir = new FrmSalir2();
            salir.ShowDialog();

            if (salir.resultado)
            {
                this.Dispose();
            }
        }

        private void dgvLotes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvLotes.Rows.Count == 1)
            {
                btnConfirmar.Enabled = true;
            }
        }

        private void dgvLotes_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvLotes.Rows.Count == 0)
            {
                btnConfirmar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarAgregar())
            {
                Lotes lote = new Lotes();

                Productos producto = (Productos)cboProducto.SelectedItem;
                Proveedores proveedor = (Proveedores)cboProveedores.SelectedItem;
                lote.Producto = producto;
                lote.Cantidad = Convert.ToInt32(nudCantidad.Value);
                lote.Proveedor = proveedor;
                lote.Precio = Convert.ToInt32(nudPrecio.Value);

                nuevoPedido.AgregarLote(lote);

                dgvLotes.Rows.Add(lote,
                                  lote.Producto.Descripcion,
                                  lote.Precio,
                                  lote.Cantidad,
                                  $"{lote.Proveedor.Calle} {lote.Proveedor.Altura}",
                                  "Quitar");
                Limpiar();
            }
            else
            {
                lblAviso.Visible = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarConfirmar())
            {
                if (servicios.Pedidos.Agregar(nuevoPedido))
                {
                    FrmExito exito = new FrmExito();
                    exito.ShowDialog();
                }
                else
                {
                    FrmError error = new FrmError();
                    error.ShowDialog();
                }
            }
            else
            {
                lblAviso.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmCancelar ca = new FrmCancelar();
            ca.ShowDialog();
            if (ca.resultado)
            {
                this.Dispose();
            }
        }

        private void dgvLotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLotes.CurrentCell.ColumnIndex == 5)
            {
                nuevoPedido.QuitarLote(dgvLotes.CurrentRow.Index);
                dgvLotes.Rows.RemoveAt(dgvLotes.CurrentRow.Index);
                CalcularTotal();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
