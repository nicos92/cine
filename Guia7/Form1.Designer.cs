namespace Guia7
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LblPelicula = new System.Windows.Forms.Label();
            this.TituloModulo = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.FlowPanelPeli = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.TLPBtns = new System.Windows.Forms.TableLayoutPanel();
            this.LblHorario = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblSala = new System.Windows.Forms.Label();
            this.CmbSala = new System.Windows.Forms.ComboBox();
            this.CMBFecha = new System.Windows.Forms.ComboBox();
            this.CMBHorario = new System.Windows.Forms.ComboBox();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.TLPBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.PanelTop.Controls.Add(this.LblPelicula);
            this.PanelTop.Controls.Add(this.TituloModulo);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(784, 64);
            this.PanelTop.TabIndex = 0;
            // 
            // LblPelicula
            // 
            this.LblPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.LblPelicula.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblPelicula.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPelicula.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblPelicula.Location = new System.Drawing.Point(0, 30);
            this.LblPelicula.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LblPelicula.Name = "LblPelicula";
            this.LblPelicula.Size = new System.Drawing.Size(784, 34);
            this.LblPelicula.TabIndex = 1;
            this.LblPelicula.Text = "ELIGE TU PELICULA";
            this.LblPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TituloModulo
            // 
            this.TituloModulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TituloModulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloModulo.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloModulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TituloModulo.Location = new System.Drawing.Point(0, 0);
            this.TituloModulo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.TituloModulo.Name = "TituloModulo";
            this.TituloModulo.Size = new System.Drawing.Size(784, 64);
            this.TituloModulo.TabIndex = 0;
            this.TituloModulo.Text = "PELÍCULAS EN CARTELERA\r\n";
            this.TituloModulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelMain.Controls.Add(this.FlowPanelPeli);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 64);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Padding = new System.Windows.Forms.Padding(16);
            this.PanelMain.Size = new System.Drawing.Size(784, 317);
            this.PanelMain.TabIndex = 1;
            // 
            // FlowPanelPeli
            // 
            this.FlowPanelPeli.AutoScroll = true;
            this.FlowPanelPeli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FlowPanelPeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelPeli.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlowPanelPeli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FlowPanelPeli.Location = new System.Drawing.Point(16, 16);
            this.FlowPanelPeli.Name = "FlowPanelPeli";
            this.FlowPanelPeli.Size = new System.Drawing.Size(752, 285);
            this.FlowPanelPeli.TabIndex = 0;
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.TLPBtns);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 381);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(784, 80);
            this.PanelBottom.TabIndex = 1;
            // 
            // TLPBtns
            // 
            this.TLPBtns.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TLPBtns.ColumnCount = 4;
            this.TLPBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPBtns.Controls.Add(this.LblHorario, 2, 0);
            this.TLPBtns.Controls.Add(this.LblFecha, 1, 0);
            this.TLPBtns.Controls.Add(this.LblSala, 0, 0);
            this.TLPBtns.Controls.Add(this.CmbSala, 0, 1);
            this.TLPBtns.Controls.Add(this.CMBFecha, 1, 1);
            this.TLPBtns.Controls.Add(this.CMBHorario, 2, 1);
            this.TLPBtns.Controls.Add(this.BtnSiguiente, 3, 0);
            this.TLPBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPBtns.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TLPBtns.Location = new System.Drawing.Point(0, 0);
            this.TLPBtns.Name = "TLPBtns";
            this.TLPBtns.RowCount = 2;
            this.TLPBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TLPBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.TLPBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPBtns.Size = new System.Drawing.Size(784, 80);
            this.TLPBtns.TabIndex = 0;
            // 
            // LblHorario
            // 
            this.LblHorario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblHorario.AutoSize = true;
            this.LblHorario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHorario.Location = new System.Drawing.Point(463, 11);
            this.LblHorario.Name = "LblHorario";
            this.LblHorario.Size = new System.Drawing.Size(53, 17);
            this.LblHorario.TabIndex = 2;
            this.LblHorario.Text = "Horario";
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(273, 11);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(41, 17);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha";
            // 
            // LblSala
            // 
            this.LblSala.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblSala.AutoSize = true;
            this.LblSala.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSala.Location = new System.Drawing.Point(58, 11);
            this.LblSala.Name = "LblSala";
            this.LblSala.Size = new System.Drawing.Size(80, 17);
            this.LblSala.TabIndex = 0;
            this.LblSala.Text = "Tipo de sala";
            // 
            // CmbSala
            // 
            this.CmbSala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbSala.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.CmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSala.Enabled = false;
            this.CmbSala.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CmbSala.FormattingEnabled = true;
            this.CmbSala.Items.AddRange(new object[] {
            "2D",
            "3D",
            "4D",
            "2D-Box",
            "3D-Box"});
            this.CmbSala.Location = new System.Drawing.Point(17, 31);
            this.CmbSala.Name = "CmbSala";
            this.CmbSala.Size = new System.Drawing.Size(161, 25);
            this.CmbSala.TabIndex = 3;
            this.CmbSala.SelectedIndexChanged += new System.EventHandler(this.CmbSala_SelectedIndexChanged);
            // 
            // CMBFecha
            // 
            this.CMBFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CMBFecha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.CMBFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBFecha.Enabled = false;
            this.CMBFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CMBFecha.FormattingEnabled = true;
            this.CMBFecha.Items.AddRange(new object[] {
            "2D",
            "3D",
            "4D",
            "2D-Box",
            "3D-Box"});
            this.CMBFecha.Location = new System.Drawing.Point(213, 31);
            this.CMBFecha.Name = "CMBFecha";
            this.CMBFecha.Size = new System.Drawing.Size(161, 25);
            this.CMBFecha.TabIndex = 4;
            this.CMBFecha.SelectedIndexChanged += new System.EventHandler(this.CMBFecha_SelectedIndexChanged);
            // 
            // CMBHorario
            // 
            this.CMBHorario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CMBHorario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.CMBHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBHorario.Enabled = false;
            this.CMBHorario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CMBHorario.FormattingEnabled = true;
            this.CMBHorario.Items.AddRange(new object[] {
            "16:00hs",
            "18:00hs",
            "20:00hs",
            "22:00hs",
            "00:00hs"});
            this.CMBHorario.Location = new System.Drawing.Point(409, 31);
            this.CMBHorario.Name = "CMBHorario";
            this.CMBHorario.Size = new System.Drawing.Size(161, 25);
            this.CMBHorario.TabIndex = 5;
            this.CMBHorario.SelectedIndexChanged += new System.EventHandler(this.CMBHorario_SelectedIndexChanged);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.BtnSiguiente.Enabled = false;
            this.BtnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BtnSiguiente.FlatAppearance.BorderSize = 2;
            this.BtnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.BtnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSiguiente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BtnSiguiente.Image = global::Guia7.Properties.Resources.angle_right_red;
            this.BtnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSiguiente.Location = new System.Drawing.Point(622, 16);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.TLPBtns.SetRowSpan(this.BtnSiguiente, 2);
            this.BtnSiguiente.Size = new System.Drawing.Size(128, 48);
            this.BtnSiguiente.TabIndex = 6;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cine Mama Mia";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelMain.ResumeLayout(false);
            this.PanelBottom.ResumeLayout(false);
            this.TLPBtns.ResumeLayout(false);
            this.TLPBtns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label TituloModulo;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelPeli;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.TableLayoutPanel TLPBtns;
        private System.Windows.Forms.Label LblHorario;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblSala;
        private System.Windows.Forms.ComboBox CmbSala;
        private System.Windows.Forms.ComboBox CMBFecha;
        private System.Windows.Forms.ComboBox CMBHorario;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Label LblPelicula;
    }
}

