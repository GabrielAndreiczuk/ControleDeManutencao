namespace Projeto_TCC
{
    partial class TelaConclusao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreditiva = new System.Windows.Forms.RadioButton();
            this.btnPreventiva = new System.Windows.Forms.RadioButton();
            this.btnCorretiva = new System.Windows.Forms.RadioButton();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPecas = new System.Windows.Forms.Label();
            this.btnConcluir = new Projeto_TCC.RoundedButton();
            this.btnIncluirPecas = new Projeto_TCC.RoundedButton();
            this.roundedLabel2 = new Projeto_TCC.RoundedLabel();
            this.roundedLabel1 = new Projeto_TCC.RoundedLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnPreditiva);
            this.groupBox1.Controls.Add(this.btnPreventiva);
            this.groupBox1.Controls.Add(this.btnCorretiva);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(50, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo da Manutenção";
            // 
            // btnPreditiva
            // 
            this.btnPreditiva.Location = new System.Drawing.Point(290, 28);
            this.btnPreditiva.Name = "btnPreditiva";
            this.btnPreditiva.Size = new System.Drawing.Size(140, 45);
            this.btnPreditiva.TabIndex = 2;
            this.btnPreditiva.Text = "Preditiva";
            this.btnPreditiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPreditiva.UseVisualStyleBackColor = true;
            // 
            // btnPreventiva
            // 
            this.btnPreventiva.Location = new System.Drawing.Point(145, 28);
            this.btnPreventiva.Name = "btnPreventiva";
            this.btnPreventiva.Size = new System.Drawing.Size(140, 45);
            this.btnPreventiva.TabIndex = 1;
            this.btnPreventiva.Text = "Preventiva";
            this.btnPreventiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPreventiva.UseVisualStyleBackColor = true;
            // 
            // btnCorretiva
            // 
            this.btnCorretiva.Checked = true;
            this.btnCorretiva.Location = new System.Drawing.Point(0, 28);
            this.btnCorretiva.Name = "btnCorretiva";
            this.btnCorretiva.Size = new System.Drawing.Size(140, 45);
            this.btnCorretiva.TabIndex = 0;
            this.btnCorretiva.TabStop = true;
            this.btnCorretiva.Text = "Corretiva";
            this.btnCorretiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCorretiva.UseVisualStyleBackColor = true;
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaracteres.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteres.ForeColor = System.Drawing.Color.White;
            this.lblCaracteres.Location = new System.Drawing.Point(401, 410);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(65, 24);
            this.lblCaracteres.TabIndex = 32;
            this.lblCaracteres.Text = "0/100";
            this.lblCaracteres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Descrição da manutenção";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(65, 263);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(401, 130);
            this.txtDescricao.TabIndex = 29;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(530, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Lista de peças";
            // 
            // lblPecas
            // 
            this.lblPecas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPecas.BackColor = System.Drawing.Color.White;
            this.lblPecas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblPecas.Location = new System.Drawing.Point(534, 263);
            this.lblPecas.Name = "lblPecas";
            this.lblPecas.Size = new System.Drawing.Size(405, 130);
            this.lblPecas.TabIndex = 38;
            this.lblPecas.Text = "Nenhuma peça foi inclusa...";
            // 
            // btnConcluir
            // 
            this.btnConcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcluir.FlatAppearance.BorderSize = 0;
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.ForeColor = System.Drawing.Color.White;
            this.btnConcluir.Location = new System.Drawing.Point(350, 470);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(300, 50);
            this.btnConcluir.TabIndex = 36;
            this.btnConcluir.Text = "Concluir Manutenção";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnIncluirPecas
            // 
            this.btnIncluirPecas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIncluirPecas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnIncluirPecas.FlatAppearance.BorderSize = 0;
            this.btnIncluirPecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirPecas.ForeColor = System.Drawing.Color.White;
            this.btnIncluirPecas.Location = new System.Drawing.Point(520, 131);
            this.btnIncluirPecas.Name = "btnIncluirPecas";
            this.btnIncluirPecas.Size = new System.Drawing.Size(430, 50);
            this.btnIncluirPecas.TabIndex = 35;
            this.btnIncluirPecas.Text = "Incluir Peças";
            this.btnIncluirPecas.UseVisualStyleBackColor = false;
            this.btnIncluirPecas.Click += new System.EventHandler(this.btnIncluirPecas_Click);
            // 
            // roundedLabel2
            // 
            this.roundedLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel2.BackColor = System.Drawing.Color.White;
            this.roundedLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel2.ForeColor = System.Drawing.Color.White;
            this.roundedLabel2.Location = new System.Drawing.Point(520, 248);
            this.roundedLabel2.Name = "roundedLabel2";
            this.roundedLabel2.Size = new System.Drawing.Size(430, 157);
            this.roundedLabel2.TabIndex = 34;
            this.roundedLabel2.Text = "roundedLabel2";
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel1.BackColor = System.Drawing.Color.White;
            this.roundedLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel1.ForeColor = System.Drawing.Color.White;
            this.roundedLabel1.Location = new System.Drawing.Point(50, 248);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(430, 157);
            this.roundedLabel1.TabIndex = 31;
            this.roundedLabel1.Text = "roundedLabel1";
            // 
            // TelaConclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.lblPecas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnIncluirPecas);
            this.Controls.Add(this.roundedLabel2);
            this.Controls.Add(this.lblCaracteres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.roundedLabel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TelaConclusao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnCorretiva;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private RoundedLabel roundedLabel1;
        private System.Windows.Forms.RadioButton btnPreditiva;
        private System.Windows.Forms.RadioButton btnPreventiva;
        private RoundedLabel roundedLabel2;
        private RoundedButton btnIncluirPecas;
        private RoundedButton btnConcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPecas;
    }
}