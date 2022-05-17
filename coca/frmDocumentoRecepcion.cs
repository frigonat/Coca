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
    public partial class frmDocumentoRecepcion : Form
    {

        private Documento documentoActual;
        private List<string> lotesActuales;
        private List<string> unidadesActuales;

        public frmDocumentoRecepcion()
        {
            InitializeComponent();
        }

        public void Mostrar(Documento documentoRecibido)
        {
            documentoActual = documentoRecibido;
            this.mostrar();

            FormCollection fc = Application.OpenForms;
            this.MdiParent = fc[0];
        }

        private void mostrar()
        {
            this.Text = "Documento de Recepción " + documentoActual.Numero.ToString();
            this.Show();
        }

        public void Mostrar()
        {
            this.Show();
        }  

        private void frmDocumentoRecepcion_Load(object sender, EventArgs e)
        {
            List<Pallet> pallets = new List<Pallet>();
            List<Caja> cajas = new List<Caja>();
            List<Unidad> unidades = new List<Unidad>();

            pallets = documentoActual.ObtenerPallets();

            trvContenido.Nodes.Clear();
            int contadorDePallets = 1;
            int indicePallet = 0;
            //int indiceCajas = 0;

            trvContenido.Nodes.Add("Documento " + documentoActual.Numero.ToString() + " " + documentoActual.Evento);

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

            lblAlmacen.Text = documentoActual.NombreDeAlmacen + "(" + documentoActual.CodigoDeAlmacen + ")";
            lblCNPJ.Text = documentoActual.CNPJ_Almacen;
            lblNroDocumento.Text = documentoActual.Numero.ToString();
            lblNotaFiscal.Text = documentoActual.NumeroNotaFiscal;
            lblTipoDeDocumento.Text = documentoActual.Tipo.Descripcion;
            lblNroDocumentoRecepcion.Text = documentoActual.NumeroDocumentoDeEntrada;
            lblEstado.Text = "";

            lblCantidadDePallets.Text = documentoActual.CantidadDePallets.ToString() + " Pallets";
            lblCantidadDeCajas.Text = documentoActual.CantidadDeCajas.ToString() + " Cajas";
            lblCantidadDeUnidades.Text = documentoActual.CantidadDeUnidades.ToString() + " Unidades";

            lblFechaHoraRecepcion.Text = documentoActual.FechaHoraDeAlta.ToString("dd.MM.yyyy - hh:MM:ss");
            if (documentoActual.FechaHoraDeProceso.ToString("yyyy") == "1900")
                lblFechaHoraProceso.Text = "";
            else
                lblFechaHoraProceso.Text = documentoActual.FechaHoraDeProceso.ToString("dd.MM.yyyy - hh:MM:ss");

            lblUsuarioDeProceso.Text = documentoActual.UsuarioDeProceso;
            lblEvento.Text = documentoActual.Evento;
            lblEvtNotifId.Text = documentoActual.EvtNotifId;
            lblEstado.Text = documentoActual.Estado.ToString();

            lblPartnerOrigen.Text = documentoActual.CnpjSOAP_Sender;
            lblPartnerDestino.Text = documentoActual.CnpjSOAP_Receiver;

            lblPartner.Text = documentoActual.CnpjPartner;
            lblDeclarante.Text = documentoActual.CnpjDeclarante;
            lblTransportista.Text = documentoActual.CnpjTransporte;
        }

        private void btnRecuperarContenido_Click(object sender, EventArgs e)
        {
            lvwLotes.Items.Clear();
            lvwProductos.Items.Clear();

            lotesActuales = documentoActual.ObtenerLotes();
            unidadesActuales = documentoActual.ObtenerUnidades();

            foreach (string lote in lotesActuales)
                lvwLotes.Items.Add("Lote " + lote, 0);

            foreach (string unidad in unidadesActuales)
                lvwProductos.Items.Add("SKU " + unidad, 1);

            lblCantidadDeLotesDiferentes.Text = lotesActuales.Count().ToString();
            lblCantidadDeProductosDiferentes.Text = unidadesActuales.Count().ToString();
        }

        private void trvContenido_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (trvContenido.SelectedNode != null)
            {
                if (e.Node.Text.Substring(0,6) == "Pallet")
                {
                    List<string> cajas = documentoActual.ObtenerCajas(e.Node.Name);

                    trvContenido.Nodes[0].Nodes[e.Node.Index].Nodes[0].Remove();   //retiro el phantom

                    foreach (string  ssccCaja in cajas)
                        trvContenido.Nodes[0].Nodes[e.Node.Index].Nodes.Add("Caja: " + ssccCaja);
                }

                //MessageBox.Show(trvContenido.SelectedNode.Text);
                //MessageBox.Show(e.Node.Text);
            }
        }


    }
}
