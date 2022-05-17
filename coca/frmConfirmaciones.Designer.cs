namespace coca
{
    partial class frmConfirmaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmaciones));
            this.dgvConfirmaciones = new System.Windows.Forms.DataGridView();
            this.colConfirmacionAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionNombreAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionNotaFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionDocEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionUsuarioAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionArchivoProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionFechaProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionUsuarioProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionCantidadPallets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionCantidadCajas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmacionCantidadUnidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslCantidadDeConfirmaciones = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalUnidades = new System.Windows.Forms.Label();
            this.lblTotalCajas = new System.Windows.Forms.Label();
            this.lblTotalPallets = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroDeLote = new System.Windows.Forms.TextBox();
            this.cmbTiposDeDocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmaciones)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConfirmaciones
            // 
            this.dgvConfirmaciones.AllowUserToAddRows = false;
            this.dgvConfirmaciones.AllowUserToDeleteRows = false;
            this.dgvConfirmaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConfirmaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfirmaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConfirmacionAlmacen,
            this.colConfirmacionNombreAlmacen,
            this.colConfirmacionTipoDocumento,
            this.colConfirmacionNumero,
            this.colConfirmacionNotaFiscal,
            this.colConfirmacionDocEntrada,
            this.colConfirmacionEstado,
            this.colConfirmacionEvento,
            this.colConfirmacionFechaAlta,
            this.colConfirmacionUsuarioAlta,
            this.colConfirmacionArchivoProceso,
            this.colConfirmacionFechaProceso,
            this.colConfirmacionUsuarioProceso,
            this.colConfirmacionCantidadPallets,
            this.colConfirmacionCantidadCajas,
            this.colConfirmacionCantidadUnidades});
            this.dgvConfirmaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConfirmaciones.Location = new System.Drawing.Point(13, 116);
            this.dgvConfirmaciones.Name = "dgvConfirmaciones";
            this.dgvConfirmaciones.RowHeadersVisible = false;
            this.dgvConfirmaciones.Size = new System.Drawing.Size(1436, 419);
            this.dgvConfirmaciones.TabIndex = 0;
            this.dgvConfirmaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfirmaciones_CellDoubleClick);
            // 
            // colConfirmacionAlmacen
            // 
            this.colConfirmacionAlmacen.HeaderText = "Almacén ";
            this.colConfirmacionAlmacen.Name = "colConfirmacionAlmacen";
            // 
            // colConfirmacionNombreAlmacen
            // 
            this.colConfirmacionNombreAlmacen.HeaderText = "Nombre";
            this.colConfirmacionNombreAlmacen.Name = "colConfirmacionNombreAlmacen";
            this.colConfirmacionNombreAlmacen.Width = 250;
            // 
            // colConfirmacionTipoDocumento
            // 
            this.colConfirmacionTipoDocumento.HeaderText = "Tipo de Documento";
            this.colConfirmacionTipoDocumento.Name = "colConfirmacionTipoDocumento";
            this.colConfirmacionTipoDocumento.Width = 140;
            // 
            // colConfirmacionNumero
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            this.colConfirmacionNumero.DefaultCellStyle = dataGridViewCellStyle1;
            this.colConfirmacionNumero.HeaderText = "Número";
            this.colConfirmacionNumero.Name = "colConfirmacionNumero";
            this.colConfirmacionNumero.Width = 80;
            // 
            // colConfirmacionNotaFiscal
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.colConfirmacionNotaFiscal.DefaultCellStyle = dataGridViewCellStyle2;
            this.colConfirmacionNotaFiscal.HeaderText = "Nota Fiscal";
            this.colConfirmacionNotaFiscal.Name = "colConfirmacionNotaFiscal";
            this.colConfirmacionNotaFiscal.Width = 90;
            // 
            // colConfirmacionDocEntrada
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.colConfirmacionDocEntrada.DefaultCellStyle = dataGridViewCellStyle3;
            this.colConfirmacionDocEntrada.HeaderText = "Doc.Entrada";
            this.colConfirmacionDocEntrada.Name = "colConfirmacionDocEntrada";
            // 
            // colConfirmacionEstado
            // 
            this.colConfirmacionEstado.HeaderText = "Estado";
            this.colConfirmacionEstado.Name = "colConfirmacionEstado";
            // 
            // colConfirmacionEvento
            // 
            this.colConfirmacionEvento.HeaderText = "Evento";
            this.colConfirmacionEvento.Name = "colConfirmacionEvento";
            // 
            // colConfirmacionFechaAlta
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colConfirmacionFechaAlta.DefaultCellStyle = dataGridViewCellStyle4;
            this.colConfirmacionFechaAlta.HeaderText = "Fecha Alta";
            this.colConfirmacionFechaAlta.Name = "colConfirmacionFechaAlta";
            this.colConfirmacionFechaAlta.Width = 110;
            // 
            // colConfirmacionUsuarioAlta
            // 
            this.colConfirmacionUsuarioAlta.HeaderText = "Usuario Alta";
            this.colConfirmacionUsuarioAlta.Name = "colConfirmacionUsuarioAlta";
            // 
            // colConfirmacionArchivoProceso
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colConfirmacionArchivoProceso.DefaultCellStyle = dataGridViewCellStyle5;
            this.colConfirmacionArchivoProceso.HeaderText = "Archivo Proceso";
            this.colConfirmacionArchivoProceso.Name = "colConfirmacionArchivoProceso";
            this.colConfirmacionArchivoProceso.Width = 180;
            // 
            // colConfirmacionFechaProceso
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colConfirmacionFechaProceso.DefaultCellStyle = dataGridViewCellStyle6;
            this.colConfirmacionFechaProceso.HeaderText = "Fecha Proceso";
            this.colConfirmacionFechaProceso.Name = "colConfirmacionFechaProceso";
            this.colConfirmacionFechaProceso.Width = 110;
            // 
            // colConfirmacionUsuarioProceso
            // 
            this.colConfirmacionUsuarioProceso.HeaderText = "Usuario Proceso";
            this.colConfirmacionUsuarioProceso.Name = "colConfirmacionUsuarioProceso";
            this.colConfirmacionUsuarioProceso.Width = 110;
            // 
            // colConfirmacionCantidadPallets
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            this.colConfirmacionCantidadPallets.DefaultCellStyle = dataGridViewCellStyle7;
            this.colConfirmacionCantidadPallets.HeaderText = "Pallets";
            this.colConfirmacionCantidadPallets.Name = "colConfirmacionCantidadPallets";
            this.colConfirmacionCantidadPallets.Width = 40;
            // 
            // colConfirmacionCantidadCajas
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            this.colConfirmacionCantidadCajas.DefaultCellStyle = dataGridViewCellStyle8;
            this.colConfirmacionCantidadCajas.HeaderText = "Cajas";
            this.colConfirmacionCantidadCajas.Name = "colConfirmacionCantidadCajas";
            this.colConfirmacionCantidadCajas.Width = 40;
            // 
            // colConfirmacionCantidadUnidades
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            this.colConfirmacionCantidadUnidades.DefaultCellStyle = dataGridViewCellStyle9;
            this.colConfirmacionCantidadUnidades.HeaderText = "Unidades";
            this.colConfirmacionCantidadUnidades.Name = "colConfirmacionCantidadUnidades";
            this.colConfirmacionCantidadUnidades.Width = 60;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslCantidadDeConfirmaciones,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1461, 24);
            this.statusStrip1.TabIndex = 1;
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
            // tslCantidadDeConfirmaciones
            // 
            this.tslCantidadDeConfirmaciones.AutoSize = false;
            this.tslCantidadDeConfirmaciones.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslCantidadDeConfirmaciones.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tslCantidadDeConfirmaciones.Name = "tslCantidadDeConfirmaciones";
            this.tslCantidadDeConfirmaciones.Size = new System.Drawing.Size(122, 19);
            this.tslCantidadDeConfirmaciones.Text = "...";
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblTotalUnidades);
            this.groupBox1.Controls.Add(this.lblTotalCajas);
            this.groupBox1.Controls.Add(this.lblTotalPallets);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNumeroDeLote);
            this.groupBox1.Controls.Add(this.cmbTiposDeDocumento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbClientes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbEstados);
            this.groupBox1.Controls.Add(this.btnRefrescar);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1436, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros:";
            // 
            // lblTotalUnidades
            // 
            this.lblTotalUnidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalUnidades.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUnidades.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblTotalUnidades.Location = new System.Drawing.Point(1123, 23);
            this.lblTotalUnidades.Name = "lblTotalUnidades";
            this.lblTotalUnidades.Size = new System.Drawing.Size(114, 25);
            this.lblTotalUnidades.TabIndex = 22;
            this.lblTotalUnidades.Text = "999";
            this.lblTotalUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCajas
            // 
            this.lblTotalCajas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCajas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCajas.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblTotalCajas.Location = new System.Drawing.Point(924, 53);
            this.lblTotalCajas.Name = "lblTotalCajas";
            this.lblTotalCajas.Size = new System.Drawing.Size(77, 25);
            this.lblTotalCajas.TabIndex = 21;
            this.lblTotalCajas.Text = "999";
            this.lblTotalCajas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPallets
            // 
            this.lblTotalPallets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPallets.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPallets.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblTotalPallets.Location = new System.Drawing.Point(924, 22);
            this.lblTotalPallets.Name = "lblTotalPallets";
            this.lblTotalPallets.Size = new System.Drawing.Size(77, 25);
            this.lblTotalPallets.TabIndex = 20;
            this.lblTotalPallets.Text = "999";
            this.lblTotalPallets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1020, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total de Unidades:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(838, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total de Cajas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(834, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total de Pallets:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(633, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lote:";
            // 
            // txtNumeroDeLote
            // 
            this.txtNumeroDeLote.Location = new System.Drawing.Point(671, 26);
            this.txtNumeroDeLote.Name = "txtNumeroDeLote";
            this.txtNumeroDeLote.Size = new System.Drawing.Size(148, 21);
            this.txtNumeroDeLote.TabIndex = 13;
            // 
            // cmbTiposDeDocumento
            // 
            this.cmbTiposDeDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposDeDocumento.FormattingEnabled = true;
            this.cmbTiposDeDocumento.Location = new System.Drawing.Point(382, 56);
            this.cmbTiposDeDocumento.Name = "cmbTiposDeDocumento";
            this.cmbTiposDeDocumento.Size = new System.Drawing.Size(136, 21);
            this.cmbTiposDeDocumento.Sorted = true;
            this.cmbTiposDeDocumento.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo de Documento:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(319, 26);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(272, 21);
            this.cmbClientes.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cliente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::coca.Properties.Resources.database_up_icon64;
            this.pictureBox1.Location = new System.Drawing.Point(10, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 68);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "dd.MM.yyyy";
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(160, 54);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(95, 21);
            this.dtpFechaHasta.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "dd.MM.yyyy";
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesde.Location = new System.Drawing.Point(160, 26);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(93, 21);
            this.dtpFechaDesde.TabIndex = 3;
            this.dtpFechaDesde.Leave += new System.EventHandler(this.dtpFechaDesde_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado:";
            // 
            // cmbEstados
            // 
            this.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(648, 57);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(121, 21);
            this.cmbEstados.Sorted = true;
            this.cmbEstados.TabIndex = 1;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescar.Image = global::coca.Properties.Resources.Actions_view_refresh_icon48;
            this.btnRefrescar.Location = new System.Drawing.Point(1367, 22);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(63, 54);
            this.btnRefrescar.TabIndex = 0;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmConfirmaciones
            // 
            this.AcceptButton = this.btnRefrescar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvConfirmaciones);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfirmaciones";
            this.Text = "Confirmaciones";
            this.Load += new System.EventHandler(this.frmConfirmaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmaciones)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConfirmaciones;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslCantidadDeConfirmaciones;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTiposDeDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroDeLote;
        private System.Windows.Forms.Label lblTotalUnidades;
        private System.Windows.Forms.Label lblTotalCajas;
        private System.Windows.Forms.Label lblTotalPallets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionNombreAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionNotaFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionDocEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionUsuarioAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionArchivoProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionFechaProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionUsuarioProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionCantidadPallets;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionCantidadCajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmacionCantidadUnidades;
    }
}