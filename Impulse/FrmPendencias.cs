using Impulse.bancoTableAdapters;
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
    public partial class FrmPendencias : Form
    {
        //private bool isCollapsed;
        public FrmPendencias()
        {
            InitializeComponent();
        }
        double totalpendete;
        public int codCli, codVenda;
       

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tccItemVenda' table. You can move, or remove it, as needed.
            this.tccItemVendaTableAdapter.Fill(this.banco.tccItemVenda);
            // TODO: This line of code loads data into the 'banco.tccVenda' table. You can move, or remove it, as needed.
            this.tccVendaTableAdapter.Fill(this.banco.tccVenda);
            // TODO: This line of code loads data into the 'banco.tccVenda' table. You can move, or remove it, as needed.
            this.tccVendaTableAdapter.Fill(this.banco.tccVenda);
            // TODO: This line of code loads data into the 'banco.pagamento' table. You can move, or remove it, as needed.
            this.pagamentoTableAdapter.Fill(this.banco.pagamento);
            // TODO: This line of code loads data into the 'banco.tccVenda' table. You can move, or remove it, as needed.

                // TODO: This line of code loads data into the 'db_05266_14_A_1_2017DataSet.tccPendencias' table. You can move, or remove it, as needed.
                //this.tccPendenciasTableAdapter.Fill(this.db_05266_14_A_1_2017DataSet.tccPendencias);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

        }

        private void dgvPendencias_SelectionChanged(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow item in dgvPendencias.Rows)
            
            //    //var venda = (tccVendaBindingSource.Current as DataRowView).Row as banco.tccVendaRow;
            //    //int cod = Convert.ToInt32(dgvPendencias.Rows[item.Index].Cells[0].Value.ToString());
            //    double total = Convert.ToDouble(tccVendaTableAdapter.GetTotal(cod));
            //    double pagamentos = Convert.ToDouble(pagamentoTableAdapter1.GetPagamentos(cod));
            //    if (total < pagamentos)
            //    {
            //        item.DefaultCellStyle.BackColor = Color.Red;
            //    }
            //    else
            //    {
            //        item.DefaultCellStyle.BackColor = Color.Green;
            //    }
            //}
        }

        private void btnQuitar_Click_1(object sender, EventArgs e)
        {
            if (txtValorRestante.Text.Trim() != "")
            {
                int IdVenda = Convert.ToInt32(dgvPagamentos[0, dgvPagamentos.CurrentRow.Index].Value);
                if (Convert.ToInt32(txtValorRestante.Text) ==  0)
                {
                   
                    pagamentoTableAdapter1.DeleteQuery(IdVenda);
                    tccItemVendaTableAdapter.DeleteTodos(IdVenda);
                    tccVendaTableAdapter.DeleteQuery(IdVenda);
                    MessageBox.Show("Venda finalizada com sucesso!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Refresh();

                }
                else
                {
                    pagamentoTableAdapter1.UpdateQuery(Convert.ToInt32(txtValorRestante.Text), IdVenda);
                }
                //pagamentoTableAdapter.InsertQuery(codcli, codvenda, valor)
                /*double quitado,
                quiatado = Convert.ToDouble(txtQuitacao.Text);
              //  tccItemVendaTableAdapter.DeleteTodos(codVenda);
                //tccVendaTableAdapter.DeleteQuery(codVenda);
                MessageBox.Show("Venda finalizada com sucesso!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();*/

            }
            else
            {
            }
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void dgvPagamentos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPagamentos.CurrentRow.Index != 0);
            txtValorInical.Text = dgvPagamentos[5, dgvPagamentos.CurrentRow.Index].Value.ToString();
        }

        private void txtQuitacao_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNumVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuitacao_TextChanged(object sender, EventArgs e)
        {
            double toud;
            if (txtQuitacao.Text.Trim() != "")
            {
                if ((Convert.ToInt32(txtValorInical.Text) - Convert.ToDouble(txtQuitacao.Text)) >= 0)
                {
                    toud = ((Convert.ToInt32(txtValorInical.Text)) - Convert.ToDouble(txtQuitacao.Text));
                    txtValorRestante.Text = toud.ToString();
                    

                }
                else
                {
                    txtValorRestante.Text = "0";
                }
               
            }
            else if (txtQuitacao.Text == "")
            {

                txtValorRestante.Text = txtValorInical.Text;


            }

        }

        private void txtValorRestante_TextChanged(object sender, EventArgs e)
        {
            txtValorRestante.Enabled = false;
        }
    }
}
