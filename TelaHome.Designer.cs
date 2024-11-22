namespace Projeto_TCC
{
    partial class TelaHome
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedPanel6 = new Projeto_TCC.RoundedPanel();
            this.roundedPanel5 = new Projeto_TCC.RoundedPanel();
            this.roundedPanel4 = new Projeto_TCC.RoundedPanel();
            this.roundedPanel2 = new Projeto_TCC.RoundedPanel();
            this.roundedPanel1 = new Projeto_TCC.RoundedPanel();
            this.roundedPanel3 = new Projeto_TCC.RoundedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(52, 33);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(404, 240);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(553, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordens em aberto";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(799, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ordens concluídas";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(550, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 100);
            this.label3.TabIndex = 7;
            this.label3.Text = "10";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(800, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 100);
            this.label4.TabIndex = 8;
            this.label4.Text = "6";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel6.BackColor = System.Drawing.Color.White;
            this.roundedPanel6.ForeColor = System.Drawing.Color.White;
            this.roundedPanel6.Location = new System.Drawing.Point(525, 357);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(450, 161);
            this.roundedPanel6.TabIndex = 10;
            this.roundedPanel6.Text = "roundedPanel6";
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel5.BackColor = System.Drawing.Color.White;
            this.roundedPanel5.ForeColor = System.Drawing.Color.White;
            this.roundedPanel5.Location = new System.Drawing.Point(25, 357);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(450, 161);
            this.roundedPanel5.TabIndex = 9;
            this.roundedPanel5.Text = "roundedPanel5";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel4.BackColor = System.Drawing.Color.White;
            this.roundedPanel4.ForeColor = System.Drawing.Color.White;
            this.roundedPanel4.Location = new System.Drawing.Point(525, 12);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(450, 58);
            this.roundedPanel4.TabIndex = 5;
            this.roundedPanel4.Text = "roundedPanel4";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.ForeColor = System.Drawing.Color.White;
            this.roundedPanel2.Location = new System.Drawing.Point(775, 99);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(200, 200);
            this.roundedPanel2.TabIndex = 1;
            this.roundedPanel2.Text = "roundedPanel2";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(525, 99);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(200, 200);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.Text = "roundedPanel1";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel3.BackColor = System.Drawing.Color.White;
            this.roundedPanel3.ForeColor = System.Drawing.Color.White;
            this.roundedPanel3.Location = new System.Drawing.Point(25, 12);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(450, 287);
            this.roundedPanel3.TabIndex = 3;
            this.roundedPanel3.Text = "roundedPanel3";
            // 
            // TelaHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.roundedPanel6);
            this.Controls.Add(this.roundedPanel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundedPanel3);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TelaHome";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label label1;
        private RoundedPanel roundedPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RoundedPanel roundedPanel5;
        private RoundedPanel roundedPanel6;
    }
}