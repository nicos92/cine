namespace Guia7
{
    partial class CardPelicula
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel = new System.Windows.Forms.Panel();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.ElTitulo = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.PanelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Silver;
            this.Panel.Controls.Add(this.Foto);
            this.Panel.Controls.Add(this.PanelTitulo);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Padding = new System.Windows.Forms.Padding(4);
            this.Panel.Size = new System.Drawing.Size(160, 250);
            this.Panel.TabIndex = 1;
            // 
            // Foto
            // 
            this.Foto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Foto.Image = global::Guia7.Properties.Resources.ADO;
            this.Foto.Location = new System.Drawing.Point(4, 47);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(152, 199);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto.TabIndex = 1;
            this.Foto.TabStop = false;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.Controls.Add(this.ElTitulo);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(4, 4);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(152, 43);
            this.PanelTitulo.TabIndex = 2;
            // 
            // ElTitulo
            // 
            this.ElTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ElTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ElTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElTitulo.Location = new System.Drawing.Point(0, 0);
            this.ElTitulo.Name = "ElTitulo";
            this.ElTitulo.Size = new System.Drawing.Size(152, 43);
            this.ElTitulo.TabIndex = 0;
            this.ElTitulo.Text = "destino\r\nfinal";
            // 
            // CardPelicula
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Panel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.Name = "CardPelicula";
            this.Size = new System.Drawing.Size(160, 250);
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.PanelTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel Panel;
        public System.Windows.Forms.PictureBox Foto;
        public System.Windows.Forms.Panel PanelTitulo;
        public System.Windows.Forms.Label ElTitulo;
    }
}
