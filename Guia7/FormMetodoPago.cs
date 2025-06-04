using Colores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validacion;

namespace Guia7
{
    public partial class FormMetodoPago : Form
    {
        private FormAsientos _formAsientos;
        private FormCompra _formCompra;
        private FormPrincipal _formPrincipal;
        public FuncionPeli Funcion { get; set; }
        public FormMetodoPago(FormAsientos formAnterior, FormPrincipal formPrincipal)
        {
            InitializeComponent();
            _formAsientos = formAnterior;
            _formPrincipal = formPrincipal;
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(ref e);

            Validaciones.Borrar(ref e);
        }

        private void TxtNombreTitular_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validaciones.Letras(ref e);

            Validaciones.EspaciosBorrar(ref e);
        }

        private void TxtfechaVencimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(ref e);

            Validaciones.Borrar(ref e);

            if (e.KeyChar == 45)
            {
                e.Handled = false;
            }
        }

        private void FormMetodoPago_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_formAsientos != null || !_formAsientos.IsDisposed)
            {

                _formAsientos.Show();
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            _formAsientos.WindowState = this.WindowState;
            _formAsientos.BringToFront();
            _formAsientos.Show();
            this.Hide();
        }

        private void HabilitarSig_TextChanged(object sender, EventArgs e)
        {
            bool bdni = Regex.IsMatch(TxtDNI.Text, @"^[0-9]{8}$");
            bool bntarj = Regex.IsMatch(TxtNrotarjeta.Text, @"^[0-9]{16}$");
         
            bool bnom = Regex.IsMatch(TxtNombreTitular.Text.Trim(), @"^[a-zA-Z\s]{4,45}$");
            bool bfecha = Regex.IsMatch(TxtFechaVencimiento.Text, @"^(0[1-9]|1[0-2])-[0-9]{2}$");
            bool bcvv = Regex.IsMatch(TxtCVV.Text, @"^[0-9]{3}$");
         
            if (bfecha)
            {
                string[] fechas = TxtFechaVencimiento.Text.Split('-');
                int anio = Convert.ToInt32(fechas[1]);
                int mes = Convert.ToInt32(fechas[0]);
                bfecha= ValidarFechaVenc(mes, anio);
                

            }
            ErrorDni(bdni, bntarj, bnom, bfecha, bcvv);
            BtnSiguiente.Enabled = bdni && bntarj && bnom && bfecha && bcvv;
            Console.WriteLine($"{bdni} - {bntarj} - {bnom} - {bfecha} - {bcvv}");
        }

       

        

        private void ErrorDni(bool bdni, bool bntarj, bool bnom, bool bfecha, bool bcvv)
        {
                ErrorForm.Clear();
            if (!bdni)
            {
                ErrorForm.SetError(TxtDNI, "Dni Invalido");
                CheckDni.Visible = false;

            }
            else
            {
                CheckDni.Visible = true;
            }
            if (!bntarj)
            {
                ErrorForm.SetError(TxtNrotarjeta, "Número de tarjeta Invalido");
                CheckTarj.Visible = false;
            }
            else
            {
                CheckTarj.Visible = true;
            }
            if (!bnom)
            {
                ErrorForm.SetError(TxtNombreTitular, "Nombre de titular Invalido");
                CheckNom.Visible = false;
            }
            else
            {
                CheckNom.Visible = true;
            }
            if (!bfecha)
            {
                ErrorForm.SetError(TxtFechaVencimiento, "Fecha de vencimiento Invalida");
                CheckFecha.Visible = false;
            }
            else
            {
                CheckFecha.Visible = true;
            }
            if (!bcvv)
            {
                ErrorForm.SetError(TxtCVV, "CVV Invalido");
                CheckCvv.Visible = false;
            }
            else
            {
                CheckCvv.Visible = true;
            }

        }

        private bool ValidarFechaVenc(int mes, int anio)
        {
            string hoy = DateTime.Now.ToShortDateString();
            string[] hoyS = hoy.Split('/');
            int _mes = Convert.ToInt32(hoyS[1]);
            int _anio = Convert.ToInt32(hoyS[2].Substring(2));
            
            if (anio >= _anio && mes >= _mes)
            {
               return  true;
            }
            return false;
        }

        private void BtnSiguiente_EnabledChanged(object sender, EventArgs e)
        {
            if (BtnSiguiente.Enabled)
            {
                BtnSiguiente.FlatAppearance.BorderColor = MaterialColors.Red300;
                BtnSiguiente.ForeColor = MaterialColors.Red500;
            }
            else
            {
                BtnSiguiente.FlatAppearance.BorderColor = MaterialColors.Grey300;
                BtnSiguiente.ForeColor = MaterialColors.Grey300;
            }
        }

        private void FormMetodoPago_Load(object sender, EventArgs e)
        {
            this.WindowState = _formAsientos.WindowState;
            CargarDatos();

        }


        private void CargarDatos()
        {
            TituloModulo.Text = "ELIGE TUS ASIENTOS PARA VER\n" + Funcion.LaPelicula.Titulo;
            Foto.Image = Funcion.LaPelicula.Imagen;
            LblSala.Text = "Sala: " + Funcion.Sala;
            LblFecha.Text = "Fecha: " + Funcion.Fecha;
            LblHora.Text = "Hora: " + Funcion.Horario;
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (_formCompra == null || _formCompra.IsDisposed)
            {
                _formCompra = new FormCompra(this, _formAsientos, _formPrincipal);
                _formCompra.FuncionPeli = Funcion;
                _formCompra.Show();
            }
            else
            {
                _formCompra.FuncionPeli = Funcion;

                _formCompra.BringToFront();
                _formCompra.Show();
            }
            this.Hide();
        }
    }
}
