namespace Guia7
{
    partial class FormAsientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsientos));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TituloModulo = new System.Windows.Forms.Label();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPantalla = new System.Windows.Forms.Label();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.TLPBtns = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.LblAsientos = new System.Windows.Forms.Label();
            this.LblCant = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblSala = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.TLPBtns.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.PanelTop.Controls.Add(this.tableLayoutPanel1);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.MinimumSize = new System.Drawing.Size(0, 75);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Padding = new System.Windows.Forms.Padding(4);
            this.PanelTop.Size = new System.Drawing.Size(784, 75);
            this.PanelTop.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.2149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.7851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.Controls.Add(this.TituloModulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Foto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 67);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TituloModulo
            // 
            this.TituloModulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TituloModulo.AutoSize = true;
            this.TituloModulo.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloModulo.Location = new System.Drawing.Point(160, 21);
            this.TituloModulo.Margin = new System.Windows.Forms.Padding(16, 0, 3, 0);
            this.TituloModulo.Name = "TituloModulo";
            this.TituloModulo.Size = new System.Drawing.Size(201, 25);
            this.TituloModulo.TabIndex = 0;
            this.TituloModulo.Text = "ELIJE TUS ASIENTOS";
            this.TituloModulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Foto
            // 
            this.Foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Foto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Foto.Location = new System.Drawing.Point(509, 0);
            this.Foto.Margin = new System.Windows.Forms.Padding(0);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(68, 67);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Foto.TabIndex = 1;
            this.Foto.TabStop = false;
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelMain.Controls.Add(this.panel2);
            this.PanelMain.Controls.Add(this.panel3);
            this.PanelMain.Controls.Add(this.panel1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 75);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Padding = new System.Windows.Forms.Padding(4);
            this.PanelMain.Size = new System.Drawing.Size(784, 285);
            this.PanelMain.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 51);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(776, 230);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 730F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(768, 222);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(724, 216);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 2);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblPantalla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 45);
            this.panel1.TabIndex = 1;
            // 
            // LblPantalla
            // 
            this.LblPantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPantalla.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPantalla.ForeColor = System.Drawing.Color.Black;
            this.LblPantalla.Location = new System.Drawing.Point(0, 0);
            this.LblPantalla.Margin = new System.Windows.Forms.Padding(16, 0, 3, 0);
            this.LblPantalla.Name = "LblPantalla";
            this.LblPantalla.Size = new System.Drawing.Size(776, 45);
            this.LblPantalla.TabIndex = 1;
            this.LblPantalla.Text = "PANTALLA";
            this.LblPantalla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.TLPBtns);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 360);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(784, 101);
            this.PanelBottom.TabIndex = 3;
            // 
            // TLPBtns
            // 
            this.TLPBtns.ColumnCount = 4;
            this.TLPBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.TLPBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.37245F));
            this.TLPBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPBtns.Controls.Add(this.BtnAtras, 0, 0);
            this.TLPBtns.Controls.Add(this.BtnSiguiente, 3, 0);
            this.TLPBtns.Controls.Add(this.LblAsientos, 2, 0);
            this.TLPBtns.Controls.Add(this.LblCant, 1, 0);
            this.TLPBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPBtns.Location = new System.Drawing.Point(0, 0);
            this.TLPBtns.Name = "TLPBtns";
            this.TLPBtns.RowCount = 1;
            this.TLPBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPBtns.Size = new System.Drawing.Size(784, 101);
            this.TLPBtns.TabIndex = 0;
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.BtnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.BtnAtras.FlatAppearance.BorderSize = 2;
            this.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.BtnAtras.Image = global::Guia7.Properties.Resources.angle_left_purple;
            this.BtnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAtras.Location = new System.Drawing.Point(65, 26);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(128, 48);
            this.BtnAtras.TabIndex = 8;
            this.BtnAtras.Tag = "seleccionado";
            this.BtnAtras.Text = "Atrás";
            this.BtnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.BtnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.BtnSiguiente.Location = new System.Drawing.Point(590, 26);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(128, 48);
            this.BtnSiguiente.TabIndex = 6;
            this.BtnSiguiente.Tag = "seleccionado";
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            this.BtnSiguiente.EnabledChanged += new System.EventHandler(this.BtnSiguiente_EnabledChanged);
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // LblAsientos
            // 
            this.LblAsientos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblAsientos.AutoSize = true;
            this.LblAsientos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAsientos.Location = new System.Drawing.Point(493, 38);
            this.LblAsientos.Name = "LblAsientos";
            this.LblAsientos.Size = new System.Drawing.Size(23, 25);
            this.LblAsientos.TabIndex = 7;
            this.LblAsientos.Text = "0";
            // 
            // LblCant
            // 
            this.LblCant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblCant.AutoSize = true;
            this.LblCant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCant.Location = new System.Drawing.Point(243, 40);
            this.LblCant.Name = "LblCant";
            this.LblCant.Size = new System.Drawing.Size(244, 21);
            this.LblCant.TabIndex = 0;
            this.LblCant.Text = "Cantidad de Asientos elegidos:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.LblHora, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.LblFecha, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.LblSala, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(580, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(193, 61);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // LblSala
            // 
            this.LblSala.AutoSize = true;
            this.LblSala.Location = new System.Drawing.Point(3, 0);
            this.LblSala.Name = "LblSala";
            this.LblSala.Size = new System.Drawing.Size(36, 16);
            this.LblSala.TabIndex = 0;
            this.LblSala.Text = "Sala";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(3, 20);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(48, 16);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Location = new System.Drawing.Point(3, 40);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(38, 16);
            this.LblHora.TabIndex = 2;
            this.LblHora.Text = "Hora";
            // 
            // FormAsientos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelBottom);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormAsientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asientos";
            this.Activated += new System.EventHandler(this.FormAsientos_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAsientos_FormClosed);
            this.Load += new System.EventHandler(this.FormAsientos_Load);
            this.PanelTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelBottom.ResumeLayout(false);
            this.TLPBtns.ResumeLayout(false);
            this.TLPBtns.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label TituloModulo;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.TableLayoutPanel TLPBtns;
        private System.Windows.Forms.Label LblCant;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.PictureBox Foto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblAsientos;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblPantalla;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblSala;
    }
}