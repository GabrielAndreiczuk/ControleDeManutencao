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
            this.rjButton1 = new Projeto_TCC.RoundedButton();
            this.rjLabel1 = new Projeto_TCC.RoundedLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.roundedLabel1 = new Projeto_TCC.RoundedLabel();
            this.SuspendLayout();
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(250, 488);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(300, 50);
            this.rjButton1.TabIndex = 24;
            this.rjButton1.Text = "Cadastrar-se";
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjLabel1
            // 
            this.rjLabel1.BackColor = System.Drawing.Color.White;
            this.rjLabel1.ForeColor = System.Drawing.Color.Black;
            this.rjLabel1.Location = new System.Drawing.Point(250, 388);
            this.rjLabel1.Name = "rjLabel1";
            this.rjLabel1.Size = new System.Drawing.Size(300, 50);
            this.rjLabel1.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(260, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 27);
            this.comboBox1.TabIndex = 26;
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.BackColor = System.Drawing.Color.Black;
            this.roundedLabel1.ForeColor = System.Drawing.Color.White;
            this.roundedLabel1.Location = new System.Drawing.Point(250, 133);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(300, 50);
            this.roundedLabel1.TabIndex = 27;
            this.roundedLabel1.Text = "roundedLabel1";
            // 
            // TelaCadastroComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.roundedLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rjLabel1);
            this.Controls.Add(this.rjButton1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "TelaCadastroComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton rjButton1;
        private RoundedLabel rjLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private RoundedLabel roundedLabel1;
    }
}