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
    public partial class FrmAlterarFeira : Form
    {
        public FrmAlterarFeira()
        {
            InitializeComponent();
        }
        private int codigo;
        public bool alterar;
        public void Preencher(string nome, string data_feira, string localizacao_feira, int cod)
        {
            txtNome.Text = nome;
            cmbDias.Text = data_feira;
            txtEndereco.Text = localizacao_feira;

            codigo = cod;
        }
       

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAvista_Click(object sender, EventArgs e)
        {
          //  FrmPagar form = new FrmPagar();
          //  form.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
       
            
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
               
                {
                    
                }
                if (alterar == true)
                {
                    tccFeiraTableAdapter.UpdateQuery(txtNome.Text, cmbDias.Text,
                    txtEndereco.Text, codigo);
                    tccFeiraTableAdapter.UpdateQuery(txtNome.Text, cmbDias.Text, txtEndereco.Text, codigo);
                    MessageBox.Show("Alterado com sucesso!", "Alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                
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
            if (MessageBox.Show("Deseja mesmo cancelar a alteração?", "Confirmação", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmAlterarFeira_Load(object sender, EventArgs e)
        {
            var dias = cmbDias;
            dias.Items.Add("Sedunda-Feira");
            dias.Items.Add("Terça-Feira");
            dias.Items.Add("Quarta-Feira");
            dias.Items.Add("Quinta-Feira");
            dias.Items.Add("Sexta-Feira");
            dias.Items.Add("Sábado");
            dias.Items.Add("Domingo");
        }
    }
}
