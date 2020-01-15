using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace Impulse
{
    public partial class Backup : Form
    {
        String sqlconnection = @"Provider=SQLOLEDB.1;Password=Spizzica10;Persist Security Info=True;User ID=05266_14_A_1_2017;Initial Catalog=db_05266_14_A_1_2017;Data Source=MOTORHEAD";

        string SqlConn = @"Provider=SQLOLEDB.1;Password=Spizzica10;Persist Security Info=True;User ID=05266_14_A_1_2017;Initial Catalog=master;Data Source=MOTORHEAD";
        OleDbConnection conexao;
        string _sql;
        OleDbCommand comando;


        public Backup()
        {
            InitializeComponent();
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            if (rbBackup.Checked)
            {
                SaveFileDialog SalvarArquivo = new SaveFileDialog();
                SalvarArquivo.Title = "Gerar Backup";
                SalvarArquivo.Filter = "Salvar|*.bak";
                if (SalvarArquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtLocalArquivo.Text = SalvarArquivo.FileName;
                }
            }
            else if (rbRestaurar.Checked)
            {
                OpenFileDialog AbrirArquivo = new OpenFileDialog();
                AbrirArquivo.Filter = "Restaurar o Sistema|*.bak";
                AbrirArquivo.Title = "Modo de Segurança";
                if (AbrirArquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtLocalArquivo.Text = AbrirArquivo.FileName;
                }

            }
        }

        private void rbBackup_CheckedChanged(object sender, EventArgs e)
        {
            this.btnBackupRestore.Image = global::Impulse.Properties.Resources.Database_Backup_icon__1_;
        }

        private void rbRestaurar_CheckedChanged(object sender, EventArgs e)
        {
            this.btnBackupRestore.Image = global::Impulse.Properties.Resources.Backup_restore_icon;
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            if (rbBackup.Checked)
            {
                conexao = new OleDbConnection(sqlconnection);
                _sql = "BACKUP DATABASE db_05266_14_A_1_2017 TO DISK =  '" +
                    txtLocalArquivo.Text + "'";
                comando = new OleDbCommand(_sql, conexao);
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Backup realizado com sucesso", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                }
            }
            else if (rbRestaurar.Checked)
            {
                conexao = new OleDbConnection(SqlConn);
               _sql = "RESTORE DATABASE master FROM DISK =  '" +
                    txtLocalArquivo.Text + "'";
                comando = new OleDbCommand(_sql, conexao);
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Restauração do Sistem realizada com sucesso", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();

                }
            }
            else
            {
                MessageBox.Show("Selecione a opção desejada!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtLocalArquivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Backup_Load(object sender, EventArgs e)
        {

        }
    }
}
