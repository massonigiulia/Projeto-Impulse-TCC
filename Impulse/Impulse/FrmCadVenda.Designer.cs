namespace Impulse
{
    partial class FrmCadVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAlterar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExcluir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPesquisar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIncluir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtpDataEntrega = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtpDataVenda = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbCliente = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCodVenda = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbProduto = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnCancelarItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAlterarItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nudQtdItem = new System.Windows.Forms.NumericUpDown();
            this.btnCadastrarItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnExcluirItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSubTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnPesquisarItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPrecoUnit = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnIncluirItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnPagar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.db_05266_14_A_1_2017DataSet = new Impulse.db_05266_14_A_1_2017DataSet();
            this.tccItemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Impulse.db_05266_14_A_1_2017DataSetTableAdapters.TableAdapterManager();
            this.tccItemVendaTableAdapter = new Impulse.db_05266_14_A_1_2017DataSetTableAdapters.tccItemVendaTableAdapter();
            this.tblItemVenda = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_05266_14_A_1_2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnIncluir);
            this.panel1.Location = new System.Drawing.Point(8, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 65);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = null;
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 90D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(614, 16);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(79, 32);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.BorderRadius = 0;
            this.btnAlterar.ButtonText = "Alterar";
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAlterar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAlterar.Iconimage = null;
            this.btnAlterar.Iconimage_right = null;
            this.btnAlterar.Iconimage_right_Selected = null;
            this.btnAlterar.Iconimage_Selected = null;
            this.btnAlterar.IconMarginLeft = 0;
            this.btnAlterar.IconMarginRight = 0;
            this.btnAlterar.IconRightVisible = true;
            this.btnAlterar.IconRightZoom = 0D;
            this.btnAlterar.IconVisible = true;
            this.btnAlterar.IconZoom = 90D;
            this.btnAlterar.IsTab = false;
            this.btnAlterar.Location = new System.Drawing.Point(282, 16);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAlterar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAlterar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAlterar.selected = false;
            this.btnAlterar.Size = new System.Drawing.Size(79, 32);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAlterar.Textcolor = System.Drawing.Color.White;
            this.btnAlterar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.BorderRadius = 0;
            this.btnCadastrar.ButtonText = "Cadastrar ";
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Iconimage = null;
            this.btnCadastrar.Iconimage_right = null;
            this.btnCadastrar.Iconimage_right_Selected = null;
            this.btnCadastrar.Iconimage_Selected = null;
            this.btnCadastrar.IconMarginLeft = 0;
            this.btnCadastrar.IconMarginRight = 0;
            this.btnCadastrar.IconRightVisible = true;
            this.btnCadastrar.IconRightZoom = 0D;
            this.btnCadastrar.IconVisible = true;
            this.btnCadastrar.IconZoom = 90D;
            this.btnCadastrar.IsTab = false;
            this.btnCadastrar.Location = new System.Drawing.Point(442, 16);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCadastrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCadastrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrar.selected = false;
            this.btnCadastrar.Size = new System.Drawing.Size(145, 32);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar ";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrar.Textcolor = System.Drawing.Color.White;
            this.btnCadastrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnExcluir
            // 
            this.btnExcluir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.BorderRadius = 0;
            this.btnExcluir.ButtonText = "Excluir";
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.DisabledColor = System.Drawing.Color.Gray;
            this.btnExcluir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExcluir.Iconimage = null;
            this.btnExcluir.Iconimage_right = null;
            this.btnExcluir.Iconimage_right_Selected = null;
            this.btnExcluir.Iconimage_Selected = null;
            this.btnExcluir.IconMarginLeft = 0;
            this.btnExcluir.IconMarginRight = 0;
            this.btnExcluir.IconRightVisible = true;
            this.btnExcluir.IconRightZoom = 0D;
            this.btnExcluir.IconVisible = true;
            this.btnExcluir.IconZoom = 90D;
            this.btnExcluir.IsTab = false;
            this.btnExcluir.Location = new System.Drawing.Point(197, 16);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExcluir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExcluir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExcluir.selected = false;
            this.btnExcluir.Size = new System.Drawing.Size(79, 32);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcluir.Textcolor = System.Drawing.Color.White;
            this.btnExcluir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.BorderRadius = 0;
            this.btnPesquisar.ButtonText = "Pesquisar";
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.DisabledColor = System.Drawing.Color.Gray;
            this.btnPesquisar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Iconimage = null;
            this.btnPesquisar.Iconimage_right = null;
            this.btnPesquisar.Iconimage_right_Selected = null;
            this.btnPesquisar.Iconimage_Selected = null;
            this.btnPesquisar.IconMarginLeft = 0;
            this.btnPesquisar.IconMarginRight = 0;
            this.btnPesquisar.IconRightVisible = true;
            this.btnPesquisar.IconRightZoom = 0D;
            this.btnPesquisar.IconVisible = true;
            this.btnPesquisar.IconZoom = 90D;
            this.btnPesquisar.IsTab = false;
            this.btnPesquisar.Location = new System.Drawing.Point(113, 16);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPesquisar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPesquisar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPesquisar.selected = false;
            this.btnPesquisar.Size = new System.Drawing.Size(79, 32);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisar.Textcolor = System.Drawing.Color.White;
            this.btnPesquisar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnIncluir
            // 
            this.btnIncluir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncluir.BorderRadius = 0;
            this.btnIncluir.ButtonText = "Incluir";
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.DisabledColor = System.Drawing.Color.Gray;
            this.btnIncluir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIncluir.Iconimage = null;
            this.btnIncluir.Iconimage_right = null;
            this.btnIncluir.Iconimage_right_Selected = null;
            this.btnIncluir.Iconimage_Selected = null;
            this.btnIncluir.IconMarginLeft = 0;
            this.btnIncluir.IconMarginRight = 0;
            this.btnIncluir.IconRightVisible = true;
            this.btnIncluir.IconRightZoom = 0D;
            this.btnIncluir.IconVisible = true;
            this.btnIncluir.IconZoom = 90D;
            this.btnIncluir.IsTab = false;
            this.btnIncluir.Location = new System.Drawing.Point(29, 16);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIncluir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnIncluir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIncluir.selected = false;
            this.btnIncluir.Size = new System.Drawing.Size(79, 32);
            this.btnIncluir.TabIndex = 12;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIncluir.Textcolor = System.Drawing.Color.White;
            this.btnIncluir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtObs);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.dtpDataEntrega);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.dtpDataVenda);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.cmbCliente);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.txtCodVenda);
            this.panel2.Location = new System.Drawing.Point(8, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 210);
            this.panel2.TabIndex = 3;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(59, 107);
            this.txtObs.Margin = new System.Windows.Forms.Padding(2);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(643, 94);
            this.txtObs.TabIndex = 70;
            this.txtObs.Text = "";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(10, 103);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(45, 21);
            this.bunifuCustomLabel5.TabIndex = 69;
            this.bunifuCustomLabel5.Text = "Obs:";
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpDataEntrega.BorderRadius = 0;
            this.dtpDataEntrega.ForeColor = System.Drawing.Color.White;
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrega.FormatCustom = null;
            this.dtpDataEntrega.Location = new System.Drawing.Point(508, 56);
            this.dtpDataEntrega.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(194, 36);
            this.dtpDataEntrega.TabIndex = 68;
            this.dtpDataEntrega.Value = new System.DateTime(2019, 8, 12, 23, 43, 16, 202);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(380, 68);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(123, 21);
            this.bunifuCustomLabel3.TabIndex = 67;
            this.bunifuCustomLabel3.Text = "Data entrega:";
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpDataVenda.BorderRadius = 0;
            this.dtpDataVenda.ForeColor = System.Drawing.Color.White;
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.FormatCustom = null;
            this.dtpDataVenda.Location = new System.Drawing.Point(123, 53);
            this.dtpDataVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(194, 36);
            this.dtpDataVenda.TabIndex = 66;
            this.dtpDataVenda.Value = new System.DateTime(2019, 8, 12, 23, 43, 16, 202);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(10, 58);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(111, 21);
            this.bunifuCustomLabel2.TabIndex = 65;
            this.bunifuCustomLabel2.Text = "Data venda:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.Transparent;
            this.cmbCliente.BorderRadius = 3;
            this.cmbCliente.ForeColor = System.Drawing.Color.White;
            this.cmbCliente.Items = new string[0];
            this.cmbCliente.Location = new System.Drawing.Point(508, 10);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmbCliente.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmbCliente.selectedIndex = -1;
            this.cmbCliente.Size = new System.Drawing.Size(194, 31);
            this.cmbCliente.TabIndex = 64;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(380, 25);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(70, 21);
            this.bunifuCustomLabel1.TabIndex = 63;
            this.bunifuCustomLabel1.Text = "Cliente:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(10, 19);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(67, 21);
            this.bunifuCustomLabel4.TabIndex = 62;
            this.bunifuCustomLabel4.Text = "Venda:";
            // 
            // txtCodVenda
            // 
            this.txtCodVenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodVenda.Enabled = false;
            this.txtCodVenda.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodVenda.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodVenda.HintText = "";
            this.txtCodVenda.isPassword = false;
            this.txtCodVenda.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCodVenda.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodVenda.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCodVenda.LineThickness = 3;
            this.txtCodVenda.Location = new System.Drawing.Point(81, 10);
            this.txtCodVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodVenda.Name = "txtCodVenda";
            this.txtCodVenda.Size = new System.Drawing.Size(236, 29);
            this.txtCodVenda.TabIndex = 0;
            this.txtCodVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbProduto);
            this.panel4.Controls.Add(this.btnCancelarItem);
            this.panel4.Controls.Add(this.btnAlterarItem);
            this.panel4.Controls.Add(this.nudQtdItem);
            this.panel4.Controls.Add(this.btnCadastrarItem);
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Controls.Add(this.btnExcluirItem);
            this.panel4.Controls.Add(this.txtSubTotal);
            this.panel4.Controls.Add(this.btnPesquisarItem);
            this.panel4.Controls.Add(this.txtPrecoUnit);
            this.panel4.Controls.Add(this.btnIncluirItem);
            this.panel4.Controls.Add(this.bunifuCustomLabel11);
            this.panel4.Controls.Add(this.bunifuCustomLabel10);
            this.panel4.Controls.Add(this.bunifuCustomLabel9);
            this.panel4.Controls.Add(this.bunifuCustomLabel8);
            this.panel4.Controls.Add(this.bunifuCustomLabel7);
            this.panel4.Location = new System.Drawing.Point(8, 334);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(707, 128);
            this.panel4.TabIndex = 7;
            // 
            // cmbProduto
            // 
            this.cmbProduto.BackColor = System.Drawing.Color.Transparent;
            this.cmbProduto.BorderRadius = 3;
            this.cmbProduto.ForeColor = System.Drawing.Color.White;
            this.cmbProduto.Items = new string[0];
            this.cmbProduto.Location = new System.Drawing.Point(14, 86);
            this.cmbProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmbProduto.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmbProduto.selectedIndex = -1;
            this.cmbProduto.Size = new System.Drawing.Size(256, 31);
            this.cmbProduto.TabIndex = 73;
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarItem.BorderRadius = 0;
            this.btnCancelarItem.ButtonText = "Cancelar";
            this.btnCancelarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelarItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelarItem.Iconimage = null;
            this.btnCancelarItem.Iconimage_right = null;
            this.btnCancelarItem.Iconimage_right_Selected = null;
            this.btnCancelarItem.Iconimage_Selected = null;
            this.btnCancelarItem.IconMarginLeft = 0;
            this.btnCancelarItem.IconMarginRight = 0;
            this.btnCancelarItem.IconRightVisible = true;
            this.btnCancelarItem.IconRightZoom = 0D;
            this.btnCancelarItem.IconVisible = true;
            this.btnCancelarItem.IconZoom = 90D;
            this.btnCancelarItem.IsTab = false;
            this.btnCancelarItem.Location = new System.Drawing.Point(614, 16);
            this.btnCancelarItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelarItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancelarItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelarItem.selected = false;
            this.btnCancelarItem.Size = new System.Drawing.Size(79, 32);
            this.btnCancelarItem.TabIndex = 17;
            this.btnCancelarItem.Text = "Cancelar";
            this.btnCancelarItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelarItem.Textcolor = System.Drawing.Color.White;
            this.btnCancelarItem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAlterarItem
            // 
            this.btnAlterarItem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAlterarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAlterarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterarItem.BorderRadius = 0;
            this.btnAlterarItem.ButtonText = "Alterar";
            this.btnAlterarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnAlterarItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAlterarItem.Iconimage = null;
            this.btnAlterarItem.Iconimage_right = null;
            this.btnAlterarItem.Iconimage_right_Selected = null;
            this.btnAlterarItem.Iconimage_Selected = null;
            this.btnAlterarItem.IconMarginLeft = 0;
            this.btnAlterarItem.IconMarginRight = 0;
            this.btnAlterarItem.IconRightVisible = true;
            this.btnAlterarItem.IconRightZoom = 0D;
            this.btnAlterarItem.IconVisible = true;
            this.btnAlterarItem.IconZoom = 90D;
            this.btnAlterarItem.IsTab = false;
            this.btnAlterarItem.Location = new System.Drawing.Point(273, 16);
            this.btnAlterarItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterarItem.Name = "btnAlterarItem";
            this.btnAlterarItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAlterarItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAlterarItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAlterarItem.selected = false;
            this.btnAlterarItem.Size = new System.Drawing.Size(79, 32);
            this.btnAlterarItem.TabIndex = 16;
            this.btnAlterarItem.Text = "Alterar";
            this.btnAlterarItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAlterarItem.Textcolor = System.Drawing.Color.White;
            this.btnAlterarItem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // nudQtdItem
            // 
            this.nudQtdItem.Location = new System.Drawing.Point(315, 93);
            this.nudQtdItem.Margin = new System.Windows.Forms.Padding(2);
            this.nudQtdItem.Name = "nudQtdItem";
            this.nudQtdItem.Size = new System.Drawing.Size(80, 20);
            this.nudQtdItem.TabIndex = 72;
            // 
            // btnCadastrarItem
            // 
            this.btnCadastrarItem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCadastrarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCadastrarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarItem.BorderRadius = 0;
            this.btnCadastrarItem.ButtonText = "Cadastrar";
            this.btnCadastrarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastrarItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastrarItem.Iconimage = null;
            this.btnCadastrarItem.Iconimage_right = null;
            this.btnCadastrarItem.Iconimage_right_Selected = null;
            this.btnCadastrarItem.Iconimage_Selected = null;
            this.btnCadastrarItem.IconMarginLeft = 0;
            this.btnCadastrarItem.IconMarginRight = 0;
            this.btnCadastrarItem.IconRightVisible = true;
            this.btnCadastrarItem.IconRightZoom = 0D;
            this.btnCadastrarItem.IconVisible = true;
            this.btnCadastrarItem.IconZoom = 90D;
            this.btnCadastrarItem.IsTab = false;
            this.btnCadastrarItem.Location = new System.Drawing.Point(442, 16);
            this.btnCadastrarItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrarItem.Name = "btnCadastrarItem";
            this.btnCadastrarItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCadastrarItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCadastrarItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrarItem.selected = false;
            this.btnCadastrarItem.Size = new System.Drawing.Size(145, 32);
            this.btnCadastrarItem.TabIndex = 15;
            this.btnCadastrarItem.Text = "Cadastrar";
            this.btnCadastrarItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrarItem.Textcolor = System.Drawing.Color.White;
            this.btnCadastrarItem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtTotal
            // 
            this.txtTotal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTotal.BorderThickness = 3;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.isPassword = false;
            this.txtTotal.Location = new System.Drawing.Point(640, 84);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(53, 33);
            this.txtTotal.TabIndex = 71;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExcluirItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExcluirItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirItem.BorderRadius = 0;
            this.btnExcluirItem.ButtonText = "Excluir";
            this.btnExcluirItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnExcluirItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExcluirItem.Iconimage = null;
            this.btnExcluirItem.Iconimage_right = null;
            this.btnExcluirItem.Iconimage_right_Selected = null;
            this.btnExcluirItem.Iconimage_Selected = null;
            this.btnExcluirItem.IconMarginLeft = 0;
            this.btnExcluirItem.IconMarginRight = 0;
            this.btnExcluirItem.IconRightVisible = true;
            this.btnExcluirItem.IconRightZoom = 0D;
            this.btnExcluirItem.IconVisible = true;
            this.btnExcluirItem.IconZoom = 90D;
            this.btnExcluirItem.IsTab = false;
            this.btnExcluirItem.Location = new System.Drawing.Point(188, 16);
            this.btnExcluirItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExcluirItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExcluirItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExcluirItem.selected = false;
            this.btnExcluirItem.Size = new System.Drawing.Size(79, 32);
            this.btnExcluirItem.TabIndex = 14;
            this.btnExcluirItem.Text = "Excluir";
            this.btnExcluirItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcluirItem.Textcolor = System.Drawing.Color.White;
            this.btnExcluirItem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSubTotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubTotal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSubTotal.BorderThickness = 3;
            this.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubTotal.isPassword = false;
            this.txtSubTotal.Location = new System.Drawing.Point(547, 84);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(53, 33);
            this.txtSubTotal.TabIndex = 70;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPesquisarItem
            // 
            this.btnPesquisarItem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPesquisarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPesquisarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarItem.BorderRadius = 0;
            this.btnPesquisarItem.ButtonText = "Pesquisar";
            this.btnPesquisarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnPesquisarItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPesquisarItem.Iconimage = null;
            this.btnPesquisarItem.Iconimage_right = null;
            this.btnPesquisarItem.Iconimage_right_Selected = null;
            this.btnPesquisarItem.Iconimage_Selected = null;
            this.btnPesquisarItem.IconMarginLeft = 0;
            this.btnPesquisarItem.IconMarginRight = 0;
            this.btnPesquisarItem.IconRightVisible = true;
            this.btnPesquisarItem.IconRightZoom = 0D;
            this.btnPesquisarItem.IconVisible = true;
            this.btnPesquisarItem.IconZoom = 90D;
            this.btnPesquisarItem.IsTab = false;
            this.btnPesquisarItem.Location = new System.Drawing.Point(104, 16);
            this.btnPesquisarItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisarItem.Name = "btnPesquisarItem";
            this.btnPesquisarItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPesquisarItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPesquisarItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPesquisarItem.selected = false;
            this.btnPesquisarItem.Size = new System.Drawing.Size(79, 32);
            this.btnPesquisarItem.TabIndex = 13;
            this.btnPesquisarItem.Text = "Pesquisar";
            this.btnPesquisarItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisarItem.Textcolor = System.Drawing.Color.White;
            this.btnPesquisarItem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPrecoUnit.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecoUnit.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPrecoUnit.BorderThickness = 3;
            this.txtPrecoUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecoUnit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecoUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecoUnit.isPassword = false;
            this.txtPrecoUnit.Location = new System.Drawing.Point(454, 84);
            this.txtPrecoUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.Size = new System.Drawing.Size(53, 33);
            this.txtPrecoUnit.TabIndex = 69;
            this.txtPrecoUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnIncluirItem
            // 
            this.btnIncluirItem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIncluirItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIncluirItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncluirItem.BorderRadius = 0;
            this.btnIncluirItem.ButtonText = "Incluir";
            this.btnIncluirItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluirItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnIncluirItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIncluirItem.Iconimage = null;
            this.btnIncluirItem.Iconimage_right = null;
            this.btnIncluirItem.Iconimage_right_Selected = null;
            this.btnIncluirItem.Iconimage_Selected = null;
            this.btnIncluirItem.IconMarginLeft = 0;
            this.btnIncluirItem.IconMarginRight = 0;
            this.btnIncluirItem.IconRightVisible = true;
            this.btnIncluirItem.IconRightZoom = 0D;
            this.btnIncluirItem.IconVisible = true;
            this.btnIncluirItem.IconZoom = 90D;
            this.btnIncluirItem.IsTab = false;
            this.btnIncluirItem.Location = new System.Drawing.Point(20, 16);
            this.btnIncluirItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIncluirItem.Name = "btnIncluirItem";
            this.btnIncluirItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIncluirItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnIncluirItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIncluirItem.selected = false;
            this.btnIncluirItem.Size = new System.Drawing.Size(79, 32);
            this.btnIncluirItem.TabIndex = 12;
            this.btnIncluirItem.Text = "Incluir";
            this.btnIncluirItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIncluirItem.Textcolor = System.Drawing.Color.White;
            this.btnIncluirItem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(644, 61);
            this.bunifuCustomLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(49, 21);
            this.bunifuCustomLabel11.TabIndex = 68;
            this.bunifuCustomLabel11.Text = "Total";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(527, 61);
            this.bunifuCustomLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(82, 21);
            this.bunifuCustomLabel10.TabIndex = 67;
            this.bunifuCustomLabel10.Text = "Sub Total";
            this.bunifuCustomLabel10.Click += new System.EventHandler(this.BunifuCustomLabel10_Click);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(429, 61);
            this.bunifuCustomLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(93, 21);
            this.bunifuCustomLabel9.TabIndex = 66;
            this.bunifuCustomLabel9.Text = "Preço Unit.";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(299, 61);
            this.bunifuCustomLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(108, 21);
            this.bunifuCustomLabel8.TabIndex = 65;
            this.bunifuCustomLabel8.Text = "Quantidade";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(14, 61);
            this.bunifuCustomLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(76, 21);
            this.bunifuCustomLabel7.TabIndex = 64;
            this.bunifuCustomLabel7.Text = "Produto:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(15, 6);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(250, 28);
            this.bunifuCustomLabel6.TabIndex = 71;
            this.bunifuCustomLabel6.Text = "Cadastro de vendas";
            this.bunifuCustomLabel6.Click += new System.EventHandler(this.bunifuCustomLabel6_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagar.BorderRadius = 0;
            this.btnPagar.ButtonText = "Pagar";
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.DisabledColor = System.Drawing.Color.Gray;
            this.btnPagar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPagar.Iconimage = null;
            this.btnPagar.Iconimage_right = null;
            this.btnPagar.Iconimage_right_Selected = null;
            this.btnPagar.Iconimage_Selected = null;
            this.btnPagar.IconMarginLeft = 0;
            this.btnPagar.IconMarginRight = 0;
            this.btnPagar.IconRightVisible = true;
            this.btnPagar.IconRightZoom = 0D;
            this.btnPagar.IconVisible = true;
            this.btnPagar.IconZoom = 90D;
            this.btnPagar.IsTab = false;
            this.btnPagar.Location = new System.Drawing.Point(281, 638);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPagar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPagar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPagar.selected = false;
            this.btnPagar.Size = new System.Drawing.Size(145, 32);
            this.btnPagar.TabIndex = 72;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPagar.Textcolor = System.Drawing.Color.White;
            this.btnPagar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // db_05266_14_A_1_2017DataSet
            // 
            this.db_05266_14_A_1_2017DataSet.DataSetName = "db_05266_14_A_1_2017DataSet";
            this.db_05266_14_A_1_2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tccItemVendaBindingSource
            // 
            this.tccItemVendaBindingSource.DataMember = "tccItemVenda";
            this.tccItemVendaBindingSource.DataSource = this.db_05266_14_A_1_2017DataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tccClienteTableAdapter = null;
            this.tableAdapterManager.tccCompraTableAdapter = null;
            this.tableAdapterManager.tccFeiraTableAdapter = null;
            this.tableAdapterManager.tccFornecedorTableAdapter = null;
            this.tableAdapterManager.tccItemCompraTableAdapter = null;
            this.tableAdapterManager.tccItemVendaTableAdapter = null;
            this.tableAdapterManager.tccPendenciasTableAdapter = null;
            this.tableAdapterManager.tccProdutoTableAdapter = null;
            this.tableAdapterManager.tccUsuariosTableAdapter = null;
            this.tableAdapterManager.tccVendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Impulse.db_05266_14_A_1_2017DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tccItemVendaTableAdapter
            // 
            this.tccItemVendaTableAdapter.ClearBeforeFill = true;
            // 
            // tblItemVenda
            // 
            this.tblItemVenda.AllowUserToAddRows = false;
            this.tblItemVenda.AllowUserToDeleteRows = false;
            this.tblItemVenda.AutoGenerateColumns = false;
            this.tblItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tblItemVenda.DataSource = this.tccItemVendaBindingSource;
            this.tblItemVenda.Location = new System.Drawing.Point(8, 467);
            this.tblItemVenda.Name = "tblItemVenda";
            this.tblItemVenda.ReadOnly = true;
            this.tblItemVenda.Size = new System.Drawing.Size(707, 163);
            this.tblItemVenda.TabIndex = 72;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_venda";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código da venda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor_unitario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor unitário";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "subtotal";
            this.dataGridViewTextBoxColumn5.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // FrmCadVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 629);
            this.Controls.Add(this.tblItemVenda);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIncluirVenda";
            this.Load += new System.EventHandler(this.FrmCadVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_05266_14_A_1_2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcluir;
        private Bunifu.Framework.UI.BunifuFlatButton btnPesquisar;
        private Bunifu.Framework.UI.BunifuFlatButton btnIncluir;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodVenda;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAlterar;
        private System.Windows.Forms.RichTextBox txtObs;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown cmbCliente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nudQtdItem;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSubTotal;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPrecoUnit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuDatepicker dtpDataEntrega;
        private Bunifu.Framework.UI.BunifuDatepicker dtpDataVenda;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelarItem;
        private Bunifu.Framework.UI.BunifuFlatButton btnAlterarItem;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrarItem;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcluirItem;
        private Bunifu.Framework.UI.BunifuFlatButton btnPesquisarItem;
        private Bunifu.Framework.UI.BunifuFlatButton btnIncluirItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuFlatButton btnPagar;
        private Bunifu.Framework.UI.BunifuDropdown cmbProduto;
        private System.Windows.Forms.Timer timer1;
        private db_05266_14_A_1_2017DataSet db_05266_14_A_1_2017DataSet;
        private System.Windows.Forms.BindingSource tccItemVendaBindingSource;
        private db_05266_14_A_1_2017DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private db_05266_14_A_1_2017DataSetTableAdapters.tccItemVendaTableAdapter tccItemVendaTableAdapter;
        private System.Windows.Forms.DataGridView tblItemVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}