using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ExamenBrayanDaniel
{
    // Datos mínimos para renderizar el ticket sin depender del POS
    public class TicketData
    {
        public string Comercio { get; set; }           // Ej: "CAFETERÍA XYZ"
        public string Cliente { get; set; }            // Nombre cliente
        public string Mesa { get; set; }               // "—" si no aplica
        public string Servicio { get; set; }           // Llevar / Mesa / Domicilio
        public string MetodoPago { get; set; }         // Efectivo / Tarjeta
        public DateTime Fecha { get; set; }            // DateTime.Now
        public List<string> Lineas { get; set; }       // Líneas ya formateadas (xN  $importe)
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal ServicioCargo { get; set; }
        public decimal Total { get; set; }
        public string Notas { get; set; }            
    }

    public partial class TicketForm : Form
    {
        private readonly TicketData _data;

        public TicketForm(TicketData data)
        {
            _data = data ?? new TicketData { Lineas = new List<string>(), Fecha = DateTime.Now };
            InitializeComponent();
            Render();
        }

        private void Render()
        {
            var sb = new StringBuilder();
            string comercio = string.IsNullOrWhiteSpace(_data.Comercio) ? "CAFETERÍA" : _data.Comercio;

            sb.AppendLine(Centrar(comercio.ToUpper()));
            sb.AppendLine(Centrar("Ticket de compra"));
            sb.AppendLine(Centrar(_data.Fecha.ToString("yyyy-MM-dd HH:mm")));
            sb.AppendLine(new string('-', 32));

            sb.AppendLine($"Cliente : {_data.Cliente ?? "—"}");
            sb.AppendLine($"Mesa    : {(!string.IsNullOrWhiteSpace(_data.Mesa) ? _data.Mesa : "—")}");
            sb.AppendLine($"Servicio: {(_data.Servicio ?? "—")}");
            sb.AppendLine($"Pago    : {(_data.MetodoPago ?? "—")}");
            sb.AppendLine(new string('-', 32));

            // Encabezado de ítems
            sb.AppendLine("DESC                       IMP");
            sb.AppendLine(new string('-', 32));

            if (_data.Lineas != null && _data.Lineas.Count > 0)
            {
                foreach (var ln in _data.Lineas)
                    sb.AppendLine(RecortarLinea(ln, 29)); // deja 3 espacios para margen
            }
            else
            {
                sb.AppendLine("(Sin productos)");
            }

            sb.AppendLine(new string('-', 32));
            sb.AppendLine(FormatoKV("SUBTOTAL", _data.Subtotal));
            sb.AppendLine(FormatoKV("DESCUENTO", -_data.Descuento));
            sb.AppendLine(FormatoKV("SERVICIO", _data.ServicioCargo));
            sb.AppendLine(new string('-', 32));
            sb.AppendLine(FormatoKV("TOTAL", _data.Total, true));
            sb.AppendLine(new string('-', 32));

            if (!string.IsNullOrWhiteSpace(_data.Notas))
            {
                sb.AppendLine("Notas:");
                sb.AppendLine(_data.Notas);
                sb.AppendLine(new string('-', 32));
            }

            sb.AppendLine(Centrar("¡Gracias por tu compra!"));

            rtbTicket.Text = sb.ToString();
        }

        private string FormatoKV(string clave, decimal valor, bool negrita = false)
        {
            var sValor = (valor >= 0 ? "$" + valor.ToString("0.00") : "-$" + Math.Abs(valor).ToString("0.00"));
            var linea = clave.PadRight(20).Substring(0, 20) + sValor.PadLeft(12);
            return negrita ? linea.ToUpper() : linea;
        }

        private string Centrar(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return "";
            const int ancho = 32;
            texto = texto.Length > ancho ? texto.Substring(0, ancho) : texto;
            int left = Math.Max(0, (ancho - texto.Length) / 2);
            return new string(' ', left) + texto;
        }

        private string RecortarLinea(string texto, int ancho)
        {
            if (string.IsNullOrEmpty(texto)) return "";
            if (texto.Length <= ancho) return texto;
            return texto.Substring(0, ancho - 1) + "…";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
