using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia7
{
    public partial class FormCompra : Form
    {
        private FormMetodoPago _formMetodoPago;
        private FormAsientos _formAsientos;
        private FormPrincipal _formPrincipal;
        public FuncionPeli FuncionPeli { get; set; }
        public FormCompra(FormMetodoPago formMetodoPago, FormAsientos formAsientos, FormPrincipal formPrincipal )
        {
            InitializeComponent();
            _formMetodoPago = formMetodoPago;
            _formAsientos = formAsientos;
            _formPrincipal = formPrincipal;
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            this.WindowState = _formMetodoPago.WindowState;
            CargarDatos();
        }

        private void CargarDatos()
        {
            int entradas = FuncionPeli.asientos.Count();
            LblDesc.Text = "ESTAS A PUNTO DE COMPRAR " +( entradas > 1 ?  entradas + " ENTRADAS" : entradas + " ENTRADA");
            LblPeli.Text= FuncionPeli.LaPelicula.Titulo;
            LblSala.Text = FuncionPeli.Sala;
            LblFecha.Text = FuncionPeli.Fecha;
            LblHora.Text = FuncionPeli.Horario;
            ImgPeli.Image = FuncionPeli.LaPelicula.Imagen;
            LblAsientos.Text = string.Empty;
            FuncionPeli.asientos.Sort();
            FuncionPeli.asientos.ForEach(a =>
           {
               LblAsientos.Text += a + " _ ";
           });

        }

        private void ValidarFechaVenc()
        {
            string hoy = DateTime.Now.ToShortDateString();
            string[] s = hoy.Split('/');
            int mes = Convert.ToInt32(s[1]);
            int anio = Convert.ToInt32(s[2].Substring(2));

        }

        private void FormCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ( !_formMetodoPago.IsDisposed)
            {

            _formMetodoPago.WindowState = this.WindowState;
            _formMetodoPago.BringToFront();

            _formMetodoPago.Show();
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            _formMetodoPago.WindowState = this.WindowState;
            _formMetodoPago.BringToFront();
            _formMetodoPago.Show();
            this.Hide();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            BtnAtras.Enabled = false;
            BtnSiguiente.Enabled = false;
            Progres.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                worker.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

     
            Progres.Value = e.ProgressPercentage;
        
           
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Progres.Visible = false;
            MessageBox.Show("Compra Exitosa", "COMPRA");
            _formMetodoPago.Close();
            _formAsientos.Close();
            _formPrincipal.BringToFront();
            _formPrincipal.Show();
            this.Close();

        }

        private void FormCompra_Activated(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
