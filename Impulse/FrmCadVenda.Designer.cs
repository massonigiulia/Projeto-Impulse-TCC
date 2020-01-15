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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGravar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAlterar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExcluir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIncluir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cmbFeira = new System.Windows.Forms.ComboBox();
            this.tccFeiraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco = new Impulse.banco();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.tccClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFeira = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tccVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGravarItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDesconto = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.tccProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvItemVendas = new System.Windows.Forms.DataGridView();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tccItemVendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPagar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelarItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnExcluirItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSubTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPrecoUnit = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnIncluirItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tccItemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccVendaTableAdapter = new Impulse.bancoTableAdapters.tccVendaTableAdapter();
            this.tableAdapterManager = new Impulse.bancoTableAdapters.TableAdapterManager();
            this.tccItemVendaTableAdapter = new Impulse.bancoTableAdapters.tccItemVendaTableAdapter();
            this.tccProdutoTableAdapter1 = new Impulse.db_05266_14_A_1_2017DataSetTableAdapters.tccProdutoTableAdapter();
            this.tccProdutoTableAdapter = new Impulse.bancoTableAdapters.tccProdutoTableAdapter();
            this.tccClienteTableAdapter = new Impulse.bancoTableAdapters.tccClienteTableAdapter();
            this.tccFeiraTableAdapter = new Impulse.bancoTableAdapters.tccFeiraTableAdapter();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentoTableAdapter = new Impulse.bancoTableAdapters.pagamentoTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccFeiraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccVendaBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemVendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnIncluir);
            this.panel1.Location = new System.Drawing.Point(8, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 65);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
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
            this.btnPesquisar.Location = new System.Drawing.Point(309, 16);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPesquisar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPesquisar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPesquisar.selected = false;
            this.btnPesquisar.Size = new System.Drawing.Size(79, 32);
            this.btnPesquisar.TabIndex = 79;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisar.Textcolor = System.Drawing.Color.White;
            this.btnPesquisar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // btnGravar
            // 
            this.btnGravar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGravar.BorderRadius = 0;
            this.btnGravar.ButtonText = "Gravar";
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGravar.Enabled = false;
            this.btnGravar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGravar.Iconimage = null;
            this.btnGravar.Iconimage_right = null;
            this.btnGravar.Iconimage_right_Selected = null;
            this.btnGravar.Iconimage_Selected = null;
            this.btnGravar.IconMarginLeft = 0;
            this.btnGravar.IconMarginRight = 0;
            this.btnGravar.IconRightVisible = true;
            this.btnGravar.IconRightZoom = 0D;
            this.btnGravar.IconVisible = true;
            this.btnGravar.IconZoom = 90D;
            this.btnGravar.IsTab = false;
            this.btnGravar.Location = new System.Drawing.Point(634, 16);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGravar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGravar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGravar.selected = false;
            this.btnGravar.Size = new System.Drawing.Size(79, 32);
            this.btnGravar.TabIndex = 18;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGravar.Textcolor = System.Drawing.Color.White;
            this.btnGravar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
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
            this.btnCancelar.Enabled = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(547, 16);
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
            this.btnAlterar.Location = new System.Drawing.Point(222, 16);
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
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            this.btnExcluir.Location = new System.Drawing.Point(137, 16);
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
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnIncluir.Location = new System.Drawing.Point(44, 16);
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
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpData);
            this.panel2.Controls.Add(this.cmbFeira);
            this.panel2.Controls.Add(this.cmbCliente);
            this.panel2.Controls.Add(this.txtObs);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.lblFeira);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.dgvVendas);
            this.panel2.Location = new System.Drawing.Point(8, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 402);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(502, 37);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(150, 20);
            this.dtpData.TabIndex = 90;
            // 
            // cmbFeira
            // 
            this.cmbFeira.DataSource = this.tccFeiraBindingSource;
            this.cmbFeira.DisplayMember = "nome_feira";
            this.cmbFeira.Enabled = false;
            this.cmbFeira.FormattingEnabled = true;
            this.cmbFeira.Location = new System.Drawing.Point(165, 59);
            this.cmbFeira.Name = "cmbFeira";
            this.cmbFeira.Size = new System.Drawing.Size(187, 21);
            this.cmbFeira.TabIndex = 88;
            this.cmbFeira.ValueMember = "cod_feira";
            // 
            // tccFeiraBindingSource
            // 
            this.tccFeiraBindingSource.DataMember = "tccFeira";
            this.tccFeiraBindingSource.DataSource = this.banco;
            // 
            // banco
            // 
            this.banco.DataSetName = "banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataSource = this.tccClienteBindingSource;
            this.cmbCliente.DisplayMember = "nome";
            this.cmbCliente.Enabled = false;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(165, 16);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(187, 21);
            this.cmbCliente.TabIndex = 87;
            this.cmbCliente.ValueMember = "cod_cli";
            // 
            // tccClienteBindingSource
            // 
            this.tccClienteBindingSource.DataMember = "tccCliente";
            this.tccClienteBindingSource.DataSource = this.banco;
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(62, 101);
            this.txtObs.Margin = new System.Windows.Forms.Padding(2);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(643, 94);
            this.txtObs.TabIndex = 86;
            this.txtObs.Text = "";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(13, 97);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(45, 21);
            this.bunifuCustomLabel5.TabIndex = 85;
            this.bunifuCustomLabel5.Text = "Obs:";
            // 
            // lblFeira
            // 
            this.lblFeira.AutoSize = true;
            this.lblFeira.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeira.ForeColor = System.Drawing.Color.Black;
            this.lblFeira.Location = new System.Drawing.Point(65, 59);
            this.lblFeira.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeira.Name = "lblFeira";
            this.lblFeira.Size = new System.Drawing.Size(51, 21);
            this.lblFeira.TabIndex = 83;
            this.lblFeira.Text = "Feira:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(386, 37);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(111, 21);
            this.bunifuCustomLabel2.TabIndex = 81;
            this.bunifuCustomLabel2.Text = "Data venda:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(65, 16);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(70, 21);
            this.bunifuCustomLabel4.TabIndex = 79;
            this.bunifuCustomLabel4.Text = "Cliente:";
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AllowUserToResizeColumns = false;
            this.dgvVendas.AutoGenerateColumns = false;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn13});
            this.dgvVendas.DataSource = this.tccVendaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVendas.Location = new System.Drawing.Point(7, 212);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVendas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(729, 145);
            this.dgvVendas.TabIndex = 76;
            this.dgvVendas.SelectionChanged += new System.EventHandler(this.dgvVendas_SelectionChanged_1);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "cod_venda";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cód. Venda";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn14.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "data";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn10.HeaderText = "Data";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "nome_feira";
            this.dataGridViewTextBoxColumn15.HeaderText = "Feira";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "obs";
            this.dataGridViewTextBoxColumn13.HeaderText = "Obs.";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 200;
            // 
            // tccVendaBindingSource
            // 
            this.tccVendaBindingSource.DataMember = "tccVenda";
            this.tccVendaBindingSource.DataSource = this.banco;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGravarItem);
            this.panel4.Controls.Add(this.bunifuCustomLabel1);
            this.panel4.Controls.Add(this.txtDesconto);
            this.panel4.Controls.Add(this.cmbProduto);
            this.panel4.Controls.Add(this.dgvItemVendas);
            this.panel4.Controls.Add(this.btnPagar);
            this.panel4.Controls.Add(this.btnCancelarItem);
            this.panel4.Controls.Add(this.nudQtd);
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Controls.Add(this.btnExcluirItem);
            this.panel4.Controls.Add(this.txtSubTotal);
            this.panel4.Controls.Add(this.txtPrecoUnit);
            this.panel4.Controls.Add(this.btnIncluirItem);
            this.panel4.Controls.Add(this.bunifuCustomLabel11);
            this.panel4.Controls.Add(this.bunifuCustomLabel10);
            this.panel4.Controls.Add(this.bunifuCustomLabel9);
            this.panel4.Controls.Add(this.bunifuCustomLabel8);
            this.panel4.Controls.Add(this.bunifuCustomLabel7);
            this.panel4.Location = new System.Drawing.Point(20, 530);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 356);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnGravarItem
            // 
            this.btnGravarItem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGravarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGravarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGravarItem.BorderRadius = 0;
            this.btnGravarItem.ButtonText = "Gravar";
            this.btnGravarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravarItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnGravarItem.Enabled = false;
            this.btnGravarItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGravarItem.Iconimage = null;
            this.btnGravarItem.Iconimage_right = null;
            this.btnGravarItem.Iconimage_right_Selected = null;
            this.btnGravarItem.Iconimage_Selected = null;
            this.btnGravarItem.IconMarginLeft = 0;
            this.btnGravarItem.IconMarginRight = 0;
            this.btnGravarItem.IconRightVisible = true;
            this.btnGravarItem.IconRightZoom = 0D;
            this.btnGravarItem.IconVisible = true;
            this.btnGravarItem.IconZoom = 90D;
            this.btnGravarItem.IsTab = false;
            this.btnGravarItem.Location = new System.Drawing.Point(510, 16);
            this.btnGravarItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGravarItem.Name = "btnGravarItem";
            this.btnGravarItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGravarItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGravarItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGravarItem.selected = false;
            this.btnGravarItem.Size = new System.Drawing.Size(79, 32);
            this.btnGravarItem.TabIndex = 77;
            this.btnGravarItem.Text = "Gravar";
            this.btnGravarItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGravarItem.Textcolor = System.Drawing.Color.White;
            this.btnGravarItem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarItem.Click += new System.EventHandler(this.btnGravarItem_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(389, 322);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(85, 21);
            this.bunifuCustomLabel1.TabIndex = 76;
            this.bunifuCustomLabel1.Text = "Desconto";
            this.bunifuCustomLabel1.Visible = false;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDesconto.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDesconto.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtDesconto.BorderThickness = 3;
            this.txtDesconto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesconto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDesconto.isPassword = false;
            this.txtDesconto.Location = new System.Drawing.Point(480, 315);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(53, 33);
            this.txtDesconto.TabIndex = 75;
            this.txtDesconto.Text = "0";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesconto.Visible = false;
            // 
            // cmbProduto
            // 
            this.cmbProduto.DataSource = this.tccProdutoBindingSource;
            this.cmbProduto.DisplayMember = "descricao";
            this.cmbProduto.Enabled = false;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(42, 85);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(155, 21);
            this.cmbProduto.TabIndex = 74;
            this.cmbProduto.ValueMember = "cod_pro";
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // tccProdutoBindingSource
            // 
            this.tccProdutoBindingSource.DataMember = "tccProduto";
            this.tccProdutoBindingSource.DataSource = this.banco;
            // 
            // dgvItemVendas
            // 
            this.dgvItemVendas.AllowUserToAddRows = false;
            this.dgvItemVendas.AllowUserToDeleteRows = false;
            this.dgvItemVendas.AutoGenerateColumns = false;
            this.dgvItemVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantidade,
            this.descricao,
            this.dataGridViewTextBoxColumn4});
            this.dgvItemVendas.DataSource = this.tccItemVendaBindingSource1;
            this.dgvItemVendas.Location = new System.Drawing.Point(41, 124);
            this.dgvItemVendas.Name = "dgvItemVendas";
            this.dgvItemVendas.ReadOnly = true;
            this.dgvItemVendas.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvItemVendas.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItemVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemVendas.Size = new System.Drawing.Size(647, 184);
            this.dgvItemVendas.TabIndex = 73;
            this.dgvItemVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemVendas_CellContentClick);
            this.dgvItemVendas.SelectionChanged += new System.EventHandler(this.dgvItemVendas_SelectionChanged);
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.quantidade.DefaultCellStyle = dataGridViewCellStyle4;
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 75;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.descricao.DefaultCellStyle = dataGridViewCellStyle5;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor_unitario";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Format = "C2";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn4.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // tccItemVendaBindingSource1
            // 
            this.tccItemVendaBindingSource1.DataMember = "FK_tccItemVenda_tccVenda";
            this.tccItemVendaBindingSource1.DataSource = this.tccVendaBindingSource;
            // 
            // btnPagar
            // 
            this.btnPagar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagar.BorderRadius = 0;
            this.btnPagar.ButtonText = "Pagar Venda";
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
            this.btnPagar.Location = new System.Drawing.Point(14, 316);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPagar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPagar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPagar.selected = false;
            this.btnPagar.Size = new System.Drawing.Size(145, 32);
            this.btnPagar.TabIndex = 72;
            this.btnPagar.Text = "Pagar Venda";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPagar.Textcolor = System.Drawing.Color.White;
            this.btnPagar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
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
            this.btnCancelarItem.Enabled = false;
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
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // nudQtd
            // 
            this.nudQtd.Enabled = false;
            this.nudQtd.Location = new System.Drawing.Point(237, 86);
            this.nudQtd.Margin = new System.Windows.Forms.Padding(2);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(80, 20);
            this.nudQtd.TabIndex = 72;
            this.nudQtd.ValueChanged += new System.EventHandler(this.quantidadeNumericUpDown_ValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.BorderColorFocused = System.Drawing.Color.Teal;
            this.txtTotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.txtTotal.BorderThickness = 3;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTotal.isPassword = false;
            this.txtTotal.Location = new System.Drawing.Point(594, 315);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(94, 33);
            this.txtTotal.TabIndex = 71;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.OnValueChanged += new System.EventHandler(this.txtTotal_OnValueChanged);
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
            this.btnExcluirItem.Location = new System.Drawing.Point(107, 16);
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
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSubTotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubTotal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSubTotal.BorderThickness = 3;
            this.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubTotal.isPassword = false;
            this.txtSubTotal.Location = new System.Drawing.Point(455, 84);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(90, 33);
            this.txtSubTotal.TabIndex = 70;
            this.txtSubTotal.Text = "0";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSubTotal.OnValueChanged += new System.EventHandler(this.txtSubTotal_OnValueChanged);
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPrecoUnit.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecoUnit.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPrecoUnit.BorderThickness = 3;
            this.txtPrecoUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecoUnit.Enabled = false;
            this.txtPrecoUnit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecoUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecoUnit.isPassword = false;
            this.txtPrecoUnit.Location = new System.Drawing.Point(340, 84);
            this.txtPrecoUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.Size = new System.Drawing.Size(87, 33);
            this.txtPrecoUnit.TabIndex = 69;
            this.txtPrecoUnit.Text = "1";
            this.txtPrecoUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecoUnit.OnValueChanged += new System.EventHandler(this.txtPrecoUnit_OnValueChanged);
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
            this.btnIncluirItem.Click += new System.EventHandler(this.btnIncluirItem_Click);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(540, 322);
            this.bunifuCustomLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(53, 22);
            this.bunifuCustomLabel11.TabIndex = 68;
            this.bunifuCustomLabel11.Text = "Total";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(451, 59);
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
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(336, 59);
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
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(224, 61);
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
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(83, 61);
            this.bunifuCustomLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(72, 21);
            this.bunifuCustomLabel7.TabIndex = 64;
            this.bunifuCustomLabel7.Text = "Produto";
            this.bunifuCustomLabel7.Click += new System.EventHandler(this.bunifuCustomLabel7_Click);
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
            // tccItemVendaBindingSource
            // 
            this.tccItemVendaBindingSource.DataMember = "tccItemVenda";
            this.tccItemVendaBindingSource.DataSource = this.banco;
            // 
            // tccVendaTableAdapter
            // 
            this.tccVendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tccClienteTableAdapter = null;
            this.tableAdapterManager.tccFeiraTableAdapter = null;
            this.tableAdapterManager.tccProdutoTableAdapter = null;
            this.tableAdapterManager.tccUsuariosTableAdapter = null;
            this.tableAdapterManager.tccVendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Impulse.bancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tccItemVendaTableAdapter
            // 
            this.tccItemVendaTableAdapter.ClearBeforeFill = true;
            // 
            // tccProdutoTableAdapter1
            // 
            this.tccProdutoTableAdapter1.ClearBeforeFill = true;
            // 
            // tccProdutoTableAdapter
            // 
            this.tccProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tccClienteTableAdapter
            // 
            this.tccClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tccFeiraTableAdapter
            // 
            this.tccFeiraTableAdapter.ClearBeforeFill = true;
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataMember = "pagamento";
            this.pagamentoBindingSource.DataSource = this.banco;
            // 
            // pagamentoTableAdapter
            // 
            this.pagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCadVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 920);
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
            ((System.ComponentModel.ISupportInitialize)(this.tccFeiraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccVendaBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemVendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcluir;
        private Bunifu.Framework.UI.BunifuFlatButton btnIncluir;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAlterar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSubTotal;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPrecoUnit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelarItem;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcluirItem;
        private Bunifu.Framework.UI.BunifuFlatButton btnIncluirItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuFlatButton btnPagar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private banco banco;
        private System.Windows.Forms.BindingSource tccVendaBindingSource;
        private bancoTableAdapters.tccVendaTableAdapter tccVendaTableAdapter;
        private bancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tccItemVendaBindingSource;
        private bancoTableAdapters.tccItemVendaTableAdapter tccItemVendaTableAdapter;
        private System.Windows.Forms.DataGridView dgvItemVendas;
        private System.Windows.Forms.BindingSource tccItemVendaBindingSource1;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGravar;
        private db_05266_14_A_1_2017DataSetTableAdapters.tccProdutoTableAdapter tccProdutoTableAdapter1;
        private System.Windows.Forms.BindingSource tccProdutoBindingSource;
        private bancoTableAdapters.tccProdutoTableAdapter tccProdutoTableAdapter;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cmbFeira;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.RichTextBox txtObs;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFeira;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.BindingSource tccClienteBindingSource;
        private bancoTableAdapters.tccClienteTableAdapter tccClienteTableAdapter;
        private System.Windows.Forms.BindingSource tccFeiraBindingSource;
        private bancoTableAdapters.tccFeiraTableAdapter tccFeiraTableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton btnPesquisar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGravarItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDesconto;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
        private bancoTableAdapters.pagamentoTableAdapter pagamentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}