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
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescricao = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtValorVenda = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCadastrarPro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.banco = new Impulse.banco();
            this.tccProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccProdutoTableAdapter = new Impulse.bancoTableAdapters.tccProdutoTableAdapter();
            this.tableAdapterManager = new Impulse.bancoTableAdapters.TableAdapterManager();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(11, 58);
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
            this.txtDescricao.Location = new System.Drawing.Point(15, 80);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(247, 29);
            this.txtDescricao.TabIndex = 19;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtValorVenda.Location = new System.Drawing.Point(278, 80);
            this.txtValorVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(247, 29);
            this.txtValorVenda.TabIndex = 15;
            this.txtValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtValorVenda.OnValueChanged += new System.EventHandler(this.txtValorVenda_OnValueChanged);
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
            this.btnCancelar.Location = new System.Drawing.Point(324, 203);
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
            this.btnCadastrarPro.Location = new System.Drawing.Point(63, 203);
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
            // banco
            // 
            this.banco.DataSetName = "banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tccProdutoBindingSource
            // 
            this.tccProdutoBindingSource.DataMember = "tccProduto";
            this.tccProdutoBindingSource.DataSource = this.banco;
            // 
            // tccProdutoTableAdapter
            // 
            this.tccProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tccClienteTableAdapter = null;
            this.tableAdapterManager.tccFeiraTableAdapter = null;
            this.tableAdapterManager.tccProdutoTableAdapter = this.tccProdutoTableAdapter;
            this.tableAdapterManager.tccUsuariosTableAdapter = null;
            this.tableAdapterManager.tccVendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Impulse.bancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(274, 58);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(121, 21);
            this.bunifuCustomLabel6.TabIndex = 16;
            this.bunifuCustomLabel6.Text = "Preço unitário:";
            this.bunifuCustomLabel6.Click += new System.EventHandler(this.bunifuCustomLabel6_Click);
            // 
            // FrmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 262);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrarPro);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.txtValorVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadProdutos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadProdutos_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescricao;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtValorVenda;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrarPro;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private banco banco;
        private System.Windows.Forms.BindingSource tccProdutoBindingSource;
        private bancoTableAdapters.tccProdutoTableAdapter tccProdutoTableAdapter;
        private bancoTableAdapters.TableAdapterManager tableAdapterManager;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
    }
}