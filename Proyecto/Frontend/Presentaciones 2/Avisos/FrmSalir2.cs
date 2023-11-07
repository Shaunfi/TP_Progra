namespace Frontend.Presentaciones_2.Avisos
{
    public partial class FrmSalir2 : Form
    {
        public bool resultado;

        public FrmSalir2()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resultado = false;
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            resultado = true;
            this.Dispose();
        }

        private void FrmSalir2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
