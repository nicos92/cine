using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia7
{
    public partial class FormCompraHecha : Form
    {
        private FormCompra _formCompra;
        private FormMetodoPago _formMetodoPago;
        private FormAsientos _formAsientos;

        public FuncionPeli Funcion { get; set; }


        public FormCompraHecha()
        {
            InitializeComponent();
        }

        public FormCompraHecha(FormCompra formCompra)
        {
            InitializeComponent();

            this._formCompra = formCompra;
        }

        public FormCompraHecha(FormCompra formCompra, FormMetodoPago formMetodoPago, FormAsientos formAsientos) : this(formCompra)
        {
            _formCompra = formCompra;
            _formMetodoPago = formMetodoPago;
            _formAsientos = formAsientos;
        }

        private void FormCompraHecha_Load(object sender, EventArgs e)
        {
            this.WindowState = _formCompra.WindowState;
            CargarDatos();
        }

        private void CargarDatos()
        {
            int entradas = Funcion.asientos.Count();
            LblDesc.Text += " " + Properties.Settings.Default.codigoCompra;
            LblPeli.Text = Funcion.LaPelicula.Titulo;
            LblSala.Text = Funcion.Sala;
            LblFecha.Text = Funcion.Fecha;
            LblHora.Text = Funcion.Horario;
            ImgPeli.Image = Funcion.LaPelicula.Imagen;
            LblAsientos.Text = string.Empty;
            Funcion.asientos.Sort();
            Funcion.asientos.ForEach(a =>
            {
                LblAsientos.Text += a + " _ ";
            });
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void FormCompraHecha_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formCompra.Close();
            _formMetodoPago.Close();
            _formAsientos.Close();

            
        }
    }
}
