namespace ExamenBrayanDaniel
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // NUEVOS componentes visuales
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLeft;
        private System.Windows.Forms.ToolStripStatusLabel statusRight;
        private System.Windows.Forms.ToolTip toolTip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.pnlPago = new System.Windows.Forms.Panel();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.pnlServicio = new System.Windows.Forms.Panel();
            this.rbDomicilio = new System.Windows.Forms.RadioButton();
            this.rbMesa = new System.Windows.Forms.RadioButton();
            this.rbLlevar = new System.Windows.Forms.RadioButton();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbSinCebolla = new System.Windows.Forms.CheckBox();
            this.cbPanIntegral = new System.Windows.Forms.CheckBox();
            this.cbSalsa = new System.Windows.Forms.CheckBox();
            this.cbBacon = new System.Windows.Forms.CheckBox();
            this.cbQueso = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpResumen = new System.Windows.Forms.GroupBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.panelTotales = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.grpDescuentos = new System.Windows.Forms.GroupBox();
            this.chkEmpleado = new System.Windows.Forms.CheckBox();
            this.chkProfesor = new System.Windows.Forms.CheckBox();
            this.chkEstudiante = new System.Windows.Forms.CheckBox();
            this.grpProductosPedido = new System.Windows.Forms.GroupBox();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.lstResumen = new System.Windows.Forms.ListBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpCliente.SuspendLayout();
            this.pnlPago.SuspendLayout();
            this.pnlServicio.SuspendLayout();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.grpResumen.SuspendLayout();
            this.panelTotales.SuspendLayout();
            this.grpDescuentos.SuspendLayout();
            this.grpProductosPedido.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCliente
            // 
            this.grpCliente.BackColor = System.Drawing.Color.White;
            this.grpCliente.Controls.Add(this.pnlPago);
            this.grpCliente.Controls.Add(this.pnlServicio);
            this.grpCliente.Controls.Add(this.btnLimpiarCliente);
            this.grpCliente.Controls.Add(this.label6);
            this.grpCliente.Controls.Add(this.label3);
            this.grpCliente.Controls.Add(this.txtMesa);
            this.grpCliente.Controls.Add(this.label2);
            this.grpCliente.Controls.Add(this.txtNombre);
            this.grpCliente.Controls.Add(this.label1);
            this.grpCliente.Location = new System.Drawing.Point(12, 82);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.grpCliente.Size = new System.Drawing.Size(340, 430);
            this.grpCliente.TabIndex = 0;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Información del Cliente";
            // 
            // pnlPago
            // 
            this.pnlPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPago.Controls.Add(this.rbTarjeta);
            this.pnlPago.Controls.Add(this.rbEfectivo);
            this.pnlPago.Location = new System.Drawing.Point(20, 300);
            this.pnlPago.Name = "pnlPago";
            this.pnlPago.Size = new System.Drawing.Size(300, 36);
            this.pnlPago.TabIndex = 13;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Location = new System.Drawing.Point(100, 8);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(60, 19);
            this.rbTarjeta.TabIndex = 1;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Checked = true;
            this.rbEfectivo.Location = new System.Drawing.Point(10, 8);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(67, 19);
            this.rbEfectivo.TabIndex = 0;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // pnlServicio
            // 
            this.pnlServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlServicio.Controls.Add(this.rbDomicilio);
            this.pnlServicio.Controls.Add(this.rbMesa);
            this.pnlServicio.Controls.Add(this.rbLlevar);
            this.pnlServicio.Location = new System.Drawing.Point(20, 188);
            this.pnlServicio.Name = "pnlServicio";
            this.pnlServicio.Size = new System.Drawing.Size(300, 78);
            this.pnlServicio.TabIndex = 12;
            // 
            // rbDomicilio
            // 
            this.rbDomicilio.AutoSize = true;
            this.rbDomicilio.Location = new System.Drawing.Point(10, 50);
            this.rbDomicilio.Name = "rbDomicilio";
            this.rbDomicilio.Size = new System.Drawing.Size(128, 19);
            this.rbDomicilio.TabIndex = 2;
            this.rbDomicilio.Text = "Domicilio (+$15.00)";
            this.rbDomicilio.UseVisualStyleBackColor = true;
            this.rbDomicilio.CheckedChanged += new System.EventHandler(this.Servicio_CheckedChanged);
            // 
            // rbMesa
            // 
            this.rbMesa.AutoSize = true;
            this.rbMesa.Location = new System.Drawing.Point(10, 28);
            this.rbMesa.Name = "rbMesa";
            this.rbMesa.Size = new System.Drawing.Size(99, 19);
            this.rbMesa.TabIndex = 1;
            this.rbMesa.Text = "Mesa (+$5.00)";
            this.rbMesa.UseVisualStyleBackColor = true;
            this.rbMesa.CheckedChanged += new System.EventHandler(this.Servicio_CheckedChanged);
            // 
            // rbLlevar
            // 
            this.rbLlevar.AutoSize = true;
            this.rbLlevar.Checked = true;
            this.rbLlevar.Location = new System.Drawing.Point(10, 6);
            this.rbLlevar.Name = "rbLlevar";
            this.rbLlevar.Size = new System.Drawing.Size(140, 19);
            this.rbLlevar.TabIndex = 0;
            this.rbLlevar.TabStop = true;
            this.rbLlevar.Text = "Para llevar (Sin Costo)";
            this.rbLlevar.UseVisualStyleBackColor = true;
            this.rbLlevar.CheckedChanged += new System.EventHandler(this.Servicio_CheckedChanged);
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.BackColor = System.Drawing.Color.SlateGray;
            this.btnLimpiarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCliente.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCliente.Location = new System.Drawing.Point(20, 360);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(300, 36);
            this.btnLimpiarCliente.TabIndex = 11;
            this.btnLimpiarCliente.Text = "LIMPIAR CLIENTE";
            this.toolTip.SetToolTip(this.btnLimpiarCliente, "Limpia datos del cliente y reinicia el pedido");
            this.btnLimpiarCliente.UseVisualStyleBackColor = false;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(17, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Método de Pago:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Servicio:";
            // 
            // txtMesa
            // 
            this.txtMesa.Location = new System.Drawing.Point(20, 132);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Size = new System.Drawing.Size(300, 23);
            this.txtMesa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de Mesa:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(20, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Cliente:";
            // 
            // grpProducto
            // 
            this.grpProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpProducto.BackColor = System.Drawing.Color.White;
            this.grpProducto.Controls.Add(this.btnLimpiar);
            this.grpProducto.Controls.Add(this.btnAgregar);
            this.grpProducto.Controls.Add(this.txtObs);
            this.grpProducto.Controls.Add(this.label13);
            this.grpProducto.Controls.Add(this.cbSinCebolla);
            this.grpProducto.Controls.Add(this.cbPanIntegral);
            this.grpProducto.Controls.Add(this.cbSalsa);
            this.grpProducto.Controls.Add(this.cbBacon);
            this.grpProducto.Controls.Add(this.cbQueso);
            this.grpProducto.Controls.Add(this.label12);
            this.grpProducto.Controls.Add(this.nudCantidad);
            this.grpProducto.Controls.Add(this.btnMas);
            this.grpProducto.Controls.Add(this.btnMenos);
            this.grpProducto.Controls.Add(this.lblPrecio);
            this.grpProducto.Controls.Add(this.label8);
            this.grpProducto.Controls.Add(this.cboProducto);
            this.grpProducto.Controls.Add(this.label7);
            this.grpProducto.Controls.Add(this.cboCategoria);
            this.grpProducto.Controls.Add(this.label5);
            this.grpProducto.Location = new System.Drawing.Point(366, 82);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.grpProducto.Size = new System.Drawing.Size(440, 430);
            this.grpProducto.TabIndex = 1;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Selección de Productos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Peru;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(226, 370);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(188, 36);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "LIMPIAR";
            this.toolTip.SetToolTip(this.btnLimpiar, "Limpia selección y extras");
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(26, 370);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 36);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "AGREGAR";
            this.toolTip.SetToolTip(this.btnAgregar, "Agregar producto al pedido");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(26, 284);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(388, 23);
            this.txtObs.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(23, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 22);
            this.label13.TabIndex = 15;
            this.label13.Text = "Observaciones:";
            // 
            // cbSinCebolla
            // 
            this.cbSinCebolla.AutoSize = true;
            this.cbSinCebolla.Location = new System.Drawing.Point(214, 232);
            this.cbSinCebolla.Name = "cbSinCebolla";
            this.cbSinCebolla.Size = new System.Drawing.Size(83, 19);
            this.cbSinCebolla.TabIndex = 14;
            this.cbSinCebolla.Text = "Sin cebolla";
            this.cbSinCebolla.UseVisualStyleBackColor = true;
            // 
            // cbPanIntegral
            // 
            this.cbPanIntegral.AutoSize = true;
            this.cbPanIntegral.Location = new System.Drawing.Point(26, 232);
            this.cbPanIntegral.Name = "cbPanIntegral";
            this.cbPanIntegral.Size = new System.Drawing.Size(120, 19);
            this.cbPanIntegral.TabIndex = 13;
            this.cbPanIntegral.Text = "Pan integral (+$5)";
            this.cbPanIntegral.UseVisualStyleBackColor = true;
            this.cbPanIntegral.CheckedChanged += new System.EventHandler(this.CostoCambia);
            // 
            // cbSalsa
            // 
            this.cbSalsa.AutoSize = true;
            this.cbSalsa.Location = new System.Drawing.Point(214, 207);
            this.cbSalsa.Name = "cbSalsa";
            this.cbSalsa.Size = new System.Drawing.Size(83, 19);
            this.cbSalsa.TabIndex = 12;
            this.cbSalsa.Text = "Salsa (+$3)";
            this.cbSalsa.UseVisualStyleBackColor = true;
            this.cbSalsa.CheckedChanged += new System.EventHandler(this.CostoCambia);
            // 
            // cbBacon
            // 
            this.cbBacon.AutoSize = true;
            this.cbBacon.Location = new System.Drawing.Point(26, 207);
            this.cbBacon.Name = "cbBacon";
            this.cbBacon.Size = new System.Drawing.Size(96, 19);
            this.cbBacon.TabIndex = 11;
            this.cbBacon.Text = "Bacon (+$12)";
            this.cbBacon.UseVisualStyleBackColor = true;
            this.cbBacon.CheckedChanged += new System.EventHandler(this.CostoCambia);
            // 
            // cbQueso
            // 
            this.cbQueso.AutoSize = true;
            this.cbQueso.Location = new System.Drawing.Point(26, 182);
            this.cbQueso.Name = "cbQueso";
            this.cbQueso.Size = new System.Drawing.Size(91, 19);
            this.cbQueso.TabIndex = 10;
            this.cbQueso.Text = "Queso (+$8)";
            this.cbQueso.UseVisualStyleBackColor = true;
            this.cbQueso.CheckedChanged += new System.EventHandler(this.CostoCambia);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(23, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 22);
            this.label12.TabIndex = 9;
            this.label12.Text = "Extras Disponibles:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(186, 122);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(60, 23);
            this.nudCantidad.TabIndex = 8;
            this.nudCantidad.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCantidad.ValueChanged += new System.EventHandler(this.CostoCambia);
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(252, 121);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(30, 25);
            this.btnMas.TabIndex = 7;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(150, 121);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(30, 25);
            this.btnMenos.TabIndex = 6;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.Honeydew;
            this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(26, 80);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(388, 30);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio: $35.00";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(23, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cantidad:";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.Location = new System.Drawing.Point(296, 42);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(118, 23);
            this.cboProducto.TabIndex = 3;
            this.toolTip.SetToolTip(this.cboProducto, "Selecciona el producto");
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(234, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Producto:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Location = new System.Drawing.Point(112, 42);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(118, 23);
            this.cboCategoria.TabIndex = 1;
            this.toolTip.SetToolTip(this.cboCategoria, "Filtra productos por categoría");
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Categoría:";
            // 
            // grpResumen
            // 
            this.grpResumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResumen.BackColor = System.Drawing.Color.White;
            this.grpResumen.Controls.Add(this.btnPagar);
            this.grpResumen.Controls.Add(this.panelTotales);
            this.grpResumen.Controls.Add(this.grpDescuentos);
            this.grpResumen.Controls.Add(this.grpProductosPedido);
            this.grpResumen.Location = new System.Drawing.Point(820, 82);
            this.grpResumen.Name = "grpResumen";
            this.grpResumen.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.grpResumen.Size = new System.Drawing.Size(348, 430);
            this.grpResumen.TabIndex = 2;
            this.grpResumen.TabStop = false;
            this.grpResumen.Text = "Resumen del Pedido";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(15, 382);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(316, 36);
            this.btnPagar.TabIndex = 18;
            this.btnPagar.Text = "PAGAR";
            this.toolTip.SetToolTip(this.btnPagar, "Generar ticket y finalizar pedido");
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // panelTotales
            // 
            this.panelTotales.BackColor = System.Drawing.Color.Honeydew;
            this.panelTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotales.Controls.Add(this.lblTotal);
            this.panelTotales.Controls.Add(this.label21);
            this.panelTotales.Controls.Add(this.lblServicio);
            this.panelTotales.Controls.Add(this.label19);
            this.panelTotales.Controls.Add(this.lblDescuento);
            this.panelTotales.Controls.Add(this.label17);
            this.panelTotales.Controls.Add(this.lblSubtotal);
            this.panelTotales.Controls.Add(this.label15);
            this.panelTotales.Location = new System.Drawing.Point(15, 268);
            this.panelTotales.Name = "panelTotales";
            this.panelTotales.Size = new System.Drawing.Size(316, 106);
            this.panelTotales.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(184, 74);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(114, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(14, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 20);
            this.label21.TabIndex = 6;
            this.label21.Text = "TOTAL:";
            // 
            // lblServicio
            // 
            this.lblServicio.Location = new System.Drawing.Point(190, 52);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(108, 15);
            this.lblServicio.TabIndex = 5;
            this.lblServicio.Text = "+$0.00";
            this.lblServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(14, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 15);
            this.label19.TabIndex = 4;
            this.label19.Text = "Servicio:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Location = new System.Drawing.Point(190, 30);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(108, 15);
            this.lblDescuento.TabIndex = 3;
            this.lblDescuento.Text = "-$0.00";
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(14, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "Descuento:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Location = new System.Drawing.Point(190, 8);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(108, 15);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "$0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(14, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Subtotal:";
            // 
            // grpDescuentos
            // 
            this.grpDescuentos.Controls.Add(this.chkEmpleado);
            this.grpDescuentos.Controls.Add(this.chkProfesor);
            this.grpDescuentos.Controls.Add(this.chkEstudiante);
            this.grpDescuentos.Location = new System.Drawing.Point(15, 160);
            this.grpDescuentos.Name = "grpDescuentos";
            this.grpDescuentos.Size = new System.Drawing.Size(316, 102);
            this.grpDescuentos.TabIndex = 1;
            this.grpDescuentos.TabStop = false;
            this.grpDescuentos.Text = "Descuentos Disponibles";
            // 
            // chkEmpleado
            // 
            this.chkEmpleado.AutoSize = true;
            this.chkEmpleado.Location = new System.Drawing.Point(17, 72);
            this.chkEmpleado.Name = "chkEmpleado";
            this.chkEmpleado.Size = new System.Drawing.Size(112, 19);
            this.chkEmpleado.TabIndex = 2;
            this.chkEmpleado.Text = "Empleado (25%)";
            this.chkEmpleado.UseVisualStyleBackColor = true;
            this.chkEmpleado.CheckedChanged += new System.EventHandler(this.Descuento_CheckedChanged);
            // 
            // chkProfesor
            // 
            this.chkProfesor.AutoSize = true;
            this.chkProfesor.Location = new System.Drawing.Point(17, 47);
            this.chkProfesor.Name = "chkProfesor";
            this.chkProfesor.Size = new System.Drawing.Size(103, 19);
            this.chkProfesor.TabIndex = 1;
            this.chkProfesor.Text = "Profesor (20%)";
            this.chkProfesor.UseVisualStyleBackColor = true;
            this.chkProfesor.CheckedChanged += new System.EventHandler(this.Descuento_CheckedChanged);
            // 
            // chkEstudiante
            // 
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.Location = new System.Drawing.Point(17, 22);
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.Size = new System.Drawing.Size(114, 19);
            this.chkEstudiante.TabIndex = 0;
            this.chkEstudiante.Text = "Estudiante (15%)";
            this.chkEstudiante.UseVisualStyleBackColor = true;
            this.chkEstudiante.CheckedChanged += new System.EventHandler(this.Descuento_CheckedChanged);
            // 
            // grpProductosPedido
            // 
            this.grpProductosPedido.Controls.Add(this.lblTotalProductos);
            this.grpProductosPedido.Controls.Add(this.lstResumen);
            this.grpProductosPedido.Location = new System.Drawing.Point(15, 22);
            this.grpProductosPedido.Name = "grpProductosPedido";
            this.grpProductosPedido.Size = new System.Drawing.Size(316, 132);
            this.grpProductosPedido.TabIndex = 0;
            this.grpProductosPedido.TabStop = false;
            this.grpProductosPedido.Text = "Productos en el pedido";
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.Location = new System.Drawing.Point(169, 16);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(130, 15);
            this.lblTotalProductos.TabIndex = 1;
            this.lblTotalProductos.Text = "Total de productos: 0";
            this.lblTotalProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstResumen
            // 
            this.lstResumen.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstResumen.FormattingEnabled = true;
            this.lstResumen.HorizontalScrollbar = true;
            this.lstResumen.ItemHeight = 14;
            this.lstResumen.Location = new System.Drawing.Point(17, 34);
            this.lstResumen.Name = "lstResumen";
            this.lstResumen.Size = new System.Drawing.Size(282, 74);
            this.lstResumen.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Controls.Add(this.lblBrand);
            this.panelHeader.Controls.Add(this.lblTagline);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.panelHeader.Size = new System.Drawing.Size(1180, 70);
            this.panelHeader.TabIndex = 1000;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogo.Image = global::ExamenBrayanDaniel.Properties.Resources._360_F_483160952_bYB2DOjUdsuB33gTXodCnnn8qDMxtSkl;
            this.pictureBoxLogo.Location = new System.Drawing.Point(14, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(76, 10);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(234, 30);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Nube y Canela — POS";
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTagline.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTagline.Location = new System.Drawing.Point(79, 40);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(130, 19);
            this.lblTagline.TabIndex = 2;
            this.lblTagline.Text = "Rápido, claro y listo.";
            this.lblTagline.Click += new System.EventHandler(this.lblTagline_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLeft,
            this.statusRight});
            this.statusStrip.Location = new System.Drawing.Point(0, 538);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1180, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1001;
            // 
            // statusLeft
            // 
            this.statusLeft.Name = "statusLeft";
            this.statusLeft.Size = new System.Drawing.Size(376, 17);
            this.statusLeft.Text = "© 2025 Nube y Canela — Autor: Brian Daniel González Flores | IME 221";
            // 
            // statusRight
            // 
            this.statusRight.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusRight.Name = "statusRight";
            this.statusRight.Size = new System.Drawing.Size(95, 17);
            this.statusRight.Text = "2025-08-15 20:34";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1180, 560);
            this.Controls.Add(this.grpResumen);
            this.Controls.Add(this.grpProducto);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta - Nube y Canela";
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.pnlPago.ResumeLayout(false);
            this.pnlPago.PerformLayout();
            this.pnlServicio.ResumeLayout(false);
            this.pnlServicio.PerformLayout();
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.grpResumen.ResumeLayout(false);
            this.panelTotales.ResumeLayout(false);
            this.grpDescuentos.ResumeLayout(false);
            this.grpDescuentos.PerformLayout();
            this.grpProductosPedido.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.TextBox txtMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiarCliente;

        private System.Windows.Forms.Panel pnlServicio;
        private System.Windows.Forms.RadioButton rbDomicilio;
        private System.Windows.Forms.RadioButton rbMesa;
        private System.Windows.Forms.RadioButton rbLlevar;

        private System.Windows.Forms.Panel pnlPago;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.RadioButton rbEfectivo;

        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.CheckBox cbQueso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbSinCebolla;
        private System.Windows.Forms.CheckBox cbPanIntegral;
        private System.Windows.Forms.CheckBox cbSalsa;
        private System.Windows.Forms.CheckBox cbBacon;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;

        private System.Windows.Forms.GroupBox grpResumen;
        private System.Windows.Forms.GroupBox grpProductosPedido;
        private System.Windows.Forms.ListBox lstResumen;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.GroupBox grpDescuentos;
        private System.Windows.Forms.CheckBox chkEmpleado;
        private System.Windows.Forms.CheckBox chkProfesor;
        private System.Windows.Forms.CheckBox chkEstudiante;
        private System.Windows.Forms.Panel panelTotales;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnPagar;
    }
}
