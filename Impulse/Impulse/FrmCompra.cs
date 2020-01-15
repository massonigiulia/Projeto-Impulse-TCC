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
    public partial class FrmCompra : Form
    {
       
        public FrmCompra()
        {
            InitializeComponent();
        }


        private void FrmCompra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_05266_14_A_1_2017DataSet.tccItemCompra' table. You can move, or remove it, as needed.
            this.tccItemCompraTableAdapter.Fill(this.db_05266_14_A_1_2017DataSet.tccItemCompra);

        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {

            btnSair.Enabled = false;
            this.Close();
        }

        private void cmbPago_onItemSelected(object sender, EventArgs e)
        {

        }

        private void cmbProduto_onItemSelected(object sender, EventArgs e)
        {

        }

        private void nudQtd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpData_onValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDesconto_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtValorTotal_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void cmbFornecedor_onItemSelected(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
