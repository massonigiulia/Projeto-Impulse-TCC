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
    public partial class FrmMenu : Form
    {
       
        private bool isCollapsed;
        Form _objForm;
        public FrmMenu()
        {
            InitializeComponent();
            FrmPendencias frmpend = new FrmPendencias();

           
            _objForm?.Close();
            _objForm = new FrmPendencias
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlPrincipal.Controls.Add(_objForm);
            _objForm.Show(); 
            
            

        }

        private void BtnDados_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlDropDownDados.Height += 10;
                if (pnlDropDownDados.Size == pnlDropDownDados.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                pnlDropDownDados.Height -= 10;
                if (pnlDropDownDados.Size == pnlDropDownDados.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {

            _objForm?.Close();
            _objForm = new FrmCadVenda
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlPrincipal.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {

            _objForm?.Close();
            _objForm = new FrmDadosClientes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlPrincipal.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {

            _objForm?.Close();
            _objForm = new FrmDadosProdutos
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlPrincipal.Controls.Add(_objForm);
            _objForm.Show();
        }     

        private void BtnFeiras_Click(object sender, EventArgs e)
        {

            _objForm?.Close();
            _objForm = new FrmDadosFeiras
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlPrincipal.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void BtnPendencias_Click(object sender, EventArgs e)
        {

            _objForm?.Close();
            _objForm = new FrmPendencias
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlPrincipal.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void PnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Bloquear o Sistema??", "Confirmação", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                FrmLogin form = new FrmLogin();
                form.ShowDialog();
                
            }

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Backup form = new Backup();
            form.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            FrmRptPendencias relatorios = new FrmRptPendencias();
            relatorios.Show();
        }
    }
}
