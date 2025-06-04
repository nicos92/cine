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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public Pelicula LaPelicula;
        private FormAsientos _formAsientos;
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //todo para revisar despues en la validacion de la fecha de vencimiento de la tarjeta
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year.ToString().Substring(2));


            CargarPeliculas();
            Cargarsalas();
            CargarDias();
            CargarHorarios();

        }
        

        private void CargarPeliculas()
        {

            foreach (var item in ListaPeliculas.peliculas)
            {
                if (item.EnCartelera)
                {

                    CardPelicula cardPeli = new CardPelicula();
                    cardPeli.Titulo = item.Titulo;
                    cardPeli.Imagen = item.Imagen;
                    cardPeli.pelicula = item;
                    cardPeli.Click += cardPelicula1_Click_1;
                    FlowPanelPeli.Controls.Add(cardPeli);
                }
            }
        }
        private void Cargarsalas()
        {
            string[] salas = new string[] { "2D", "3D", "4D", "2D-Box", "3D-Box", "4D-Box" };
            CmbSala.Items.Clear();

            foreach (var item in salas)
            {
                CmbSala.Items.Add(item);
            }
        }
        private void CargarDias()
        {
            DateTime today = DateTime.Now;

            CMBFecha.Items.Clear();
            for (int i = 0; i < 7; i++)
            {
                CMBFecha.Items.Add(today.AddDays(i).ToShortDateString());
            }
        }

        private void CargarHorarios()
        {
            string[] horarios = new string[] { "16:00hs", "18:00hs", "20:00hs", "22:00hs", "00:00hs" };
            CMBHorario.Items.Clear();

            foreach (var item in horarios)
            {
                CMBHorario.Items.Add(item);
            }
        }

        private void cardPelicula1_Click_1(object sender, EventArgs e)
        {
            CardPelicula card = (CardPelicula)sender;
            Desellecionar();
            Seleccionar(card);
        }

        public void Desellecionar()
        {
            
            foreach (CardPelicula card in FlowPanelPeli.Controls)
            {
                card.Panel.BackColor = Color.Silver;
                card.PanelTitulo.BackColor = Color.Silver;
                card.ElTitulo.ForeColor = Color.Black;

                card._seleccionado = !card._seleccionado;
            }
            FunteNormal();


        }

        private void FunteNormal()
        {
            LblSala.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            LblFecha.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            LblHorario.Font = new Font("Segoe UI", 10, FontStyle.Regular);

        }
        private void Seleccionar(CardPelicula card)
        {
            card.Panel.BackColor = MaterialColors.Red300;
            card.PanelTitulo.BackColor = MaterialColors.Red50;
            card.ElTitulo.ForeColor = MaterialColors.Red500;
            card._seleccionado = !card._seleccionado;
            LblPelicula.Text = "Elegiste " + card.Titulo.ToUpper();
            LblPelicula.ForeColor = MaterialColors.Red50;
            LaPelicula = card.pelicula;
            LblSala.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            ActivarCmbSala();
        }

        private void ActivarCmbSala()
        {
            Cargarsalas();
            CmbSala.Enabled = true;
            CMBFecha.Enabled = false;
            CMBHorario.Enabled = false;
            BtnSiguiente.FlatAppearance.BorderColor = MaterialColors.Grey450;
            BtnSiguiente.Enabled = false;
        }

        private void ActivarSiguiente()
        {
            BtnSiguiente.Enabled = !(string.IsNullOrWhiteSpace(CmbSala.Text) && string.IsNullOrWhiteSpace(CMBFecha.Text) && string.IsNullOrWhiteSpace(CMBHorario.Text));
        }

        private void CmbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMBFecha.Enabled = true;
            LblFecha.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            CargarDias();
        }

        private void CMBFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMBHorario.Enabled = true;
            LblHorario.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            CargarHorarios();
        }

        private void CMBHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnSiguiente.Enabled = true;
            BtnSiguiente.ForeColor = MaterialColors.Red500;
            BtnSiguiente.FlatAppearance.BorderColor = MaterialColors.Red500;
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            FuncionPeli funcionPeli = new FuncionPeli();
            funcionPeli.LaPelicula = LaPelicula;
            funcionPeli.Sala = CmbSala.Text;
            funcionPeli.Fecha = CMBFecha.Text;
            funcionPeli.Horario = CMBHorario.Text;

            if (_formAsientos == null || _formAsientos.IsDisposed)
            {

                _formAsientos = new FormAsientos(this);
                _formAsientos.FuncionPeli = funcionPeli;
                _formAsientos.Show();
            }
            else
            {
                _formAsientos.FuncionPeli = funcionPeli;

                _formAsientos.BringToFront();
                _formAsientos.Show();
            }
            this.Hide();

        }
    }
}
