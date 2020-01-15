using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace Impulse
{
    public partial class FrmDadosClientes : Form
    {
        //Form main;

        public FrmDadosClientes()
        {
            InitializeComponent();
            //this.main = main;
        }

        public FrmDadosClientes(Form main)
        {
            InitializeComponent();
        }




        private void BtnCadCliente_Click(object sender, EventArgs e)
        {
            /*Form teste = new FrmCompra
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            //FrmMenu a = new FrmMenu();

            foreach (Control controle in main.Controls)
            {
                if (controle is Panel)
                {
                    if (controle.Name == "pnlPrincipal")
                    {
                        controle.Controls.Add(teste);
                    }
                }
            }
            btnCadCliente.Enabled = false;
            this.Close();
            teste.Show();*/
            FrmCadClientes form = new FrmCadClientes() { incluir = true };
            form.ShowDialog();
        }

        public void FrmDadosClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tccCliente' table. You can move, or remove it, as needed.
            this.tccClienteTableAdapter.Fill(this.banco.tccCliente);
            this.tccClienteTableAdapter.Fill(this.banco.tccCliente);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var cliente = (tccClienteBindingSource.Current as DataRowView).Row as banco.tccClienteRow;
            FrmCadClientes form = new FrmCadClientes() { alterar = true };
            form.Preencher(cliente.nome, cliente.cpf, cliente.setor, cliente.telefone, cliente.cod_cli);
            form.ShowDialog();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir a venda selecionada?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                try
                {

                    var cliente = (tccClienteBindingSource.Current as DataRowView).Row as banco.tccClienteRow;
                    tccClienteTableAdapter.Delete(cliente.cod_cli);
                    FrmDadosClientes_Load(null, null);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Este cliente está relacionado com uma venda", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
          
           
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = Interaction.InputBox("Informe o valor da pesquisa:", "Pesquisa");
            if (!pesquisa.Equals(""))
                tccClienteTableAdapter.FillByNome(banco.tccCliente, "%" + pesquisa + "%");
        }

        private void tccClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tccClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmDadosClientes_Load(null, null);
        }
    }
}
