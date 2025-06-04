using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Colores;

namespace Guia7
{
    public partial class FormAsientos : Form
    {
        private FormPrincipal _formPrincipal;
        public FuncionPeli FuncionPeli { get; set; }
        private int _asientos = 0;
        private FormMetodoPago _formMetodoPago;
        public FormAsientos(FormPrincipal SeleccionPeli)
        {
            InitializeComponent();
            _formPrincipal = SeleccionPeli;

        }



        private void FormAsientos_FormClosed(object sender, FormClosedEventArgs e)
        {

            _formPrincipal.Show();
        }

        private void FormAsientos_Load(object sender, EventArgs e)
        {
            this.WindowState = _formPrincipal.WindowState;

            CargarDatos();
            CargarAsientos();
        }

        private void CargarDatos()
        {
            TituloModulo.Text = "ELIGE TUS ASIENTOS PARA VER\n" + FuncionPeli.LaPelicula.Titulo;
            Foto.Image = FuncionPeli.LaPelicula.Imagen;
            LblSala.Text = "Sala: " + FuncionPeli.Sala;
            LblFecha.Text = "Fecha: " + FuncionPeli.Fecha;
            LblHora.Text = "Hora: " + FuncionPeli.Horario;
        }

        private void CargarAsientos()
        {
            for (int i = 0; i < 54; i++)
            {

                Button button = new Button();
                button.Name = "Btn" + (i + 1);
                button.Text = "" + (i + 1);
                button.Size = new Size(72, 28);
                button.BackColor = MaterialColors.Red50;
                button.ForeColor = MaterialColors.Red500;

                button.Cursor = Cursors.Hand;
                button.Tag = "deselecionado";
                button.FlatStyle = FlatStyle.Flat;
                button.Click += (s, e) => button_click(s, e);
                flowLayoutPanel1.Controls.Add(button);
            }

        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Tag.ToString() == "deselecionado")
            {
                button.BackColor = MaterialColors.Green500;
                button.ForeColor = MaterialColors.Green50;
                button.Tag = "seleccionado";
                _asientos++;
                FuncionPeli.asientos.Add(button.Text);
            }
            else
            {
                button.BackColor = MaterialColors.Red50;
                button.ForeColor = MaterialColors.Red500;

                button.Tag = "deselecionado";
                _asientos--;
                FuncionPeli.asientos.Remove(button.Text);


            }
            LblAsientos.Text = _asientos.ToString();

            ActivarSiguiente();
        }

        private void ActivarSiguiente()
        {
            BtnSiguiente.Enabled = _asientos > 0;
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (_formMetodoPago == null || _formMetodoPago.IsDisposed)
            {

                _formMetodoPago = new FormMetodoPago(this, _formPrincipal);
                _formMetodoPago.Funcion = FuncionPeli;
                _formMetodoPago.Show();

            }
            else
            {
                _formMetodoPago.BringToFront();
                _formMetodoPago.Show();
            }
            this.Hide();
        }



        private void BtnAtras_Click(object sender, EventArgs e)
        {
            _formPrincipal.WindowState = this.WindowState;
            _formPrincipal.Show();
            this.Hide();
        }

        private void BtnSiguiente_EnabledChanged(object sender, EventArgs e)
        {
            if (BtnSiguiente.Enabled)
            {
                BtnSiguiente.ForeColor = MaterialColors.Red500;
                BtnSiguiente.FlatAppearance.BorderColor = MaterialColors.Red500;
            }
            else
            {
                BtnSiguiente.ForeColor = MaterialColors.Green500;
                BtnSiguiente.FlatAppearance.BorderColor = MaterialColors.Green500;
            }
        }

        private void FormAsientos_Activated(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
