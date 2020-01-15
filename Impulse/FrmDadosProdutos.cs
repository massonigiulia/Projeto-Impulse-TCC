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
    public partial class FrmDadosProdutos : Form
    {

        public FrmDadosProdutos()
        {
            InitializeComponent();
        }

        public void FrmDadosProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tccProduto' table. You can move, or remove it, as needed.
            this.tccProdutoTableAdapter.Fill(this.banco.tccProduto);
            this.tccProdutoTableAdapter.Fill(this.banco.tccProduto);

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            FrmCadProdutos form = new FrmCadProdutos() { incluir = true };
            form.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = Interaction.InputBox("Informe o valor da pesquisa:", "Pesquisa");
            if (!pesquisa.Equals(""))
                tccProdutoTableAdapter.FillByDescricao(banco.tccProduto, "%" + pesquisa + "%");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var produto = (tccProdutoBindingSource.Current as DataRowView).Row as banco.tccProdutoRow;//variavel generica para selecionar o produto
            FrmCadProdutos form = new FrmCadProdutos() { incluir = false };//criar o formulario de cadastro
            form.Preencher(produto.descricao, produto.valor_unitario, produto.cod_pro);//usar o metodo preencher
            form.ShowDialog();//abrir o formulario de cadastro
            /*var prod = (tccProdutoBindingSource.Current as DataRowView).Row as db_05266_14_A_1_2017DataSet.tccProdutoRow;
            FrmCadProdutos cadpro = new FrmCadProdutos()
            {
                nome = prod.nome,
                tamanho = prod.item,
                valorCusto = prod.valor_custo.ToString(),
                valorVenda = prod.valor_unitario.ToString(),
                Tipo = prod.tipo,
                descricao = prod.descricao
            };*/
            //cadpro.ShowDialog();
        }

        private void tblProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var produto = (tccProdutoBindingSource.Current as DataRowView).Row as banco.tccProdutoRow; //variavel generica para selecionar o produto
            if(MessageBox.Show("Deseja excluir o produto?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // verificar se o usuario realmente quer excluir esse item
            {
                try
                {
                    tccProdutoTableAdapter.DeleteQuery(produto.cod_pro);//excluir o item
                    tccProdutoTableAdapter.Fill(banco.tccProduto); // atualizar a tabela
                    //tratamento de erro
                }catch(NullReferenceException ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Este produto está relacionado com uma venda", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void tccProdutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tccProdutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmDadosProdutos_Load(null, null);
        }
    }
}
    
