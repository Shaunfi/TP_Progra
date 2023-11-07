namespace Frontend.Presentaciones_2.Avisos
{
    public partial class FrmSalir3 : Form
    {
        public bool resultado;

        public FrmSalir3()
        {
            InitializeComponent();
        }

        private void FrmSalir3_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            resultado = true;
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resultado = false;
            this.Dispose();
        }
    }
}
