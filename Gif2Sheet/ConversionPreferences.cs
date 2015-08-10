using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace Gif2Sheet
{
    [Serializable()]
    public class ConversionPreferences : INotifyPropertyChanged
    {
        private Color srcBackgroundColor;

        [Description("Color de fondo del GIF origen")]
        [DisplayName("Color de fondo origen")]
        public Color SrcBackgroundColor
        {
            get { return srcBackgroundColor; }
            set 
            { 
                srcBackgroundColor = value;
                this.RaisePropertyChanged("SrcBackgroundColor");
            }
        }

        private Color destBackgroundColor;

        [Description("Color de fondo del PNG destino")]
        [DisplayName("Color de fondo destino")]
        public Color DestBackgroundColor
        {
            get { return destBackgroundColor; }
            set 
            { 
                destBackgroundColor = value;
                this.RaisePropertyChanged("DestBackgroundColor");
            }
        }

        private Color betweenFrameColor;

        [Description("Color a utilizar para el marco entre frames")]
        [DisplayName("Color entre frames")]
        public Color BetweenFrameColor
        {
            get { return betweenFrameColor; }
            set 
            { 
                betweenFrameColor = value;
                this.RaisePropertyChanged("BetweenFrameColor");
            }
        }

        private int betweenFrameWidth;

        [Description("Anchura de la línea a insertar entre frames")]
        [DisplayName("Anchura entre frames")]
        public int BetweenFrameWidth
        {
            get { return betweenFrameWidth; }
            set 
            { 
                betweenFrameWidth = value;
                this.RaisePropertyChanged("BetweenFrameWidth");
            }
        }

        private int framesPerRow;

        [Description("Número de frames a colocar por fila")]
        [DisplayName("Frames por fila")]
        public int FramesPerRow
        {
            get { return framesPerRow; }
            set 
            { 
                framesPerRow = value;
                this.RaisePropertyChanged("FramesPerRow");
            }
        }

        private bool drawFlipped;

        [Description("Indica si los sprites deben voltearse horizontalmente")]
        [DisplayName("Voltear horizontal")]
        public bool DrawFlipped
        {
            get { return drawFlipped; }
            set 
            {
                drawFlipped = value;
                this.RaisePropertyChanged("DrawFlipped");
            }
        }

        private float zoom;

        [Description("Indica el nivel de zoom a aplicar a la hora de visualizar las imágenes.")]
        [DisplayName("Zoom")]
        public float Zoom
        {
            get { return zoom; }
            set
            {
                zoom = value;
                this.RaisePropertyChanged("Zoom");
            }
        }
	

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(property));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs evArgs)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, evArgs);
            }
        }

        #endregion
    }
}
