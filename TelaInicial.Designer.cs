namespace Projeto_TCC
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.pibMinimizar = new System.Windows.Forms.PictureBox();
            this.pibFechar = new System.Windows.Forms.PictureBox();
            this.pibMaximizar = new System.Windows.Forms.PictureBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.lblMaximizar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // pibMinimizar
            // 
            this.pibMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pibMinimizar.Image")));
            this.pibMinimizar.Location = new System.Drawing.Point(885, 6);
            this.pibMinimizar.Name = "pibMinimizar";
            this.pibMinimizar.Size = new System.Drawing.Size(23, 23);
            this.pibMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibMinimizar.TabIndex = 32;
            this.pibMinimizar.TabStop = false;
            this.pibMinimizar.Click += new System.EventHandler(this.btnMinimize_Click);
            this.pibMinimizar.MouseEnter += new System.EventHandler(this.pibMinimizar_MouseHover);
            this.pibMinimizar.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // pibFechar
            // 
            this.pibFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibFechar.Image = ((System.Drawing.Image)(resources.GetObject("pibFechar.Image")));
            this.pibFechar.Location = new System.Drawing.Point(985, 6);
            this.pibFechar.Name = "pibFechar";
            this.pibFechar.Size = new System.Drawing.Size(23, 23);
            this.pibFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibFechar.TabIndex = 33;
            this.pibFechar.TabStop = false;
            this.pibFechar.Click += new System.EventHandler(this.btnClose_Click);
            this.pibFechar.MouseEnter += new System.EventHandler(this.pibFechar_MouseHover);
            this.pibFechar.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // pibMaximizar
            // 
            this.pibMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pibMaximizar.Image")));
            this.pibMaximizar.Location = new System.Drawing.Point(935, 6);
            this.pibMaximizar.Name = "pibMaximizar";
            this.pibMaximizar.Size = new System.Drawing.Size(23, 23);
            this.pibMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibMaximizar.TabIndex = 31;
            this.pibMaximizar.TabStop = false;
            this.pibMaximizar.Click += new System.EventHandler(this.btnMaximize_Click);
            this.pibMaximizar.MouseEnter += new System.EventHandler(this.pibMaximizar_MouseHover);
            this.pibMaximizar.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Location = new System.Drawing.Point(971, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(50, 35);
            this.labelClose.TabIndex = 34;
            this.labelClose.Click += new System.EventHandler(this.btnClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.pibFechar_MouseHover);
            this.labelClose.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // lblMaximizar
            // 
            this.lblMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMaximizar.Location = new System.Drawing.Point(921, 0);
            this.lblMaximizar.Name = "lblMaximizar";
            this.lblMaximizar.Size = new System.Drawing.Size(50, 35);
            this.lblMaximizar.TabIndex = 35;
            this.lblMaximizar.Click += new System.EventHandler(this.btnMaximize_Click);
            this.lblMaximizar.MouseEnter += new System.EventHandler(this.pibMaximizar_MouseHover);
            this.lblMaximizar.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Location = new System.Drawing.Point(871, 0);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(50, 35);
            this.lblMinimizar.TabIndex = 36;
            this.lblMinimizar.Click += new System.EventHandler(this.btnMinimize_Click);
            this.lblMinimizar.MouseEnter += new System.EventHandler(this.pibMinimizar_MouseHover);
            this.lblMinimizar.MouseLeave += new System.EventHandler(this.ResetBackground_MouseLeave);
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelInfo.Location = new System.Drawing.Point(10, 50);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1000, 650);
            this.panelInfo.TabIndex = 37;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1020, 710);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.pibMinimizar);
            this.Controls.Add(this.pibFechar);
            this.Controls.Add(this.pibMaximizar);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.lblMaximizar);
            this.Controls.Add(this.lblMinimizar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TelaInicial_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pibMinimizar;
        private System.Windows.Forms.PictureBox pibFechar;
        private System.Windows.Forms.PictureBox pibMaximizar;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label lblMaximizar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Panel panelInfo;
    }
}