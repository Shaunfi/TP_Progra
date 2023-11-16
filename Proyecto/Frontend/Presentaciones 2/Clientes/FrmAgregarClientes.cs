using System.Runtime.InteropServices;
using Backend.Entidades;
using Backend.Factory;
using Backend.Servicio;
using Frontend.Client;
using Frontend.Presentaciones_2.Avisos;
using Newtonsoft.Json;

namespace Frontend.Presentaciones_2.PClientes
{
    public partial class FrmAgregarClientes : Form
    {
        IServicios servicios;
        Clientes nuevoCliente;
        public FrmAgregarClientes(FactoryAbs fabrica)
        {
            InitializeComponent();
            servicios = fabrica.CrearServicio();
            nuevoCliente = new Clientes();
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
           

        private void FrmAgregarClientes_Load(object sender, EventArgs e)
        {
            LimpiarForm();
            // cambios para probar el github
            CargarComboBox(cboCiudades, "Valor", "Display", servicios.TablasAuxiliares.ListarCiudades());
            CargarComboBox(cboTipodoc, "Valor", "Display", servicios.TablasAuxiliares.ListarTiposDocumento());
            CargarComboBox(cboMutual, "Valor", "Display", servicios.TablasAuxiliares.ListarMutuales());
        }

        private void FrmAgregarClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LimpiarForm()
        {
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtNombre.Text = "";
            nudAfiliado.Value = 0;
            nudAltura.Value = 1;
            nudDocumento.Text = "";
            cboBarrios.SelectedIndex = -1;
            cboCiudades.SelectedIndex = -1;
            cboMutual.SelectedIndex = -1;
            cboTipodoc.SelectedIndex = -1;
        }

        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        // metodo asincrono para cargar los combo box
        private async void CargarComboAsync(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            string url = "";
            var data = await ClientSingleton.GetInstance().GetAsync(url);
            List<object> lista = JsonConvert.DeserializeObject<List<object>>(data);
            combo.DataSource = lista;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool Validar()
        {
            // Por hacer
            if(txtNombre.Text == String.Empty)
            {
                return false;
            }
            if(txtApellido.Text == String.Empty)
            {
                return false;
            }
            if(txtCalle.Text == String.Empty)
            {
                return false;
            }
            if(cboBarrios.SelectedIndex == -1)
            {
                return false;
            }
            if(cboCiudades.SelectedIndex == -1)
            {
                return false;
            }
            if(cboMutual.SelectedIndex == -1)
            {
                return false;
            }
            if(cboTipodoc.SelectedIndex == -1)
            {
                return false;
            }
            if(nudAfiliado.Value < 0)
            {
                return false;
            }
            if(nudAltura.Value < 0)
            {
                return false;
            }
            if(nudDocumento.Value < 0)
            {
                return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                nuevoCliente.Nombre = txtNombre.Text;
                nuevoCliente.Apellido = txtApellido.Text;
                nuevoCliente.CodBarrio = Convert.ToInt32(cboBarrios.SelectedValue);
                nuevoCliente.Calle = txtCalle.Text;
                nuevoCliente.Altura = Convert.ToInt32(nudAltura.Value);
                nuevoCliente.NroAfliliado = Convert.ToInt32(nudAfiliado.Value);
                nuevoCliente.NroDoc = Convert.ToInt32(nudDocumento.Value);
                nuevoCliente.TipoDoc = Convert.ToInt32(cboTipodoc.SelectedValue);
                nuevoCliente.CodMutual = Convert.ToInt32(cboMutual.SelectedValue);

                CargarClienteAsync(nuevoCliente);
            }
            else
            {
                lblAviso.Visible = true;
            }

        }

        // metodo para hacer un post de un cliente
        private async void CargarClienteAsync(Clientes cliente)
        {
            string url = $"https://localhost:7265/api/Clientes";
            string bodyContent = JsonConvert.SerializeObject(cliente);

            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Cliente registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            TablasAuxiliares ciudad = (TablasAuxiliares)cboCiudades.SelectedItem;


            CargarComboBox(cboBarrios, "Valor", "Display", servicios.TablasAuxiliares.ListarBarrios(ciudad.Valor));
        }
    }
}
