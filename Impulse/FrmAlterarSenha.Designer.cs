namespace Impulse
{
    partial class FrmAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterarSenha));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnmenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txtPalavraVerificacao = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAlterarSenha = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.banco = new Impulse.banco();
            this.tccUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccUsuariosTableAdapter = new Impulse.bancoTableAdapters.tccUsuariosTableAdapter();
            this.tableAdapterManager = new Impulse.bancoTableAdapters.TableAdapterManager();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNovaSenha1 = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtVerificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.linkAlterarSenha = new System.Windows.Forms.LinkLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnmenu);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCards1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.ForestGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkSlateGray;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(903, 581);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.Transparent;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.ImageActive = null;
            this.btnmenu.Location = new System.Drawing.Point(852, 11);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(31, 32);
            this.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmenu.TabIndex = 25;
            this.btnmenu.TabStop = false;
            this.btnmenu.Zoom = 10;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkSlateGray;
            this.bunifuCards1.Controls.Add(this.linkAlterarSenha);
            this.bunifuCards1.Controls.Add(this.txtVerificar);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.txtNovaSenha1);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.Controls.Add(this.txtNovaSenha);
            this.bunifuCards1.Controls.Add(this.txtPalavraVerificacao);
            this.bunifuCards1.Controls.Add(this.btnAlterarSenha);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(267, 25);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(352, 398);
            this.bunifuCards1.TabIndex = 0;
            // 
            // txtPalavraVerificacao
            // 
            this.txtPalavraVerificacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPalavraVerificacao.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPalavraVerificacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPalavraVerificacao.HintForeColor = System.Drawing.Color.Empty;
            this.txtPalavraVerificacao.HintText = "Digite a palavra de verificação";
            this.txtPalavraVerificacao.isPassword = false;
            this.txtPalavraVerificacao.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.txtPalavraVerificacao.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPalavraVerificacao.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.txtPalavraVerificacao.LineThickness = 3;
            this.txtPalavraVerificacao.Location = new System.Drawing.Point(26, 171);
            this.txtPalavraVerificacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtPalavraVerificacao.Name = "txtPalavraVerificacao";
            this.txtPalavraVerificacao.Size = new System.Drawing.Size(313, 44);
            this.txtPalavraVerificacao.TabIndex = 8;
            this.txtPalavraVerificacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPalavraVerificacao.OnValueChanged += new System.EventHandler(this.TxtPalavraVerificacao_OnValueChanged);
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAlterarSenha.AllowDrop = true;
            this.btnAlterarSenha.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAlterarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterarSenha.BorderRadius = 0;
            this.btnAlterarSenha.ButtonText = "Alterar";
            this.btnAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarSenha.DisabledColor = System.Drawing.Color.Gray;
            this.btnAlterarSenha.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAlterarSenha.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAlterarSenha.Iconimage")));
            this.btnAlterarSenha.Iconimage_right = null;
            this.btnAlterarSenha.Iconimage_right_Selected = null;
            this.btnAlterarSenha.Iconimage_Selected = null;
            this.btnAlterarSenha.IconMarginLeft = 0;
            this.btnAlterarSenha.IconMarginRight = 0;
            this.btnAlterarSenha.IconRightVisible = true;
            this.btnAlterarSenha.IconRightZoom = 0D;
            this.btnAlterarSenha.IconVisible = true;
            this.btnAlterarSenha.IconZoom = 90D;
            this.btnAlterarSenha.IsTab = false;
            this.btnAlterarSenha.Location = new System.Drawing.Point(234, 320);
            this.btnAlterarSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnAlterarSenha.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAlterarSenha.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAlterarSenha.selected = false;
            this.btnAlterarSenha.Size = new System.Drawing.Size(105, 48);
            this.btnAlterarSenha.TabIndex = 7;
            this.btnAlterarSenha.Text = "Alterar";
            this.btnAlterarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarSenha.Textcolor = System.Drawing.Color.White;
            this.btnAlterarSenha.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSenha.Visible = false;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(127, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(86, 13);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Altere sua senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // banco
            // 
            this.banco.DataSetName = "banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tccUsuariosBindingSource
            // 
            this.tccUsuariosBindingSource.DataMember = "tccUsuarios";
            this.tccUsuariosBindingSource.DataSource = this.banco;
            // 
            // tccUsuariosTableAdapter
            // 
            this.tccUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
           // this.tableAdapterManager.pagamentoTableAdapter = null;
            this.tableAdapterManager.tccClienteTableAdapter = null;
            this.tableAdapterManager.tccFeiraTableAdapter = null;
            this.tableAdapterManager.tccProdutoTableAdapter = null;
            this.tableAdapterManager.tccUsuariosTableAdapter = this.tccUsuariosTableAdapter;
            this.tableAdapterManager.tccVendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Impulse.bancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Enabled = false;
            this.txtNovaSenha.Location = new System.Drawing.Point(26, 253);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(313, 20);
            this.txtNovaSenha.TabIndex = 9;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(23, 237);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(117, 13);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Insira uma nova senha:";
            // 
            // txtNovaSenha1
            // 
            this.txtNovaSenha1.Enabled = false;
            this.txtNovaSenha1.Location = new System.Drawing.Point(26, 292);
            this.txtNovaSenha1.Name = "txtNovaSenha1";
            this.txtNovaSenha1.Size = new System.Drawing.Size(313, 20);
            this.txtNovaSenha1.TabIndex = 11;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(23, 276);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(130, 13);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Confirme sua nova senha:";
            // 
            // txtVerificar
            // 
            this.txtVerificar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.txtVerificar.AllowDrop = true;
            this.txtVerificar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtVerificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtVerificar.BorderRadius = 0;
            this.txtVerificar.ButtonText = "Verificar";
            this.txtVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtVerificar.DisabledColor = System.Drawing.Color.Gray;
            this.txtVerificar.Iconcolor = System.Drawing.Color.Transparent;
            this.txtVerificar.Iconimage = ((System.Drawing.Image)(resources.GetObject("txtVerificar.Iconimage")));
            this.txtVerificar.Iconimage_right = null;
            this.txtVerificar.Iconimage_right_Selected = null;
            this.txtVerificar.Iconimage_Selected = null;
            this.txtVerificar.IconMarginLeft = 0;
            this.txtVerificar.IconMarginRight = 0;
            this.txtVerificar.IconRightVisible = true;
            this.txtVerificar.IconRightZoom = 0D;
            this.txtVerificar.IconVisible = true;
            this.txtVerificar.IconZoom = 90D;
            this.txtVerificar.IsTab = false;
            this.txtVerificar.Location = new System.Drawing.Point(112, 320);
            this.txtVerificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVerificar.Name = "txtVerificar";
            this.txtVerificar.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.txtVerificar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.txtVerificar.OnHoverTextColor = System.Drawing.Color.White;
            this.txtVerificar.selected = false;
            this.txtVerificar.Size = new System.Drawing.Size(114, 48);
            this.txtVerificar.TabIndex = 13;
            this.txtVerificar.Text = "Verificar";
            this.txtVerificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtVerificar.Textcolor = System.Drawing.Color.White;
            this.txtVerificar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificar.Click += new System.EventHandler(this.txtVerificar_Click);
            // 
            // linkAlterarSenha
            // 
            this.linkAlterarSenha.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkAlterarSenha.AutoSize = true;
            this.linkAlterarSenha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAlterarSenha.LinkColor = System.Drawing.Color.Black;
            this.linkAlterarSenha.Location = new System.Drawing.Point(216, 373);
            this.linkAlterarSenha.Name = "linkAlterarSenha";
            this.linkAlterarSenha.Size = new System.Drawing.Size(123, 16);
            this.linkAlterarSenha.TabIndex = 26;
            this.linkAlterarSenha.TabStop = true;
            this.linkAlterarSenha.Text = "Voltar a tela de Login";
            this.linkAlterarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAlterarSenha_LinkClicked);
            // 
            // FrmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 581);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.Load += new System.EventHandler(this.FrmAlterarSenha_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAlterarSenha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPalavraVerificacao;
        private Bunifu.Framework.UI.BunifuImageButton btnmenu;
        private banco banco;
        private System.Windows.Forms.BindingSource tccUsuariosBindingSource;
        private bancoTableAdapters.tccUsuariosTableAdapter tccUsuariosTableAdapter;
        private bancoTableAdapters.TableAdapterManager tableAdapterManager;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox txtNovaSenha1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private Bunifu.Framework.UI.BunifuFlatButton txtVerificar;
        private System.Windows.Forms.LinkLabel linkAlterarSenha;
    }
}