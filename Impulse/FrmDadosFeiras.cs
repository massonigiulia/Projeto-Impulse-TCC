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
    
public partial class FrmDadosFeiras : Form
    {
        public bool incluir;
        public bool alterar;
        private int codigo;
        private int alterar1 = 0;
        private int IdFeira;
        public FrmDadosFeiras()
        {
            InitializeComponent();
            var dias = cmbDias;
            dias.Items.Add("Segunda-Feira");
            dias.Items.Add("Terça-Feira");
            dias.Items.Add("Quarta-Feira");
            dias.Items.Add("Quinta-Feira");
            dias.Items.Add("Sexta-Feira");
            dias.Items.Add("Sábado");
            dias.Items.Add("Domingo");
        }

        private void habilitaBotoes(bool hab)
        {
            btnCadastrar.Enabled = hab;
            bunifuFlatButton1.Enabled = hab;
        }

        private void habilitaCampos(bool hab)
        {
            txtNome.Enabled = hab;
            cmbDias.Enabled = hab;
            txtEndereco.Enabled = hab;
            btnAlterar.Enabled = !hab;
            btnPesquisar.Enabled = !hab;
            btnIncluir.Enabled = !hab;
            btnExcluir.Enabled = !hab;

        }

        private void BunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel6_Click_1(object sender, EventArgs e)
        {

        }


        public void FrmDadosFeiras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tccFeira' table. You can move, or remove it, as needed.
            this.tccFeiraTableAdapter.Fill(this.banco.tccFeira);
            // TODO: This line of code loads data into the 'db_05266_14_A_1_2017DataSet.tccFeira' table. You can move, or remove it, as needed.
            this.tccFeiraTableAdapter.Fill(this.banco.tccFeira);

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            
        }

        private void tccFeiraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tccFeiraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (alterar1 == 0)
            {
                try
                {
                    tccFeiraTableAdapter.InsertQuery(
                        txtNome.Text,
                       cmbDias.Text,
                   txtEndereco.Text);
                    MessageBox.Show("Incluído com sucesso!", "Incluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tccFeiraTableAdapter.Fill(this.banco.tccFeira);

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

            else
            {
                try
                {
                    tccFeiraTableAdapter.UpdateQuery(txtNome.Text, cmbDias.Text, txtEndereco.Text, IdFeira);
                    MessageBox.Show("Alterado com sucesso!", "Alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmDadosFeiras_Load(null, null);

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
            FrmDadosFeiras_Load(null, null);
            alterar1 = 0;
            habilitaCampos(false);
            habilitaBotoes(false);

        }
        private void FrmDadosFeiras_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmDadosFeiras form = Application.OpenForms.OfType<FrmDadosFeiras>().Single();
            form.FrmDadosFeiras_Load(null, null);
        }

        public void Preencher(string nome, string data_feira, string localizacao_feira, int cod)
        {
            txtNome.Text = nome;
            cmbDias.Text = data_feira;
            txtEndereco.Text = localizacao_feira;

            codigo = cod;
        }

        private void cmbDias_onItemSelected(object sender, EventArgs e)
        {

           
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {


            habilitaBotoes(true);
            habilitaCampos(true);
            alterar1 = 1;
            txtNome.Text = tccFeiraDataGridView[1, tccFeiraDataGridView.CurrentRow.Index].Value.ToString();
            cmbDias.SelectedValue = tccFeiraDataGridView[2, tccFeiraDataGridView.CurrentRow.Index].Value;
            txtEndereco.Text = tccFeiraDataGridView[3, tccFeiraDataGridView.CurrentRow.Index].Value.ToString();
            IdFeira = Convert.ToInt32(tccFeiraDataGridView[0, tccFeiraDataGridView.CurrentRow.Index].Value);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = Interaction.InputBox("Informe o valor da pesquisa:", "Pesquisa");
            if (!pesquisa.Equals(""))
               tccFeiraTableAdapter.FillByNome(banco.tccFeira, "%" + pesquisa + "%");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir a feira?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try

            {
                var feira = (tccFeiraBindingSource.Current as DataRowView).Row as banco.tccFeiraRow;
                tccFeiraTableAdapter.DeleteQuery(feira.cod_feira);
                FrmDadosFeiras_Load(null, null);

            }
            catch (SqlException)
            {

                MessageBox.Show("Esta feira está relacionada com uma venda", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cmbDias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tccFeiraBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tccFeiraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void doubleBitmapControl1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmDadosFeiras_Load(null, null);
            bunifuFlatButton1.Enabled = false;
            habilitaBotoes(false);
            habilitaCampos(false);
        }

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {
            habilitaBotoes(true);
            habilitaCampos(true);
        }
    }
}
