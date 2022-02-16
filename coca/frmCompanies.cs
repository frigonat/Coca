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
    public partial class frmCompanies : Form
    {
        public frmCompanies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Compania> companias = new List<Compania>();

            companias = Compania.Obtener();
        }
    }
}
