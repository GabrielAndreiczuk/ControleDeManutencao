namespace Projeto_TCC
{
    partial class TelaCadastroComp
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
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedLabel3 = new Projeto_TCC.RoundedLabel();
            this.roundedLabel2 = new Projeto_TCC.RoundedLabel();
            this.btnFinalizar = new Projeto_TCC.RoundedButton();
            this.roundedLabel1 = new Projeto_TCC.RoundedLabel();
            this.roundedRightPanel1 = new Projeto_TCC.RoundedRightPanel();
            this.SuspendLayout();
            // 
            // cmbSetor
            // 
            this.cmbSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSetor.BackColor = System.Drawing.Color.White;
            this.cmbSetor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(63, 217);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(274, 27);
            this.cmbSetor.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Setor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Contato";
            // 
            // txtContato
            // 
            this.txtContato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContato.Location = new System.Drawing.Point(60, 421);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(283, 19);
            this.txtContato.TabIndex = 39;
            this.txtContato.TextChanged += new System.EventHandler(this.ContactFormatting);
            this.txtContato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigit);
            // 
            // cmbCargo
            // 
            this.cmbCargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCargo.BackColor = System.Drawing.Color.White;
            this.cmbCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(63, 317);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(274, 27);
            this.cmbCargo.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 44);
            this.label4.TabIndex = 42;
            this.label4.Text = "Nome do Sistema";
            // 
            // roundedLabel3
            // 
            this.roundedLabel3.BackColor = System.Drawing.Color.White;
            this.roundedLabel3.ForeColor = System.Drawing.Color.Black;
            this.roundedLabel3.Location = new System.Drawing.Point(50, 405);
            this.roundedLabel3.Name = "roundedLabel3";
            this.roundedLabel3.Size = new System.Drawing.Size(300, 50);
            this.roundedLabel3.TabIndex = 40;
            // 
            // roundedLabel2
            // 
            this.roundedLabel2.BackColor = System.Drawing.Color.White;
            this.roundedLabel2.ForeColor = System.Drawing.Color.Black;
            this.roundedLabel2.Location = new System.Drawing.Point(50, 305);
            this.roundedLabel2.Name = "roundedLabel2";
            this.roundedLabel2.Size = new System.Drawing.Size(300, 50);
            this.roundedLabel2.TabIndex = 36;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(50, 525);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(300, 50);
            this.btnFinalizar.TabIndex = 24;
            this.btnFinalizar.Text = "Finalizar Cadastro";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel1.BackColor = System.Drawing.Color.White;
            this.roundedLabel1.ForeColor = System.Drawing.Color.White;
            this.roundedLabel1.Location = new System.Drawing.Point(50, 205);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(300, 50);
            this.roundedLabel1.TabIndex = 27;
            this.roundedLabel1.Text = "roundedLabel1";
            // 
            // roundedRightPanel1
            // 
            this.roundedRightPanel1.BackColor = System.Drawing.Color.Black;
            this.roundedRightPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedRightPanel1.Location = new System.Drawing.Point(400, 0);
            this.roundedRightPanel1.Name = "roundedRightPanel1";
            this.roundedRightPanel1.Size = new System.Drawing.Size(400, 650);
            this.roundedRightPanel1.TabIndex = 43;
            this.roundedRightPanel1.Text = "roundedRightPanel1";
            // 
            // TelaCadastroComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.roundedRightPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.roundedLabel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundedLabel2);
            this.Controls.Add(this.cmbSetor);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.roundedLabel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "TelaCadastroComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton btnFinalizar;
        private System.Windows.Forms.ComboBox cmbSetor;
        private RoundedLabel roundedLabel1;
        private System.Windows.Forms.Label label1;
        private RoundedLabel roundedLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContato;
        private RoundedLabel roundedLabel3;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label label4;
        private RoundedRightPanel roundedRightPanel1;
    }
}