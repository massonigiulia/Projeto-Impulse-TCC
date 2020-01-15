using System;
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
    public partial class FrmAlterarSenha : Form
    {
        public FrmAlterarSenha()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tccUsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tccUsuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_05266_14_A_1_2017DataSet);

        }

        private void FrmAlterarSenha_Load(object sender, EventArgs e)
        {
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
            FrmLogin frmlog = new FrmLogin();
            frmlog.Show();
            Close();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            btnmenu.Enabled = false;
            this.Close();
        }
    }
}
