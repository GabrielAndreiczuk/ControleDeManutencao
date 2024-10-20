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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panDescricao = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panMaquina = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panSetor = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panAbertura = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panSolicitante = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panID = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.panStatus = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panDescricao.SuspendLayout();
            this.panMaquina.SuspendLayout();
            this.panSetor.SuspendLayout();
            this.panAbertura.SuspendLayout();
            this.panSolicitante.SuspendLayout();
            this.panID.SuspendLayout();
            this.panStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.panStatus);
            this.panel3.Controls.Add(this.panDescricao);
            this.panel3.Controls.Add(this.panMaquina);
            this.panel3.Controls.Add(this.panSetor);
            this.panel3.Controls.Add(this.panAbertura);
            this.panel3.Controls.Add(this.panSolicitante);
            this.panel3.Controls.Add(this.panID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 550);
            this.panel3.TabIndex = 0;
            // 
            // panDescricao
            // 
            this.panDescricao.AutoSize = true;
            this.panDescricao.BackColor = System.Drawing.Color.RosyBrown;
            this.panDescricao.Controls.Add(this.label15);
            this.panDescricao.Controls.Add(this.label7);
            this.panDescricao.Dock = System.Windows.Forms.DockStyle.Left;
            this.panDescricao.Location = new System.Drawing.Point(540, 0);
            this.panDescricao.MinimumSize = new System.Drawing.Size(180, 500);
            this.panDescricao.Name = "panDescricao";
            this.panDescricao.Size = new System.Drawing.Size(180, 550);
            this.panDescricao.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(0, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 2);
            this.label15.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(180, 48);
            this.label7.TabIndex = 3;
            this.label7.Text = "Descrição";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panMaquina
            // 
            this.panMaquina.AutoSize = true;
            this.panMaquina.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panMaquina.Controls.Add(this.label13);
            this.panMaquina.Controls.Add(this.label5);
            this.panMaquina.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMaquina.Location = new System.Drawing.Point(420, 0);
            this.panMaquina.MinimumSize = new System.Drawing.Size(120, 500);
            this.panMaquina.Name = "panMaquina";
            this.panMaquina.Size = new System.Drawing.Size(120, 550);
            this.panMaquina.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(0, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 2);
            this.label13.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(120, 48);
            this.label5.TabIndex = 3;
            this.label5.Text = "Máquina";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panSetor
            // 
            this.panSetor.AutoSize = true;
            this.panSetor.BackColor = System.Drawing.Color.RosyBrown;
            this.panSetor.Controls.Add(this.label12);
            this.panSetor.Controls.Add(this.label4);
            this.panSetor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSetor.Location = new System.Drawing.Point(300, 0);
            this.panSetor.MinimumSize = new System.Drawing.Size(120, 500);
            this.panSetor.Name = "panSetor";
            this.panSetor.Size = new System.Drawing.Size(120, 550);
            this.panSetor.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(0, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 2);
            this.label12.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(120, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Setor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panAbertura
            // 
            this.panAbertura.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panAbertura.Controls.Add(this.label11);
            this.panAbertura.Controls.Add(this.label3);
            this.panAbertura.Dock = System.Windows.Forms.DockStyle.Left;
            this.panAbertura.Location = new System.Drawing.Point(200, 0);
            this.panAbertura.MinimumSize = new System.Drawing.Size(100, 500);
            this.panAbertura.Name = "panAbertura";
            this.panAbertura.Size = new System.Drawing.Size(100, 550);
            this.panAbertura.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(0, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 2);
            this.label11.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(100, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "Abertura";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panSolicitante
            // 
            this.panSolicitante.AutoSize = true;
            this.panSolicitante.BackColor = System.Drawing.Color.RosyBrown;
            this.panSolicitante.Controls.Add(this.label10);
            this.panSolicitante.Controls.Add(this.label2);
            this.panSolicitante.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSolicitante.Location = new System.Drawing.Point(100, 0);
            this.panSolicitante.MinimumSize = new System.Drawing.Size(100, 500);
            this.panSolicitante.Name = "panSolicitante";
            this.panSolicitante.Size = new System.Drawing.Size(100, 550);
            this.panSolicitante.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(0, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 2);
            this.label10.TabIndex = 4;
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
            this.label2.TabIndex = 3;
            this.label2.Text = "Solicitante";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panID
            // 
            this.panID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panID.Controls.Add(this.label9);
            this.panID.Controls.Add(this.label1);
            this.panID.Dock = System.Windows.Forms.DockStyle.Left;
            this.panID.Location = new System.Drawing.Point(0, 0);
            this.panID.MinimumSize = new System.Drawing.Size(100, 500);
            this.panID.Name = "panID";
            this.panID.Size = new System.Drawing.Size(100, 550);
            this.panID.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 2);
            this.label9.TabIndex = 2;
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
            this.label1.TabIndex = 1;
            this.label1.Text = "N° Ordem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // panStatus
            // 
            this.panStatus.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panStatus.Controls.Add(this.label6);
            this.panStatus.Controls.Add(this.label8);
            this.panStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.panStatus.Location = new System.Drawing.Point(720, 0);
            this.panStatus.MinimumSize = new System.Drawing.Size(140, 500);
            this.panStatus.Name = "panStatus";
            this.panStatus.Size = new System.Drawing.Size(140, 550);
            this.panStatus.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 2);
            this.label6.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(140, 48);
            this.label8.TabIndex = 5;
            this.label8.Text = "Status";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Location = new System.Drawing.Point(860, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 2);
            this.label14.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.label16.Location = new System.Drawing.Point(860, 0);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(5);
            this.label16.Size = new System.Drawing.Size(140, 48);
            this.label16.TabIndex = 9;
            this.label16.Text = "Ação";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(876, 50);
            this.panel1.MinimumSize = new System.Drawing.Size(106, 700);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 700);
            this.panel1.TabIndex = 11;
            // 
            // TelaOrdensAberto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaOrdensAberto";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panDescricao.ResumeLayout(false);
            this.panMaquina.ResumeLayout(false);
            this.panSetor.ResumeLayout(false);
            this.panAbertura.ResumeLayout(false);
            this.panSolicitante.ResumeLayout(false);
            this.panID.ResumeLayout(false);
            this.panStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Panel panID;
        private System.Windows.Forms.Panel panSolicitante;
        private System.Windows.Forms.Panel panSetor;
        private System.Windows.Forms.Panel panAbertura;
        private System.Windows.Forms.Panel panDescricao;
        private System.Windows.Forms.Panel panMaquina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
    }
}