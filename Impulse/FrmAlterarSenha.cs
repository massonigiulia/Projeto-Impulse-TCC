using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impulse
{
    public partial class FrmAlterarSenha : Form
    {
        public FrmAlterarSenha()
        {
            InitializeComponent();
        }
        public string Pergunta = "preto";




        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tccUsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tccUsuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void FrmAlterarSenha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tccUsuarios' table. You can move, or remove it, as needed.
            this.tccUsuariosTableAdapter.Fill(this.banco.tccUsuarios);
            // TODO: This line of code loads data into the 'db_05266_14_A_1_2017DataSet.tccUsuarios' table. You can move, or remove it, as needed.
            //this.tccUsuariosTableAdapter.Fill(this.db_05266_14_A_1_2017DataSet.tccUsuarios);

        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void senhaLabel_Click(object sender, EventArgs e)
        {

        }

        private void senhaLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void senhaTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtPalavraVerificacao_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text == txtNovaSenha1.Text)
            {
                string Senha = txtNovaSenha1.Text;
                txtNovaSenha.Enabled = true;
                txtNovaSenha1.Enabled = true;
                txtNovaSenha.Focus();
                Config.UpdateAppSettings("Senha", Senha);
                MessageBox.Show("Senha alterada com sucesso");
                btnAlterarSenha.Visible = false;






            }
            else
            {
                MessageBox.Show("Por favor, tente novamente! A verificação de senha falhou.");

                //txtSenha.Text = "";
                //txtSenha.Focus();
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            btnmenu.Enabled = false;
            this.Close();
        }

        private void tccUsuariosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tccUsuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtVerificar_Click(object sender, EventArgs e)
        {
            if (txtPalavraVerificacao.Text == Pergunta)
            {
                btnAlterarSenha.Visible = true;
                txtNovaSenha.Enabled = true;
                txtNovaSenha1.Enabled = true;
                txtPalavraVerificacao.Text = "";
                txtPalavraVerificacao.Enabled = false;


            }
            else
            {
                MessageBox.Show("Resposta errada, por favor tente novamente");
                txtPalavraVerificacao.Text = "";
                txtPalavraVerificacao.Focus();
            }
        }

   

    private void linkAlterarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //FrmLogin frmalt = new FrmLogin();
            //frmalt.Show();
            FrmLogin form = new FrmLogin();
            form.ShowDialog();
            Close();
        }
    }
    }

