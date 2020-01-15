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
    public partial class FrmCadProdutos : Form
    {
        public bool incluir;
        private int Prod;
        public FrmCadProdutos()
        {
            InitializeComponent();
        }


        private void FrmCadProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_05266_14_A_1_2017DataSet.tccProduto' table. You can move, or remove it, as needed.
            this.tccProdutoTableAdapter.Fill(this.db_05266_14_A_1_2017DataSet.tccProduto);

        }
        
        private void Cancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }



        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (incluir)
                    {
                        tccProdutoTableAdapter.InsertQuery( 
                            txtProduto.Text,
                            txtDescricao.Text,
                            txtTipo.Text,
                            txtItem.Text,
                            double.Parse(txtValorVenda.Text),
                            double.Parse(txtValorCusto.Text) );
                        MessageBox.Show("Incluído com sucesso!", "Incluir",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //tccProdutoTableAdapter.Fill(db_05266_14_A_1_2017DataSet.tccProduto);
                    }else
                    {
                        tccProdutoTableAdapter.UpdateQuery(txtTipo.Text, double.Parse(txtValorCusto.Text), txtDescricao.Text, double.Parse(txtValorVenda.Text), txtItem.Text,txtProduto.Text, Prod);
                        MessageBox.Show("Alterado com sucesso!", "Alterar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //FrmCadProdutos_Load(null, null);
                    var dados = Application.OpenForms.OfType<FrmDadosProdutos>().Single();//achar o formulario de dados
                    dados.FrmDadosProdutos_Load(null, null);//usar o loas() do formulario de dados
                    Cancelar_Click(null, null);//n sei
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
        

        private void FrmCadProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmDadosProdutos form = Application.OpenForms.OfType<FrmDadosProdutos>().Single();
            form.FrmDadosProdutos_Load(null, null);
        }

        /// <summary>
        /// metodo para preencher todos os campos, baseado nos parametros, com os mesmos nomes dos campos.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="descricao"></param>
        /// <param name="tipo"></param>
        /// <param name="item"></param>
        /// <param name="valor_unitario"></param>
        /// <param name="valor_custo"></param>
        /// <param name="codigo"></param>
        public void Preencher(string nome, string descricao, string tipo, string item, double valor_unitario, double valor_custo, int codigo)
        {
            txtProduto.Text = nome;
            txtDescricao.Text = descricao;
            txtTipo.Text = tipo;
            txtItem.Text = item;
            txtValorCusto.Text = valor_custo.ToString();
            txtValorVenda.Text = valor_unitario.ToString();
            Prod = codigo;
        }
    }
}