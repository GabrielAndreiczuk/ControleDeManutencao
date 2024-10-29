namespace Projeto_TCC
{
    partial class TelaOrdensAberto
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
            this.panMenu = new System.Windows.Forms.Panel();
            this.panDescricao = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panMaquina = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panSetor = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panSolicitante = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panAbertura = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panID = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panStatus = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panBotoes = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.label6 = new System.Windows.Forms.Label();
            this.panMenu.SuspendLayout();
            this.panDescricao.SuspendLayout();
            this.panMaquina.SuspendLayout();
            this.panSetor.SuspendLayout();
            this.panSolicitante.SuspendLayout();
            this.panAbertura.SuspendLayout();
            this.panID.SuspendLayout();
            this.panStatus.SuspendLayout();
            this.panBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.AutoScroll = true;
            this.panMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panMenu.Controls.Add(this.panDescricao);
            this.panMenu.Controls.Add(this.panMaquina);
            this.panMenu.Controls.Add(this.panSetor);
            this.panMenu.Controls.Add(this.panSolicitante);
            this.panMenu.Controls.Add(this.panAbertura);
            this.panMenu.Controls.Add(this.panID);
            this.panMenu.Controls.Add(this.panStatus);
            this.panMenu.Controls.Add(this.panBotoes);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(1000, 550);
            this.panMenu.TabIndex = 0;
            // 
            // panDescricao
            // 
            this.panDescricao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panDescricao.Controls.Add(this.label6);
            this.panDescricao.Controls.Add(this.label7);
            this.panDescricao.Controls.Add(this.label15);
            this.panDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDescricao.Location = new System.Drawing.Point(560, 0);
            this.panDescricao.MinimumSize = new System.Drawing.Size(100, 550);
            this.panDescricao.Name = "panDescricao";
            this.panDescricao.Size = new System.Drawing.Size(190, 550);
            this.panDescricao.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 2);
            this.label7.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(5);
            this.label15.Size = new System.Drawing.Size(190, 48);
            this.label15.TabIndex = 5;
            this.label15.Text = "Descrição";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panMaquina
            // 
            this.panMaquina.AutoSize = true;
            this.panMaquina.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panMaquina.Controls.Add(this.label5);
            this.panMaquina.Controls.Add(this.label13);
            this.panMaquina.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMaquina.Location = new System.Drawing.Point(440, 0);
            this.panMaquina.MaximumSize = new System.Drawing.Size(200, 0);
            this.panMaquina.MinimumSize = new System.Drawing.Size(120, 550);
            this.panMaquina.Name = "panMaquina";
            this.panMaquina.Size = new System.Drawing.Size(120, 550);
            this.panMaquina.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 2);
            this.label5.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(5);
            this.label13.Size = new System.Drawing.Size(120, 48);
            this.label13.TabIndex = 5;
            this.label13.Text = "Máquina";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panSetor
            // 
            this.panSetor.AutoSize = true;
            this.panSetor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panSetor.Controls.Add(this.label4);
            this.panSetor.Controls.Add(this.label12);
            this.panSetor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSetor.Location = new System.Drawing.Point(320, 0);
            this.panSetor.MaximumSize = new System.Drawing.Size(200, 0);
            this.panSetor.MinimumSize = new System.Drawing.Size(120, 550);
            this.panSetor.Name = "panSetor";
            this.panSetor.Size = new System.Drawing.Size(120, 550);
            this.panSetor.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 2);
            this.label4.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5);
            this.label12.Size = new System.Drawing.Size(120, 48);
            this.label12.TabIndex = 5;
            this.label12.Text = "Setor";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panSolicitante
            // 
            this.panSolicitante.AutoSize = true;
            this.panSolicitante.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panSolicitante.Controls.Add(this.label3);
            this.panSolicitante.Controls.Add(this.label11);
            this.panSolicitante.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSolicitante.Location = new System.Drawing.Point(200, 0);
            this.panSolicitante.MaximumSize = new System.Drawing.Size(200, 0);
            this.panSolicitante.MinimumSize = new System.Drawing.Size(120, 550);
            this.panSolicitante.Name = "panSolicitante";
            this.panSolicitante.Size = new System.Drawing.Size(120, 550);
            this.panSolicitante.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 2);
            this.label3.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5);
            this.label11.Size = new System.Drawing.Size(120, 48);
            this.label11.TabIndex = 7;
            this.label11.Text = "Solicitante";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panAbertura
            // 
            this.panAbertura.Controls.Add(this.label10);
            this.panAbertura.Controls.Add(this.label2);
            this.panAbertura.Dock = System.Windows.Forms.DockStyle.Left;
            this.panAbertura.Location = new System.Drawing.Point(100, 0);
            this.panAbertura.MaximumSize = new System.Drawing.Size(100, 0);
            this.panAbertura.MinimumSize = new System.Drawing.Size(100, 550);
            this.panAbertura.Name = "panAbertura";
            this.panAbertura.Size = new System.Drawing.Size(100, 550);
            this.panAbertura.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(0, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 2);
            this.label10.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(100, 48);
            this.label2.TabIndex = 16;
            this.label2.Text = "Abertura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panID
            // 
            this.panID.Controls.Add(this.label9);
            this.panID.Controls.Add(this.label1);
            this.panID.Dock = System.Windows.Forms.DockStyle.Left;
            this.panID.Location = new System.Drawing.Point(0, 0);
            this.panID.MaximumSize = new System.Drawing.Size(100, 0);
            this.panID.MinimumSize = new System.Drawing.Size(100, 550);
            this.panID.Name = "panID";
            this.panID.Size = new System.Drawing.Size(100, 550);
            this.panID.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 2);
            this.label9.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(100, 48);
            this.label1.TabIndex = 14;
            this.label1.Text = "N° Ordem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panStatus
            // 
            this.panStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panStatus.Controls.Add(this.label17);
            this.panStatus.Controls.Add(this.label18);
            this.panStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.panStatus.Location = new System.Drawing.Point(750, 0);
            this.panStatus.MaximumSize = new System.Drawing.Size(140, 0);
            this.panStatus.MinimumSize = new System.Drawing.Size(140, 550);
            this.panStatus.Name = "panStatus";
            this.panStatus.Size = new System.Drawing.Size(140, 550);
            this.panStatus.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Location = new System.Drawing.Point(0, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 2);
            this.label17.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(5);
            this.label18.Size = new System.Drawing.Size(140, 48);
            this.label18.TabIndex = 7;
            this.label18.Text = "Status";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panBotoes
            // 
            this.panBotoes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panBotoes.Controls.Add(this.label14);
            this.panBotoes.Controls.Add(this.label16);
            this.panBotoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.panBotoes.Location = new System.Drawing.Point(890, 0);
            this.panBotoes.MaximumSize = new System.Drawing.Size(110, 0);
            this.panBotoes.MinimumSize = new System.Drawing.Size(110, 550);
            this.panBotoes.Name = "panBotoes";
            this.panBotoes.Size = new System.Drawing.Size(110, 550);
            this.panBotoes.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Location = new System.Drawing.Point(0, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 2);
            this.label14.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(5);
            this.label16.Size = new System.Drawing.Size(110, 48);
            this.label16.TabIndex = 11;
            this.label16.Text = "Ação";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // TelaOrdensAberto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panMenu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaOrdensAberto";
            this.Text = "Form1";
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.panDescricao.ResumeLayout(false);
            this.panMaquina.ResumeLayout(false);
            this.panSetor.ResumeLayout(false);
            this.panSolicitante.ResumeLayout(false);
            this.panAbertura.ResumeLayout(false);
            this.panID.ResumeLayout(false);
            this.panStatus.ResumeLayout(false);
            this.panBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panMenu;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Panel panBotoes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panStatus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panAbertura;
        private System.Windows.Forms.Panel panID;
        private System.Windows.Forms.Panel panSolicitante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panMaquina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panSetor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
    }
}