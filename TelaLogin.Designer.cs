namespace Projeto_TCC
{
    partial class TelaLogin
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.linePanel3 = new Projeto_TCC.LinePanel();
            this.btnLogin = new Projeto_TCC.RoundedButton();
            this.linePanel4 = new Projeto_TCC.LinePanel();
            this.roundedLabel1 = new Projeto_TCC.RoundedLabel();
            this.roundedLabel2 = new Projeto_TCC.RoundedLabel();
            this.rjPanel21 = new Projeto_TCC.RoundedLeftPanel();
            this.rjLabel2 = new Projeto_TCC.RoundedLabel();
            this.linePanel1 = new Projeto_TCC.LinePanel();
            this.rjButton2 = new Projeto_TCC.RoundedButton();
            this.linePanel2 = new Projeto_TCC.LinePanel();
            this.rjLabel1 = new Projeto_TCC.RoundedLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjPanel1 = new Projeto_TCC.RoundedRightPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.textBox2.Location = new System.Drawing.Point(113, 343);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(306, 19);
            this.textBox2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(189, 576);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "Cadastrar-se";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.lblCadastro_Click);
            this.label7.MouseLeave += new System.EventHandler(this.lblCadastro_MouseLeave);
            this.label7.MouseHover += new System.EventHandler(this.lblCadastro_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(238, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "OU";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(107, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "As senhas não coincidem!";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome do Sistema";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "E-mail";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.textBox1.Location = new System.Drawing.Point(113, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 19);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Senha";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.lblSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Yellow;
            this.lblSenha.Location = new System.Drawing.Point(107, 408);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(287, 16);
            this.lblSenha.TabIndex = 56;
            this.lblSenha.Text = "As senhas não coincidem!";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSenha.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(238, 535);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 52;
            this.label9.Text = "OU";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCadastro
            // 
            this.lblCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.lblCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.White;
            this.lblCadastro.Location = new System.Drawing.Point(189, 569);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(122, 19);
            this.lblCadastro.TabIndex = 53;
            this.lblCadastro.Text = "Cadastre-se";
            this.lblCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCadastro.Click += new System.EventHandler(this.lblCadastro_Click);
            this.lblCadastro.MouseEnter += new System.EventHandler(this.lblCadastro_MouseHover);
            this.lblCadastro.MouseLeave += new System.EventHandler(this.lblCadastro_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(64, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 44);
            this.label2.TabIndex = 57;
            this.label2.Text = "Bem vindo de volta!";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(68, 116);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(372, 45);
            this.label10.TabIndex = 60;
            this.label10.Text = "Insiria suas informações abaixo para fazer login";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linePanel3
            // 
            this.linePanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linePanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.linePanel3.Location = new System.Drawing.Point(262, 541);
            this.linePanel3.Name = "linePanel3";
            this.linePanel3.Size = new System.Drawing.Size(145, 12);
            this.linePanel3.TabIndex = 55;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(75, 461);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(350, 50);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Conectar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linePanel4
            // 
            this.linePanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linePanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.linePanel4.Location = new System.Drawing.Point(92, 541);
            this.linePanel4.Name = "linePanel4";
            this.linePanel4.Size = new System.Drawing.Size(145, 12);
            this.linePanel4.TabIndex = 54;
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel1.BackColor = System.Drawing.Color.White;
            this.roundedLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedLabel1.ForeColor = System.Drawing.Color.White;
            this.roundedLabel1.Location = new System.Drawing.Point(75, 242);
            this.roundedLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(350, 50);
            this.roundedLabel1.TabIndex = 47;
            // 
            // roundedLabel2
            // 
            this.roundedLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedLabel2.BackColor = System.Drawing.Color.White;
            this.roundedLabel2.ForeColor = System.Drawing.Color.Black;
            this.roundedLabel2.Location = new System.Drawing.Point(75, 327);
            this.roundedLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.roundedLabel2.Name = "roundedLabel2";
            this.roundedLabel2.Size = new System.Drawing.Size(350, 50);
            this.roundedLabel2.TabIndex = 48;
            // 
            // rjPanel21
            // 
            this.rjPanel21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.rjPanel21.ForeColor = System.Drawing.Color.White;
            this.rjPanel21.Location = new System.Drawing.Point(0, 0);
            this.rjPanel21.Name = "rjPanel21";
            this.rjPanel21.Size = new System.Drawing.Size(500, 650);
            this.rjPanel21.TabIndex = 10;
            // 
            // rjLabel2
            // 
            this.rjLabel2.BackColor = System.Drawing.Color.White;
            this.rjLabel2.ForeColor = System.Drawing.Color.Black;
            this.rjLabel2.Location = new System.Drawing.Point(75, 334);
            this.rjLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rjLabel2.Name = "rjLabel2";
            this.rjLabel2.Size = new System.Drawing.Size(350, 50);
            this.rjLabel2.TabIndex = 11;
            // 
            // linePanel1
            // 
            this.linePanel1.Location = new System.Drawing.Point(92, 548);
            this.linePanel1.Name = "linePanel1";
            this.linePanel1.Size = new System.Drawing.Size(145, 12);
            this.linePanel1.TabIndex = 42;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.rjButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(75, 468);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(350, 50);
            this.rjButton2.TabIndex = 4;
            this.rjButton2.Text = "Conectar";
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linePanel2
            // 
            this.linePanel2.Location = new System.Drawing.Point(262, 548);
            this.linePanel2.Name = "linePanel2";
            this.linePanel2.Size = new System.Drawing.Size(145, 12);
            this.linePanel2.TabIndex = 43;
            // 
            // rjLabel1
            // 
            this.rjLabel1.BackColor = System.Drawing.Color.White;
            this.rjLabel1.ForeColor = System.Drawing.Color.Black;
            this.rjLabel1.Location = new System.Drawing.Point(75, 249);
            this.rjLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rjLabel1.Name = "rjLabel1";
            this.rjLabel1.Size = new System.Drawing.Size(350, 50);
            this.rjLabel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Projeto_TCC.Properties.Resources.password_icon;
            this.pictureBox2.Location = new System.Drawing.Point(86, 341);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Projeto_TCC.Properties.Resources.user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(87, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // rjPanel1
            // 
            this.rjPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel1.BackColor = System.Drawing.Color.White;
            this.rjPanel1.BackgroundImage = global::Projeto_TCC.Properties.Resources.imagem_tela_login;
            this.rjPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(498, 0);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(500, 650);
            this.rjPanel1.TabIndex = 0;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.linePanel3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linePanel4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.roundedLabel1);
            this.Controls.Add(this.roundedLabel2);
            this.Controls.Add(this.rjPanel21);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedRightPanel rjPanel1;
        private System.Windows.Forms.TextBox textBox2;
        private RoundedLabel rjLabel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private LinePanel linePanel1;
        private RoundedButton rjButton2;
        private LinePanel linePanel2;
        private System.Windows.Forms.Label label8;
        private RoundedLabel rjLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private RoundedLabel roundedLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSenha;
        private LinePanel linePanel3;
        private RoundedButton btnLogin;
        private LinePanel linePanel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCadastro;
        private RoundedLabel roundedLabel2;
        private System.Windows.Forms.Label label2;
        private RoundedLeftPanel rjPanel21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
    }
}