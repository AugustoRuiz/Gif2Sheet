using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Gif2Sheet
{
    public class ZoomingPicture : PictureBox
    {
        private float zoomFactor = 1.0f;

        public float ZoomFactor
        {
            get
            {
                return zoomFactor;
            }
            set
            {
                if (value != zoomFactor)
                {
                    zoomFactor = value;
                    this.Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            pe.Graphics.ScaleTransform(zoomFactor, zoomFactor);
            base.OnPaint(pe);
        }
    }
}
