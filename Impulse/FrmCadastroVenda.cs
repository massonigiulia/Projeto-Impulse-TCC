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
    public partial class FrmCadastroVenda : Form
    {
        public bool novoCadastro;
        public int IdVenda;

        private string NomeCliente;
        private string NomeFeira;

        public void PreencherCampos(string Cliente, string Feira, string obs)
        {
            NomeCliente = Cliente;
            NomeFeira = Feira; 
            txtObs.Text = obs;
        }



        public FrmCadastroVenda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco1.tccFeira' table. You can move, or remove it, as needed.
            this.tccFeiraTableAdapter1.Fill(this.banco1.tccFeira);
            // TODO: This line of code loads data into the 'banco.tccVenda' table. You can move, or remove it, as needed.
            this.tccVendaTableAdapter1.Fill(this.banco.tccVenda);
            // TODO: This line of code loads data into the 'banco.tccCliente' table. You can move, or remove it, as needed.
            this.tccClienteTableAdapter1.Fill(this.banco.tccCliente);

            //this.tccClienteTableAdapter.Fill(this.banco.tccCliente);
            //this.tccFeiraTableAdapter.Fill(this.banco.tccFeira);
            //this.tccVendaTableAdapter.Fill(this.banco.tccVenda);
            if (novoCadastro)
            {
                cmbCliente_SelectedIndexChanged_SelectedIndexChanged(null, null);
              
            }
            else
            {
                cmbCliente.Text = NomeCliente;
               
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (novoCadastro)
                {
                    //tccVendaTableAdapter1.InsertQuery(
                       // Convert.ToInt32(cmbCliente.SelectedValue),
                       // DateTime.Now,
                       // Convert.ToInt32(cmbFeira.SelectedValue),
                       // txtObs.Text
                       // );

                    tccVendaTableAdapter1.InsertQuery1((int)cmbCliente.SelectedValue, (int)cmbFeira.SelectedValue, txtObs.Text);
                }
                else
                {
                    tccVendaTableAdapter.UpdateQuery(
                        (int)cmbCliente.SelectedValue,
                        DateTime.Now,
                        (int)cmbFeira.SelectedValue,
                        txtObs.Text,
                        IdVenda
                        );
                }

                MessageBox.Show("Salvo com sucesso!",
                        "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmCadastroVenda_Load(null, null);
                Close();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*try
            {
                if (cmbCliente.SelectedValue != null)
                {
                    tccClienteTableAdapter.FillByNome(banco.tccCliente, "%" + cmbCliente + "%");
                    var auto = (tccClienteBindingSource.Current as DataRowView).Row as banco.tccClienteRow;
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void brnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
