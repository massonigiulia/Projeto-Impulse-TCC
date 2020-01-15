using Impulse.db_05266_14_A_1_2017DataSetTableAdapters;
using System;
using System.Data.SqlClient;
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
    public partial class FrmCadFornecedores : Form
    {
        public bool incluir;
        public bool alterar;
        private int codigo;
        public FrmCadFornecedores()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }

        public void FrmCadFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_05266_14_A_1_2017DataSet.tccFornecedor' table. You can move, or remove it, as needed.
            this.tccFornecedorTableAdapter.Fill(this.db_05266_14_A_1_2017DataSet.tccFornecedor);

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (incluir)
                    {
                        tccFornecedorTableAdapter.InsertQuery(
                            txtNome.Text,
                            txtCnpj.Text,
                            txtTel.Text,
                            txtEndereco.Text);
                        MessageBox.Show("Incluído com sucesso!", "Incluir",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tccFornecedorTableAdapter.Fill(this.db_05266_14_A_1_2017DataSet.tccFornecedor);
                    }
                    if (alterar)
                    {
                        //tccClienteTableAdapter.UpdateQuery(txtNome.Text, txtSetor.Text,
                        // txtCpf.Text, txtTel.Text);
                        tccFornecedorTableAdapter.UpdateQuery(txtNome.Text, txtCnpj.Text, txtTel.Text, txtEndereco.Text, codigo);
                        MessageBox.Show("Alterado com sucesso!", "Alterar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    FrmCadFornecedores_Load(null, null);
                    btnCancelar_Click(null, null);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ocorreu um erro no bd:\n" + ex.Message, "Erro:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tccFornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tccFornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_05266_14_A_1_2017DataSet);

        }
        public void Preencher(string fornecedor, string cnpj, string endereco , string telefone, int codigo)
        {
            txtNome.Text = fornecedor;
            txtCnpj.Text = cnpj;
            txtEndereco.Text = endereco;
            txtTel.Text = telefone;

            codigo = codigo;
        }

        private void txtNome_OnValueChanged(object sender, EventArgs e)
        {

        }

        public void FrmCadFornecedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmDadosFornecedores form = Application.OpenForms.OfType<FrmDadosFornecedores>().Single();
            form.FrmDadosFornecedores_Load(null, null);
        }
    }
}
