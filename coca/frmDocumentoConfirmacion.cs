using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coca
{
    public partial class frmDocumentoConfirmacion : Form
    {
        private Confirmacion confirmacionActual;
        private List<string> lotesActuales;
        private List<string> unidadesActuales;

        public frmDocumentoConfirmacion()
        {
            InitializeComponent();
        }

        public void Mostrar(Confirmacion confirmacionRecibida )
        {
            confirmacionActual = confirmacionRecibida;
            this.mostrar();

            FormCollection fc = Application.OpenForms;
            this.MdiParent = fc[0];
        }

        private void mostrar()
        {
            this.Text = "Documento de Confirmación " + confirmacionActual.Numero.ToString();
            this.Show();
        }

        public void Mostrar()
        {
            this.Show();
        }

        private void frmDocumentoConfirmacion_Load(object sender, EventArgs e)
        {
            List<Pallet> pallets = new List<Pallet>();
            List<Caja> cajas = new List<Caja>();
            List<Unidad> unidades = new List<Unidad>();

            pallets = confirmacionActual.ObtenerPallets();

            trvContenido.Nodes.Clear();
            int contadorDePallets = 1;
            int indicePallet = 0;
            //int indiceCajas = 0;

            trvContenido.Nodes.Add("Confirmación " + confirmacionActual.Numero.ToString() + " " + confirmacionActual.Evento);
            confirmacionActual.ObtenerPallets();

            foreach (Pallet p in pallets)
            {
                trvContenido.Nodes[0].Nodes.Add(p.CodigoSSCC, "Pallet " + contadorDePallets.ToString() + ": " + p.CodigoSSCC);
                trvContenido.Nodes[0].Nodes[indicePallet].Nodes.Add("Phantom");

                //cajas = p.ObtenerCajas();
                //foreach (Caja c in cajas)
                //{
                //    trvContenido.Nodes[0].Nodes[indicePallet].Nodes.Add(c.CodigoSSCC);

                //    unidades = c.ObtenerUnidades();
                //    foreach (Unidad d in unidades)
                //        trvContenido.Nodes[0].Nodes[indicePallet].Nodes[indiceCajas].Nodes.Add(d.NumeroDeSerie);

                //    indiceCajas++;
                //}

                indicePallet++;
                //indiceCajas = 0;
                contadorDePallets++;
            }

            trvContenido.Nodes[0].Expand();

            lblAlmacen.Text = confirmacionActual.NombreDeAlmacen + "(" + confirmacionActual.CodigoDeAlmacen + ")";
            lblCNPJ.Text = confirmacionActual.CNPJ_Almacen;
            lblTipoDeDocumento.Text = confirmacionActual.Tipo.Descripcion;
            lblNroDocumento.Text = confirmacionActual.Numero.ToString();
            lblNroDocumentoRecepcion.Text = confirmacionActual.NumeroDocumentoDeEntrada;
            lblPartner.Text = confirmacionActual.CnpjPartner;
            lblDeclarante.Text = confirmacionActual.CnpjDeclarante;
            lblTransportista.Text = confirmacionActual.CnpjTransporte;
            lblNotaFiscal.Text = confirmacionActual.NumeroNotaFiscal;
            lblEstado.Text = confirmacionActual.Estado.ToString();

            lblPartnerOrigen.Text = confirmacionActual.CnpjSOAP_Sender;
            lblPartnerDestino.Text = confirmacionActual.CnpjSOAP_Receiver;

            //Contenido
            lblCantidadDePallets.Text = confirmacionActual.CantidadDePallets.ToString() + " Pallets";
            lblCantidadDeCajas.Text = confirmacionActual.CantidadDeCajas.ToString() + " Cajas";
            lblCantidadDeUnidades.Text = confirmacionActual.CantidadDeUnidades.ToString() + " Unidades";

            //Datos de Auditoría
            lblEvento.Text = confirmacionActual.Evento;
            lblEvtNotifId.Text = confirmacionActual.EvtNotifId;

            lblFechaDeAlta.Text = confirmacionActual.FechaHoraDeAlta.ToString("dd.MM.yyyy");
            lblUsuarioDeAlta.Text = confirmacionActual.UsuarioDeAlta;

            lblFechaDeProceso.Text = confirmacionActual.FechaHoraDeAlta.ToString("dd.MM.yyyy");
            if (confirmacionActual.FechaHoraDeProceso.ToString("yyyy") == "1900")
                lblFechaDeProceso.Text = "";
            else
                lblFechaDeProceso.Text = confirmacionActual.FechaHoraDeProceso.ToString("dd.MM.yyyy");

            lblUsuarioDeProceso.Text = confirmacionActual.UsuarioDeProceso;
            lblArchivoDeProceso.Text = confirmacionActual.NombreArchivoDeTransmision;
        }

        private void trvContenido_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (trvContenido.SelectedNode != null)
            {
                if (e.Node.Text.Substring(0, 6) == "Pallet")
                {
                    List<string> cajas = confirmacionActual.ObtenerCajas(e.Node.Name);

                    trvContenido.Nodes[0].Nodes[e.Node.Index].Nodes[0].Remove();   //retiro el phantom

                    foreach (string ssccCaja in cajas)
                        trvContenido.Nodes[0].Nodes[e.Node.Index].Nodes.Add("Caja: " + ssccCaja);
                }
            }
        }

        private void btnRecuperarProductosLotes_Click(object sender, EventArgs e)
        {
            lvwLotes.Items.Clear();
            lvwProductos.Items.Clear();
            
            lotesActuales = confirmacionActual.ObtenerLotes();
            unidadesActuales = confirmacionActual.ObtenerUnidades();

            foreach (string lote in lotesActuales)
                lvwLotes.Items.Add("Lote " + lote, 0);

            foreach (string unidad in unidadesActuales)
                lvwProductos.Items.Add("SKU " + unidad, 1);

            lblCantidadDeLotesDiferentes.Text = lotesActuales.Count().ToString();
            lblCantidadDeProductosDiferentes.Text = unidadesActuales.Count().ToString();
        }

        private void trvContenido_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                pctNumero1.Visible = false;
                pctNumero2.Visible = false;
                pctNumero3.Visible = false;
            }

            if (e.Node.Level == 1)
            {


                pctNumero1.Visible = true;
                pctNumero2.Visible = false;
                pctNumero3.Visible = false;

                string x = "";
                x = e.Node.Text;
                int r = x.IndexOf(":");
                string xx = x.Substring(r+1).Trim();
                Pallet p = new Pallet(xx, confirmacionActual.Numero);

                lblPalletCantidadCajas.Text = p.CantidadCajas.ToString();
                lblPalletDocumento.Text = p.NumeroDocumento.ToString();
                lblPalletSSCC.Text = p.CodigoSSCC.ToString();


            }

            if (e.Node.Level == 2)
            {
                pctNumero1.Visible = false;
                pctNumero2.Visible = true;
                pctNumero3.Visible = false;
            }

            if (e.Node.Level == 3)
            {
                pctNumero1.Visible = false;
                pctNumero2.Visible = false;
                pctNumero3.Visible = true;
            }
        }
    }
}
