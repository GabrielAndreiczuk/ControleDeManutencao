using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCC
{
    // CLASSE BASE PARA ARREDONDAMENTO
    public class RoundedComponentBase : Control
    {
        protected int borderSize = 0;
        protected int borderRadius = 35;
        protected Color borderColor = Color.AliceBlue;
        protected bool[] roundedCorners = { true, true, true, true }; 

        public RoundedComponentBase()
        {
            this.Size = new Size(150, 40);
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
        }

        // MÉTODO PARA DEFINIR QUAIS CANTOS SERÃO ARREDONDADOS
        protected GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // CANTO ESQUERDO SUPERIOR
            if (roundedCorners[0])
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            else
                path.AddLine(rect.X, rect.Y, rect.X + radius, rect.Y);

            // CANTO DIREIRO SUPERIOR
            if (roundedCorners[1])
                path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            else
                path.AddLine(rect.Width - radius, rect.Y, rect.Width, rect.Y);

            // CANTO DIREITO INFERIOR
            if (roundedCorners[2])
                path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            else
                path.AddLine(rect.Width, rect.Height - radius, rect.Width, rect.Height);

            // CANTO ESQUERDO INFERIOR
            if (roundedCorners[3])
                path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            else
                path.AddLine(rect.X + radius, rect.Height, rect.X, rect.Height);

            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pavent)
        {
            base.OnPaint(pavent);
            pavent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2) //FORMA ARREDONDADA
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;

                    // SUPERFÍCIE
                    this.Region = new Region(pathSurface);
                    pavent.Graphics.DrawPath(penSurface, pathSurface);

                    // BORDA
                    if (borderSize >= 1)
                    {
                        pavent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pavent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        // BackColor change handler
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }

    // CLASSES DERIVADAS DA CLASSE PRINCIPAL
    // LABEL
    public class RoundedLabel : RoundedComponentBase
    {
        public RoundedLabel() : base()
        {
            this.Size = new Size(300, 50);
            this.BackColor = Color.White;
        }
    }

    // PAINEL COM ARREDONDAMENTO DIREITO
    public class RoundedRightPanel : RoundedComponentBase
    {
        public RoundedRightPanel() : base()
        {
            this.Size = new Size(400, 650);
            //PASSA COMANDO DE ARREDONDAR APENAS AS BORDAS DIREITAS
            this.roundedCorners = new bool[] { false, true, true, false };
            this.borderRadius = 50;
        }
    }

    // PAINEL COM ARREDONDAMENTO ESQUERDO
    public class RoundedLeftPanel : RoundedComponentBase
    {
        public RoundedLeftPanel() : base()
        {
            this.Size = new Size(400, 650);
            //PASSA COMANDO DE ARREDONDAR APENAS AS BORDAS ESQUERDAS
            this.roundedCorners = new bool[] { true, false, false, true };
            this.borderRadius = 50;
        }
    }

    // LINHA COM BASE EM PAINEL
    public class LinePanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.White, 3); 
            g.DrawLine(pen, new Point(10, 0), new Point(Width - 10, 0));
            pen.Dispose();
        }
    }

    // ARREDONDAMENTO BOTÃO
    public class RoundedButton : Button // Alterar para herdar de Button
    {
        private int borderSize = 0;
        private int borderRadius = 35;
        private Color borderColor = Color.Black;

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(300, 50);
            this.BackColor = Color.FromArgb(54, 124, 221);
            this.ForeColor = Color.White;
        }

        protected GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // ESQUERDA CIMA
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pavent)
        {
            base.OnPaint(pavent);
            pavent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2) // Rounded shape
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;

                    // Surface
                    this.Region = new Region(pathSurface);
                    pavent.Graphics.DrawPath(penSurface, pathSurface);

                    // Border
                    if (borderSize >= 1)
                    {
                        pavent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else // Regular shape
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pavent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}