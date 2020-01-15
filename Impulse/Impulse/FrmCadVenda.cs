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
    public partial class FrmCadVenda : Form
    {
        public FrmCadVenda()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void FrmCadVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_05266_14_A_1_2017DataSet.tccItemVenda' table. You can move, or remove it, as needed.
            //this.tccItemVendaTableAdapter.Fill(this.db_05266_14_A_1_2017DataSet.tccItemVenda);

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmenu_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }
    }
}
