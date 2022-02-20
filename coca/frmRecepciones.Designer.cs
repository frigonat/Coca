namespace coca
{
    partial class frmRecepciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTiposDeDocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dgvRecepciones = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslCantidadDeRecepciones = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.colRecepcionAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRececpcionNombreAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecepcionTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecepcionNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecepcionNotaFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecepcionDocEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecepcionFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecepcionHoraIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecepcionArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecepcionCantidadPallets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecepcionCantidadCajas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecepcionCantidadUnidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepciones)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbTiposDeDocumento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRefrescar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cmbClientes);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1452, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbTiposDeDocumento
            // 
            this.cmbTiposDeDocumento.FormattingEnabled = true;
            this.cmbTiposDeDocumento.Location = new System.Drawing.Point(337, 53);
            this.cmbTiposDeDocumento.Name = "cmbTiposDeDocumento";
            this.cmbTiposDeDocumento.Size = new System.Drawing.Size(148, 21);
            this.cmbTiposDeDocumento.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo de Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lote:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha Desde:";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescar.Location = new System.Drawing.Point(1372, 28);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(43, 35);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 21);
            this.textBox1.TabIndex = 3;
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(278, 24);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(224, 21);
            this.cmbClientes.TabIndex = 2;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "dd.MM.yyyy";
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(97, 47);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(106, 21);
            this.dtpFechaHasta.TabIndex = 1;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "dd.MM.yyyy";
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesde.Location = new System.Drawing.Point(97, 20);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(106, 21);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // dgvRecepciones
            // 
            this.dgvRecepciones.AllowUserToAddRows = false;
            this.dgvRecepciones.AllowUserToDeleteRows = false;
            this.dgvRecepciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecepcionAlmacen,
            this.colRececpcionNombreAlmacen,
            this.colRecepcionTipoDocumento,
            this.colRecepcionNumero,
            this.colRecepcionNotaFiscal,
            this.colRecepcionDocEntrada,
            this.colRecepcionFechaIngreso,
            this.colRecepcionHoraIngreso,
            this.colRecepcionArchivo,
            this.colRecepcionCantidadPallets,
            this.colRecepcionCantidadCajas,
            this.colRecepcionCantidadUnidades});
            this.dgvRecepciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRecepciones.Location = new System.Drawing.Point(13, 118);
            this.dgvRecepciones.Name = "dgvRecepciones";
            this.dgvRecepciones.RowHeadersVisible = false;
            this.dgvRecepciones.Size = new System.Drawing.Size(1451, 458);
            this.dgvRecepciones.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslCantidadDeRecepciones,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1481, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // tslCantidadDeRecepciones
            // 
            this.tslCantidadDeRecepciones.AutoSize = false;
            this.tslCantidadDeRecepciones.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslCantidadDeRecepciones.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tslCantidadDeRecepciones.Name = "tslCantidadDeRecepciones";
            this.tslCantidadDeRecepciones.Size = new System.Drawing.Size(122, 19);
            this.tslCantidadDeRecepciones.Text = "...";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabel3.Text = "...";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabel4.Text = "...";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.AutoSize = false;
            this.toolStripStatusLabel5.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabel5.Text = "...";
            // 
            // colRecepcionAlmacen
            // 
            this.colRecepcionAlmacen.HeaderText = "Almacen";
            this.colRecepcionAlmacen.Name = "colRecepcionAlmacen";
            // 
            // colRececpcionNombreAlmacen
            // 
            this.colRececpcionNombreAlmacen.HeaderText = "Nombre";
            this.colRececpcionNombreAlmacen.Name = "colRececpcionNombreAlmacen";
            this.colRececpcionNombreAlmacen.Width = 250;
            // 
            // colRecepcionTipoDocumento
            // 
            this.colRecepcionTipoDocumento.HeaderText = "Tipo de Documento";
            this.colRecepcionTipoDocumento.Name = "colRecepcionTipoDocumento";
            this.colRecepcionTipoDocumento.Width = 140;
            // 
            // colRecepcionNumero
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            this.colRecepcionNumero.DefaultCellStyle = dataGridViewCellStyle9;
            this.colRecepcionNumero.HeaderText = "Número";
            this.colRecepcionNumero.Name = "colRecepcionNumero";
            // 
            // colRecepcionNotaFiscal
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            this.colRecepcionNotaFiscal.DefaultCellStyle = dataGridViewCellStyle10;
            this.colRecepcionNotaFiscal.HeaderText = "Nota Fiscal";
            this.colRecepcionNotaFiscal.Name = "colRecepcionNotaFiscal";
            // 
            // colRecepcionDocEntrada
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N0";
            this.colRecepcionDocEntrada.DefaultCellStyle = dataGridViewCellStyle11;
            this.colRecepcionDocEntrada.HeaderText = "Doc.Entrada";
            this.colRecepcionDocEntrada.Name = "colRecepcionDocEntrada";
            // 
            // colRecepcionFechaIngreso
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colRecepcionFechaIngreso.DefaultCellStyle = dataGridViewCellStyle12;
            this.colRecepcionFechaIngreso.HeaderText = "Fecha Ingreso";
            this.colRecepcionFechaIngreso.Name = "colRecepcionFechaIngreso";
            // 
            // colRecepcionHoraIngreso
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colRecepcionHoraIngreso.DefaultCellStyle = dataGridViewCellStyle13;
            this.colRecepcionHoraIngreso.HeaderText = "Hora Ingreso";
            this.colRecepcionHoraIngreso.Name = "colRecepcionHoraIngreso";
            // 
            // colRecepcionArchivo
            // 
            this.colRecepcionArchivo.HeaderText = "Archivo";
            this.colRecepcionArchivo.Name = "colRecepcionArchivo";
            this.colRecepcionArchivo.Width = 200;
            // 
            // colRecepcionCantidadPallets
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N0";
            this.colRecepcionCantidadPallets.DefaultCellStyle = dataGridViewCellStyle14;
            this.colRecepcionCantidadPallets.HeaderText = "Pallets";
            this.colRecepcionCantidadPallets.Name = "colRecepcionCantidadPallets";
            this.colRecepcionCantidadPallets.Width = 50;
            // 
            // colRecepcionCantidadCajas
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N0";
            this.colRecepcionCantidadCajas.DefaultCellStyle = dataGridViewCellStyle15;
            this.colRecepcionCantidadCajas.HeaderText = "Cajas";
            this.colRecepcionCantidadCajas.Name = "colRecepcionCantidadCajas";
            this.colRecepcionCantidadCajas.Width = 50;
            // 
            // colRecepcionCantidadUnidades
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N0";
            this.colRecepcionCantidadUnidades.DefaultCellStyle = dataGridViewCellStyle16;
            this.colRecepcionCantidadUnidades.HeaderText = "Unidades";
            this.colRecepcionCantidadUnidades.Name = "colRecepcionCantidadUnidades";
            // 
            // frmRecepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 615);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvRecepciones);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmRecepciones";
            this.Text = "Recepciones";
            this.Load += new System.EventHandler(this.frmRecepciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepciones)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRecepciones;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslCantidadDeRecepciones;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTiposDeDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecepcionAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRececpcionNombreAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecepcionTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecepcionNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecepcionNotaFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecepcionDocEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecepcionFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecepcionHoraIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecepcionArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecepcionCantidadPallets;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecepcionCantidadCajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecepcionCantidadUnidades;
    }
}