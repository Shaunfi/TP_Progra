namespace TPPepas.Presentaciones_2
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            barraTitulo = new Panel();
            btnHerramientas = new PictureBox();
            btnUsuario = new PictureBox();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            panelMenuLateral = new Panel();
            pnlSubMenuAyuda = new Panel();
            btnAcercaDe = new Button();
            btnPreguntas = new Button();
            btnAyuda = new Button();
            pnlSubMenuInforme = new Panel();
            btnInformePedidos = new Button();
            btnInformeProductos = new Button();
            btnInformeClientes = new Button();
            btnInformeVentas = new Button();
            btnInforme = new Button();
            pnlSubMenuPedido = new Panel();
            btnConsultarPedido = new Button();
            btnNuevoPedido = new Button();
            btnPedidos = new Button();
            pnlSubMenuProveedor = new Panel();
            btnConsultarProveedor = new Button();
            btnAgregarProveedor = new Button();
            btnProveedor = new Button();
            pnlSubMenuCliente = new Panel();
            btnConsultarCliente = new Button();
            btnAgregarCliente = new Button();
            btnCliente = new Button();
            pnlSubMenuProducto = new Panel();
            btnConsultarProducto = new Button();
            btnAgregarProducto = new Button();
            btnProducto = new Button();
            pnlSubMenuVenta = new Panel();
            btnConsultarVenta = new Button();
            btnNuevaVenta = new Button();
            btnVentas = new Button();
            panelLogo = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHerramientas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panelMenuLateral.SuspendLayout();
            pnlSubMenuAyuda.SuspendLayout();
            pnlSubMenuInforme.SuspendLayout();
            pnlSubMenuPedido.SuspendLayout();
            pnlSubMenuProveedor.SuspendLayout();
            pnlSubMenuCliente.SuspendLayout();
            pnlSubMenuProducto.SuspendLayout();
            pnlSubMenuVenta.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(0, 211, 119);
            barraTitulo.Controls.Add(btnHerramientas);
            barraTitulo.Controls.Add(btnUsuario);
            barraTitulo.Controls.Add(btnRestaurar);
            barraTitulo.Controls.Add(btnMaximizar);
            barraTitulo.Controls.Add(btnMinimizar);
            barraTitulo.Controls.Add(btnCerrar);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Margin = new Padding(4, 3, 4, 3);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(1538, 38);
            barraTitulo.TabIndex = 0;
            barraTitulo.MouseDown += barraTitulo_MouseDown;
            // 
            // btnHerramientas
            // 
            btnHerramientas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHerramientas.Cursor = Cursors.Hand;
            btnHerramientas.Image = Frontend.Properties.Resources._39170581;
            btnHerramientas.Location = new Point(1368, 3);
            btnHerramientas.Margin = new Padding(4, 3, 4, 3);
            btnHerramientas.Name = "btnHerramientas";
            btnHerramientas.Size = new Size(42, 31);
            btnHerramientas.SizeMode = PictureBoxSizeMode.Zoom;
            btnHerramientas.TabIndex = 4;
            btnHerramientas.TabStop = false;
            btnHerramientas.Click += btnHerramientas_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Cursor = Cursors.Hand;
            btnUsuario.Image = (Image)resources.GetObject("btnUsuario.Image");
            btnUsuario.Location = new Point(0, 0);
            btnUsuario.Margin = new Padding(4, 3, 4, 3);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(49, 38);
            btnUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            btnUsuario.TabIndex = 1;
            btnUsuario.TabStop = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = Frontend.Properties.Resources.minimizar1;
            btnRestaurar.Location = new Point(1465, 3);
            btnRestaurar.Margin = new Padding(4, 3, 4, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(30, 29);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = Frontend.Properties.Resources.maximizar;
            btnMaximizar.Location = new Point(1465, 3);
            btnMaximizar.Margin = new Padding(4, 3, 4, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(30, 29);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 2;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Frontend.Properties.Resources.minimizar_signo;
            btnMinimizar.Location = new Point(1428, 3);
            btnMinimizar.Margin = new Padding(4, 3, 4, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 29);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Frontend.Properties.Resources.cerrar11;
            btnCerrar.Location = new Point(1503, 3);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 29);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.AutoScroll = true;
            panelMenuLateral.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMenuLateral.BackColor = Color.FromArgb(26, 32, 40);
            panelMenuLateral.Controls.Add(pnlSubMenuAyuda);
            panelMenuLateral.Controls.Add(btnAyuda);
            panelMenuLateral.Controls.Add(pnlSubMenuInforme);
            panelMenuLateral.Controls.Add(btnInforme);
            panelMenuLateral.Controls.Add(pnlSubMenuPedido);
            panelMenuLateral.Controls.Add(btnPedidos);
            panelMenuLateral.Controls.Add(pnlSubMenuProveedor);
            panelMenuLateral.Controls.Add(btnProveedor);
            panelMenuLateral.Controls.Add(pnlSubMenuCliente);
            panelMenuLateral.Controls.Add(btnCliente);
            panelMenuLateral.Controls.Add(pnlSubMenuProducto);
            panelMenuLateral.Controls.Add(btnProducto);
            panelMenuLateral.Controls.Add(pnlSubMenuVenta);
            panelMenuLateral.Controls.Add(btnVentas);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Margin = new Padding(4, 3, 4, 3);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(309, 689);
            panelMenuLateral.TabIndex = 0;
            // 
            // pnlSubMenuAyuda
            // 
            pnlSubMenuAyuda.BackColor = Color.FromArgb(26, 39, 48);
            pnlSubMenuAyuda.Controls.Add(btnAcercaDe);
            pnlSubMenuAyuda.Controls.Add(btnPreguntas);
            pnlSubMenuAyuda.Dock = DockStyle.Bottom;
            pnlSubMenuAyuda.Location = new Point(0, 918);
            pnlSubMenuAyuda.Margin = new Padding(4, 3, 4, 3);
            pnlSubMenuAyuda.Name = "pnlSubMenuAyuda";
            pnlSubMenuAyuda.Size = new Size(292, 69);
            pnlSubMenuAyuda.TabIndex = 17;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.BackColor = Color.FromArgb(39, 66, 82);
            btnAcercaDe.Dock = DockStyle.Top;
            btnAcercaDe.FlatAppearance.BorderSize = 0;
            btnAcercaDe.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnAcercaDe.FlatStyle = FlatStyle.Flat;
            btnAcercaDe.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcercaDe.ForeColor = SystemColors.ButtonHighlight;
            btnAcercaDe.Location = new Point(0, 35);
            btnAcercaDe.Margin = new Padding(4, 3, 4, 3);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new Size(292, 35);
            btnAcercaDe.TabIndex = 1;
            btnAcercaDe.Text = "Acerca de ";
            btnAcercaDe.UseVisualStyleBackColor = false;
            btnAcercaDe.Click += btnAcercaDe_Click;
            // 
            // btnPreguntas
            // 
            btnPreguntas.BackColor = Color.FromArgb(39, 66, 82);
            btnPreguntas.Dock = DockStyle.Top;
            btnPreguntas.FlatAppearance.BorderSize = 0;
            btnPreguntas.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnPreguntas.FlatStyle = FlatStyle.Flat;
            btnPreguntas.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreguntas.ForeColor = SystemColors.ButtonHighlight;
            btnPreguntas.Location = new Point(0, 0);
            btnPreguntas.Margin = new Padding(4, 3, 4, 3);
            btnPreguntas.Name = "btnPreguntas";
            btnPreguntas.Size = new Size(292, 35);
            btnPreguntas.TabIndex = 0;
            btnPreguntas.Text = "Preguntas Frecuentes";
            btnPreguntas.UseVisualStyleBackColor = false;
            btnPreguntas.Click += btnPreguntas_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.Dock = DockStyle.Bottom;
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 211, 119);
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAyuda.ForeColor = SystemColors.ButtonHighlight;
            btnAyuda.Image = Frontend.Properties.Resources.Manitosss;
            btnAyuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyuda.Location = new Point(0, 987);
            btnAyuda.Margin = new Padding(4, 3, 4, 3);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(292, 45);
            btnAyuda.TabIndex = 6;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // pnlSubMenuInforme
            // 
            pnlSubMenuInforme.BackColor = Color.FromArgb(26, 39, 48);
            pnlSubMenuInforme.Controls.Add(btnInformePedidos);
            pnlSubMenuInforme.Controls.Add(btnInformeProductos);
            pnlSubMenuInforme.Controls.Add(btnInformeClientes);
            pnlSubMenuInforme.Controls.Add(btnInformeVentas);
            pnlSubMenuInforme.Dock = DockStyle.Top;
            pnlSubMenuInforme.Location = new Point(0, 775);
            pnlSubMenuInforme.Margin = new Padding(4, 3, 4, 3);
            pnlSubMenuInforme.Name = "pnlSubMenuInforme";
            pnlSubMenuInforme.Size = new Size(292, 143);
            pnlSubMenuInforme.TabIndex = 15;
            // 
            // btnInformePedidos
            // 
            btnInformePedidos.BackColor = Color.FromArgb(39, 66, 82);
            btnInformePedidos.Dock = DockStyle.Top;
            btnInformePedidos.FlatAppearance.BorderSize = 0;
            btnInformePedidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnInformePedidos.FlatStyle = FlatStyle.Flat;
            btnInformePedidos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInformePedidos.ForeColor = SystemColors.ButtonHighlight;
            btnInformePedidos.Location = new Point(0, 105);
            btnInformePedidos.Margin = new Padding(4, 3, 4, 3);
            btnInformePedidos.Name = "btnInformePedidos";
            btnInformePedidos.Size = new Size(292, 35);
            btnInformePedidos.TabIndex = 3;
            btnInformePedidos.Text = "Pedidos";
            btnInformePedidos.UseVisualStyleBackColor = false;
            // 
            // btnInformeProductos
            // 
            btnInformeProductos.BackColor = Color.FromArgb(39, 66, 82);
            btnInformeProductos.Dock = DockStyle.Top;
            btnInformeProductos.FlatAppearance.BorderSize = 0;
            btnInformeProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnInformeProductos.FlatStyle = FlatStyle.Flat;
            btnInformeProductos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInformeProductos.ForeColor = SystemColors.ButtonHighlight;
            btnInformeProductos.Location = new Point(0, 70);
            btnInformeProductos.Margin = new Padding(4, 3, 4, 3);
            btnInformeProductos.Name = "btnInformeProductos";
            btnInformeProductos.Size = new Size(292, 35);
            btnInformeProductos.TabIndex = 2;
            btnInformeProductos.Text = "Productos";
            btnInformeProductos.UseVisualStyleBackColor = false;
            // 
            // btnInformeClientes
            // 
            btnInformeClientes.BackColor = Color.FromArgb(39, 66, 82);
            btnInformeClientes.Dock = DockStyle.Top;
            btnInformeClientes.FlatAppearance.BorderSize = 0;
            btnInformeClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnInformeClientes.FlatStyle = FlatStyle.Flat;
            btnInformeClientes.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInformeClientes.ForeColor = SystemColors.ButtonHighlight;
            btnInformeClientes.Location = new Point(0, 35);
            btnInformeClientes.Margin = new Padding(4, 3, 4, 3);
            btnInformeClientes.Name = "btnInformeClientes";
            btnInformeClientes.Size = new Size(292, 35);
            btnInformeClientes.TabIndex = 1;
            btnInformeClientes.Text = "Clientes";
            btnInformeClientes.UseVisualStyleBackColor = false;
            // 
            // btnInformeVentas
            // 
            btnInformeVentas.BackColor = Color.FromArgb(39, 66, 82);
            btnInformeVentas.Dock = DockStyle.Top;
            btnInformeVentas.FlatAppearance.BorderSize = 0;
            btnInformeVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnInformeVentas.FlatStyle = FlatStyle.Flat;
            btnInformeVentas.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInformeVentas.ForeColor = SystemColors.ButtonHighlight;
            btnInformeVentas.Location = new Point(0, 0);
            btnInformeVentas.Margin = new Padding(4, 3, 4, 3);
            btnInformeVentas.Name = "btnInformeVentas";
            btnInformeVentas.Size = new Size(292, 35);
            btnInformeVentas.TabIndex = 0;
            btnInformeVentas.Text = "Ventas";
            btnInformeVentas.UseVisualStyleBackColor = false;
            // 
            // btnInforme
            // 
            btnInforme.Dock = DockStyle.Top;
            btnInforme.FlatAppearance.BorderSize = 0;
            btnInforme.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 211, 130);
            btnInforme.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 211, 119);
            btnInforme.FlatStyle = FlatStyle.Flat;
            btnInforme.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInforme.ForeColor = SystemColors.ButtonHighlight;
            btnInforme.Image = Frontend.Properties.Resources.reportes1;
            btnInforme.ImageAlign = ContentAlignment.MiddleLeft;
            btnInforme.Location = new Point(0, 730);
            btnInforme.Margin = new Padding(4, 3, 4, 3);
            btnInforme.Name = "btnInforme";
            btnInforme.Size = new Size(292, 45);
            btnInforme.TabIndex = 5;
            btnInforme.Text = "Informes";
            btnInforme.UseVisualStyleBackColor = true;
            btnInforme.Click += btnInforme_Click;
            // 
            // pnlSubMenuPedido
            // 
            pnlSubMenuPedido.BackColor = Color.FromArgb(26, 39, 48);
            pnlSubMenuPedido.Controls.Add(btnConsultarPedido);
            pnlSubMenuPedido.Controls.Add(btnNuevoPedido);
            pnlSubMenuPedido.Dock = DockStyle.Top;
            pnlSubMenuPedido.Location = new Point(0, 652);
            pnlSubMenuPedido.Margin = new Padding(4, 3, 4, 3);
            pnlSubMenuPedido.Name = "pnlSubMenuPedido";
            pnlSubMenuPedido.Size = new Size(292, 78);
            pnlSubMenuPedido.TabIndex = 10;
            // 
            // btnConsultarPedido
            // 
            btnConsultarPedido.BackColor = Color.FromArgb(39, 66, 82);
            btnConsultarPedido.Dock = DockStyle.Top;
            btnConsultarPedido.FlatAppearance.BorderSize = 0;
            btnConsultarPedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnConsultarPedido.FlatStyle = FlatStyle.Flat;
            btnConsultarPedido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarPedido.ForeColor = SystemColors.ButtonHighlight;
            btnConsultarPedido.Location = new Point(0, 35);
            btnConsultarPedido.Margin = new Padding(4, 3, 4, 3);
            btnConsultarPedido.Name = "btnConsultarPedido";
            btnConsultarPedido.Size = new Size(292, 35);
            btnConsultarPedido.TabIndex = 1;
            btnConsultarPedido.Text = "Consultar Pedido";
            btnConsultarPedido.UseVisualStyleBackColor = false;
            btnConsultarPedido.Click += btnConsultarPedido_Click;
            // 
            // btnNuevoPedido
            // 
            btnNuevoPedido.BackColor = Color.FromArgb(39, 66, 82);
            btnNuevoPedido.Dock = DockStyle.Top;
            btnNuevoPedido.FlatAppearance.BorderSize = 0;
            btnNuevoPedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnNuevoPedido.FlatStyle = FlatStyle.Flat;
            btnNuevoPedido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoPedido.ForeColor = SystemColors.ButtonHighlight;
            btnNuevoPedido.Location = new Point(0, 0);
            btnNuevoPedido.Margin = new Padding(4, 3, 4, 3);
            btnNuevoPedido.Name = "btnNuevoPedido";
            btnNuevoPedido.Size = new Size(292, 35);
            btnNuevoPedido.TabIndex = 0;
            btnNuevoPedido.Text = "Nuevo Pedido";
            btnNuevoPedido.UseVisualStyleBackColor = false;
            btnNuevoPedido.Click += btnNuevoPedido_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Dock = DockStyle.Top;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 211, 130);
            btnPedidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 211, 119);
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPedidos.ForeColor = SystemColors.ButtonHighlight;
            btnPedidos.Image = Frontend.Properties.Resources.producto;
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(0, 607);
            btnPedidos.Margin = new Padding(4, 3, 4, 3);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(292, 45);
            btnPedidos.TabIndex = 4;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // pnlSubMenuProveedor
            // 
            pnlSubMenuProveedor.BackColor = Color.FromArgb(26, 39, 48);
            pnlSubMenuProveedor.Controls.Add(btnConsultarProveedor);
            pnlSubMenuProveedor.Controls.Add(btnAgregarProveedor);
            pnlSubMenuProveedor.Dock = DockStyle.Top;
            pnlSubMenuProveedor.Location = new Point(0, 529);
            pnlSubMenuProveedor.Margin = new Padding(4, 3, 4, 3);
            pnlSubMenuProveedor.Name = "pnlSubMenuProveedor";
            pnlSubMenuProveedor.Size = new Size(292, 78);
            pnlSubMenuProveedor.TabIndex = 8;
            // 
            // btnConsultarProveedor
            // 
            btnConsultarProveedor.BackColor = Color.FromArgb(39, 66, 82);
            btnConsultarProveedor.Dock = DockStyle.Top;
            btnConsultarProveedor.FlatAppearance.BorderSize = 0;
            btnConsultarProveedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnConsultarProveedor.FlatStyle = FlatStyle.Flat;
            btnConsultarProveedor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarProveedor.ForeColor = SystemColors.ButtonHighlight;
            btnConsultarProveedor.Location = new Point(0, 35);
            btnConsultarProveedor.Margin = new Padding(4, 3, 4, 3);
            btnConsultarProveedor.Name = "btnConsultarProveedor";
            btnConsultarProveedor.Size = new Size(292, 35);
            btnConsultarProveedor.TabIndex = 1;
            btnConsultarProveedor.Text = "Consultar Proveedor";
            btnConsultarProveedor.UseVisualStyleBackColor = false;
            btnConsultarProveedor.Click += btnConsultarProveedor_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.BackColor = Color.FromArgb(39, 66, 82);
            btnAgregarProveedor.Dock = DockStyle.Top;
            btnAgregarProveedor.FlatAppearance.BorderSize = 0;
            btnAgregarProveedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnAgregarProveedor.FlatStyle = FlatStyle.Flat;
            btnAgregarProveedor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProveedor.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarProveedor.Location = new Point(0, 0);
            btnAgregarProveedor.Margin = new Padding(4, 3, 4, 3);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(292, 35);
            btnAgregarProveedor.TabIndex = 0;
            btnAgregarProveedor.Text = "Agregar Proveedor";
            btnAgregarProveedor.UseVisualStyleBackColor = false;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.Dock = DockStyle.Top;
            btnProveedor.FlatAppearance.BorderSize = 0;
            btnProveedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 211, 130);
            btnProveedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 211, 119);
            btnProveedor.FlatStyle = FlatStyle.Flat;
            btnProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProveedor.ForeColor = SystemColors.ButtonHighlight;
            btnProveedor.Image = Frontend.Properties.Resources.compras2;
            btnProveedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedor.Location = new Point(0, 484);
            btnProveedor.Margin = new Padding(4, 3, 4, 3);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(292, 45);
            btnProveedor.TabIndex = 3;
            btnProveedor.Text = "Proveedores";
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // pnlSubMenuCliente
            // 
            pnlSubMenuCliente.BackColor = Color.FromArgb(26, 39, 48);
            pnlSubMenuCliente.Controls.Add(btnConsultarCliente);
            pnlSubMenuCliente.Controls.Add(btnAgregarCliente);
            pnlSubMenuCliente.Dock = DockStyle.Top;
            pnlSubMenuCliente.Location = new Point(0, 406);
            pnlSubMenuCliente.Margin = new Padding(4, 3, 4, 3);
            pnlSubMenuCliente.Name = "pnlSubMenuCliente";
            pnlSubMenuCliente.Size = new Size(292, 78);
            pnlSubMenuCliente.TabIndex = 6;
            // 
            // btnConsultarCliente
            // 
            btnConsultarCliente.BackColor = Color.FromArgb(39, 66, 82);
            btnConsultarCliente.Dock = DockStyle.Top;
            btnConsultarCliente.FlatAppearance.BorderSize = 0;
            btnConsultarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnConsultarCliente.FlatStyle = FlatStyle.Flat;
            btnConsultarCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnConsultarCliente.Location = new Point(0, 35);
            btnConsultarCliente.Margin = new Padding(4, 3, 4, 3);
            btnConsultarCliente.Name = "btnConsultarCliente";
            btnConsultarCliente.Size = new Size(292, 35);
            btnConsultarCliente.TabIndex = 1;
            btnConsultarCliente.Text = "Consultar Cliente";
            btnConsultarCliente.UseVisualStyleBackColor = false;
            btnConsultarCliente.Click += btnConsultarCliente_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.FromArgb(39, 66, 82);
            btnAgregarCliente.Dock = DockStyle.Top;
            btnAgregarCliente.FlatAppearance.BorderSize = 0;
            btnAgregarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnAgregarCliente.FlatStyle = FlatStyle.Flat;
            btnAgregarCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarCliente.Location = new Point(0, 0);
            btnAgregarCliente.Margin = new Padding(4, 3, 4, 3);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(292, 35);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnCliente
            // 
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 211, 130);
            btnCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 211, 119);
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCliente.ForeColor = SystemColors.ButtonHighlight;
            btnCliente.Image = Frontend.Properties.Resources.clientes1;
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.Location = new Point(0, 361);
            btnCliente.Margin = new Padding(4, 3, 4, 3);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(292, 45);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // pnlSubMenuProducto
            // 
            pnlSubMenuProducto.BackColor = Color.FromArgb(26, 39, 48);
            pnlSubMenuProducto.Controls.Add(btnConsultarProducto);
            pnlSubMenuProducto.Controls.Add(btnAgregarProducto);
            pnlSubMenuProducto.Dock = DockStyle.Top;
            pnlSubMenuProducto.Location = new Point(0, 283);
            pnlSubMenuProducto.Margin = new Padding(4, 3, 4, 3);
            pnlSubMenuProducto.Name = "pnlSubMenuProducto";
            pnlSubMenuProducto.Size = new Size(292, 78);
            pnlSubMenuProducto.TabIndex = 4;
            // 
            // btnConsultarProducto
            // 
            btnConsultarProducto.BackColor = Color.FromArgb(39, 66, 82);
            btnConsultarProducto.Dock = DockStyle.Top;
            btnConsultarProducto.FlatAppearance.BorderSize = 0;
            btnConsultarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnConsultarProducto.FlatStyle = FlatStyle.Flat;
            btnConsultarProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarProducto.ForeColor = SystemColors.ButtonHighlight;
            btnConsultarProducto.Location = new Point(0, 35);
            btnConsultarProducto.Margin = new Padding(4, 3, 4, 3);
            btnConsultarProducto.Name = "btnConsultarProducto";
            btnConsultarProducto.Size = new Size(292, 35);
            btnConsultarProducto.TabIndex = 1;
            btnConsultarProducto.Text = "Consultar Producto";
            btnConsultarProducto.UseVisualStyleBackColor = false;
            btnConsultarProducto.Click += btnConsultarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(39, 66, 82);
            btnAgregarProducto.Dock = DockStyle.Top;
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProducto.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarProducto.Location = new Point(0, 0);
            btnAgregarProducto.Margin = new Padding(4, 3, 4, 3);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(292, 35);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnProducto
            // 
            btnProducto.Dock = DockStyle.Top;
            btnProducto.FlatAppearance.BorderSize = 0;
            btnProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 211, 130);
            btnProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 211, 119);
            btnProducto.FlatStyle = FlatStyle.Flat;
            btnProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProducto.ForeColor = SystemColors.ButtonHighlight;
            btnProducto.Image = Frontend.Properties.Resources.venta2;
            btnProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducto.Location = new Point(0, 238);
            btnProducto.Margin = new Padding(4, 3, 4, 3);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(292, 45);
            btnProducto.TabIndex = 1;
            btnProducto.Text = "Productos";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += button1_Click;
            // 
            // pnlSubMenuVenta
            // 
            pnlSubMenuVenta.BackColor = Color.FromArgb(26, 39, 48);
            pnlSubMenuVenta.Controls.Add(btnConsultarVenta);
            pnlSubMenuVenta.Controls.Add(btnNuevaVenta);
            pnlSubMenuVenta.Dock = DockStyle.Top;
            pnlSubMenuVenta.Location = new Point(0, 160);
            pnlSubMenuVenta.Margin = new Padding(4, 3, 4, 3);
            pnlSubMenuVenta.Name = "pnlSubMenuVenta";
            pnlSubMenuVenta.Size = new Size(292, 78);
            pnlSubMenuVenta.TabIndex = 2;
            // 
            // btnConsultarVenta
            // 
            btnConsultarVenta.BackColor = Color.FromArgb(39, 66, 82);
            btnConsultarVenta.Dock = DockStyle.Top;
            btnConsultarVenta.FlatAppearance.BorderSize = 0;
            btnConsultarVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnConsultarVenta.FlatStyle = FlatStyle.Flat;
            btnConsultarVenta.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarVenta.ForeColor = SystemColors.ButtonHighlight;
            btnConsultarVenta.Location = new Point(0, 35);
            btnConsultarVenta.Margin = new Padding(4, 3, 4, 3);
            btnConsultarVenta.Name = "btnConsultarVenta";
            btnConsultarVenta.Size = new Size(292, 35);
            btnConsultarVenta.TabIndex = 1;
            btnConsultarVenta.Text = "Consultar Venta";
            btnConsultarVenta.UseVisualStyleBackColor = false;
            btnConsultarVenta.Click += btnConsultarVenta_Click_1;
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.BackColor = Color.FromArgb(39, 66, 82);
            btnNuevaVenta.Dock = DockStyle.Top;
            btnNuevaVenta.FlatAppearance.BorderSize = 0;
            btnNuevaVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 79);
            btnNuevaVenta.FlatStyle = FlatStyle.Flat;
            btnNuevaVenta.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevaVenta.ForeColor = SystemColors.ButtonHighlight;
            btnNuevaVenta.Location = new Point(0, 0);
            btnNuevaVenta.Margin = new Padding(4, 3, 4, 3);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Size = new Size(292, 35);
            btnNuevaVenta.TabIndex = 0;
            btnNuevaVenta.Text = "Nueva Venta";
            btnNuevaVenta.UseVisualStyleBackColor = false;
            btnNuevaVenta.Click += btnNuevaVenta_Click;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 211, 130);
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 211, 119);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.ForeColor = SystemColors.ButtonHighlight;
            btnVentas.Image = Frontend.Properties.Resources.pagos1;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 115);
            btnVentas.Margin = new Padding(4, 3, 4, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(292, 45);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(label3);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(4, 3, 4, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(292, 115);
            panelLogo.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 211, 119);
            label3.Location = new Point(95, 39);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 38);
            label3.TabIndex = 4;
            label3.Text = "APOTEK";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Frontend.Properties.Resources.Sin_titulotek;
            pictureBox1.Location = new Point(4, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Controls.Add(pictureBox2);
            panelContenedor.Controls.Add(panelMenuLateral);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 38);
            panelContenedor.Margin = new Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1538, 689);
            panelContenedor.TabIndex = 3;
            panelContenedor.Paint += panelContenedor_Paint_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 211, 119);
            label1.Location = new Point(749, 531);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(308, 27);
            label1.TabIndex = 2;
            label1.Text = "Tu Hogar de Salud y Bienestar";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Frontend.Properties.Resources.LoguetePRUEBA;
            pictureBox2.Location = new Point(719, 138);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(414, 392);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1538, 727);
            Controls.Add(panelContenedor);
            Controls.Add(barraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPRINCIPAL";
            barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHerramientas).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panelMenuLateral.ResumeLayout(false);
            pnlSubMenuAyuda.ResumeLayout(false);
            pnlSubMenuInforme.ResumeLayout(false);
            pnlSubMenuPedido.ResumeLayout(false);
            pnlSubMenuProveedor.ResumeLayout(false);
            pnlSubMenuCliente.ResumeLayout(false);
            pnlSubMenuProducto.ResumeLayout(false);
            pnlSubMenuVenta.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel barraTitulo;
        private PictureBox btnCerrar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
        private PictureBox btnRestaurar;
        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox btnUsuario;
        private PictureBox btnHerramientas;
        private Panel panelContenedor;
        private Panel panelMenuLateral;
        private Panel pnlSubMenuAyuda;
        private Button btnAcercaDe;
        private Button btnPreguntas;
        private Button btnAyuda;
        private Panel pnlSubMenuInforme;
        private Button btnInformeClientes;
        private Button btnInformeVentas;
        private Button btnInforme;
        private Panel pnlSubMenuPedido;
        private Button btnConsultarPedido;
        private Button btnNuevoPedido;
        private Button btnPedidos;
        private Panel pnlSubMenuProveedor;
        private Button btnConsultarProveedor;
        private Button btnAgregarProveedor;
        private Button btnProveedor;
        private Panel pnlSubMenuCliente;
        private Button btnConsultarCliente;
        private Button btnAgregarCliente;
        private Button btnCliente;
        private Panel pnlSubMenuProducto;
        private Button btnConsultarProducto;
        private Button btnAgregarProducto;
        private Button btnProducto;
        private Panel pnlSubMenuVenta;
        private Button btnConsultarVenta;
        private Button btnNuevaVenta;
        private Button btnVentas;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button btnInformePedidos;
        private Button btnInformeProductos;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label3;
    }
}