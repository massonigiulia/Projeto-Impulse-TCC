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
    public partial class FrmPagar : Form
    {
        double total;
        public int codCli, codVenda;
        public FrmPagar()
        {
            InitializeComponent();
        }
        public FrmPagar(string dinheiro)
        {
            InitializeComponent();
            total = Convert.ToDouble(dinheiro);
            lblTotal.Text = dinheiro;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            FrmAlterarFeira form = new FrmAlterarFeira();
        }

        private void txtTroco_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtValorRestante_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtTroco.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtValorRestante.Enabled = false;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            if (txtValorRestante.Text.Trim() == "")
            {
                //pagamentoTableAdapter.InsertQuery(codcli, codvenda, valor)
                double recebido, troco;
                recebido = Convert.ToDouble(txtValorRecebido.Text);
                troco = Convert.ToDouble(txtTroco.Text);
                double valor = recebido - troco;
                tccItemVendaTableAdapter.DeleteTodos(codVenda);
                tccVendaTableAdapter.DeleteQuery(codVenda);
                MessageBox.Show("Venda finalizada com sucesso!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                double valor = Convert.ToDouble(txtValorRestante.Text);
                pagamentoTableAdapter1.InsertQuery(codCli, codVenda, valor);
                MessageBox.Show("Venda com pendencia no valor de: " + valor, "Pendente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
           
        }

        private void txtValorRecebido_OnValueChanged(object sender, EventArgs e)
        {
            double toud;
            if (txtValorRecebido.Text.Trim() != "") { 
            if ((total - Convert.ToDouble(txtValorRecebido.Text)) >= 0)
            {
                    toud = (total - Convert.ToDouble(txtValorRecebido.Text));
                    txtValorRestante.Text = toud.ToString();
                    txtTroco.Text = "";
                    
                }
            else
            {

                    toud = (total - Convert.ToDouble(txtValorRecebido.Text));
                    double invert = toud * (-1);
                    txtTroco.Text = invert.ToString();
                    txtValorRestante.Text = "";


                } }
        }

        private void tccVendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tccVendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void FrmPagar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tccItemVenda' table. You can move, or remove it, as needed.
            this.tccItemVendaTableAdapter.Fill(this.banco.tccItemVenda);
            // TODO: This line of code loads data into the 'banco.tccVenda' table. You can move, or remove it, as needed.
            this.tccVendaTableAdapter.Fill(this.banco.tccVenda);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
