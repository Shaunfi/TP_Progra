using Frontend.Presentaciones_2.Avisos;

namespace Frontend.Presentaciones_2.Ayuda
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
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
    }
}
