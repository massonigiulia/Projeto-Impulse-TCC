namespace Impulse
{
    partial class FrmCadProdutos
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
            this.txtProduto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtItem = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtValorCusto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescricao = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTipo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtValorVenda = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCadastrarPro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.db_05266_14_A_1_2017DataSet = new Impulse.db_05266_14_A_1_2017DataSet();
            this.tccProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccProdutoTableAdapter = new Impulse.db_05266_14_A_1_2017DataSetTableAdapters.tccProdutoTableAdapter();
            this.tableAdapterManager = new Impulse.db_05266_14_A_1_2017DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.db_05266_14_A_1_2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProduto.HintForeColor = System.Drawing.Color.Empty;
            this.txtProduto.HintText = "";
            this.txtProduto.isPassword = false;
            this.txtProduto.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProduto.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProduto.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProduto.LineThickness = 3;
            this.txtProduto.Location = new System.Drawing.Point(13, 70);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(247, 29);
            this.txtProduto.TabIndex = 3;
            this.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(9, 48);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(61, 21);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "Nome:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 105);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(89, 21);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Tamanho:";
            // 
            // txtItem
            // 
            this.txtItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtItem.HintForeColor = System.Drawing.Color.Empty;
            this.txtItem.HintText = "";
            this.txtItem.isPassword = false;
            this.txtItem.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtItem.LineIdleColor = System.Drawing.Color.Gray;
            this.txtItem.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtItem.LineThickness = 3;
            this.txtItem.Location = new System.Drawing.Point(13, 127);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(247, 29);
            this.txtItem.TabIndex = 11;
            this.txtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(9, 173);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(101, 21);
            this.bunifuCustomLabel2.TabIndex = 14;
            this.bunifuCustomLabel2.Text = "Valor custo:";
            // 
            // txtValorCusto
            // 
            this.txtValorCusto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorCusto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtValorCusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorCusto.HintForeColor = System.Drawing.Color.Empty;
            this.txtValorCusto.HintText = "";
            this.txtValorCusto.isPassword = false;
            this.txtValorCusto.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtValorCusto.LineIdleColor = System.Drawing.Color.Gray;
            this.txtValorCusto.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtValorCusto.LineThickness = 3;
            this.txtValorCusto.Location = new System.Drawing.Point(13, 195);
            this.txtValorCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorCusto.Name = "txtValorCusto";
            this.txtValorCusto.Size = new System.Drawing.Size(247, 29);
            this.txtValorCusto.TabIndex = 13;
            this.txtValorCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(277, 173);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(91, 21);
            this.bunifuCustomLabel3.TabIndex = 20;
            this.bunifuCustomLabel3.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescricao.HintForeColor = System.Drawing.Color.Empty;
            this.txtDescricao.HintText = "";
            this.txtDescricao.isPassword = false;
            this.txtDescricao.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDescricao.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDescricao.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDescricao.LineThickness = 3;
            this.txtDescricao.Location = new System.Drawing.Point(281, 195);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(247, 29);
            this.txtDescricao.TabIndex = 19;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(277, 105);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(46, 21);
            this.bunifuCustomLabel5.TabIndex = 18;
            this.bunifuCustomLabel5.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipo.HintForeColor = System.Drawing.Color.Empty;
            this.txtTipo.HintText = "";
            this.txtTipo.isPassword = false;
            this.txtTipo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTipo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTipo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTipo.LineThickness = 3;
            this.txtTipo.Location = new System.Drawing.Point(281, 127);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(247, 29);
            this.txtTipo.TabIndex = 17;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(277, 48);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(110, 21);
            this.bunifuCustomLabel6.TabIndex = 16;
            this.bunifuCustomLabel6.Text = "Valor venda:";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorVenda.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtValorVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorVenda.HintForeColor = System.Drawing.Color.Empty;
            this.txtValorVenda.HintText = "";
            this.txtValorVenda.isPassword = false;
            this.txtValorVenda.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtValorVenda.LineIdleColor = System.Drawing.Color.Gray;
            this.txtValorVenda.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtValorVenda.LineThickness = 3;
            this.txtValorVenda.Location = new System.Drawing.Point(281, 70);
            this.txtValorVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(247, 29);
            this.txtValorVenda.TabIndex = 15;
            this.txtValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.ButtonText = "Cancelar e apagar";
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
            this.btnCancelar.Location = new System.Drawing.Point(341, 260);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(135, 35);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar e apagar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnCadastrarPro
            // 
            this.btnCadastrarPro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCadastrarPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCadastrarPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarPro.BorderRadius = 0;
            this.btnCadastrarPro.ButtonText = "Cadastrar";
            this.btnCadastrarPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarPro.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastrarPro.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastrarPro.Iconimage = null;
            this.btnCadastrarPro.Iconimage_right = null;
            this.btnCadastrarPro.Iconimage_right_Selected = null;
            this.btnCadastrarPro.Iconimage_Selected = null;
            this.btnCadastrarPro.IconMarginLeft = 0;
            this.btnCadastrarPro.IconMarginRight = 0;
            this.btnCadastrarPro.IconRightVisible = true;
            this.btnCadastrarPro.IconRightZoom = 0D;
            this.btnCadastrarPro.IconVisible = true;
            this.btnCadastrarPro.IconZoom = 90D;
            this.btnCadastrarPro.IsTab = false;
            this.btnCadastrarPro.Location = new System.Drawing.Point(66, 260);
            this.btnCadastrarPro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrarPro.Name = "btnCadastrarPro";
            this.btnCadastrarPro.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCadastrarPro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCadastrarPro.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrarPro.selected = false;
            this.btnCadastrarPro.Size = new System.Drawing.Size(135, 35);
            this.btnCadastrarPro.TabIndex = 21;
            this.btnCadastrarPro.Text = "Cadastrar";
            this.btnCadastrarPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrarPro.Textcolor = System.Drawing.Color.White;
            this.btnCadastrarPro.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPro.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(9, 6);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(267, 28);
            this.bunifuCustomLabel7.TabIndex = 40;
            this.bunifuCustomLabel7.Text = "Cadastro de produtos";
            // 
            // db_05266_14_A_1_2017DataSet
            // 
            this.db_05266_14_A_1_2017DataSet.DataSetName = "db_05266_14_A_1_2017DataSet";
            this.db_05266_14_A_1_2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tccProdutoBindingSource
            // 
            this.tccProdutoBindingSource.DataMember = "tccProduto";
            this.tccProdutoBindingSource.DataSource = this.db_05266_14_A_1_2017DataSet;
            // 
            // tccProdutoTableAdapter
            // 
            this.tccProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tccClienteTableAdapter = null;
            this.tableAdapterManager.tccCompraTableAdapter = null;
            this.tableAdapterManager.tccFeiraTableAdapter = null;
            this.tableAdapterManager.tccFornecedorTableAdapter = null;
            this.tableAdapterManager.tccItemCompraTableAdapter = null;
            this.tableAdapterManager.tccItemVendaTableAdapter = null;
            this.tableAdapterManager.tccPendenciasTableAdapter = null;
            this.tableAdapterManager.tccProdutoTableAdapter = this.tccProdutoTableAdapter;
            this.tableAdapterManager.tccUsuariosTableAdapter = null;
            this.tableAdapterManager.tccVendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Impulse.db_05266_14_A_1_2017DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 598);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrarPro);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtValorCusto);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txtProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadProdutos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadProdutos_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_05266_14_A_1_2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProduto;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescricao;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtValorVenda;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrarPro;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtValorCusto;
        private db_05266_14_A_1_2017DataSet db_05266_14_A_1_2017DataSet;
        private System.Windows.Forms.BindingSource tccProdutoBindingSource;
        private db_05266_14_A_1_2017DataSetTableAdapters.tccProdutoTableAdapter tccProdutoTableAdapter;
        private db_05266_14_A_1_2017DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}