namespace Impulse
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.rbBackup = new System.Windows.Forms.RadioButton();
            this.rbRestaurar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLocalArquivo = new System.Windows.Forms.TextBox();
            this.btnBackupRestore = new System.Windows.Forms.Button();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbBackup
            // 
            this.rbBackup.AutoSize = true;
            this.rbBackup.Checked = true;
            this.rbBackup.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBackup.Location = new System.Drawing.Point(23, 69);
            this.rbBackup.Name = "rbBackup";
            this.rbBackup.Size = new System.Drawing.Size(146, 26);
            this.rbBackup.TabIndex = 0;
            this.rbBackup.TabStop = true;
            this.rbBackup.Text = "Gerar Backup";
            this.rbBackup.UseVisualStyleBackColor = true;
            this.rbBackup.CheckedChanged += new System.EventHandler(this.rbBackup_CheckedChanged);
            // 
            // rbRestaurar
            // 
            this.rbRestaurar.AutoSize = true;
            this.rbRestaurar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRestaurar.Location = new System.Drawing.Point(196, 69);
            this.rbRestaurar.Name = "rbRestaurar";
            this.rbRestaurar.Size = new System.Drawing.Size(180, 26);
            this.rbRestaurar.TabIndex = 1;
            this.rbRestaurar.Text = "Restaurar Sistema";
            this.rbRestaurar.UseVisualStyleBackColor = true;
            this.rbRestaurar.CheckedChanged += new System.EventHandler(this.rbRestaurar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRestaurar);
            this.groupBox1.Controls.Add(this.rbBackup);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha uma opção";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtLocalArquivo
            // 
            this.txtLocalArquivo.Enabled = false;
            this.txtLocalArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalArquivo.Location = new System.Drawing.Point(12, 173);
            this.txtLocalArquivo.Name = "txtLocalArquivo";
            this.txtLocalArquivo.Size = new System.Drawing.Size(338, 20);
            this.txtLocalArquivo.TabIndex = 3;
            this.txtLocalArquivo.TextChanged += new System.EventHandler(this.txtLocalArquivo_TextChanged);
            // 
            // btnBackupRestore
            // 
            this.btnBackupRestore.Image = global::Impulse.Properties.Resources.Database_Backup_icon__1_;
            this.btnBackupRestore.Location = new System.Drawing.Point(12, 199);
            this.btnBackupRestore.Name = "btnBackupRestore";
            this.btnBackupRestore.Size = new System.Drawing.Size(338, 43);
            this.btnBackupRestore.TabIndex = 5;
            this.btnBackupRestore.UseVisualStyleBackColor = true;
            this.btnBackupRestore.Click += new System.EventHandler(this.btnBackupRestore_Click);
            // 
            // btnArquivo
            // 
            this.btnArquivo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btnArquivo.Image")));
            this.btnArquivo.Location = new System.Drawing.Point(356, 176);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(75, 54);
            this.btnArquivo.TabIndex = 4;
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 242);
            this.Controls.Add(this.btnBackupRestore);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.txtLocalArquivo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Segurança";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBackup;
        private System.Windows.Forms.RadioButton rbRestaurar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLocalArquivo;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Button btnBackupRestore;
    }
}