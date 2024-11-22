namespace Projeto_TCC
{
    partial class TelaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnOrdensAberto = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnIndicativos = new System.Windows.Forms.Button();
            this.btnOrdem = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pibMinimizar = new System.Windows.Forms.PictureBox();
            this.pibFechar = new System.Windows.Forms.PictureBox();
            this.pibMaximizar = new System.Windows.Forms.PictureBox();
            this.lblTittle = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.lblMaximizar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnOrdensAberto);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.btnHistorico);
            this.panel1.Controls.Add(this.btnIndicativos);
            this.panel1.Controls.Add(this.btnOrdem);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 700);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Projeto_TCC.Properties.Resources.icone_recolher;
            this.pictureBox1.Location = new System.Drawing.Point(20, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(68, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 24);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Nome do Sistema";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrdensAberto
            // 
            this.btnOrdensAberto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnOrdensAberto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdensAberto.FlatAppearance.BorderSize = 0;
            this.btnOrdensAberto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdensAberto.ForeColor = System.Drawing.Color.White;
            this.btnOrdensAberto.Image = global::Projeto_TCC.Properties.Resources.icone_ordens_aberto;
            this.btnOrdensAberto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdensAberto.Location = new System.Drawing.Point(0, 329);
            this.btnOrdensAberto.Name = "btnOrdensAberto";
            this.btnOrdensAberto.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnOrdensAberto.Size = new System.Drawing.Size(300, 75);
            this.btnOrdensAberto.TabIndex = 7;
            this.btnOrdensAberto.Text = "      Ordens em aberto";
            this.btnOrdensAberto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdensAberto.UseVisualStyleBackColor = false;
            this.btnOrdensAberto.Click += new System.EventHandler(this.btnOrdensAberto_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Image = global::Projeto_TCC.Properties.Resources.icone_configuracoes;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 625);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnConfig.Size = new System.Drawing.Size(300, 75);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.Text = "      Configurações";
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Image = global::Projeto_TCC.Properties.Resources.icone_historico_2;
            this.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.Location = new System.Drawing.Point(0, 404);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHistorico.Size = new System.Drawing.Size(300, 75);
            this.btnHistorico.TabIndex = 5;
            this.btnHistorico.Text = "      Consultar Histórico";
            this.btnHistorico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnIndicativos
            // 
            this.btnIndicativos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnIndicativos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIndicativos.FlatAppearance.BorderSize = 0;
            this.btnIndicativos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndicativos.ForeColor = System.Drawing.Color.White;
            this.btnIndicativos.Image = global::Projeto_TCC.Properties.Resources.icone_indicativos_2;
            this.btnIndicativos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIndicativos.Location = new System.Drawing.Point(0, 479);
            this.btnIndicativos.Name = "btnIndicativos";
            this.btnIndicativos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnIndicativos.Size = new System.Drawing.Size(300, 75);
            this.btnIndicativos.TabIndex = 3;
            this.btnIndicativos.Text = "      Consultar Indicativos";
            this.btnIndicativos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIndicativos.UseVisualStyleBackColor = false;
            this.btnIndicativos.Click += new System.EventHandler(this.btnIndicativos_Click);
            // 
            // btnOrdem
            // 
            this.btnOrdem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnOrdem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdem.FlatAppearance.BorderSize = 0;
            this.btnOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdem.ForeColor = System.Drawing.Color.White;
            this.btnOrdem.Image = global::Projeto_TCC.Properties.Resources.icone_serviço;
            this.btnOrdem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdem.Location = new System.Drawing.Point(0, 254);
            this.btnOrdem.Name = "btnOrdem";
            this.btnOrdem.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnOrdem.Size = new System.Drawing.Size(300, 75);
            this.btnOrdem.TabIndex = 4;
            this.btnOrdem.Text = "      Nova Ordem";
            this.btnOrdem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdem.UseVisualStyleBackColor = false;
            this.btnOrdem.Click += new System.EventHandler(this.btnOrdem_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 179);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(300, 75);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "      Menu Inicial";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 120);
            this.label1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.pibMinimizar);
            this.panel2.Controls.Add(this.pibFechar);
            this.panel2.Controls.Add(this.pibMaximizar);
            this.panel2.Controls.Add(this.lblTittle);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.lblMaximizar);
            this.panel2.Controls.Add(this.lblMinimizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 120);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            // 
            // pibMinimizar
            // 
            this.pibMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pibMinimizar.Image")));
            this.pibMinimizar.Location = new System.Drawing.Point(884, 6);
            this.pibMinimizar.Name = "pibMinimizar";
            this.pibMinimizar.Size = new System.Drawing.Size(23, 23);
            this.pibMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibMinimizar.TabIndex = 1;
            this.pibMinimizar.TabStop = false;
            this.pibMinimizar.Click += new System.EventHandler(this.btnMinimize_Click);
            this.pibMinimizar.MouseEnter += new System.EventHandler(this.pibMinimizar_MouseHover);
            this.pibMinimizar.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // pibFechar
            // 
            this.pibFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibFechar.Image = ((System.Drawing.Image)(resources.GetObject("pibFechar.Image")));
            this.pibFechar.Location = new System.Drawing.Point(984, 6);
            this.pibFechar.Name = "pibFechar";
            this.pibFechar.Size = new System.Drawing.Size(23, 23);
            this.pibFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibFechar.TabIndex = 27;
            this.pibFechar.TabStop = false;
            this.pibFechar.Click += new System.EventHandler(this.btnClose_Click);
            this.pibFechar.MouseEnter += new System.EventHandler(this.pibFechar_MouseHover);
            this.pibFechar.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // pibMaximizar
            // 
            this.pibMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pibMaximizar.Image")));
            this.pibMaximizar.Location = new System.Drawing.Point(934, 6);
            this.pibMaximizar.Name = "pibMaximizar";
            this.pibMaximizar.Size = new System.Drawing.Size(23, 23);
            this.pibMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibMaximizar.TabIndex = 0;
            this.pibMaximizar.TabStop = false;
            this.pibMaximizar.Click += new System.EventHandler(this.btnMaximize_Click);
            this.pibMaximizar.MouseEnter += new System.EventHandler(this.pibMaximizar_MouseHover);
            this.pibMaximizar.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTittle.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(260, 35);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(510, 50);
            this.lblTittle.TabIndex = 23;
            this.lblTittle.Text = "Menu Inicial";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.Location = new System.Drawing.Point(970, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(50, 35);
            this.labelClose.TabIndex = 28;
            this.labelClose.MouseEnter += new System.EventHandler(this.pibFechar_MouseHover);
            this.labelClose.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // lblMaximizar
            // 
            this.lblMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaximizar.Location = new System.Drawing.Point(920, 0);
            this.lblMaximizar.Name = "lblMaximizar";
            this.lblMaximizar.Size = new System.Drawing.Size(50, 35);
            this.lblMaximizar.TabIndex = 29;
            this.lblMaximizar.MouseEnter += new System.EventHandler(this.pibMaximizar_MouseHover);
            this.lblMaximizar.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimizar.Location = new System.Drawing.Point(870, 0);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(50, 35);
            this.lblMinimizar.TabIndex = 30;
            this.lblMinimizar.MouseEnter += new System.EventHandler(this.pibMinimizar_MouseHover);
            this.lblMinimizar.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(300, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 580);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(302, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1018, 2);
            this.label3.TabIndex = 4;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(302, 122);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1018, 578);
            this.panelMenu.TabIndex = 5;
            // 
            // TelaMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1320, 700);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnIndicativos;
        private System.Windows.Forms.Button btnOrdem;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnOrdensAberto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pibFechar;
        private System.Windows.Forms.PictureBox pibMaximizar;
        private System.Windows.Forms.PictureBox pibMinimizar;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label lblMaximizar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelMenu;
    }
}