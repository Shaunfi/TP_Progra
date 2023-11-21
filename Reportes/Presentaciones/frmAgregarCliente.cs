using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPepas.Servicio;

namespace TPPepas.Presentaciones
{
    public partial class frmAgregarCliente : Form
    {
  
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            // cambios para probar el github
            
        }

        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, List<object> listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
