using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia7
{
    public partial class CardPelicula : UserControl
    {
        public CardPelicula()
        {
            InitializeComponent();
            Foto.Click += (s, e) => OnClick(e);
            ElTitulo.Click += (s, e) => OnClick(e);
            
        }
        public Pelicula pelicula { get; set; }

        public bool _seleccionado
        {
            get; set;
        } = false;

        public string Titulo
        {
            get
            {
                return ElTitulo.Text;
            }
            set
            {
                ElTitulo.Text = value;
            }
        }

        public Image Imagen
        {
            get
            {
                return Foto.Image;
            }
            set
            {
                Foto.Image = value;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e); 
        }

        public void Pelicula_Click(object sender, EventArgs e)
        {
            //if (!_seleccionado)
            //{
            //    Panel.BackColor = Color.Red;
            //    PanelTitulo.BackColor = Color.Azure;
            //    _seleccionado = !_seleccionado;
            //}
            //else
            //{
            //    Panel.BackColor = Color.Silver;
            //    PanelTitulo.BackColor = Color.Silver;
            //    _seleccionado = !_seleccionado;

            //}
            //this.OnClick(e);

        }
        public void EstaSeleccionada()
        {
            if (_seleccionado)
            {
                Panel.BackColor = Color.Silver;
                PanelTitulo.BackColor = Color.Silver;
                _seleccionado = !_seleccionado;

            }
        }
        

    }
}
