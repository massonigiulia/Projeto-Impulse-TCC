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
            this.tccClienteTableAdapter.Fill(this.db_05266_14_A_1_2017DataSet1.tccCliente);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var cliente = (tccClienteBindingSource.Current as DataRowView).Row as db_05266_14_A_1_2017DataSet.tccClienteRow;
            FrmCadClientes form = new FrmCadClientes() { alterar = true };
            form.Preencher(cliente.nome, cliente.cpf, cliente.setor, cliente.telefone, cliente.cod_cli);
            form.ShowDialog();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var cliente = (tccClienteBindingSource.Current as DataRowView).Row as db_05266_14_A_1_2017DataSet.tccClienteRow;
            tccClienteTableAdapter.Delete(cliente.cod_cli);
            FrmDadosClientes_Load(null, null);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = Interaction.InputBox("Informe o valor da pesquisa:", "Pesquisa");
            if (!pesquisa.Equals(""))
                tccClienteTableAdapter.FillByNome(db_05266_14_A_1_2017DataSet.tccCliente, "%" + pesquisa + "%");
        }
    }
}
