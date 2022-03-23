namespace coca
{
    partial class frmDocumentoRecepcion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Unidad 1");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Unidad 2");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Caja1", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Caja2");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Pallet1", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Caja 1");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Caja2");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Pallet 2", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Documento", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode17});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentoRecepcion));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvContenido = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblPartner = new System.Windows.Forms.Label();
            this.lblDeclarante = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTransportista = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.fraContenido = new System.Windows.Forms.GroupBox();
            this.lblCantidadDeUnidades = new System.Windows.Forms.Label();
            this.lblCantidadDeCajas = new System.Windows.Forms.Label();
            this.lblCantidadDePallets = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblPartnerDestino = new System.Windows.Forms.Label();
            this.lblPartnerOrigen = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNroDocumentoRecepcion = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTipoDeDocumento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlmacen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fraConfirmacion = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUsuarioDeProceso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaHoraProceso = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblFechaHoraRecepcion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fraProductos = new System.Windows.Forms.GroupBox();
            this.lvwProductos = new System.Windows.Forms.ListView();
            this.imagenesLotes = new System.Windows.Forms.ImageList(this.components);
            this.fraLotes = new System.Windows.Forms.GroupBox();
            this.lvwLotes = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCantidadDeProductosDiferentes = new System.Windows.Forms.Label();
            this.lblCantidadDeLotesDiferentes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRecuperarContenido = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.fraContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.fraConfirmacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.fraProductos.SuspendLayout();
            this.fraLotes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 634);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 24);
            this.statusStrip1.TabIndex = 0;
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
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabel2.Text = "...";
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
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel6.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabel6.Text = "...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1084, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvContenido);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 609);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.TabIndex = 2;
            // 
            // trvContenido
            // 
            this.trvContenido.BackColor = System.Drawing.Color.LightCyan;
            this.trvContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvContenido.Location = new System.Drawing.Point(0, 0);
            this.trvContenido.Name = "trvContenido";
            treeNode10.Name = "Nodo14";
            treeNode10.Text = "Unidad 1";
            treeNode11.Name = "Nodo15";
            treeNode11.Text = "Unidad 2";
            treeNode12.Name = "Nodo3";
            treeNode12.Text = "Caja1";
            treeNode13.Name = "Nodo6";
            treeNode13.Text = "Caja2";
            treeNode14.Name = "Nodo2";
            treeNode14.Text = "Pallet1";
            treeNode15.Name = "Nodo12";
            treeNode15.Text = "Caja 1";
            treeNode16.Name = "Nodo13";
            treeNode16.Text = "Caja2";
            treeNode17.Name = "Nodo11";
            treeNode17.Text = "Pallet 2";
            treeNode18.Name = "Nodo0";
            treeNode18.Text = "Documento";
            this.trvContenido.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.trvContenido.Size = new System.Drawing.Size(488, 605);
            this.trvContenido.TabIndex = 0;
            this.trvContenido.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvContenido_BeforeExpand);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 605);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblPartner);
            this.tabPage1.Controls.Add(this.lblDeclarante);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.lblTransportista);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.fraContenido);
            this.tabPage1.Controls.Add(this.lblEstado);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.lblPartnerDestino);
            this.tabPage1.Controls.Add(this.lblPartnerOrigen);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.lblNroDocumentoRecepcion);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.lblNotaFiscal);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.lblNroDocumento);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.lblTipoDeDocumento);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblCNPJ);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblAlmacen);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cabecera";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblPartner
            // 
            this.lblPartner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPartner.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartner.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPartner.Location = new System.Drawing.Point(68, 217);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(195, 23);
            this.lblPartner.TabIndex = 25;
            this.lblPartner.Text = "label22";
            this.lblPartner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeclarante
            // 
            this.lblDeclarante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeclarante.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeclarante.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDeclarante.Location = new System.Drawing.Point(84, 174);
            this.lblDeclarante.Name = "lblDeclarante";
            this.lblDeclarante.Size = new System.Drawing.Size(195, 23);
            this.lblDeclarante.TabIndex = 24;
            this.lblDeclarante.Text = "label20";
            this.lblDeclarante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 179);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Declarante:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 222);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Partner:";
            // 
            // lblTransportista
            // 
            this.lblTransportista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTransportista.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportista.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTransportista.Location = new System.Drawing.Point(96, 262);
            this.lblTransportista.Name = "lblTransportista";
            this.lblTransportista.Size = new System.Drawing.Size(195, 23);
            this.lblTransportista.TabIndex = 21;
            this.lblTransportista.Text = "label13";
            this.lblTransportista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Transportista:";
            // 
            // fraContenido
            // 
            this.fraContenido.Controls.Add(this.lblCantidadDeUnidades);
            this.fraContenido.Controls.Add(this.lblCantidadDeCajas);
            this.fraContenido.Controls.Add(this.lblCantidadDePallets);
            this.fraContenido.Controls.Add(this.pictureBox3);
            this.fraContenido.Controls.Add(this.pictureBox2);
            this.fraContenido.Controls.Add(this.pictureBox1);
            this.fraContenido.Location = new System.Drawing.Point(428, 179);
            this.fraContenido.Name = "fraContenido";
            this.fraContenido.Size = new System.Drawing.Size(134, 353);
            this.fraContenido.TabIndex = 19;
            this.fraContenido.TabStop = false;
            this.fraContenido.Text = "Contenido:";
            // 
            // lblCantidadDeUnidades
            // 
            this.lblCantidadDeUnidades.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeUnidades.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCantidadDeUnidades.Location = new System.Drawing.Point(0, 327);
            this.lblCantidadDeUnidades.Name = "lblCantidadDeUnidades";
            this.lblCantidadDeUnidades.Size = new System.Drawing.Size(128, 23);
            this.lblCantidadDeUnidades.TabIndex = 22;
            this.lblCantidadDeUnidades.Text = "label15";
            this.lblCantidadDeUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadDeCajas
            // 
            this.lblCantidadDeCajas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeCajas.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCantidadDeCajas.Location = new System.Drawing.Point(6, 215);
            this.lblCantidadDeCajas.Name = "lblCantidadDeCajas";
            this.lblCantidadDeCajas.Size = new System.Drawing.Size(122, 23);
            this.lblCantidadDeCajas.TabIndex = 21;
            this.lblCantidadDeCajas.Text = "label15";
            this.lblCantidadDeCajas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadDePallets
            // 
            this.lblCantidadDePallets.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDePallets.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCantidadDePallets.Location = new System.Drawing.Point(6, 96);
            this.lblCantidadDePallets.Name = "lblCantidadDePallets";
            this.lblCantidadDePallets.Size = new System.Drawing.Size(122, 23);
            this.lblCantidadDePallets.TabIndex = 20;
            this.lblCantidadDePallets.Text = "label15";
            this.lblCantidadDePallets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::coca.Properties.Resources.pills_strips_icon_48;
            this.pictureBox3.Location = new System.Drawing.Point(29, 252);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::coca.Properties.Resources._49590_boxes_customers_inventory_products_icon_64;
            this.pictureBox2.Location = new System.Drawing.Point(28, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblEstado.Location = new System.Drawing.Point(68, 462);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(285, 23);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "label24";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 467);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 17;
            this.label23.Text = "Estado:";
            // 
            // lblPartnerDestino
            // 
            this.lblPartnerDestino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPartnerDestino.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartnerDestino.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPartnerDestino.Location = new System.Drawing.Point(110, 414);
            this.lblPartnerDestino.Name = "lblPartnerDestino";
            this.lblPartnerDestino.Size = new System.Drawing.Size(285, 23);
            this.lblPartnerDestino.TabIndex = 16;
            this.lblPartnerDestino.Text = "label19";
            this.lblPartnerDestino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartnerOrigen
            // 
            this.lblPartnerOrigen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPartnerOrigen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartnerOrigen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPartnerOrigen.Location = new System.Drawing.Point(110, 368);
            this.lblPartnerOrigen.Name = "lblPartnerOrigen";
            this.lblPartnerOrigen.Size = new System.Drawing.Size(285, 23);
            this.lblPartnerOrigen.TabIndex = 15;
            this.lblPartnerOrigen.Text = "label18";
            this.lblPartnerOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 419);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Partner Destino:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 373);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Partner Origen:";
            // 
            // lblNroDocumentoRecepcion
            // 
            this.lblNroDocumentoRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNroDocumentoRecepcion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocumentoRecepcion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNroDocumentoRecepcion.Location = new System.Drawing.Point(428, 118);
            this.lblNroDocumentoRecepcion.Name = "lblNroDocumentoRecepcion";
            this.lblNroDocumentoRecepcion.Size = new System.Drawing.Size(71, 23);
            this.lblNroDocumentoRecepcion.TabIndex = 12;
            this.lblNroDocumentoRecepcion.Text = "label15";
            this.lblNroDocumentoRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(251, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Nro. de Documento de Recepción:";
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNotaFiscal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaFiscal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNotaFiscal.Location = new System.Drawing.Point(92, 316);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(195, 23);
            this.lblNotaFiscal.TabIndex = 10;
            this.lblNotaFiscal.Text = "label13";
            this.lblNotaFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Nota Fiscal:";
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNroDocumento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocumento.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNroDocumento.Location = new System.Drawing.Point(141, 118);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(71, 23);
            this.lblNroDocumento.TabIndex = 8;
            this.lblNroDocumento.Text = "label11";
            this.lblNroDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Nro. de Documento ID:";
            // 
            // lblTipoDeDocumento
            // 
            this.lblTipoDeDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTipoDeDocumento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeDocumento.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTipoDeDocumento.Location = new System.Drawing.Point(121, 69);
            this.lblTipoDeDocumento.Name = "lblTipoDeDocumento";
            this.lblTipoDeDocumento.Size = new System.Drawing.Size(214, 23);
            this.lblTipoDeDocumento.TabIndex = 6;
            this.lblTipoDeDocumento.Text = "label6";
            this.lblTipoDeDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo de Documento:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCNPJ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCNPJ.Location = new System.Drawing.Point(373, 21);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(117, 23);
            this.lblCNPJ.TabIndex = 4;
            this.lblCNPJ.Text = "label4";
            this.lblCNPJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CNPJ:";
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlmacen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAlmacen.Location = new System.Drawing.Point(84, 21);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(214, 23);
            this.lblAlmacen.TabIndex = 2;
            this.lblAlmacen.Text = "label2";
            this.lblAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Almacén:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fraConfirmacion);
            this.tabPage2.Controls.Add(this.lblUsuarioDeProceso);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lblFechaHoraProceso);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.lblFechaHoraRecepcion);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lblEvento);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auditoría";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fraConfirmacion
            // 
            this.fraConfirmacion.Controls.Add(this.pictureBox6);
            this.fraConfirmacion.Controls.Add(this.pictureBox5);
            this.fraConfirmacion.Controls.Add(this.label11);
            this.fraConfirmacion.Location = new System.Drawing.Point(21, 336);
            this.fraConfirmacion.Name = "fraConfirmacion";
            this.fraConfirmacion.Size = new System.Drawing.Size(530, 213);
            this.fraConfirmacion.TabIndex = 17;
            this.fraConfirmacion.TabStop = false;
            this.fraConfirmacion.Text = "Confirmación:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::coca.Properties.Resources.database_remove_icon128;
            this.pictureBox6.Location = new System.Drawing.Point(15, 36);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(145, 141);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::coca.Properties.Resources.sad_icon;
            this.pictureBox5.Location = new System.Drawing.Point(454, 138);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 49);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(166, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(236, 49);
            this.label11.TabIndex = 16;
            this.label11.Text = "No disponible por rotura de la trazabilidad.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuarioDeProceso
            // 
            this.lblUsuarioDeProceso.BackColor = System.Drawing.Color.White;
            this.lblUsuarioDeProceso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuarioDeProceso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioDeProceso.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUsuarioDeProceso.Location = new System.Drawing.Point(127, 217);
            this.lblUsuarioDeProceso.Name = "lblUsuarioDeProceso";
            this.lblUsuarioDeProceso.Size = new System.Drawing.Size(214, 23);
            this.lblUsuarioDeProceso.TabIndex = 14;
            this.lblUsuarioDeProceso.Text = "label22";
            this.lblUsuarioDeProceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Usuario de Proceso:";
            // 
            // lblFechaHoraProceso
            // 
            this.lblFechaHoraProceso.BackColor = System.Drawing.Color.White;
            this.lblFechaHoraProceso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaHoraProceso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraProceso.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFechaHoraProceso.Location = new System.Drawing.Point(153, 154);
            this.lblFechaHoraProceso.Name = "lblFechaHoraProceso";
            this.lblFechaHoraProceso.Size = new System.Drawing.Size(214, 23);
            this.lblFechaHoraProceso.TabIndex = 12;
            this.lblFechaHoraProceso.Text = "label22";
            this.lblFechaHoraProceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 159);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(129, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Fecha / Hora de Proceso:";
            // 
            // lblFechaHoraRecepcion
            // 
            this.lblFechaHoraRecepcion.BackColor = System.Drawing.Color.White;
            this.lblFechaHoraRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaHoraRecepcion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraRecepcion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFechaHoraRecepcion.Location = new System.Drawing.Point(164, 37);
            this.lblFechaHoraRecepcion.Name = "lblFechaHoraRecepcion";
            this.lblFechaHoraRecepcion.Size = new System.Drawing.Size(214, 23);
            this.lblFechaHoraRecepcion.TabIndex = 10;
            this.lblFechaHoraRecepcion.Text = "label20";
            this.lblFechaHoraRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fecha / Hora de Recepción:";
            // 
            // lblEvento
            // 
            this.lblEvento.BackColor = System.Drawing.Color.White;
            this.lblEvento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEvento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblEvento.Location = new System.Drawing.Point(69, 94);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(214, 23);
            this.lblEvento.TabIndex = 8;
            this.lblEvento.Text = "label7";
            this.lblEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Evento:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.fraProductos);
            this.tabPage3.Controls.Add(this.fraLotes);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.btnRecuperarContenido);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(576, 579);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contenido";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fraProductos
            // 
            this.fraProductos.Controls.Add(this.lvwProductos);
            this.fraProductos.Location = new System.Drawing.Point(20, 357);
            this.fraProductos.Name = "fraProductos";
            this.fraProductos.Size = new System.Drawing.Size(535, 203);
            this.fraProductos.TabIndex = 6;
            this.fraProductos.TabStop = false;
            this.fraProductos.Text = "Productos";
            // 
            // lvwProductos
            // 
            this.lvwProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwProductos.HideSelection = false;
            this.lvwProductos.LargeImageList = this.imagenesLotes;
            this.lvwProductos.Location = new System.Drawing.Point(6, 20);
            this.lvwProductos.Name = "lvwProductos";
            this.lvwProductos.Size = new System.Drawing.Size(523, 177);
            this.lvwProductos.TabIndex = 3;
            this.lvwProductos.UseCompatibleStateImageBehavior = false;
            // 
            // imagenesLotes
            // 
            this.imagenesLotes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagenesLotes.ImageStream")));
            this.imagenesLotes.TransparentColor = System.Drawing.Color.Transparent;
            this.imagenesLotes.Images.SetKeyName(0, "49590_boxes_customers_inventory_products_icon_48.png");
            this.imagenesLotes.Images.SetKeyName(1, "pills-3-icon.png");
            // 
            // fraLotes
            // 
            this.fraLotes.Controls.Add(this.lvwLotes);
            this.fraLotes.Location = new System.Drawing.Point(20, 116);
            this.fraLotes.Name = "fraLotes";
            this.fraLotes.Size = new System.Drawing.Size(535, 203);
            this.fraLotes.TabIndex = 5;
            this.fraLotes.TabStop = false;
            this.fraLotes.Text = "Lotes";
            // 
            // lvwLotes
            // 
            this.lvwLotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwLotes.HideSelection = false;
            this.lvwLotes.LargeImageList = this.imagenesLotes;
            this.lvwLotes.Location = new System.Drawing.Point(6, 20);
            this.lvwLotes.Name = "lvwLotes";
            this.lvwLotes.Size = new System.Drawing.Size(523, 177);
            this.lvwLotes.TabIndex = 2;
            this.lvwLotes.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCantidadDeProductosDiferentes);
            this.groupBox1.Controls.Add(this.lblCantidadDeLotesDiferentes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(20, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen:";
            // 
            // lblCantidadDeProductosDiferentes
            // 
            this.lblCantidadDeProductosDiferentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadDeProductosDiferentes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeProductosDiferentes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCantidadDeProductosDiferentes.Location = new System.Drawing.Point(264, 23);
            this.lblCantidadDeProductosDiferentes.Name = "lblCantidadDeProductosDiferentes";
            this.lblCantidadDeProductosDiferentes.Size = new System.Drawing.Size(71, 23);
            this.lblCantidadDeProductosDiferentes.TabIndex = 10;
            this.lblCantidadDeProductosDiferentes.Text = "0";
            this.lblCantidadDeProductosDiferentes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCantidadDeLotesDiferentes
            // 
            this.lblCantidadDeLotesDiferentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadDeLotesDiferentes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeLotesDiferentes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCantidadDeLotesDiferentes.Location = new System.Drawing.Point(58, 23);
            this.lblCantidadDeLotesDiferentes.Name = "lblCantidadDeLotesDiferentes";
            this.lblCantidadDeLotesDiferentes.Size = new System.Drawing.Size(71, 23);
            this.lblCantidadDeLotesDiferentes.TabIndex = 9;
            this.lblCantidadDeLotesDiferentes.Text = "0";
            this.lblCantidadDeLotesDiferentes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Productos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lotes:";
            // 
            // btnRecuperarContenido
            // 
            this.btnRecuperarContenido.Location = new System.Drawing.Point(480, 44);
            this.btnRecuperarContenido.Name = "btnRecuperarContenido";
            this.btnRecuperarContenido.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperarContenido.TabIndex = 1;
            this.btnRecuperarContenido.Text = "Recuperar";
            this.btnRecuperarContenido.UseVisualStyleBackColor = true;
            this.btnRecuperarContenido.Click += new System.EventHandler(this.btnRecuperarContenido_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(576, 579);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "XML";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::coca.Properties.Resources.under_construction;
            this.pictureBox4.Location = new System.Drawing.Point(121, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(261, 189);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // frmDocumentoRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 658);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDocumentoRecepcion";
            this.Text = "Documento de Recepcion ...";
            this.Load += new System.EventHandler(this.frmDocumentoRecepcion_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.fraContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.fraConfirmacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.fraProductos.ResumeLayout(false);
            this.fraLotes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvContenido;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTipoDeDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlmacen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPartnerDestino;
        private System.Windows.Forms.Label lblPartnerOrigen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblNroDocumentoRecepcion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFechaHoraProceso;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblFechaHoraRecepcion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox fraContenido;
        private System.Windows.Forms.Label lblCantidadDeUnidades;
        private System.Windows.Forms.Label lblCantidadDeCajas;
        private System.Windows.Forms.Label lblCantidadDePallets;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuarioDeProceso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRecuperarContenido;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lvwProductos;
        private System.Windows.Forms.ListView lvwLotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCantidadDeProductosDiferentes;
        private System.Windows.Forms.Label lblCantidadDeLotesDiferentes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox fraProductos;
        private System.Windows.Forms.GroupBox fraLotes;
        private System.Windows.Forms.ImageList imagenesLotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPartner;
        private System.Windows.Forms.Label lblDeclarante;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblTransportista;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox fraConfirmacion;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}