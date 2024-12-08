namespace Projeto_TCC
{
    partial class TelaCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenhaConfirm = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.roundedButton1 = new Projeto_TCC.RoundedButton();
            this.rjPanel21 = new Projeto_TCC.RoundedLeftPanel();
            this.rjPanel1 = new Projeto_TCC.RoundedRightPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.linePanel2 = new Projeto_TCC.LinePanel();
            this.linePanel1 = new Projeto_TCC.LinePanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjLabel1 = new Projeto_TCC.RoundedLabel();
            this.rjLabel2 = new Projeto_TCC.RoundedLabel();
            this.rjLabel3 = new Projeto_TCC.RoundedLabel();
            this.rjLabel4 = new Projeto_TCC.RoundedLabel();
            this.btnCadastrar = new Projeto_TCC.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtNome.Location = new System.Drawing.Point(613, 170);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(306, 19);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validacaoNome);
            // 
            // txtSenhaConfirm
            // 
            this.txtSenhaConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaConfirm.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtSenhaConfirm.Location = new System.Drawing.Point(611, 409);
            this.txtSenhaConfirm.Name = "txtSenhaConfirm";
            this.txtSenhaConfirm.PasswordChar = '●';
            this.txtSenhaConfirm.Size = new System.Drawing.Size(306, 23);
            this.txtSenhaConfirm.TabIndex = 4;
            this.txtSenhaConfirm.TextChanged += new System.EventHandler(this.checkPassword);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtSenha.Location = new System.Drawing.Point(613, 328);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(306, 23);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextChanged += new System.EventHandler(this.checkPassword);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtEmail.Location = new System.Drawing.Point(613, 249);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(306, 19);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validacaoEmail);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Projeto_TCC.Properties.Resources.user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(586, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Projeto_TCC.Properties.Resources.email_icon;
            this.pictureBox2.Location = new System.Drawing.Point(586, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Projeto_TCC.Properties.Resources.password_icon;
            this.pictureBox3.Location = new System.Drawing.Point(586, 329);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 61;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::Projeto_TCC.Properties.Resources.password_icon;
            this.pictureBox4.Location = new System.Drawing.Point(586, 409);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 62;
            this.pictureBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(550, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(400, 40);
            this.label10.TabIndex = 63;
            this.label10.Text = "Insiria suas informações abaixo e crie uma conta";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.roundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(575, 503);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(350, 50);
            this.roundedButton1.TabIndex = 5;
            this.roundedButton1.Text = "Cadastrar-se";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rjPanel21
            // 
            this.rjPanel21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.rjPanel21.BackgroundImage = global::Projeto_TCC.Properties.Resources.imagem_cadastro;
            this.rjPanel21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rjPanel21.ForeColor = System.Drawing.Color.White;
            this.rjPanel21.Location = new System.Drawing.Point(0, 0);
            this.rjPanel21.Name = "rjPanel21";
            this.rjPanel21.Size = new System.Drawing.Size(500, 650);
            this.rjPanel21.TabIndex = 101;
            // 
            // rjPanel1
            // 
            this.rjPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.rjPanel1.Controls.Add(this.label1);
            this.rjPanel1.Controls.Add(this.lblLogin);
            this.rjPanel1.Controls.Add(this.lblSenha);
            this.rjPanel1.Controls.Add(this.linePanel2);
            this.rjPanel1.Controls.Add(this.linePanel1);
            this.rjPanel1.Controls.Add(this.label6);
            this.rjPanel1.Controls.Add(this.label5);
            this.rjPanel1.Controls.Add(this.label4);
            this.rjPanel1.Controls.Add(this.label3);
            this.rjPanel1.Controls.Add(this.label2);
            this.rjPanel1.Controls.Add(this.rjLabel1);
            this.rjPanel1.Controls.Add(this.rjLabel2);
            this.rjPanel1.Controls.Add(this.rjLabel3);
            this.rjPanel1.Controls.Add(this.rjLabel4);
            this.rjPanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(500, 0);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(500, 650);
            this.rjPanel1.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(98, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 44);
            this.label1.TabIndex = 21;
            this.label1.Text = "Seja bem vindo!";
            // 
            // lblLogin
            // 
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(200, 610);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(100, 19);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Faça Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            this.lblLogin.MouseEnter += new System.EventHandler(this.lblLogin_MouseEnter);
            this.lblLogin.MouseLeave += new System.EventHandler(this.lblLogin_MouseLeave);
            // 
            // lblSenha
            // 
            this.lblSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Yellow;
            this.lblSenha.Location = new System.Drawing.Point(142, 465);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(217, 16);
            this.lblSenha.TabIndex = 39;
            this.lblSenha.Text = "As senhas não coincidem!";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSenha.Visible = false;
            // 
            // linePanel2
            // 
            this.linePanel2.Location = new System.Drawing.Point(263, 582);
            this.linePanel2.Name = "linePanel2";
            this.linePanel2.Size = new System.Drawing.Size(135, 12);
            this.linePanel2.TabIndex = 38;
            // 
            // linePanel1
            // 
            this.linePanel1.Location = new System.Drawing.Point(103, 582);
            this.linePanel1.Name = "linePanel1";
            this.linePanel1.Size = new System.Drawing.Size(135, 12);
            this.linePanel1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(238, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "OU";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(80, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Confirmar senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome";
            // 
            // rjLabel1
            // 
            this.rjLabel1.BackColor = System.Drawing.Color.White;
            this.rjLabel1.ForeColor = System.Drawing.Color.Black;
            this.rjLabel1.Location = new System.Drawing.Point(75, 154);
            this.rjLabel1.Name = "rjLabel1";
            this.rjLabel1.Size = new System.Drawing.Size(350, 50);
            this.rjLabel1.TabIndex = 33;
            // 
            // rjLabel2
            // 
            this.rjLabel2.BackColor = System.Drawing.Color.White;
            this.rjLabel2.ForeColor = System.Drawing.Color.Black;
            this.rjLabel2.Location = new System.Drawing.Point(75, 234);
            this.rjLabel2.Name = "rjLabel2";
            this.rjLabel2.Size = new System.Drawing.Size(350, 50);
            this.rjLabel2.TabIndex = 34;
            // 
            // rjLabel3
            // 
            this.rjLabel3.BackColor = System.Drawing.Color.White;
            this.rjLabel3.ForeColor = System.Drawing.Color.Black;
            this.rjLabel3.Location = new System.Drawing.Point(75, 314);
            this.rjLabel3.Name = "rjLabel3";
            this.rjLabel3.Size = new System.Drawing.Size(350, 50);
            this.rjLabel3.TabIndex = 35;
            // 
            // rjLabel4
            // 
            this.rjLabel4.BackColor = System.Drawing.Color.White;
            this.rjLabel4.ForeColor = System.Drawing.Color.Black;
            this.rjLabel4.Location = new System.Drawing.Point(75, 394);
            this.rjLabel4.Name = "rjLabel4";
            this.rjLabel4.Size = new System.Drawing.Size(350, 50);
            this.rjLabel4.TabIndex = 36;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(75, 502);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(350, 50);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar-se";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rjPanel21);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtSenhaConfirm);
            this.Controls.Add(this.rjPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedLeftPanel rjPanel21;
        private RoundedRightPanel rjPanel1;
        private System.Windows.Forms.Label lblSenha;
        private LinePanel linePanel2;
        private LinePanel linePanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenhaConfirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RoundedLabel rjLabel1;
        private RoundedLabel rjLabel2;
        private RoundedLabel rjLabel4;
        private RoundedLabel rjLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label10;
        private RoundedButton btnCadastrar;
        private RoundedButton roundedButton1;
    }
}

