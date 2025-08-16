using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExamenBrayanDaniel
{
    public partial class Form1 : Form
    {
        // ====== Modelos ======
        private class Producto
        {
            public string Categoria { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public override string ToString() => Nombre;
        }

        private class Linea
        {
            public string Descripcion { get; set; }
            public int Cantidad { get; set; }
            public decimal Importe { get; set; }
        }

        // C# 7.3: inicialización explícita (sin target-typed new)
        private readonly List<Producto> _catalogo = new List<Producto>();
        private readonly List<Linea> _carrito = new List<Linea>();

        // Extras
        private const decimal EXTRA_QUESO = 8m;
        private const decimal EXTRA_BACON = 12m;
        private const decimal EXTRA_SALSA = 3m;
        private const decimal EXTRA_PAN = 5m;

        // Servicio (cargo por pedido)
        private const decimal SERVICIO_LLEVAR = 0m;
        private const decimal SERVICIO_MESA = 5m;
        private const decimal SERVICIO_DOMICILIO = 15m;

        public Form1()
        {
            InitializeComponent();
            CargarCatalogo();
            CargarCombos();
            nudCantidad.Minimum = 1;
            nudCantidad.Value = 2;
            ActualizarPrecioUnitario();
            ActualizarTotales();
        }

        // ====== Catálogo ======
        private void CargarCatalogo()
        {
            _catalogo.AddRange(new Producto[]
            {
                new Producto{ Categoria="Comidas", Nombre="Sandwich",    Precio=35m },
                new Producto{ Categoria="Comidas", Nombre="Hamburguesa", Precio=45m },
                new Producto{ Categoria="Bebidas", Nombre="Café",        Precio=15m },
                new Producto{ Categoria="Bebidas", Nombre="Té",          Precio=12m },
            });
        }

        private void CargarCombos()
        {
            cboCategoria.Items.Clear();
            foreach (var cat in _catalogo.Select(c => c.Categoria).Distinct())
                cboCategoria.Items.Add(cat);
            if (cboCategoria.Items.Count > 0)
                cboCategoria.SelectedIndex = 0;
        }

        private void LlenarProductosPorCategoria()
        {
            cboProducto.Items.Clear();
            var cat = cboCategoria.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(cat)) return;

            foreach (var p in _catalogo.Where(p => p.Categoria == cat))
                cboProducto.Items.Add(p);

            if (cboProducto.Items.Count > 0)
                cboProducto.SelectedIndex = 0;
        }

        // ====== Lecturas y cálculos ======
        private Producto ProductoSeleccionado
        {
            get { return cboProducto.SelectedItem as Producto; }
        }

        private decimal PrecioUnitarioBase
        {
            get { return ProductoSeleccionado != null ? ProductoSeleccionado.Precio : 0m; }
        }

        private decimal CostoExtrasSeleccionados()
        {
            decimal e = 0m;
            if (cbQueso.Checked) e += EXTRA_QUESO;
            if (cbBacon.Checked) e += EXTRA_BACON;
            if (cbSalsa.Checked) e += EXTRA_SALSA;
            if (cbPanIntegral.Checked) e += EXTRA_PAN;
            return e; // sin cebolla no suma
        }

        private decimal PorcentajeDescuento()
        {
            if (chkEmpleado.Checked) return 0.25m;
            if (chkProfesor.Checked) return 0.20m;
            if (chkEstudiante.Checked) return 0.15m;
            return 0m;
        }

        private decimal CargoServicio()
        {
            if (rbMesa.Checked) return SERVICIO_MESA;
            if (rbDomicilio.Checked) return SERVICIO_DOMICILIO;
            // Si nada está seleccionado (no debería ocurrir), tomar "para llevar"
            return SERVICIO_LLEVAR;
        }

        private void ActualizarPrecioUnitario()
        {
            var unitario = PrecioUnitarioBase + CostoExtrasSeleccionados();
            lblPrecio.Text = string.Format("Precio: ${0:0.00}", unitario);
        }

        private void ActualizarTotales()
        {
            decimal subtotal = 0m;
            foreach (var l in _carrito) subtotal += l.Importe;

            decimal descuento = Math.Round(subtotal * PorcentajeDescuento(), 2, MidpointRounding.AwayFromZero);
            decimal servicio = CargoServicio();
            decimal total = subtotal - descuento + servicio;

            lblSubtotal.Text = string.Format("${0:0.00}", subtotal);
            lblDescuento.Text = string.Format("-${0:0.00}", descuento);
            lblServicio.Text = string.Format("+${0:0.00}", servicio);
            lblTotal.Text = string.Format("${0:0.00}", total);

            int piezas = 0;
            foreach (var l in _carrito) piezas += l.Cantidad;
            lblTotalProductos.Text = "Total de productos: " + piezas;
        }

        private void RefrescarLista()
        {
            lstResumen.Items.Clear();
            foreach (var l in _carrito)
                lstResumen.Items.Add(string.Format("{0}  x{1}   ${2:0.00}", l.Descripcion, l.Cantidad, l.Importe));
        }

        // ====== Eventos ======
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarProductosPorCategoria();
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarExtrasVisual();
            ActualizarPrecioUnitario();
        }

        private void CostoCambia(object sender, EventArgs e)
        {
            ActualizarPrecioUnitario();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (nudCantidad.Value < 1000) nudCantidad.Value += 1;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (nudCantidad.Value > 1) nudCantidad.Value -= 1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ProductoSeleccionado == null) return;

            var extras = new List<string>();
            if (cbQueso.Checked) extras.Add("Queso");
            if (cbBacon.Checked) extras.Add("Bacon");
            if (cbSalsa.Checked) extras.Add("Salsa");
            if (cbPanIntegral.Checked) extras.Add("Pan integral");
            if (cbSinCebolla.Checked) extras.Add("Sin cebolla");

            decimal unitario = PrecioUnitarioBase + CostoExtrasSeleccionados();
            int qty = (int)nudCantidad.Value;
            decimal importe = unitario * qty;

            string desc = ProductoSeleccionado.Nombre;
            if (extras.Count > 0) desc += " (Extras: " + string.Join(", ", extras) + ")";

            _carrito.Add(new Linea
            {
                Descripcion = desc,
                Cantidad = qty,
                Importe = importe
            });

            RefrescarLista();
            ActualizarTotales();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarSeleccionProducto();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtMesa.Clear();

            // defaults
            rbLlevar.Checked = true;
            rbEfectivo.Checked = true;

            _carrito.Clear();
            RefrescarLista();
            ActualizarTotales();
        }

        private void Servicio_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }

        private void Descuento_CheckedChanged(object sender, EventArgs e)
        {
            // forzar “solo uno”
            CheckBox me = sender as CheckBox;
            if (me != null && me.Checked)
            {
                CheckBox[] all = new CheckBox[] { chkEstudiante, chkProfesor, chkEmpleado };
                foreach (var cb in all) if (!object.ReferenceEquals(cb, me)) cb.Checked = false;
            }
            ActualizarTotales();
        }

        // ====== util ======
        private void LimpiarSeleccionProducto()
        {
            nudCantidad.Value = 1;
            txtObs.Clear();
            LimpiarExtrasVisual();
            ActualizarPrecioUnitario();
        }

        private void LimpiarExtrasVisual()
        {
            cbQueso.Checked = false;
            cbBacon.Checked = false;
            cbSalsa.Checked = false;
            cbPanIntegral.Checked = false;
            cbSinCebolla.Checked = false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Lee valores ya calculados en tu UI
            string cliente = txtNombre.Text;
            string mesa = string.IsNullOrWhiteSpace(txtMesa.Text) ? "—" : txtMesa.Text;

            string servicio = rbLlevar.Checked ? "Para llevar"
                             : rbMesa.Checked ? "Mesa"
                             : rbDomicilio.Checked ? "Domicilio"
                             : "—";

            string metodo = rbEfectivo.Checked ? "Efectivo"
                           : rbTarjeta.Checked ? "Tarjeta"
                           : "—";

            // Toma las líneas del ListBox
            var lineas = new List<string>();
            foreach (var it in lstResumen.Items)
                lineas.Add(it.ToString());

            // Parseo sencillo de labels tipo "$0.00"
            decimal ParseMoney(string s)
            {
                if (string.IsNullOrWhiteSpace(s)) return 0m;
                s = s.Replace("+", "").Replace("$", "").Trim();
                decimal v;
                return decimal.TryParse(s, out v) ? v : 0m;
            }

            decimal subtotal = ParseMoney(lblSubtotal.Text);
            decimal descuento = Math.Abs(ParseMoney(lblDescuento.Text));
            decimal cargoServ = ParseMoney(lblServicio.Text);
            decimal total = ParseMoney(lblTotal.Text);

            var data = new TicketData
            {
                Comercio = "CAFETERÍA",
                Cliente = string.IsNullOrWhiteSpace(cliente) ? "—" : cliente,
                Mesa = mesa,
                Servicio = servicio,
                MetodoPago = metodo,
                Fecha = DateTime.Now,
                Lineas = lineas,
                Subtotal = subtotal,
                Descuento = descuento,
                ServicioCargo = cargoServ,
                Total = total,
                Notas = ""
            };

            using (var tf = new TicketForm(data))
            {
                tf.ShowDialog(this);
            }

            // ===== LIMPIAR TODO =====
            txtNombre.Clear();
            txtMesa.Clear();

            rbLlevar.Checked = true;   // servicio por defecto
            rbEfectivo.Checked = true; // pago por defecto

            cbQueso.Checked = false;
            cbBacon.Checked = false;
            cbSalsa.Checked = false;
            cbPanIntegral.Checked = false;
            cbSinCebolla.Checked = false;

            txtObs.Clear();
            nudCantidad.Value = 1;

            chkEstudiante.Checked = false;
            chkProfesor.Checked = false;
            chkEmpleado.Checked = false;

            lstResumen.Items.Clear();
            lblSubtotal.Text = "$0.00";
            lblDescuento.Text = "-$0.00";
            lblServicio.Text = "+$0.00";
            lblTotal.Text = "$0.00";
            lblTotalProductos.Text = "Total de productos: 0";
        }

        private void lblTagline_Click(object sender, EventArgs e)
        {

        }
    }
}
