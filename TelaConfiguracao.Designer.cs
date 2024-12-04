namespace Projeto_TCC
{
    partial class TelaConfiguracao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pibEmail = new System.Windows.Forms.PictureBox();
            this.pibCargp = new System.Windows.Forms.PictureBox();
            this.pibSetor = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new Projeto_TCC.RoundedButton();
            this.roundedButton1 = new Projeto_TCC.RoundedButton();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.roundedLabel2 = new Projeto_TCC.RoundedLabel();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.roundedLabel1 = new Projeto_TCC.RoundedLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pibEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCargp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibSetor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(499, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 550);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gabriel Andreiczuk";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(117, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(246, 19);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "gabriel@gmail.com";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID: 01";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Setor:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cargo: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pibEmail
            // 
            this.pibEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pibEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibEmail.Image = global::Projeto_TCC.Properties.Resources.icone_editar_2;
            this.pibEmail.Location = new System.Drawing.Point(398, 195);
            this.pibEmail.Name = "pibEmail";
            this.pibEmail.Size = new System.Drawing.Size(30, 30);
            this.pibEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibEmail.TabIndex = 11;
            this.pibEmail.TabStop = false;
            this.pibEmail.Click += new System.EventHandler(this.pibEmail_Click);
            // 
            // pibCargp
            // 
            this.pibCargp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pibCargp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibCargp.Image = global::Projeto_TCC.Properties.Resources.icone_editar_2;
            this.pibCargp.Location = new System.Drawing.Point(398, 235);
            this.pibCargp.Name = "pibCargp";
            this.pibCargp.Size = new System.Drawing.Size(30, 30);
            this.pibCargp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibCargp.TabIndex = 12;
            this.pibCargp.TabStop = false;
            // 
            // pibSetor
            // 
            this.pibSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pibSetor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibSetor.Image = global::Projeto_TCC.Properties.Resources.icone_editar_2;
            this.pibSetor.Location = new System.Drawing.Point(398, 275);
            this.pibSetor.Name = "pibSetor";
            this.pibSetor.Size = new System.Drawing.Size(30, 30);
            this.pibSetor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibSetor.TabIndex = 13;
            this.pibSetor.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(100, 450);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(300, 50);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar alterações";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Visible = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(328, 45);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(100, 40);
            this.roundedButton1.TabIndex = 3;
            this.roundedButton1.Text = "Sair";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // cmbSetor
            // 
            this.cmbSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSetor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.cmbSetor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSetor.ForeColor = System.Drawing.Color.White;
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(39, 371);
            this.cmbSetor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(200, 27);
            this.cmbSetor.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(92, 336);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Novo Setor";
            // 
            // roundedLabel2
            // 
            this.roundedLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.roundedLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel2.ForeColor = System.Drawing.Color.White;
            this.roundedLabel2.Location = new System.Drawing.Point(29, 359);
            this.roundedLabel2.Name = "roundedLabel2";
            this.roundedLabel2.Size = new System.Drawing.Size(220, 50);
            this.roundedLabel2.TabIndex = 35;
            this.roundedLabel2.Text = "roundedLabel2";
            // 
            // cmbCargo
            // 
            this.cmbCargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.cmbCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(265, 371);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(200, 27);
            this.cmbCargo.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(315, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 19);
            this.label9.TabIndex = 42;
            this.label9.Text = "Novo Cargo";
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.roundedLabel1.ForeColor = System.Drawing.Color.Black;
            this.roundedLabel1.Location = new System.Drawing.Point(255, 359);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(220, 50);
            this.roundedLabel1.TabIndex = 43;
            // 
            // TelaConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.roundedLabel1);
            this.Controls.Add(this.cmbSetor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.roundedLabel2);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pibSetor);
            this.Controls.Add(this.pibCargp);
            this.Controls.Add(this.pibEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TelaConfiguracao";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pibEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCargp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibSetor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pibEmail;
        private System.Windows.Forms.PictureBox pibCargp;
        private System.Windows.Forms.PictureBox pibSetor;
        private RoundedButton btnConfirmar;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.Label label8;
        private RoundedLabel roundedLabel2;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label label9;
        private RoundedLabel roundedLabel1;
    }
}