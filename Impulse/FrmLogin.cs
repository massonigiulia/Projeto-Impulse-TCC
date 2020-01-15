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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public string senha = "admin";
        public string Pergunta = "preto";
      


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_05266_14_A_1_2017DataSet.tccUsuarios' table. You can move, or remove it, as needed.
            //this.tccUsuariosTableAdapter.Fill(this.db_05266_14_A_1_2017DataSet.tccUsuarios);

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tccUsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tccUsuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_05266_14_A_1_2017DataSet);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if (txtSenha.Text == senha )
            {
                FrmMenu form = new FrmMenu();
                form.ShowDialog();
                Close();
            }
            else {
                MessageBox.Show("Senha incorreta, por favor tente novamente");
                txtSenha.Text = "";
                txtSenha.Focus();
            }

            /*FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
            bunifuFlatButton1.Enabled = false;
            */

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Confirmação", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void linkAlterarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*bunifuFlatButton1.Enabled = false;
            txtSenha.Enabled = false; 
            pnlSenha.Visible = true;
            btnVerificar1.Visible = true;
            txtPalavraVerificacao.Focus();
            
            FrmLogin_Load(null, null);
            */




        }

        private void txtSenha_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnSairLogin_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair ta tela de Login?","Confirmação",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            Close();
        }

        private void painelRecuperacao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void txtNovaSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNovaSenha1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtVerificar_Click_1(object sender, EventArgs e)
        {
          

      
        }

        private void txtVerificar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {

        }

        private void txtVerificar_Click_2(object sender, EventArgs e)
        {
           /* if (txtPalavraVerificacao.Text == Pergunta)
            {
                btnAlterarSenha.Visible = true;
                txtNovaSenha.Enabled = true;
                txtNovaSenha1.Enabled = true;
                txtPalavraVerificacao.Text = "";
                txtPalavraVerificacao.Enabled = false;
                btnVerificar1.Visible = false;

            }
            else
            {
                MessageBox.Show("Resposta errada, por favor tente novamente");
                txtPalavraVerificacao.Text = "";
                txtPalavraVerificacao.Focus();
            }*/
        }

        private void btnAlterarSenha_Click_1(object sender, EventArgs e)
        {
            /*if (txtNovaSenha.Text == txtNovaSenha1.Text)
            {
                string Senha = txtNovaSenha1.Text;
                txtNovaSenha.Enabled = true;
                txtNovaSenha1.Enabled = true;
                txtNovaSenha.Focus();
                Config.UpdateAppSettings("Senha", Senha);
                MessageBox.Show("Senha alterada com sucesso");
                bunifuFlatButton1.Enabled = true;
                txtSenha.Enabled = true;
                FrmLogin_Load(null, null);
                pnlSenha.Visible = false;
                txtSenha.Focus();
                btnAlterarSenha.Visible = false;
                FrmLogin_Load(null, null);
                this.Refresh();
                FrmLogin frm = new FrmLogin();
                frm.Owner = this;
                frm.Show();






            }
            else
            {
                MessageBox.Show("Por favor, tente novamente! A verificação de senha falhou.");

                //txtSenha.Text = "";
                //txtSenha.Focus();
            }*/
        }

        private void txtNovaSenha_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void txtNovaSenha1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtPalavraVerificacao_OnValueChanged(object sender, EventArgs e)
        {
         
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*bunifuFlatButton1.Enabled = true;
            txtSenha.Enabled = true;
            pnlSenha.Visible = false;
            btnVerificar1.Visible = false;
            txtSenha.Focus();*/
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        
        }
    }
    }
    
    

