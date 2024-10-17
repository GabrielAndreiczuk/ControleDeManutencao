namespace Projeto_TCC
{
    partial class TelaOrdem
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedButton1 = new Projeto_TCC.RoundedButton();
            this.roundedLabel2 = new Projeto_TCC.RoundedLabel();
            this.roundedLabel1 = new Projeto_TCC.RoundedLabel();
            this.roundedLabel7 = new Projeto_TCC.RoundedLabel();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(300, 294);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(401, 98);
            this.txtDescricao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(296, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição do problema";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label7.Location = new System.Drawing.Point(296, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Máquina";
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMaquina.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbMaquina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaquina.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.Location = new System.Drawing.Point(300, 186);
            this.cmbMaquina.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(403, 27);
            this.cmbMaquina.TabIndex = 13;
            // 
            // cmbSetor
            // 
            this.cmbSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSetor.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbSetor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSetor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(300, 92);
            this.cmbSetor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(403, 27);
            this.cmbSetor.TabIndex = 25;
            this.cmbSetor.SelectedIndexChanged += new System.EventHandler(this.cmbSetor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(296, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Setor";
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(350, 444);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(300, 50);
            this.roundedButton1.TabIndex = 27;
            this.roundedButton1.Text = "Registrar Ordem";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // roundedLabel2
            // 
            this.roundedLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.roundedLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel2.ForeColor = System.Drawing.Color.White;
            this.roundedLabel2.Location = new System.Drawing.Point(285, 80);
            this.roundedLabel2.Name = "roundedLabel2";
            this.roundedLabel2.Size = new System.Drawing.Size(430, 50);
            this.roundedLabel2.TabIndex = 26;
            this.roundedLabel2.Text = "roundedLabel2";
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.roundedLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel1.ForeColor = System.Drawing.Color.White;
            this.roundedLabel1.Location = new System.Drawing.Point(285, 279);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(430, 126);
            this.roundedLabel1.TabIndex = 14;
            this.roundedLabel1.Text = "roundedLabel1";
            // 
            // roundedLabel7
            // 
            this.roundedLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel7.BackColor = System.Drawing.Color.Gainsboro;
            this.roundedLabel7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel7.ForeColor = System.Drawing.Color.White;
            this.roundedLabel7.Location = new System.Drawing.Point(285, 175);
            this.roundedLabel7.Name = "roundedLabel7";
            this.roundedLabel7.Size = new System.Drawing.Size(430, 50);
            this.roundedLabel7.TabIndex = 23;
            this.roundedLabel7.Text = "roundedLabel7";
            // 
            // TelaOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.cmbSetor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roundedLabel2);
            this.Controls.Add(this.cmbMaquina);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.roundedLabel1);
            this.Controls.Add(this.roundedLabel7);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaOrdem";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private RoundedLabel roundedLabel1;
        private RoundedLabel roundedLabel7;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.Label label2;
        private RoundedLabel roundedLabel2;
        private RoundedButton roundedButton1;
    }
}