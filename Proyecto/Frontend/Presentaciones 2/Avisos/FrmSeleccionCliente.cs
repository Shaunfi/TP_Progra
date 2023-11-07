﻿using Backend.Entidades;

namespace Frontend.Presentaciones_2.Avisos
{
    public partial class FrmSeleccionCliente : Form
    {
        public bool resultado;
        Clientes clientes;

        public FrmSeleccionCliente(Clientes cliente)
        {
            InitializeComponent();
            this.clientes = cliente;
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void FrmSeleccionCliente_Load(object sender, EventArgs e)
        {
            lblClienteSeleccion.Text = "Esta por seleccionar a " + clientes.Apellido + ", " + clientes.Nombre;
        }
    }
}
