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
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnIndicativos = new System.Windows.Forms.Button();
            this.btnOrdem = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTittle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.btnHistorico);
            this.panel1.Controls.Add(this.btnIndicativos);
            this.panel1.Controls.Add(this.btnOrdem);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 686);
            this.panel1.TabIndex = 0;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Image = global::Projeto_TCC.Properties.Resources.icone_configuracoes;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 611);
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
            this.btnHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Image = global::Projeto_TCC.Properties.Resources.icone_historico_2;
            this.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.Location = new System.Drawing.Point(0, 416);
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
            this.btnIndicativos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnIndicativos.FlatAppearance.BorderSize = 0;
            this.btnIndicativos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndicativos.ForeColor = System.Drawing.Color.White;
            this.btnIndicativos.Image = global::Projeto_TCC.Properties.Resources.icone_indicativos_2;
            this.btnIndicativos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIndicativos.Location = new System.Drawing.Point(0, 341);
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
            this.btnOrdem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnOrdem.FlatAppearance.BorderSize = 0;
            this.btnOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdem.ForeColor = System.Drawing.Color.White;
            this.btnOrdem.Image = global::Projeto_TCC.Properties.Resources.icone_serviço;
            this.btnOrdem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdem.Location = new System.Drawing.Point(0, 266);
            this.btnOrdem.Name = "btnOrdem";
            this.btnOrdem.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnOrdem.Size = new System.Drawing.Size(300, 75);
            this.btnOrdem.TabIndex = 4;
            this.btnOrdem.Text = "      Abrir Ordem de Serviço";
            this.btnOrdem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdem.UseVisualStyleBackColor = false;
            this.btnOrdem.Click += new System.EventHandler(this.btnOrdem_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 191);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(300, 75);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "      Menu Inicial";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 120);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome do Sistema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.lblTittle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 120);
            this.panel2.TabIndex = 1;
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTittle.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(260, 30);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(500, 60);
            this.lblTittle.TabIndex = 23;
            this.lblTittle.Text = "Menu Inicial";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(300, 120);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1020, 566);
            this.panelMenu.TabIndex = 2;
            // 
            // TelaMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1320, 686);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnIndicativos;
        private System.Windows.Forms.Button btnOrdem;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Panel panelMenu;
    }
}