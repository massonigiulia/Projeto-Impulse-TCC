using Impulse.db_05266_14_A_1_2017DataSetTableAdapters;
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
    public partial class FrmCadClientes : Form
    {
        public bool incluir;
        public bool alterar;
        private int codigo;
        public FrmCadClientes()
        {
            InitializeComponent();
        }



        public void FrmCadClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tccCliente' table. You can move, or remove it, as needed.
            this.tccClienteTableAdapter.Fill(this.banco.tccCliente);
            // TODO: This line of code loads data into the 'db_05266_14_A_1_2017DataSet.tccCliente' table. You can move, or remove it, as needed.
            this.tccClienteTableAdapter.Fill(this.banco.tccCliente);

        }

        private void limpaCampos()
        {
            foreach (Control item in this.Controls)
            {
                if ((item is TextBox))
                {
                    ((TextBox)item).Clear();
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void habilitaBotoes(bool hab)
        {
            btnCadastrar.Enabled = hab;
            btnCancelar.Enabled = hab;
        }

       

        private void habilitaCampos(bool hab)
        { 
            txtNome.Enabled = hab;
            txtSetor.Enabled = hab;
            txtCpf.Enabled = hab;
            txtTel.Enabled = hab;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    tccClienteTableAdapter.Insert(
                        txtNome.Text,
                        txtCpf.Text,
                        txtSetor.Text,
                        txtTel.Text);
                    MessageBox.Show("Incluído com sucesso!", "Incluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tccClienteTableAdapter.Fill(this.banco.tccCliente);
                }
                if (alterar)
            {
                    //tccClienteTableAdapter.UpdateQuery(txtNome.Text, txtSetor.Text,
                    // txtCpf.Text, txtTel.Text);
                    tccClienteTableAdapter.Update(txtNome.Text, txtCpf.Text, txtSetor.Text, txtTel.Text, codigo);
                MessageBox.Show("Alterado com sucesso!", "Alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FrmCadClientes_Load(null, null);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }
        

        private void FrmCadClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmDadosClientes form = Application.OpenForms.OfType<FrmDadosClientes>().Single();
            form.FrmDadosClientes_Load(null, null);
        }
        public void Preencher(string nome, string cpf, string setor, string tel, int cod)
        {
            txtNome.Text = nome;
            txtCpf.Text = cpf;
            txtSetor.Text = setor;
            txtTel.Text = tel;

            codigo = cod;
        }

        private void tccClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tccClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }
    }
}
