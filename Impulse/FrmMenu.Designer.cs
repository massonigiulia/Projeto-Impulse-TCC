namespace Impulse
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pnlBotoeeSuperior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlGradiente = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPendencias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlDropDownDados = new System.Windows.Forms.Panel();
            this.btnFeiras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProdutos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVendas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRelatorios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBloquear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnmenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlBotoeeSuperior.SuspendLayout();
            this.pnlFundo.SuspendLayout();
            this.pnlGradiente.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDropDownDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoeeSuperior
            // 
            this.pnlBotoeeSuperior.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlBotoeeSuperior.Controls.Add(this.panel1);
            this.pnlBotoeeSuperior.Controls.Add(this.bunifuImageButton2);
            this.pnlBotoeeSuperior.Controls.Add(this.bunifuImageButton1);
            this.pnlBotoeeSuperior.Controls.Add(this.btnmenu);
            this.pnlBotoeeSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoeeSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBotoeeSuperior.Name = "pnlBotoeeSuperior";
            this.pnlBotoeeSuperior.Size = new System.Drawing.Size(945, 34);
            this.pnlBotoeeSuperior.TabIndex = 86;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(200, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 647);
            this.panel1.TabIndex = 88;
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlFundo.Controls.Add(this.pnlGradiente);
            this.pnlFundo.Location = new System.Drawing.Point(0, 33);
            this.pnlFundo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(200, 713);
            this.pnlFundo.TabIndex = 87;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AccessibleName = "pnlPrincipal";
            this.pnlPrincipal.Location = new System.Drawing.Point(203, 39);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(754, 602);
            this.pnlPrincipal.TabIndex = 88;
            this.pnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPrincipal_Paint);
            // 
            // pnlGradiente
            // 
            this.pnlGradiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGradiente.BackgroundImage")));
            this.pnlGradiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGradiente.Controls.Add(this.flowLayoutPanel1);
            this.pnlGradiente.GradientBottomLeft = System.Drawing.Color.LightSeaGreen;
            this.pnlGradiente.GradientBottomRight = System.Drawing.Color.ForestGreen;
            this.pnlGradiente.GradientTopLeft = System.Drawing.Color.Teal;
            this.pnlGradiente.GradientTopRight = System.Drawing.Color.DarkSlateGray;
            this.pnlGradiente.Location = new System.Drawing.Point(0, 0);
            this.pnlGradiente.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGradiente.Name = "pnlGradiente";
            this.pnlGradiente.Quality = 10;
            this.pnlGradiente.Size = new System.Drawing.Size(200, 691);
            this.pnlGradiente.TabIndex = 88;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 691);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.btnPendencias);
            this.flowLayoutPanel2.Controls.Add(this.pnlDropDownDados);
            this.flowLayoutPanel2.Controls.Add(this.btnVendas);
            this.flowLayoutPanel2.Controls.Add(this.btnRelatorios);
            this.flowLayoutPanel2.Controls.Add(this.bunifuFlatButton1);
            this.flowLayoutPanel2.Controls.Add(this.btnBloquear);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(199, 689);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPendencias
            // 
            this.btnPendencias.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPendencias.BackColor = System.Drawing.Color.Transparent;
            this.btnPendencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPendencias.BorderRadius = 0;
            this.btnPendencias.ButtonText = "Pendências";
            this.btnPendencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPendencias.DisabledColor = System.Drawing.Color.Gray;
            this.btnPendencias.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPendencias.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPendencias.Iconimage")));
            this.btnPendencias.Iconimage_right = null;
            this.btnPendencias.Iconimage_right_Selected = null;
            this.btnPendencias.Iconimage_Selected = null;
            this.btnPendencias.IconMarginLeft = 0;
            this.btnPendencias.IconMarginRight = 0;
            this.btnPendencias.IconRightVisible = true;
            this.btnPendencias.IconRightZoom = 0D;
            this.btnPendencias.IconVisible = true;
            this.btnPendencias.IconZoom = 70D;
            this.btnPendencias.IsTab = false;
            this.btnPendencias.Location = new System.Drawing.Point(4, 111);
            this.btnPendencias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPendencias.Name = "btnPendencias";
            this.btnPendencias.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPendencias.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPendencias.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPendencias.selected = false;
            this.btnPendencias.Size = new System.Drawing.Size(186, 48);
            this.btnPendencias.TabIndex = 6;
            this.btnPendencias.Text = "Pendências";
            this.btnPendencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPendencias.Textcolor = System.Drawing.Color.White;
            this.btnPendencias.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendencias.Click += new System.EventHandler(this.BtnPendencias_Click);
            // 
            // pnlDropDownDados
            // 
            this.pnlDropDownDados.Controls.Add(this.btnFeiras);
            this.pnlDropDownDados.Controls.Add(this.btnDados);
            this.pnlDropDownDados.Controls.Add(this.btnClientes);
            this.pnlDropDownDados.Controls.Add(this.btnProdutos);
            this.pnlDropDownDados.Location = new System.Drawing.Point(2, 166);
            this.pnlDropDownDados.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDropDownDados.MaximumSize = new System.Drawing.Size(194, 131);
            this.pnlDropDownDados.MinimumSize = new System.Drawing.Size(194, 56);
            this.pnlDropDownDados.Name = "pnlDropDownDados";
            this.pnlDropDownDados.Size = new System.Drawing.Size(194, 56);
            this.pnlDropDownDados.TabIndex = 7;
            // 
            // btnFeiras
            // 
            this.btnFeiras.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFeiras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFeiras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFeiras.BorderRadius = 0;
            this.btnFeiras.ButtonText = "Feiras";
            this.btnFeiras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeiras.DisabledColor = System.Drawing.Color.Gray;
            this.btnFeiras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFeiras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFeiras.Iconimage")));
            this.btnFeiras.Iconimage_right = null;
            this.btnFeiras.Iconimage_right_Selected = null;
            this.btnFeiras.Iconimage_Selected = null;
            this.btnFeiras.IconMarginLeft = 10;
            this.btnFeiras.IconMarginRight = 0;
            this.btnFeiras.IconRightVisible = true;
            this.btnFeiras.IconRightZoom = 0D;
            this.btnFeiras.IconVisible = true;
            this.btnFeiras.IconZoom = 40D;
            this.btnFeiras.IsTab = false;
            this.btnFeiras.Location = new System.Drawing.Point(0, 103);
            this.btnFeiras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFeiras.Name = "btnFeiras";
            this.btnFeiras.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFeiras.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFeiras.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFeiras.selected = false;
            this.btnFeiras.Size = new System.Drawing.Size(195, 25);
            this.btnFeiras.TabIndex = 6;
            this.btnFeiras.Text = "Feiras";
            this.btnFeiras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFeiras.Textcolor = System.Drawing.Color.White;
            this.btnFeiras.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeiras.Click += new System.EventHandler(this.BtnFeiras_Click);
            // 
            // btnDados
            // 
            this.btnDados.Activecolor = System.Drawing.Color.Transparent;
            this.btnDados.BackColor = System.Drawing.Color.Transparent;
            this.btnDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDados.BorderRadius = 0;
            this.btnDados.ButtonText = "Dados";
            this.btnDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDados.DisabledColor = System.Drawing.Color.Transparent;
            this.btnDados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDados.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDados.Iconimage")));
            this.btnDados.Iconimage_right = null;
            this.btnDados.Iconimage_right_Selected = null;
            this.btnDados.Iconimage_Selected = null;
            this.btnDados.IconMarginLeft = 0;
            this.btnDados.IconMarginRight = 0;
            this.btnDados.IconRightVisible = true;
            this.btnDados.IconRightZoom = 0D;
            this.btnDados.IconVisible = true;
            this.btnDados.IconZoom = 70D;
            this.btnDados.IsTab = false;
            this.btnDados.Location = new System.Drawing.Point(-3, -1);
            this.btnDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDados.Name = "btnDados";
            this.btnDados.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDados.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDados.selected = false;
            this.btnDados.Size = new System.Drawing.Size(195, 48);
            this.btnDados.TabIndex = 3;
            this.btnDados.Text = "Dados";
            this.btnDados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDados.Textcolor = System.Drawing.Color.White;
            this.btnDados.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDados.Click += new System.EventHandler(this.BtnDados_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "Clientes";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage")));
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 12;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 30D;
            this.btnClientes.IsTab = false;
            this.btnClientes.Location = new System.Drawing.Point(1, 56);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(195, 25);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.Textcolor = System.Drawing.Color.White;
            this.btnClientes.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdutos.BorderRadius = 0;
            this.btnProdutos.ButtonText = "Produtos";
            this.btnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdutos.DisabledColor = System.Drawing.Color.Gray;
            this.btnProdutos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProdutos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Iconimage")));
            this.btnProdutos.Iconimage_right = null;
            this.btnProdutos.Iconimage_right_Selected = null;
            this.btnProdutos.Iconimage_Selected = null;
            this.btnProdutos.IconMarginLeft = 10;
            this.btnProdutos.IconMarginRight = 0;
            this.btnProdutos.IconRightVisible = true;
            this.btnProdutos.IconRightZoom = 0D;
            this.btnProdutos.IconVisible = true;
            this.btnProdutos.IconZoom = 40D;
            this.btnProdutos.IsTab = false;
            this.btnProdutos.Location = new System.Drawing.Point(1, 80);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProdutos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnProdutos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProdutos.selected = false;
            this.btnProdutos.Size = new System.Drawing.Size(195, 25);
            this.btnProdutos.TabIndex = 4;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProdutos.Textcolor = System.Drawing.Color.White;
            this.btnProdutos.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnVendas.BackColor = System.Drawing.Color.Transparent;
            this.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVendas.BorderRadius = 0;
            this.btnVendas.ButtonText = "Vendas";
            this.btnVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVendas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVendas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVendas.Iconimage")));
            this.btnVendas.Iconimage_right = null;
            this.btnVendas.Iconimage_right_Selected = null;
            this.btnVendas.Iconimage_Selected = null;
            this.btnVendas.IconMarginLeft = 0;
            this.btnVendas.IconMarginRight = 0;
            this.btnVendas.IconRightVisible = true;
            this.btnVendas.IconRightZoom = 0D;
            this.btnVendas.IconVisible = true;
            this.btnVendas.IconZoom = 70D;
            this.btnVendas.IsTab = true;
            this.btnVendas.Location = new System.Drawing.Point(4, 229);
            this.btnVendas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVendas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnVendas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVendas.selected = false;
            this.btnVendas.Size = new System.Drawing.Size(197, 48);
            this.btnVendas.TabIndex = 14;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVendas.Textcolor = System.Drawing.Color.White;
            this.btnVendas.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.Click += new System.EventHandler(this.BtnVendas_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorios.BorderRadius = 0;
            this.btnRelatorios.ButtonText = "Relatório Pendência";
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.DisabledColor = System.Drawing.Color.Gray;
            this.btnRelatorios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRelatorios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Iconimage")));
            this.btnRelatorios.Iconimage_right = null;
            this.btnRelatorios.Iconimage_right_Selected = null;
            this.btnRelatorios.Iconimage_Selected = null;
            this.btnRelatorios.IconMarginLeft = 0;
            this.btnRelatorios.IconMarginRight = 0;
            this.btnRelatorios.IconRightVisible = true;
            this.btnRelatorios.IconRightZoom = 0D;
            this.btnRelatorios.IconVisible = true;
            this.btnRelatorios.IconZoom = 70D;
            this.btnRelatorios.IsTab = true;
            this.btnRelatorios.Location = new System.Drawing.Point(4, 287);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRelatorios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRelatorios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRelatorios.selected = false;
            this.btnRelatorios.Size = new System.Drawing.Size(197, 48);
            this.btnRelatorios.TabIndex = 15;
            this.btnRelatorios.Text = "Relatório Pendência";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRelatorios.Textcolor = System.Drawing.Color.White;
            this.btnRelatorios.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Backup";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Impulse.Properties.Resources.databackup_theapplication_dedatos_3366;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(4, 345);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(197, 48);
            this.bunifuFlatButton1.TabIndex = 18;
            this.bunifuFlatButton1.Text = "Backup";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // btnBloquear
            // 
            this.btnBloquear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBloquear.BackColor = System.Drawing.Color.Transparent;
            this.btnBloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloquear.BorderRadius = 0;
            this.btnBloquear.ButtonText = "Bloquear Sistema";
            this.btnBloquear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBloquear.DisabledColor = System.Drawing.Color.Gray;
            this.btnBloquear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBloquear.Iconimage = global::Impulse.Properties.Resources.lock_outlined_padlock_symbol_for_security_interface_icon_icons_com_57803;
            this.btnBloquear.Iconimage_right = null;
            this.btnBloquear.Iconimage_right_Selected = null;
            this.btnBloquear.Iconimage_Selected = null;
            this.btnBloquear.IconMarginLeft = 0;
            this.btnBloquear.IconMarginRight = 0;
            this.btnBloquear.IconRightVisible = true;
            this.btnBloquear.IconRightZoom = 0D;
            this.btnBloquear.IconVisible = true;
            this.btnBloquear.IconZoom = 70D;
            this.btnBloquear.IsTab = true;
            this.btnBloquear.Location = new System.Drawing.Point(4, 403);
            this.btnBloquear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBloquear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBloquear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBloquear.selected = false;
            this.btnBloquear.Size = new System.Drawing.Size(197, 48);
            this.btnBloquear.TabIndex = 17;
            this.btnBloquear.Text = "Bloquear Sistema";
            this.btnBloquear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBloquear.Textcolor = System.Drawing.Color.White;
            this.btnBloquear.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloquear.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(831, 9);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(20, 19);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 29;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(865, 9);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 19);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 28;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.Transparent;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.ImageActive = null;
            this.btnmenu.Location = new System.Drawing.Point(899, 9);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(20, 19);
            this.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmenu.TabIndex = 27;
            this.btnmenu.TabStop = false;
            this.btnmenu.Zoom = 10;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 653);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlFundo);
            this.Controls.Add(this.pnlBotoeeSuperior);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.pnlBotoeeSuperior.ResumeLayout(false);
            this.pnlFundo.ResumeLayout(false);
            this.pnlGradiente.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDropDownDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoeeSuperior;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnmenu;
        private System.Windows.Forms.Panel pnlFundo;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlGradiente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPendencias;
        private Bunifu.Framework.UI.BunifuFlatButton btnFeiras;
        private Bunifu.Framework.UI.BunifuFlatButton btnProdutos;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private System.Windows.Forms.Panel pnlDropDownDados;
        private Bunifu.Framework.UI.BunifuFlatButton btnDados;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnVendas;
        private Bunifu.Framework.UI.BunifuFlatButton btnRelatorios;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnBloquear;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}