namespace Projeto_TCC
{
    partial class TelaInclusaoPecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInclusaoPecas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pibMinimizar = new System.Windows.Forms.PictureBox();
            this.pibFechar = new System.Windows.Forms.PictureBox();
            this.pibMaximizar = new System.Windows.Forms.PictureBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.lblMaximizar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new Projeto_TCC.RoundedButton();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.cmbPecas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedLabel2 = new Projeto_TCC.RoundedLabel();
            this.label1 = new Projeto_TCC.RoundedLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.pibMinimizar);
            this.panel1.Controls.Add(this.pibFechar);
            this.panel1.Controls.Add(this.pibMaximizar);
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Controls.Add(this.lblMaximizar);
            this.panel1.Controls.Add(this.lblMinimizar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.numQuantidade);
            this.panel1.Controls.Add(this.lblEstoque);
            this.panel1.Controls.Add(this.cmbPecas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.roundedLabel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 546);
            this.panel1.TabIndex = 0;
            // 
            // pibMinimizar
            // 
            this.pibMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pibMinimizar.Image")));
            this.pibMinimizar.Location = new System.Drawing.Point(258, 8);
            this.pibMinimizar.Name = "pibMinimizar";
            this.pibMinimizar.Size = new System.Drawing.Size(23, 23);
            this.pibMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibMinimizar.TabIndex = 37;
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
            this.pibFechar.Location = new System.Drawing.Point(358, 8);
            this.pibFechar.Name = "pibFechar";
            this.pibFechar.Size = new System.Drawing.Size(23, 23);
            this.pibFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibFechar.TabIndex = 38;
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
            this.pibMaximizar.Location = new System.Drawing.Point(308, 8);
            this.pibMaximizar.Name = "pibMaximizar";
            this.pibMaximizar.Size = new System.Drawing.Size(23, 23);
            this.pibMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibMaximizar.TabIndex = 36;
            this.pibMaximizar.TabStop = false;
            this.pibMaximizar.Click += new System.EventHandler(this.btnMaximize_Click);
            this.pibMaximizar.MouseEnter += new System.EventHandler(this.pibMaximizar_MouseHover);
            this.pibMaximizar.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.Location = new System.Drawing.Point(344, 2);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(50, 35);
            this.labelClose.TabIndex = 39;
            this.labelClose.Click += new System.EventHandler(this.btnClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.pibFechar_MouseHover);
            this.labelClose.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // lblMaximizar
            // 
            this.lblMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaximizar.Location = new System.Drawing.Point(294, 2);
            this.lblMaximizar.Name = "lblMaximizar";
            this.lblMaximizar.Size = new System.Drawing.Size(50, 35);
            this.lblMaximizar.TabIndex = 40;
            this.lblMaximizar.Click += new System.EventHandler(this.btnMaximize_Click);
            this.lblMaximizar.MouseEnter += new System.EventHandler(this.pibMaximizar_MouseHover);
            this.lblMaximizar.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimizar.Location = new System.Drawing.Point(244, 2);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(50, 35);
            this.lblMinimizar.TabIndex = 41;
            this.lblMinimizar.Click += new System.EventHandler(this.btnMinimize_Click);
            this.lblMinimizar.MouseEnter += new System.EventHandler(this.pibMinimizar_MouseHover);
            this.lblMinimizar.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(109, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Incluir Peças";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Quantidade";
            this.label3.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(25, 450);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(350, 50);
            this.btnRegistrar.TabIndex = 33;
            this.btnRegistrar.Text = "Registrar peças";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // numQuantidade
            // 
            this.numQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numQuantidade.Location = new System.Drawing.Point(44, 363);
            this.numQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(315, 22);
            this.numQuantidade.TabIndex = 31;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.Visible = false;
            // 
            // lblEstoque
            // 
            this.lblEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstoque.ForeColor = System.Drawing.Color.White;
            this.lblEstoque.Location = new System.Drawing.Point(26, 262);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(350, 50);
            this.lblEstoque.TabIndex = 30;
            this.lblEstoque.Text = "10 Unidades em estoque.";
            this.lblEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstoque.Visible = false;
            // 
            // cmbPecas
            // 
            this.cmbPecas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPecas.BackColor = System.Drawing.Color.White;
            this.cmbPecas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPecas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPecas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPecas.FormattingEnabled = true;
            this.cmbPecas.Location = new System.Drawing.Point(44, 210);
            this.cmbPecas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPecas.Name = "cmbPecas";
            this.cmbPecas.Size = new System.Drawing.Size(315, 27);
            this.cmbPecas.TabIndex = 28;
            this.cmbPecas.SelectedIndexChanged += new System.EventHandler(this.cmbPecas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Peças";
            // 
            // roundedLabel2
            // 
            this.roundedLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel2.BackColor = System.Drawing.Color.White;
            this.roundedLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel2.ForeColor = System.Drawing.Color.White;
            this.roundedLabel2.Location = new System.Drawing.Point(26, 198);
            this.roundedLabel2.Name = "roundedLabel2";
            this.roundedLabel2.Size = new System.Drawing.Size(350, 50);
            this.roundedLabel2.TabIndex = 29;
            this.roundedLabel2.Text = "roundedLabel2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 50);
            this.label1.TabIndex = 32;
            this.label1.Text = "roundedLabel1";
            this.label1.Visible = false;
            // 
            // TelaInclusaoPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TelaInclusaoPecas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.ComboBox cmbPecas;
        private System.Windows.Forms.Label label2;
        private RoundedLabel roundedLabel2;
        private RoundedButton btnRegistrar;
        private RoundedLabel label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pibMinimizar;
        private System.Windows.Forms.PictureBox pibFechar;
        private System.Windows.Forms.PictureBox pibMaximizar;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label lblMaximizar;
        private System.Windows.Forms.Label lblMinimizar;
    }
}