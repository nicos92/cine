namespace Guia7
{
    partial class FormCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.TituloModulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Progres = new System.Windows.Forms.ProgressBar();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.ImgPeli = new System.Windows.Forms.PictureBox();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.TLPBtns = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblDesc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblAsientos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNombreTarjeta = new System.Windows.Forms.Label();
            this.LblNrmTarjeta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblSala = new System.Windows.Forms.Label();
            this.LblPeli = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPeli)).BeginInit();
            this.PanelBottom.SuspendLayout();
            this.TLPBtns.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.LightGray;
            this.PanelTop.Controls.Add(this.TituloModulo);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(784, 64);
            this.PanelTop.TabIndex = 5;
            // 
            // TituloModulo
            // 
            this.TituloModulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TituloModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TituloModulo.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloModulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TituloModulo.Location = new System.Drawing.Point(0, 0);
            this.TituloModulo.Name = "TituloModulo";
            this.TituloModulo.Size = new System.Drawing.Size(784, 64);
            this.TituloModulo.TabIndex = 0;
            this.TituloModulo.Text = "CONFIRMAR COMPRA";
            this.TituloModulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.Progres);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 24);
            this.panel1.TabIndex = 6;
            // 
            // Progres
            // 
            this.Progres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Progres.Location = new System.Drawing.Point(0, 0);
            this.Progres.Name = "Progres";
            this.Progres.Size = new System.Drawing.Size(784, 24);
            this.Progres.TabIndex = 0;
            this.Progres.Value = 59;
            this.Progres.Visible = false;
            // 
            // PanelLeft
            // 
            this.PanelLeft.Controls.Add(this.ImgPeli);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 88);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(300, 272);
            this.PanelLeft.TabIndex = 7;
            // 
            // ImgPeli
            // 
            this.ImgPeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgPeli.Location = new System.Drawing.Point(0, 0);
            this.ImgPeli.Name = "ImgPeli";
            this.ImgPeli.Size = new System.Drawing.Size(300, 272);
            this.ImgPeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgPeli.TabIndex = 0;
            this.ImgPeli.TabStop = false;
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.TLPBtns);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 360);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(784, 101);
            this.PanelBottom.TabIndex = 8;
            // 
            // TLPBtns
            // 
            this.TLPBtns.ColumnCount = 4;
            this.TLPBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPBtns.Controls.Add(this.BtnAtras, 0, 0);
            this.TLPBtns.Controls.Add(this.BtnSiguiente, 3, 0);
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
            this.BtnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnSiguiente.FlatAppearance.BorderSize = 2;
            this.BtnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.BtnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSiguiente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnSiguiente.Image = global::Guia7.Properties.Resources.angle_right_red;
            this.BtnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSiguiente.Location = new System.Drawing.Point(591, 26);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(128, 48);
            this.BtnSiguiente.TabIndex = 6;
            this.BtnSiguiente.Tag = "seleccionado";
            this.BtnSiguiente.Text = "COMPRAR";
            this.BtnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelMain.Controls.Add(this.tableLayoutPanel1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(300, 88);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Padding = new System.Windows.Forms.Padding(4);
            this.PanelMain.Size = new System.Drawing.Size(484, 272);
            this.PanelMain.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.88298F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.11702F));
            this.tableLayoutPanel1.Controls.Add(this.LblDesc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblAsientos, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblNombreTarjeta, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblNrmTarjeta, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblHora, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblFecha, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblSala, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblPeli, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 2);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(552, 364);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(332, 272);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblDesc
            // 
            this.LblDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblDesc.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LblDesc, 2);
            this.LblDesc.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesc.Location = new System.Drawing.Point(3, 12);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(247, 21);
            this.LblDesc.TabIndex = 11;
            this.LblDesc.Text = "ESTAS A PUNTO DE COMPRAR";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Asiento:";
            // 
            // LblAsientos
            // 
            this.LblAsientos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblAsientos.AutoSize = true;
            this.LblAsientos.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAsientos.Location = new System.Drawing.Point(91, 238);
            this.LblAsientos.Name = "LblAsientos";
            this.LblAsientos.Size = new System.Drawing.Size(0, 21);
            this.LblAsientos.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hora:";
            // 
            // LblNombreTarjeta
            // 
            this.LblNombreTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblNombreTarjeta.AutoSize = true;
            this.LblNombreTarjeta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreTarjeta.Location = new System.Drawing.Point(39, 149);
            this.LblNombreTarjeta.Name = "LblNombreTarjeta";
            this.LblNombreTarjeta.Size = new System.Drawing.Size(46, 17);
            this.LblNombreTarjeta.TabIndex = 2;
            this.LblNombreTarjeta.Text = "Fecha:";
            // 
            // LblNrmTarjeta
            // 
            this.LblNrmTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblNrmTarjeta.AutoSize = true;
            this.LblNrmTarjeta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNrmTarjeta.Location = new System.Drawing.Point(50, 104);
            this.LblNrmTarjeta.Name = "LblNrmTarjeta";
            this.LblNrmTarjeta.Size = new System.Drawing.Size(35, 17);
            this.LblNrmTarjeta.TabIndex = 1;
            this.LblNrmTarjeta.Text = "Sala:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pelicula:";
            // 
            // LblHora
            // 
            this.LblHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(91, 192);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(84, 21);
            this.LblHora.TabIndex = 9;
            this.LblHora.Text = "Asientos:";
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(91, 147);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(84, 21);
            this.LblFecha.TabIndex = 8;
            this.LblFecha.Text = "Asientos:";
            // 
            // LblSala
            // 
            this.LblSala.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblSala.AutoSize = true;
            this.LblSala.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSala.Location = new System.Drawing.Point(91, 102);
            this.LblSala.Name = "LblSala";
            this.LblSala.Size = new System.Drawing.Size(84, 21);
            this.LblSala.TabIndex = 7;
            this.LblSala.Text = "Asientos:";
            // 
            // LblPeli
            // 
            this.LblPeli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblPeli.AutoSize = true;
            this.LblPeli.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeli.Location = new System.Drawing.Point(91, 57);
            this.LblPeli.Name = "LblPeli";
            this.LblPeli.Size = new System.Drawing.Size(84, 21);
            this.LblPeli.TabIndex = 4;
            this.LblPeli.Text = "Asientos:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Activated += new System.EventHandler(this.FormCompra_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCompra_FormClosed);
            this.Load += new System.EventHandler(this.FormCompra_Load);
            this.PanelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPeli)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            this.TLPBtns.ResumeLayout(false);
            this.PanelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label TituloModulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar Progres;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.PictureBox ImgPeli;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.TableLayoutPanel TLPBtns;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPeli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNombreTarjeta;
        private System.Windows.Forms.Label LblNrmTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblSala;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblAsientos;
        private System.Windows.Forms.Label LblDesc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}