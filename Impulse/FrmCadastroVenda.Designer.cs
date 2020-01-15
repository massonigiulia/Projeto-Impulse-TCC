namespace Impulse
{
    partial class FrmCadastroVenda
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbFeira = new System.Windows.Forms.ComboBox();
            this.tccFeiraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco1 = new Impulse.banco();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.brnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSalvar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.tccClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco = new Impulse.banco();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tccVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccClienteTableAdapter1 = new Impulse.bancoTableAdapters.tccClienteTableAdapter();
            this.tccVendaTableAdapter1 = new Impulse.bancoTableAdapters.tccVendaTableAdapter();
            this.tccFeiraTableAdapter1 = new Impulse.bancoTableAdapters.tccFeiraTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccFeiraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccVendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.cmbFeira);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.brnCancelar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.cmbCliente);
            this.panel2.Controls.Add(this.txtObs);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Location = new System.Drawing.Point(11, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 262);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AllowDrop = true;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(228, 43);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(51, 21);
            this.bunifuCustomLabel2.TabIndex = 79;
            this.bunifuCustomLabel2.Text = "Feira:";
            // 
            // cmbFeira
            // 
            this.cmbFeira.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFeira.DataSource = this.tccFeiraBindingSource;
            this.cmbFeira.DisplayMember = "nome_feira";
            this.cmbFeira.FormattingEnabled = true;
            this.cmbFeira.Location = new System.Drawing.Point(303, 43);
            this.cmbFeira.Name = "cmbFeira";
            this.cmbFeira.Size = new System.Drawing.Size(222, 21);
            this.cmbFeira.TabIndex = 78;
            this.cmbFeira.ValueMember = "cod_feira";
            // 
            // tccFeiraBindingSource
            // 
            this.tccFeiraBindingSource.DataMember = "tccFeira";
            this.tccFeiraBindingSource.DataSource = this.banco1;
            // 
            // banco1
            // 
            this.banco1.DataSetName = "banco";
            this.banco1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 77;
            // 
            // brnCancelar
            // 
            this.brnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.brnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.brnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brnCancelar.BorderRadius = 0;
            this.brnCancelar.ButtonText = "Cancelar";
            this.brnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.brnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.brnCancelar.Iconimage = null;
            this.brnCancelar.Iconimage_right = null;
            this.brnCancelar.Iconimage_right_Selected = null;
            this.brnCancelar.Iconimage_Selected = null;
            this.brnCancelar.IconMarginLeft = 0;
            this.brnCancelar.IconMarginRight = 0;
            this.brnCancelar.IconRightVisible = true;
            this.brnCancelar.IconRightZoom = 0D;
            this.brnCancelar.IconVisible = true;
            this.brnCancelar.IconZoom = 90D;
            this.brnCancelar.IsTab = false;
            this.brnCancelar.Location = new System.Drawing.Point(576, 197);
            this.brnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brnCancelar.Name = "brnCancelar";
            this.brnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.brnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.brnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.brnCancelar.selected = false;
            this.brnCancelar.Size = new System.Drawing.Size(79, 32);
            this.brnCancelar.TabIndex = 76;
            this.brnCancelar.Text = "Cancelar";
            this.brnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brnCancelar.Textcolor = System.Drawing.Color.White;
            this.brnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnCancelar.Click += new System.EventHandler(this.brnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.BorderRadius = 0;
            this.btnSalvar.ButtonText = "Salvar";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalvar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalvar.Iconimage = null;
            this.btnSalvar.Iconimage_right = null;
            this.btnSalvar.Iconimage_right_Selected = null;
            this.btnSalvar.Iconimage_Selected = null;
            this.btnSalvar.IconMarginLeft = 0;
            this.btnSalvar.IconMarginRight = 0;
            this.btnSalvar.IconRightVisible = true;
            this.btnSalvar.IconRightZoom = 0D;
            this.btnSalvar.IconVisible = true;
            this.btnSalvar.IconZoom = 90D;
            this.btnSalvar.IsTab = false;
            this.btnSalvar.Location = new System.Drawing.Point(468, 197);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSalvar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalvar.selected = false;
            this.btnSalvar.Size = new System.Drawing.Size(79, 32);
            this.btnSalvar.TabIndex = 75;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.Textcolor = System.Drawing.Color.White;
            this.btnSalvar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.DataSource = this.tccClienteBindingSource;
            this.cmbCliente.DisplayMember = "nome";
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(303, 16);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(222, 21);
            this.cmbCliente.TabIndex = 73;
            this.cmbCliente.ValueMember = "codCli";
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged_SelectedIndexChanged);
            // 
            // tccClienteBindingSource
            // 
            this.tccClienteBindingSource.DataMember = "tccCliente";
            this.tccClienteBindingSource.DataSource = this.banco;
            // 
            // banco
            // 
            this.banco.DataSetName = "banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(59, 77);
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
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(228, 16);
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
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(32, 16);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(67, 21);
            this.bunifuCustomLabel4.TabIndex = 62;
            this.bunifuCustomLabel4.Text = "Venda:";
            // 
            // tccVendaBindingSource
            // 
            this.tccVendaBindingSource.DataMember = "tccVenda";
            this.tccVendaBindingSource.DataSource = this.banco;
            // 
            // tccClienteTableAdapter1
            // 
            this.tccClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // tccVendaTableAdapter1
            // 
            this.tccVendaTableAdapter1.ClearBeforeFill = true;
            // 
            // tccFeiraTableAdapter1
            // 
            this.tccFeiraTableAdapter1.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(545, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 80;
            // 
            // FrmCadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 291);
            this.Controls.Add(this.panel2);
            this.Name = "FrmCadastroVenda";
            this.Text = "FormCadClientesPesquisar";
            this.Load += new System.EventHandler(this.FrmCadastroVenda_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccFeiraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccVendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.RichTextBox txtObs;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton brnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalvar;
        private bancoTableAdapters.tccClienteTableAdapter tccClienteTableAdapter;
        private bancoTableAdapters.tccFeiraTableAdapter tccFeiraTableAdapter;
        private bancoTableAdapters.tccVendaTableAdapter tccVendaTableAdapter;
        private banco banco;
        private System.Windows.Forms.BindingSource tccClienteBindingSource;
        private bancoTableAdapters.tccClienteTableAdapter tccClienteTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tccVendaBindingSource;
        private bancoTableAdapters.tccVendaTableAdapter tccVendaTableAdapter1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox cmbFeira;
        private banco banco1;
        private System.Windows.Forms.BindingSource tccFeiraBindingSource;
        private bancoTableAdapters.tccFeiraTableAdapter tccFeiraTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}