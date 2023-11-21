using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPPepas.Presentaciones
{
    public partial class frmAgregarProveedor : Form
    {
        public frmAgregarProveedor()
        {
            InitializeComponent();
        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargarComboBox(ComboBox combo, string propID, string propDisplay, object[] listaObjetos)
        {
            combo.DataSource = listaObjetos;
            combo.ValueMember = propID;
            combo.DisplayMember = propDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
