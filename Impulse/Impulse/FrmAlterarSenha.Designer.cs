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
            this.txtNovaSenha2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNovaSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.db_05266_14_A_1_2017DataSet = new Impulse.db_05266_14_A_1_2017DataSet();
            this.tccUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccUsuariosTableAdapter = new Impulse.db_05266_14_A_1_2017DataSetTableAdapters.tccUsuariosTableAdapter();
            this.tableAdapterManager = new Impulse.db_05266_14_A_1_2017DataSetTableAdapters.TableAdapterManager();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_05266_14_A_1_2017DataSet)).BeginInit();
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(894, 467);
            this.bunifuGradientPanel1.TabIndex = 0;
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
            this.bunifuCards1.Controls.Add(this.txtPalavraVerificacao);
            this.bunifuCards1.Controls.Add(this.btnAlterarSenha);
            this.bunifuCards1.Controls.Add(this.txtNovaSenha2);
            this.bunifuCards1.Controls.Add(this.txtNovaSenha);
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
            this.btnAlterarSenha.Location = new System.Drawing.Point(117, 332);
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
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // txtNovaSenha2
            // 
            this.txtNovaSenha2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNovaSenha2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNovaSenha2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNovaSenha2.HintForeColor = System.Drawing.Color.Empty;
            this.txtNovaSenha2.HintText = "Confirme sua senha";
            this.txtNovaSenha2.isPassword = true;
            this.txtNovaSenha2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNovaSenha2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNovaSenha2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNovaSenha2.LineThickness = 3;
            this.txtNovaSenha2.Location = new System.Drawing.Point(26, 266);
            this.txtNovaSenha2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNovaSenha2.Name = "txtNovaSenha2";
            this.txtNovaSenha2.Size = new System.Drawing.Size(302, 44);
            this.txtNovaSenha2.TabIndex = 6;
            this.txtNovaSenha2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNovaSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNovaSenha.HintForeColor = System.Drawing.Color.Empty;
            this.txtNovaSenha.HintText = "Digite a nova senha";
            this.txtNovaSenha.isPassword = true;
            this.txtNovaSenha.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNovaSenha.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNovaSenha.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNovaSenha.LineThickness = 3;
            this.txtNovaSenha.Location = new System.Drawing.Point(26, 214);
            this.txtNovaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(302, 44);
            this.txtNovaSenha.TabIndex = 5;
            this.txtNovaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // db_05266_14_A_1_2017DataSet
            // 
            this.db_05266_14_A_1_2017DataSet.DataSetName = "db_05266_14_A_1_2017DataSet";
            this.db_05266_14_A_1_2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tccUsuariosBindingSource
            // 
            this.tccUsuariosBindingSource.DataMember = "tccUsuarios";
            this.tccUsuariosBindingSource.DataSource = this.db_05266_14_A_1_2017DataSet;
            // 
            // tccUsuariosTableAdapter
            // 
            this.tccUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tccClienteTableAdapter = null;
            this.tableAdapterManager.tccCompraTableAdapter = null;
            this.tableAdapterManager.tccFeiraTableAdapter = null;
            this.tableAdapterManager.tccFornecedorTableAdapter = null;
            this.tableAdapterManager.tccPendenciasTableAdapter = null;
            this.tableAdapterManager.tccProdutoTableAdapter = null;
            this.tableAdapterManager.tccUsuariosTableAdapter = this.tccUsuariosTableAdapter;
            this.tableAdapterManager.tccVendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Impulse.db_05266_14_A_1_2017DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 467);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlterarSenha";
            this.Load += new System.EventHandler(this.FrmAlterarSenha_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_05266_14_A_1_2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNovaSenha2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNovaSenha;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAlterarSenha;
        private db_05266_14_A_1_2017DataSet db_05266_14_A_1_2017DataSet;
        private System.Windows.Forms.BindingSource tccUsuariosBindingSource;
        private db_05266_14_A_1_2017DataSetTableAdapters.tccUsuariosTableAdapter tccUsuariosTableAdapter;
        private db_05266_14_A_1_2017DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPalavraVerificacao;
        private Bunifu.Framework.UI.BunifuImageButton btnmenu;
    }
}