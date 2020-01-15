using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impulse
{
    public partial class FrmRptPendencias : Form
    {
        public FrmRptPendencias()
        {
            InitializeComponent();
        }

        private void FrmRptPendencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.pagamento' table. You can move, or remove it, as needed.
            this.pagamentoTableAdapter.Fill(this.banco.pagamento);

            this.reportViewer2.RefreshReport();
        }
    }
}
