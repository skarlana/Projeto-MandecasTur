using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Adicione daqui para baixo 
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Login
{
    public class BotaoPadraoDois : Button
    {
        // Cores para o efeito visual
        private Color corNormal = Color.FromArgb(194, 194, 194); // CINZA
        private Color corHover = Color.Gray;  // CINZA Claro

        public BotaoPadraoDois()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = corNormal;
            ForeColor = Color.Black;
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI Semibold", 10F);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Criar o caminho arredondado
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            int radius = 10; // Ajuste o arredondamento aqui
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path); // Corta o botão no formato

            // Desenhar o texto centralizado manualmente para evitar bugs de transparência
            TextRenderer.DrawText(e.Graphics, Text, Font, rect, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        // Efeito de mudar a cor ao passar o mouse
        protected override void OnMouseEnter(EventArgs e) { base.OnMouseEnter(e); BackColor = corHover; }
        protected override void OnMouseLeave(EventArgs e) { base.OnMouseLeave(e); BackColor = corNormal; }
    }




}

