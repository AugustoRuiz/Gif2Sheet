using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Gif2Sheet
{
    public partial class frmProcessImage : Form
    {
        public frmProcessImage()
        {
            InitializeComponent();
        }

        private Bitmap destinationImage;
        private int numFrames;
        private int currentFrame;

        private Image srcImage;

        public Image SrcImage
        {
            get { return srcImage; }
            set
            {
                srcImage = value;
                currentFrame = 0;
                FrameDimension frameDimensions = new FrameDimension(this.srcImage.FrameDimensionsList[0]);
                numFrames = this.srcImage.GetFrameCount(frameDimensions);
                updateImages();
                this.tmrFrameChange.Enabled = (srcImage.RawFormat.Guid == getCodecInfo("image/tiff").FormatID);
            }
        }

        private ConversionPreferences preferences;

        public ConversionPreferences Preferences
        {
            get { return preferences; }
            set
            {
                preferences = value;
                this.preferencesEditor.SelectedObject = preferences;
                preferences.PropertyChanged += new PropertyChangedEventHandler(preferences_PropertyChanged);
                updateImages();
            }
        }

        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private void updateImages()
        {
            this.sourceImage.Image = this.srcImage;
            updateDestImage();
        }

        private void updateDestImage()
        {
            if (this.sourceImage != null && this.preferences != null)
            {
                if (this.destinationImage != null)
                {
                    this.destinationImage.Dispose();
                }

                FrameDimension frameDimensions = new FrameDimension(this.srcImage.FrameDimensionsList[0]);

                int destWidth;
                int destHeight;
                if (preferences.FramesPerRow > 0)
                {
                    int numRows = (int)Math.Ceiling(numFrames / (double)preferences.FramesPerRow);
                    int numCols = (int)Math.Min(numFrames, preferences.FramesPerRow);

                    destWidth = (numCols * (this.srcImage.Width + preferences.BetweenFrameWidth)) + preferences.BetweenFrameWidth;
                    destHeight = numRows * (this.srcImage.Height + preferences.BetweenFrameWidth) + preferences.BetweenFrameWidth;
                }
                else
                {
                    destWidth = (this.srcImage.Width + preferences.BetweenFrameWidth) * numFrames + preferences.BetweenFrameWidth;
                    destHeight = this.srcImage.Height + 2 * preferences.BetweenFrameWidth;
                }

                this.destinationImage = new Bitmap(destWidth, destHeight);

                Graphics destGraphics = Graphics.FromImage(this.destinationImage);

                GraphicsUnit unit = GraphicsUnit.Pixel;

                Brush bgBrush = new SolidBrush(preferences.BetweenFrameColor);
                destGraphics.FillRectangle(bgBrush, destinationImage.GetBounds(ref unit));
                bgBrush.Dispose();

                int currentX, currentY;

                for (int frame = 0; frame < numFrames; frame++)
                {
                    this.srcImage.SelectActiveFrame(frameDimensions, frame);

                    if (preferences.FramesPerRow <= 0)
                    {
                        currentX = preferences.BetweenFrameWidth + (preferences.BetweenFrameWidth + srcImage.Width) * frame;
                        currentY = preferences.BetweenFrameWidth;
                    }
                    else
                    {
                        int fila, columna;

                        fila = (frame / preferences.FramesPerRow);
                        columna = (frame % preferences.FramesPerRow);

                        currentX = preferences.BetweenFrameWidth + (preferences.BetweenFrameWidth + srcImage.Width) * columna;
                        currentY = preferences.BetweenFrameWidth + (preferences.BetweenFrameWidth + srcImage.Height) * fila;
                    }

                    Bitmap modifiedImage = getModifiedImage();

                    if (preferences.DrawFlipped)
                    {
                        modifiedImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    }
                    destGraphics.DrawImageUnscaled(modifiedImage, currentX, currentY);
                }

                destGraphics.Dispose();

                this.sourceImage.Width = (int)Math.Ceiling(this.srcImage.Width * preferences.Zoom);
                this.sourceImage.Height = (int)Math.Ceiling(this.srcImage.Height * preferences.Zoom);
                this.sourceImage.ZoomFactor = preferences.Zoom;

                this.destImage.Image = this.destinationImage;
                this.destImage.Width = (int)Math.Ceiling(this.destinationImage.Width * preferences.Zoom);
                this.destImage.Height = (int)Math.Ceiling(this.destinationImage.Height * preferences.Zoom);
                this.destImage.ZoomFactor = preferences.Zoom;
            }
        }

        private Bitmap getModifiedImage()
        {
            Bitmap dest = new Bitmap(this.srcImage);
            for (int y = 0; y < dest.Height; y++)
            {
                for (int x = 0; x < dest.Width; x++)
                {
                    if (dest.GetPixel(x, y) == preferences.SrcBackgroundColor)
                    {
                        dest.SetPixel(x, y, preferences.DestBackgroundColor);
                    }
                }
            }
            return dest;
        }

        private void preferences_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.preferencesEditor.Refresh();
            updateDestImage();
        }

        private void preferencesEditor_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            //updateDestImage();
        }

        internal void SaveImage()
        {
            this.destinationImage.Save(this.fileName);
        }

        private void sourceImage_MouseUp(object sender, MouseEventArgs e)
        {
            Bitmap srcBitmap = this.srcImage as Bitmap;
            GraphicsUnit unit = GraphicsUnit.Pixel;
            if (srcBitmap != null)
            {
                RectangleF rectF = srcBitmap.GetBounds(ref unit);
                Rectangle rectImagen = new Rectangle((int)rectF.X, (int)rectF.Y,
                                                     (int)rectF.Width, (int)rectF.Height);

                if ((MouseButtons.Left == (e.Button & MouseButtons.Left)) &&
                    this.pnlColor.Visible)
                {
                    this.preferences.SrcBackgroundColor = this.pnlColor.BackColor;
                }
            }
        }

        private void sourceImage_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap srcBitmap = this.srcImage as Bitmap;
            GraphicsUnit unit = GraphicsUnit.Pixel;
            if (srcBitmap != null && preferences != null && preferences.Zoom != 0)
            {
                RectangleF rectF = srcBitmap.GetBounds(ref unit);
                Rectangle rectImagen = new Rectangle((int)rectF.X, (int)rectF.Y,
                                                     (int)Math.Ceiling(rectF.Width * preferences.Zoom),
                                                     (int)Math.Ceiling(rectF.Height * preferences.Zoom));

                if (rectImagen.Contains(e.Location))
                {
                    this.pnlColor.Visible = true;
                    this.pnlColor.BackColor = srcBitmap.GetPixel((int)Math.Floor(e.X / preferences.Zoom),
                                                                 (int)Math.Floor(e.Y / preferences.Zoom));
                    this.pnlColor.Invalidate();
                    this.sourceImage.Cursor = Cursors.Hand;
                }
                else
                {
                    this.sourceImage.Cursor = Cursors.Default;
                    this.pnlColor.Visible = false;
                }
            }
        }

        private void sourceImage_MouseLeave(object sender, EventArgs e)
        {
            this.pnlColor.Visible = false;
        }

        internal void SetNewSize(Size size, string sizeMode)
        {
            Point destLocation = getDestinationPos(size, sizeMode);
            Bitmap newSrcImage = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(newSrcImage);
            Brush fondo = new SolidBrush(preferences.SrcBackgroundColor);

            FrameDimension frameDimensions = new FrameDimension(newSrcImage.FrameDimensionsList[0]);
            FrameDimension oldFrameDimensions = new FrameDimension(this.srcImage.FrameDimensionsList[0]);

            EncoderParameters tiffParams = new EncoderParameters(1);
            EncoderParameter param = new EncoderParameter(System.Drawing.Imaging.Encoder.SaveFlag, (long)EncoderValue.MultiFrame);
            tiffParams.Param[0] = param;

            ImageCodecInfo tiffEncoder = getCodecInfo("image/tiff");

            string filePath = System.IO.Path.GetTempFileName();

            for (int frame = 0; frame < numFrames; frame++)
            {
                Bitmap tempImage = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);
                Graphics tempGr = Graphics.FromImage(tempImage);

                this.srcImage.SelectActiveFrame(oldFrameDimensions, frame);
                tempGr.FillRectangle(fondo, 0, 0, newSrcImage.Width, newSrcImage.Height);
                tempGr.DrawImage(this.srcImage, destLocation);

                if (frame == 0)
                {
                    g.DrawImage(this.srcImage, destLocation);
                    newSrcImage.Save(filePath, tiffEncoder, tiffParams);
                }
                else
                {
                    tiffParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.SaveFlag,
                        (long)EncoderValue.FrameDimensionPage);
                    newSrcImage.SaveAdd(tempImage, tiffParams);
                }

                tempImage.Dispose();
                GC.Collect();
            }
            tiffParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.SaveFlag,
                                            (long)EncoderValue.Flush);
            newSrcImage.SaveAdd(tiffParams);
            newSrcImage.Dispose();
            GC.Collect();

            Image temp = this.srcImage;
            this.SrcImage = Bitmap.FromFile(filePath);

            temp.Dispose();
            fondo.Dispose();
            g.Dispose();
        }

        private ImageCodecInfo getCodecInfo(string mimeType)
        {
            ImageCodecInfo result = null;
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.MimeType == mimeType)
                {
                    result = codec;
                    break;
                }
            }
            return result;
        }

        private Point getDestinationPos(Size size, string sizeMode)
        {
            Point result = Point.Empty;
            switch (sizeMode)
            {
                case Constantes.TOP_LEFT:
                    result = Point.Empty;
                    break;
                case Constantes.TOP:
                    result = new Point((size.Width - this.srcImage.Width) / 2,
                                       0);
                    break;
                case Constantes.TOP_RIGHT:
                    result = new Point((size.Width - this.srcImage.Width),
                                       0);
                    break;
                case Constantes.LEFT:
                    result = new Point(0,
                                       (size.Height - this.srcImage.Height) / 2);
                    break;
                case Constantes.MIDDLE:
                    result = new Point((size.Width - this.srcImage.Width) / 2,
                                       (size.Height - this.srcImage.Height) / 2);
                    break;
                case Constantes.RIGHT:
                    result = new Point(size.Width - this.srcImage.Width,
                                       (size.Height - this.srcImage.Height) / 2);
                    break;
                case Constantes.BOTTOM_LEFT:
                    result = new Point(0,
                                       size.Height - this.srcImage.Height);
                    break;
                case Constantes.BOTTOM:
                    result = new Point((size.Width - this.srcImage.Width) / 2,
                                       size.Height - this.srcImage.Height);
                    break;
                case Constantes.BOTTOM_RIGHT:
                    result = new Point(size.Width - this.srcImage.Width,
                                       size.Height - this.srcImage.Height);
                    break;
            }
            return result;
        }

        private void tmrFrameChange_Tick(object sender, EventArgs e)
        {
            FrameDimension dim = new FrameDimension(this.srcImage.FrameDimensionsList[0]);
            currentFrame++;
            if (currentFrame == numFrames)
            {
                currentFrame = 0;
            }
            this.srcImage.SelectActiveFrame(dim, currentFrame);
            this.sourceImage.Invalidate();
        }
    }
}