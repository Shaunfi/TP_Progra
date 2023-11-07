namespace Frontend.Presentaciones_2.Avisos
{
    public partial class FrmCancelar : Form
    {
        public bool resultado;

        public FrmCancelar()
        {
            InitializeComponent();
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
