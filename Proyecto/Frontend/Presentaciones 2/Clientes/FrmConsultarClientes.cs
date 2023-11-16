using System.Runtime.InteropServices;
using Backend.Entidades;
using Backend.Factory;
using Backend.Servicio;
using Frontend.Client;
using Frontend.Presentaciones_2.Avisos;
using Newtonsoft.Json;

namespace Frontend.Presentaciones_2.PClientes
{
    public partial class FrmConsultarClientes : Form
    {
        IServicios servicios;
        public FrmConsultarClientes(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicios = fabrica.CrearServicio();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            FrmSalir2 salir = new FrmSalir2();
            salir.ShowDialog();

            if (salir.resultado)
            {
                this.Dispose();
            }
        }

        private void FrmConsultarClientes_Load(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            txtClienteNumero.Text = "";
            ListarClientes();
        }

        private void FrmConsultarClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvConsultarCliente.Rows.Clear();

            string nombre = txtCliente.Text;
            int nroDoc = 0;
            if (int.TryParse(txtClienteNumero.Text, out _))
            {
                nroDoc = Convert.ToInt32(txtClienteNumero.Text);
            }
            if (nroDoc > 0)
            {
                ListarClientes(nombre, nroDoc);
            }
            else
            {
                ListarClientes(nombre);
            }
        }

        private async void ListarClientes()
        {
            string url = $"https://localhost:7265/api/Clientes/Consultar";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var list = JsonConvert.DeserializeObject<List<Clientes>>(result);

            dgvConsultarCliente.Rows.Clear();
            if (list != null)
            {
                foreach (Clientes c in list)
                {
                    dgvConsultarCliente.Rows.Add(new object[] { c, c.CodCliente, c.Nombre, c.Apellido, c.NroDoc, c.CodMutual, c.NroAfliliado, "modificar" });
                }
            }
        }
        private async void ListarClientes(string nombre)
        {
            string url = $"https://localhost:7265/api/Clientes/Consultar?nombre={nombre}";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var list = JsonConvert.DeserializeObject<List<Clientes>>(result);

            dgvConsultarCliente.Rows.Clear();
            if (list != null)
            {
                foreach (Clientes c in list)
                {
                    dgvConsultarCliente.Rows.Add(new object[] { c, c.CodCliente, c.Nombre, c.Apellido, c.NroDoc, c.CodMutual, c.NroAfliliado, "modificar" });
                }
            }
        }
        private async void ListarClientes(string nombre, int nroDoc)
        {
            string url = $"https://localhost:7265/api/Clientes/Consultar?nombre={nombre}&nroDoc={nroDoc}";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var list = JsonConvert.DeserializeObject<List<Clientes>>(result);

            dgvConsultarCliente.Rows.Clear();
            if (list != null)
            {
                foreach (Clientes c in list)
                {
                    dgvConsultarCliente.Rows.Add(new object[] { c, c.CodCliente, c.Nombre, c.Apellido, c.NroDoc, c.CodMutual, c.NroAfliliado, "modificar" });
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsultarCliente.Rows.Clear();
        }

        private void dgvConsultarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarCliente.CurrentCell.ColumnIndex == 7)
            {
                Clientes cliente = (Clientes)dgvConsultarCliente.CurrentRow.Cells["colObj"].Value;
                new FrmModificarCliente(servicios, cliente).ShowDialog();
            }
        }
    }
}
