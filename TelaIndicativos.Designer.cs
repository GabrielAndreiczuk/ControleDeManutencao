namespace Projeto_TCC
{
    partial class TelaIndicativos
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
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.pibFiltrar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedLabel7 = new Projeto_TCC.RoundedLabel();
            this.roundedLabel2 = new Projeto_TCC.RoundedLabel();
            this.roundedLabel1 = new Projeto_TCC.RoundedLabel();
            this.roundedLabel3 = new Projeto_TCC.RoundedLabel();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibFiltrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.pnlFiltros.Controls.Add(this.pibFiltrar);
            this.pnlFiltros.Controls.Add(this.label3);
            this.pnlFiltros.Controls.Add(this.lblLine);
            this.pnlFiltros.Controls.Add(this.label1);
            this.pnlFiltros.Controls.Add(this.cmbMaquina);
            this.pnlFiltros.Controls.Add(this.label6);
            this.pnlFiltros.Controls.Add(this.cmbSetor);
            this.pnlFiltros.Controls.Add(this.dateFinal);
            this.pnlFiltros.Controls.Add(this.dateInicial);
            this.pnlFiltros.Controls.Add(this.label7);
            this.pnlFiltros.Controls.Add(this.label2);
            this.pnlFiltros.Controls.Add(this.roundedLabel7);
            this.pnlFiltros.Controls.Add(this.roundedLabel2);
            this.pnlFiltros.Controls.Add(this.roundedLabel1);
            this.pnlFiltros.Controls.Add(this.roundedLabel3);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1000, 150);
            this.pnlFiltros.TabIndex = 1;
            // 
            // pibFiltrar
            // 
            this.pibFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibFiltrar.Image = global::Projeto_TCC.Properties.Resources.icon_filtrar;
            this.pibFiltrar.Location = new System.Drawing.Point(12, 6);
            this.pibFiltrar.Name = "pibFiltrar";
            this.pibFiltrar.Size = new System.Drawing.Size(35, 35);
            this.pibFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibFiltrar.TabIndex = 38;
            this.pibFiltrar.TabStop = false;
            this.pibFiltrar.Click += new System.EventHandler(this.pibFiltrar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1000, 2);
            this.label3.TabIndex = 37;
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BackColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(0, 48);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(1000, 2);
            this.lblLine.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(770, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Final:";
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMaquina.BackColor = System.Drawing.Color.White;
            this.cmbMaquina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaquina.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.Location = new System.Drawing.Point(290, 98);
            this.cmbMaquina.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(180, 27);
            this.cmbMaquina.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(530, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Início:";
            // 
            // cmbSetor
            // 
            this.cmbSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSetor.BackColor = System.Drawing.Color.White;
            this.cmbSetor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSetor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(50, 99);
            this.cmbSetor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(180, 27);
            this.cmbSetor.TabIndex = 31;
            // 
            // dateFinal
            // 
            this.dateFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateFinal.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dateFinal.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dateFinal.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dateFinal.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinal.Location = new System.Drawing.Point(770, 97);
            this.dateFinal.MaxDate = new System.DateTime(2024, 11, 26, 0, 0, 0, 0);
            this.dateFinal.MinimumSize = new System.Drawing.Size(4, 30);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(180, 30);
            this.dateFinal.TabIndex = 19;
            this.dateFinal.Value = new System.DateTime(2024, 11, 25, 0, 0, 0, 0);
            // 
            // dateInicial
            // 
            this.dateInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateInicial.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dateInicial.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(82)))));
            this.dateInicial.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dateInicial.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dateInicial.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInicial.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dateInicial.Location = new System.Drawing.Point(530, 97);
            this.dateInicial.MaxDate = new System.DateTime(2024, 11, 25, 19, 37, 31, 0);
            this.dateInicial.MinimumSize = new System.Drawing.Size(4, 30);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(180, 30);
            this.dateInicial.TabIndex = 18;
            this.dateInicial.Value = new System.DateTime(2024, 11, 25, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(286, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Máquina";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Setor";
            // 
            // roundedLabel7
            // 
            this.roundedLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel7.BackColor = System.Drawing.Color.White;
            this.roundedLabel7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel7.ForeColor = System.Drawing.Color.White;
            this.roundedLabel7.Location = new System.Drawing.Point(280, 87);
            this.roundedLabel7.Name = "roundedLabel7";
            this.roundedLabel7.Size = new System.Drawing.Size(200, 50);
            this.roundedLabel7.TabIndex = 29;
            this.roundedLabel7.Text = "roundedLabel7";
            // 
            // roundedLabel2
            // 
            this.roundedLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel2.BackColor = System.Drawing.Color.White;
            this.roundedLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel2.ForeColor = System.Drawing.Color.White;
            this.roundedLabel2.Location = new System.Drawing.Point(40, 87);
            this.roundedLabel2.Name = "roundedLabel2";
            this.roundedLabel2.Size = new System.Drawing.Size(200, 50);
            this.roundedLabel2.TabIndex = 32;
            this.roundedLabel2.Text = "roundedLabel2";
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel1.BackColor = System.Drawing.Color.White;
            this.roundedLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel1.ForeColor = System.Drawing.Color.White;
            this.roundedLabel1.Location = new System.Drawing.Point(520, 87);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(200, 50);
            this.roundedLabel1.TabIndex = 33;
            this.roundedLabel1.Text = "roundedLabel1";
            // 
            // roundedLabel3
            // 
            this.roundedLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel3.BackColor = System.Drawing.Color.White;
            this.roundedLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel3.ForeColor = System.Drawing.Color.White;
            this.roundedLabel3.Location = new System.Drawing.Point(760, 87);
            this.roundedLabel3.Name = "roundedLabel3";
            this.roundedLabel3.Size = new System.Drawing.Size(200, 50);
            this.roundedLabel3.TabIndex = 34;
            this.roundedLabel3.Text = "roundedLabel3";
            // 
            // TelaIndicativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlFiltros);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaIndicativos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaIndicativos_Load);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibFiltrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private RoundedLabel roundedLabel7;
        private RoundedLabel roundedLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private RoundedLabel roundedLabel1;
        private RoundedLabel roundedLabel3;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pibFiltrar;
    }
}