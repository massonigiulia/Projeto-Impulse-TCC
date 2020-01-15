namespace Impulse
{
    partial class FrmPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagar));
            this.pnlGradiente = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValorRestante = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuitar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtValorRecebido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtValor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tccVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco = new Impulse.banco();
            this.pagamentoTableAdapter1 = new Impulse.bancoTableAdapters.pagamentoTableAdapter();
            this.tccVendaTableAdapter = new Impulse.bancoTableAdapters.tccVendaTableAdapter();
            this.tableAdapterManager = new Impulse.bancoTableAdapters.TableAdapterManager();
            this.tccItemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccItemVendaTableAdapter = new Impulse.bancoTableAdapters.tccItemVendaTableAdapter();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlGradiente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGradiente
            // 
            this.pnlGradiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGradiente.BackgroundImage")));
            this.pnlGradiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGradiente.Controls.Add(this.lblTotal);
            this.pnlGradiente.Controls.Add(this.label1);
            this.pnlGradiente.GradientBottomLeft = System.Drawing.Color.LightSeaGreen;
            this.pnlGradiente.GradientBottomRight = System.Drawing.Color.ForestGreen;
            this.pnlGradiente.GradientTopLeft = System.Drawing.Color.Teal;
            this.pnlGradiente.GradientTopRight = System.Drawing.Color.DarkSlateGray;
            this.pnlGradiente.Location = new System.Drawing.Point(0, 0);
            this.pnlGradiente.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGradiente.Name = "pnlGradiente";
            this.pnlGradiente.Quality = 10;
            this.pnlGradiente.Size = new System.Drawing.Size(401, 440);
            this.pnlGradiente.TabIndex = 95;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(24, 196);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(261, 115);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "$238";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(318, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 448);
            this.panel1.TabIndex = 96;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtValorRestante);
            this.panel2.Controls.Add(this.txtTroco);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnQuitar);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.txtValorRecebido);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 446);
            this.panel2.TabIndex = 61;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtValorRestante
            // 
            this.txtValorRestante.Location = new System.Drawing.Point(198, 255);
            this.txtValorRestante.Name = "txtValorRestante";
            this.txtValorRestante.ReadOnly = true;
            this.txtValorRestante.Size = new System.Drawing.Size(247, 20);
            this.txtValorRestante.TabIndex = 70;
            this.txtValorRestante.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(198, 154);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(247, 20);
            this.txtTroco.TabIndex = 69;
            this.txtTroco.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(2, 6);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(237, 28);
            this.bunifuCustomLabel2.TabIndex = 68;
            this.bunifuCustomLabel2.Text = "Pagamento à vista:";
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
            this.btnCancelar.Location = new System.Drawing.Point(425, 348);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(135, 35);
            this.btnCancelar.TabIndex = 66;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.BorderRadius = 0;
            this.btnQuitar.ButtonText = "Pagar";
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuitar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuitar.Iconimage = null;
            this.btnQuitar.Iconimage_right = null;
            this.btnQuitar.Iconimage_right_Selected = null;
            this.btnQuitar.Iconimage_Selected = null;
            this.btnQuitar.IconMarginLeft = 0;
            this.btnQuitar.IconMarginRight = 0;
            this.btnQuitar.IconRightVisible = true;
            this.btnQuitar.IconRightZoom = 0D;
            this.btnQuitar.IconVisible = true;
            this.btnQuitar.IconZoom = 90D;
            this.btnQuitar.IsTab = false;
            this.btnQuitar.Location = new System.Drawing.Point(129, 348);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuitar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQuitar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuitar.selected = false;
            this.btnQuitar.Size = new System.Drawing.Size(135, 35);
            this.btnQuitar.TabIndex = 65;
            this.btnQuitar.Text = "Pagar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuitar.Textcolor = System.Drawing.Color.White;
            this.btnQuitar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(288, 116);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(53, 21);
            this.bunifuCustomLabel6.TabIndex = 64;
            this.bunifuCustomLabel6.Text = "Troco";
            this.bunifuCustomLabel6.Click += new System.EventHandler(this.bunifuCustomLabel6_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(252, 40);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(129, 21);
            this.bunifuCustomLabel4.TabIndex = 61;
            this.bunifuCustomLabel4.Text = "Valor Recebido";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorRecebido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtValorRecebido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorRecebido.HintForeColor = System.Drawing.Color.Empty;
            this.txtValorRecebido.HintText = "";
            this.txtValorRecebido.isPassword = false;
            this.txtValorRecebido.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtValorRecebido.LineIdleColor = System.Drawing.Color.Gray;
            this.txtValorRecebido.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtValorRecebido.LineThickness = 3;
            this.txtValorRecebido.Location = new System.Drawing.Point(198, 65);
            this.txtValorRecebido.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(247, 29);
            this.txtValorRecebido.TabIndex = 60;
            this.txtValorRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtValorRecebido.OnValueChanged += new System.EventHandler(this.txtValorRecebido_OnValueChanged);
            // 
            // txtValor
            // 
            this.txtValor.AutoSize = true;
            this.txtValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Location = new System.Drawing.Point(261, 207);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 21);
            this.txtValor.TabIndex = 62;
            this.txtValor.Text = "Valor restante";
            this.txtValor.Click += new System.EventHandler(this.bunifuCustomLabel1_Click_1);
            // 
            // tccVendaBindingSource
            // 
            this.tccVendaBindingSource.DataMember = "tccVenda";
            this.tccVendaBindingSource.DataSource = this.banco;
            // 
            // banco
            // 
            this.banco.DataSetName = "banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pagamentoTableAdapter1
            // 
            this.pagamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // tccVendaTableAdapter
            // 
            this.tccVendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tccClienteTableAdapter = null;
            this.tableAdapterManager.tccFeiraTableAdapter = null;
            this.tableAdapterManager.tccProdutoTableAdapter = null;
            this.tableAdapterManager.tccUsuariosTableAdapter = null;
            this.tableAdapterManager.tccVendaTableAdapter = this.tccVendaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Impulse.bancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tccItemVendaBindingSource
            // 
            this.tccItemVendaBindingSource.DataMember = "tccItemVenda";
            this.tccItemVendaBindingSource.DataSource = this.banco;
            // 
            // tccItemVendaTableAdapter
            // 
            this.tccItemVendaTableAdapter.ClearBeforeFill = true;
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataMember = "pagamento";
            this.pagamentoBindingSource.DataSource = this.banco;
            // 
            // FrmPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGradiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPagar";
            this.Load += new System.EventHandler(this.FrmPagar_Load);
            this.pnlGradiente.ResumeLayout(false);
            this.pnlGradiente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel pnlGradiente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuitar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtValorRecebido;
        private Bunifu.Framework.UI.BunifuCustomLabel txtValor;
        private System.Windows.Forms.TextBox txtValorRestante;
        private System.Windows.Forms.TextBox txtTroco;
        private bancoTableAdapters.pagamentoTableAdapter pagamentoTableAdapter1;
        private banco banco;
        private System.Windows.Forms.BindingSource tccVendaBindingSource;
        private bancoTableAdapters.tccVendaTableAdapter tccVendaTableAdapter;
        private bancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tccItemVendaBindingSource;
        private bancoTableAdapters.tccItemVendaTableAdapter tccItemVendaTableAdapter;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
    }
}