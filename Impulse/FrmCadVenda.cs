using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impulse
{
    public partial class FrmCadVenda : Form
    {
        private int IdProduto;
        private int IdVenda;
        double valor_pago = 0;
        double precoTemp = 0;
        Operacoes operacao;
        public bool novaVenda;
        private double PrecoTemporario;
        private int alterar = 0;
        public FrmCadVenda()
        {
            InitializeComponent();
        }


        public enum Operacoes
        {
            incluir,
            editar,
            incluirItem,
            editarItem
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
            // TODO: This line of code loads data into the 'banco.pagamento' table. You can move, or remove it, as needed.
            this.pagamentoTableAdapter.Fill(this.banco.pagamento);
            // TODO: This line of code loads data into the 'banco.tccFeira' table. You can move, or remove it, as needed.
            this.tccFeiraTableAdapter.Fill(this.banco.tccFeira);
            // TODO: This line of code loads data into the 'banco.tccCliente' table. You can move, or remove it, as needed.
            this.tccClienteTableAdapter.Fill(this.banco.tccCliente);
            // TODO: This line of code loads data into the 'banco.tccProduto' table. You can move, or remove it, as needed.
            this.tccProdutoTableAdapter.Fill(this.banco.tccProduto);
            // TODO: This line of code loads data into the 'banco.tccItemVenda' table. You can move, or remove it, as needed.
            this.tccItemVendaTableAdapter.Fill(this.banco.tccItemVenda);
            // TODO: This line of code loads data into the 'banco.tccVenda' table. You can move, or remove it, as needed.
            this.tccVendaTableAdapter.Fill(this.banco.tccVenda);

            // TODO: This line of code loads data into the 'db_05266_14_A_1_2017DataSet.tccItemVenda' table. You can move, or remove it, as needed.
            //this.tccItemVendaTableAdapter.Fill(this.db_05266_14_A_1_2017DataSet.tccItemVenda);

        }

        private void habilitaBotoes(bool hab)
        {
            btnGravar.Enabled = hab;
            btnCancelar.Enabled = hab;
        }
        private void habilitaBotoesItem(bool hab)
        {
            btnIncluirItem.Enabled = !hab;
            btnExcluirItem.Enabled = !hab;
            btnGravarItem.Enabled = hab;
            btnCancelarItem.Enabled = hab;
        }



        private void habilitaCampos(bool hab)
        {
            cmbCliente.Enabled = hab;
            cmbFeira.Enabled = hab;
            dtpData.Enabled = hab;
            txtObs.Enabled = hab;
            btnAlterar.Enabled = !hab;
            btnPesquisar.Enabled = !hab;
            btnIncluir.Enabled = !hab;
            btnExcluir.Enabled = !hab;
           

        }

        private void habilitaCamposItem(bool hab)
        {
            cmbProduto.Enabled = hab;
            nudQtd.Enabled = hab;
            txtPrecoUnit.Enabled = hab;
            txtSubTotal.Enabled = hab;


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
            FrmCadVenda_Load(null, null);
            btnCancelar.Enabled = false;
            habilitaBotoes(false);
            habilitaCampos(false);
            alterar = 0;

        }

        private void tccVendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tccVendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            habilitaBotoes(true);
            habilitaCampos(true);
            /*try
            {
                tccVendaTableAdapter.InsertQuery(Convert.ToInt32(cmbCliente.SelectedValue),
                        
                        Convert.ToInt32(cmbFeira.SelectedValue),
                        txtObs.Text, DateTime.Now
                        );
                MessageBox.Show("Salvo com sucesso!",
                       "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmCadVenda_Load(null, null);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados\n" + ex.Message, "Erro ao salvar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao salvar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {



        }

        private void dgvItemVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void cmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodVenda_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable produto = tccProdutoTableAdapter.GetDataByDescricao(cmbProduto.Text);
            precoTemp = 0;

            foreach (DataRow row in produto.Rows)
            {
                precoTemp = Convert.ToDouble(row["valor_unitario"].ToString());
            }
            nudQtd.Value = 1;
            txtPrecoUnit.Text = precoTemp.ToString("#,###,##0.00");
            txtSubTotal.Text = precoTemp.ToString("#,###,##0.00");

        }

        private void txtTotal_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            var venda = (tccVendaBindingSource.Current as DataRowView).Row as banco.tccVendaRow;
            FrmPagar form = new FrmPagar(txtTotal.Text.Replace("R$", ""))
            {
                codCli = venda.cod_cli,
                codVenda = venda.cod_venda
            };
            form.ShowDialog();
            FrmCadVenda_Load(null, null);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (alterar == 0) {
                try
                {
                    tccVendaTableAdapter.InsertQuery(Convert.ToInt32(cmbCliente.SelectedValue),

                            Convert.ToInt32(cmbFeira.SelectedValue),
                            txtObs.Text, DateTime.Now
                            );
                    MessageBox.Show("Salvo com sucesso!",
                           "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmCadVenda_Load(null, null);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro no banco de dados\n" + ex.Message, "Erro ao salvar",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao salvar",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else{
                try
                {
                    tccVendaTableAdapter.Updatezao(
                   Convert.ToInt32(cmbCliente.SelectedValue),
                   DateTime.Now,
                   Convert.ToInt32(cmbFeira.SelectedValue),
                   txtObs.Text, IdVenda);
                    FrmCadVenda_Load(null, null);

                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Erro ao abrir o formulário\n" + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            FrmCadVenda_Load(null, null);
            alterar = 0;
            habilitaCampos(false);
            habilitaBotoes(false);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = Interaction.InputBox("Informe o valor da pesquisa:", "Pesquisa");
            if (!pesquisa.Equals(""))
                tccVendaTableAdapter.FillByNome(banco.tccVenda, "%" + pesquisa + "%");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var venda = (tccVendaBindingSource.Current as DataRowView).Row as banco.tccVendaRow;
                IdVenda = venda.cod_venda;
                if (dgvVendas.RowCount >= 0)
                {
                    if (MessageBox.Show("Deseja excluir a venda selecionada?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        tccItemVendaTableAdapter.DeleteTodos(IdVenda);
                        tccVendaTableAdapter.DeleteQuery(IdVenda);
                        FrmCadVenda_Load(null, null);
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Erro ao selecionar item para excluir\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncluirItem_Click(object sender, EventArgs e)
        {
            habilitaBotoesItem(true);
            habilitaCamposItem(true);
            txtPrecoUnit.Enabled = false;
            txtSubTotal.Enabled = false;

            /*try
            {

                tccItemVendaTableAdapter.InsertQuery(
                IdVenda,
                (int)quantidadeNumericUpDown.Value,
                Convert.ToDouble(txtPrecoUnit.Text),
                (int)iDProdutoComboBox.SelectedValue,
                Convert.ToDouble(txtDesconto.Text));
                MessageBox.Show("Produto inserido com sucesso!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tccVendaDataGridView_SelectionChanged(null, null);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados\n" + ex.Message, "Erro ao inserir produto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao inserir produto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemVendas.RowCount > 0)
                {
                    if (MessageBox.Show("Deseja excluir o produto selecionado?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        tccItemVendaTableAdapter.DeleteQuery(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value), 
                            Convert.ToInt32(dgvItemVendas[2, dgvVendas.CurrentRow.Index].Value));
                        FrmCadVenda_Load(null, null);
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Nenhum objeto selecionado\n" + ex.Message, "Erro ao excluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados\n" + ex.Message, "Erro ao excluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao excluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            FrmCadVenda_Load(null, null);
            btnCancelar.Enabled = false;
            habilitaBotoesItem(false);
            habilitaCamposItem(false);
            alterar = 0;
        }

        private void btnCadastrarItem_Click(object sender, EventArgs e)
        {

        }

        private void tccVendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tccVendaDataGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void txtSubTotal_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void quantidadeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double Subtotal = (double)nudQtd.Value * precoTemp;
            txtSubTotal.Text = Subtotal.ToString("R$ #,###,##0.00");
        }

        private void btnPesquisarItem_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecoUnit_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            habilitaBotoes(true);
            habilitaCamposItem(true);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            habilitaBotoes(true);
            habilitaCampos(true);
            alterar = 1;
            txtObs.Text = dgvVendas[4, dgvVendas.CurrentRow.Index].Value.ToString();
            cmbCliente.SelectedValue = dgvVendas[5, dgvVendas.CurrentRow.Index].Value;
            cmbFeira.SelectedValue = dgvVendas[6, dgvVendas.CurrentRow.Index].Value;
            IdVenda = Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value);

            /*try
            {
                 tccVendaTableAdapter.Updatezao(
                Convert.ToInt32(cmbCliente.SelectedValue),
                DateTime.Now,
                Convert.ToInt32(cmbFeira.SelectedValue),
                txtObs.Text,8);

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Erro ao abrir o formulário\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvVendas_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvVendas.CurrentRow != null ) {
                var venda = (tccVendaBindingSource.Current as DataRowView).Row as banco.tccVendaRow;
            tccItemVendaTableAdapter.FillByCVE(banco.tccItemVenda, Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value));
                double total = 0;
                int z = 0;
                foreach (DataGridViewRow row in dgvItemVendas.Rows)
                {
                    z++;
                    //total += Convert.ToDouble(dgvItemVendas[2, row.Index].ToString());

                }
                for (int i = 0; i < z; i++)
                {
                    total += Convert.ToDouble(dgvItemVendas.Rows[i].Cells[2].Value.ToString());
                    var pgto = pagamentoTableAdapter.GetPagamentos(venda.cod_venda);
                    if (pgto.ToString() == null || pgto.ToString() == "")
                        pgto = 0;

                   /* if (total >= pgto)
                    {
                        dgvItemVendas.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }*/
                }
                txtTotal.Text = total.ToString("R$#,###,##0.00");
                
                //txtTotal.Text = Convert.ToDouble(tccVendaTableAdapter.GetTotal(venda.cod_venda)).ToString();
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            string pesquisa = Interaction.InputBox("Informe o valor da pesquisa:", "Pesquisa");
            if (!pesquisa.Equals(""))
            {
                dgvVendas.ClearSelection();
                tccVendaTableAdapter.FillByname(banco.tccVenda, "%" + pesquisa + "%");
                btnCancelar.Enabled = true;
            }
            }

        private void btnGravarItem_Click(object sender, EventArgs e)
        {
                try
                {
                    tccItemVendaTableAdapter.InsertQuery(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value), Convert.ToInt32(nudQtd.Value), double.Parse(txtSubTotal.Text.Replace("R$","")), Convert.ToInt32(cmbProduto.SelectedValue), 0);
                    MessageBox.Show("Salvo com sucesso!",
                           "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmCadVenda_Load(null, null);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro no banco de dados\n" + ex.Message, "Erro ao salvar",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao salvar",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            habilitaBotoesItem(false);
            habilitaCamposItem(false);
        }

            

        private void btnAlterarItem_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvItemVendas_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}



