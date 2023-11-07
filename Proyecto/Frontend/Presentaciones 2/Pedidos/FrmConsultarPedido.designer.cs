namespace Frontend.Presentaciones_2.PPedidos
{
    partial class FrmConsultarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            Cliente = new Label();
            dgvConsultarPedidos = new DataGridView();
            objectPedido = new DataGridViewTextBoxColumn();
            colNroPedido = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colSucursal = new DataGridViewTextBoxColumn();
            colFormaPago = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            cboSucursales = new ComboBox();
            panel1 = new Panel();
            btnSalir2 = new Button();
            label1 = new Label();
            label2 = new Label();
            nudNroPedido = new NumericUpDown();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            dgvLotes = new DataGridView();
            objectLote = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColCant = new DataGridViewTextBoxColumn();
            colFechaVencimiento = new DataGridViewTextBoxColumn();
            ColPro = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarPedidos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNroPedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLotes).BeginInit();
            SuspendLayout();
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(628, 144);
            dtpHasta.Margin = new Padding(2);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(192, 22);
            dtpHasta.TabIndex = 19;
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(628, 103);
            dtpDesde.Margin = new Padding(2);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(192, 22);
            dtpDesde.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(485, 149);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 16);
            label4.TabIndex = 15;
            label4.Text = "Fecha hasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(485, 107);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 16);
            label3.TabIndex = 14;
            label3.Text = "Fecha desde";
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Cliente.ForeColor = SystemColors.ButtonHighlight;
            Cliente.Location = new Point(100, 104);
            Cliente.Margin = new Padding(2, 0, 2, 0);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(84, 16);
            Cliente.TabIndex = 12;
            Cliente.Text = "Sucursales";
            // 
            // dgvConsultarPedidos
            // 
            dgvConsultarPedidos.AllowUserToAddRows = false;
            dgvConsultarPedidos.AllowUserToDeleteRows = false;
            dgvConsultarPedidos.BackgroundColor = Color.FromArgb(49, 66, 82);
            dgvConsultarPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarPedidos.Columns.AddRange(new DataGridViewColumn[] { objectPedido, colNroPedido, colFecha, colSucursal, colFormaPago, colAcciones });
            dgvConsultarPedidos.Location = new Point(13, 267);
            dgvConsultarPedidos.Margin = new Padding(2);
            dgvConsultarPedidos.Name = "dgvConsultarPedidos";
            dgvConsultarPedidos.ReadOnly = true;
            dgvConsultarPedidos.RowHeadersWidth = 62;
            dgvConsultarPedidos.Size = new Size(874, 309);
            dgvConsultarPedidos.TabIndex = 11;
            dgvConsultarPedidos.CellContentClick += dgvConsultarPedidos_CellContentClick;
            // 
            // objectPedido
            // 
            objectPedido.HeaderText = "Objeto Pedido";
            objectPedido.Name = "objectPedido";
            objectPedido.ReadOnly = true;
            objectPedido.Visible = false;
            // 
            // colNroPedido
            // 
            colNroPedido.HeaderText = "Numero Pedido";
            colNroPedido.Name = "colNroPedido";
            colNroPedido.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colSucursal
            // 
            colSucursal.HeaderText = "Sucursal";
            colSucursal.Name = "colSucursal";
            colSucursal.ReadOnly = true;
            // 
            // colFormaPago
            // 
            colFormaPago.HeaderText = "Forma de Pago";
            colFormaPago.Name = "colFormaPago";
            colFormaPago.ReadOnly = true;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            // 
            // cboSucursales
            // 
            cboSucursales.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboSucursales.FormattingEnabled = true;
            cboSucursales.Location = new Point(225, 103);
            cboSucursales.Margin = new Padding(4, 3, 4, 3);
            cboSucursales.Name = "cboSucursales";
            cboSucursales.Size = new Size(186, 24);
            cboSucursales.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 211, 119);
            panel1.Controls.Add(btnSalir2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 67);
            panel1.TabIndex = 23;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnSalir2
            // 
            btnSalir2.BackColor = Color.FromArgb(0, 211, 119);
            btnSalir2.FlatStyle = FlatStyle.Popup;
            btnSalir2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir2.ForeColor = Color.Black;
            btnSalir2.Location = new Point(845, 3);
            btnSalir2.Margin = new Padding(4, 3, 4, 3);
            btnSalir2.Name = "btnSalir2";
            btnSalir2.Size = new Size(59, 29);
            btnSalir2.TabIndex = 45;
            btnSalir2.Text = "X";
            btnSalir2.UseVisualStyleBackColor = false;
            btnSalir2.Click += btnSalir2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(285, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 37);
            label1.TabIndex = 0;
            label1.Text = "Consultar Pedidos";
            label1.MouseDown += label1_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(100, 149);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 16);
            label2.TabIndex = 24;
            label2.Text = "Nro Pedido";
            // 
            // nudNroPedido
            // 
            nudNroPedido.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nudNroPedido.Location = new Point(225, 144);
            nudNroPedido.Margin = new Padding(4, 3, 4, 3);
            nudNroPedido.Name = "nudNroPedido";
            nudNroPedido.Size = new Size(187, 22);
            nudNroPedido.TabIndex = 25;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(49, 66, 82);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(483, 219);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(161, 28);
            btnLimpiar.TabIndex = 27;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(49, 66, 82);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ButtonFace;
            btnBuscar.Location = new Point(251, 219);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(161, 28);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvLotes
            // 
            dgvLotes.AllowUserToAddRows = false;
            dgvLotes.AllowUserToDeleteRows = false;
            dgvLotes.BackgroundColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.55F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLotes.Columns.AddRange(new DataGridViewColumn[] { objectLote, colProducto, ColPrecio, ColCant, colFechaVencimiento, ColPro, dataGridViewButtonColumn1 });
            dgvLotes.Location = new Point(14, 283);
            dgvLotes.Margin = new Padding(4, 3, 4, 3);
            dgvLotes.Name = "dgvLotes";
            dgvLotes.ReadOnly = true;
            dgvLotes.Size = new Size(872, 293);
            dgvLotes.TabIndex = 28;
            dgvLotes.CellContentClick += dgvLotes_CellContentClick;
            // 
            // objectLote
            // 
            objectLote.HeaderText = "Objeto Lote";
            objectLote.Name = "objectLote";
            objectLote.ReadOnly = true;
            objectLote.Visible = false;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            colProducto.Width = 220;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            // 
            // ColCant
            // 
            ColCant.HeaderText = "Cantidad";
            ColCant.Name = "ColCant";
            ColCant.ReadOnly = true;
            ColCant.Width = 80;
            // 
            // colFechaVencimiento
            // 
            colFechaVencimiento.HeaderText = "Fecha Vencimiento";
            colFechaVencimiento.Name = "colFechaVencimiento";
            colFechaVencimiento.ReadOnly = true;
            // 
            // ColPro
            // 
            ColPro.HeaderText = "Proveedor";
            ColPro.Name = "ColPro";
            ColPro.ReadOnly = true;
            ColPro.Width = 180;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.HeaderText = "Acciones";
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewButtonColumn1.Text = "Quitar";
            dataGridViewButtonColumn1.Width = 87;
            // 
            // FrmConsultarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(899, 588);
            Controls.Add(dgvLotes);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(nudNroPedido);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(cboSucursales);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Cliente);
            Controls.Add(dgvConsultarPedidos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmConsultarPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConsultarPedido";
            Load += FrmConsultarPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarPedidos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNroPedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Label label4;
        private Label label3;
        private Label Cliente;
        private DataGridView dgvConsultarPedidos;
        private ComboBox cboSucursales;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private NumericUpDown nudNroPedido;
        private Button btnLimpiar;
        private Button btnBuscar;
        private Button btnSalir2;
        private DataGridViewTextBoxColumn objectPedido;
        private DataGridViewTextBoxColumn colNroPedido;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colSucursal;
        private DataGridViewTextBoxColumn colFormaPago;
        private DataGridViewButtonColumn colAcciones;
        private DataGridView dgvLotes;
        private DataGridViewTextBoxColumn objectLote;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColCant;
        private DataGridViewTextBoxColumn colFechaVencimiento;
        private DataGridViewTextBoxColumn ColPro;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}