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
    public partial class frmConsultarProductos : Form
    {
        public frmConsultarProductos()
        {
            InitializeComponent();
        }

        private void frmConsultarProductos_Load(object sender, EventArgs e)
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
