using System.Runtime.InteropServices;
using Backend.Entidades;
using Backend.Factory;
using Backend.Servicio;
using Frontend.Presentaciones_2.Avisos;

namespace Frontend.Presentaciones_2.PPedidos
{
    public partial class FrmConsultarPedido : Form
    {
        IServicios servicios;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        public FrmConsultarPedido(FactoryAbs factory)
        {
            InitializeComponent();
            servicios = factory.CrearServicio();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsultarPedidos.Rows.Clear();
        }

        private void FrmConsultarPedido_Load(object sender, EventArgs e)
        {
            dgvLotes.Visible = false;
            dgvConsultarPedidos.Rows.Clear();
            foreach (Pedidos p in servicios.Pedidos.Listar())
            {
                dgvConsultarPedidos.Rows.Add(new object[] { p, p.CodPedido, p.FechaPedido, p.Sucursal.CodSucursal, p.TipoPago, "Ver" });
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvConsultarPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarPedidos.CurrentCell.ColumnIndex == 5)
            {
                dgvConsultarPedidos.Visible = false;
                dgvLotes.Visible = true;
                Pedidos pedido = (Pedidos)dgvConsultarPedidos.CurrentRow.Cells[0].Value;
                foreach (Lotes lt in servicios.Pedidos.ListarLotes(pedido.CodPedido))
                {
                    dgvLotes.Rows.Add(lt,
                                      servicios.Productos.ConsultarProducto(lt.Producto.CodProducto),
                                      lt.Precio,
                                      lt.Cantidad,
                                      lt.FechaVencimiento,
                                      servicios.Proveedores.ConsultarProveedor(lt.Proveedor.CodProveedor),
                                      "Volver");
                }
            }
        }

        private void dgvLotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLotes.CurrentCell.ColumnIndex == 6)
            {
                dgvLotes.Visible = false;
                dgvConsultarPedidos.Visible = true;
                dgvLotes.Rows.Clear();
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

        private void btnSalir2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultarPedido_Load_1(object sender, EventArgs e)
        {
            dgvLotes.Visible = false;
            
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dgvConsultarPedidos.Rows.Clear();

            int sucursal = 1;
            int nroPedido = 0;
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            if (int.TryParse(nudNroPedido.Text, out _))
            {
                nroPedido = Convert.ToInt32(nudNroPedido.Text);
            }
            if (nroPedido > 0)
            {
                foreach (Pedidos p in servicios.Pedidos.ListarFiltro(desde, hasta, nroPedido))
                {
                    dgvConsultarPedidos.Rows.Add(new object[] { p, p.CodPedido, p.FechaPedido, p.Sucursal.CodSucursal, p.TipoPago, "Ver Lotes" });
                }
            }
        }
    }
}
