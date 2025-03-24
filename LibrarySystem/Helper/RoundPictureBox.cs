using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LibrarySystem.Helper
{
    public class RoundPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pe.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new Region(path);
                pe.Graphics.SetClip(path);

                if (this.Image != null)
                {
                    pe.Graphics.DrawImage(this.Image, new Rectangle(0, 0, Width, Height));
                }
            }

            base.OnPaint(pe);
        }
    }
}
