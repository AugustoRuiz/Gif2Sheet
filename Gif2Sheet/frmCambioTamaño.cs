using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gif2Sheet
{
    public partial class frmCambioTamaño : Form
    {
        public frmCambioTamaño()
        {
            InitializeComponent();
        }

        private Image image;

        public Image Image
        {
            get { return image; }
            set
            {
                image = value;
                initControls();
            }
        }

        public Size NewImageSize
        {
            get
            {
                return new Size((int)this.nuevoAncho.Value, (int)this.nuevoAlto.Value);
            }
        }

        private string sizeMode;

        public string SizeMode
        {
            get
            {
                return sizeMode;
            }
        }

        private void initControls()
        {
            this.anchoOriginal.Text = image.Width.ToString();
            this.altoOriginal.Text = image.Height.ToString();
            this.nuevoAncho.Value = image.Width;
            this.nuevoAlto.Value = image.Height;

            cmdMiddle.Checked = true;
        }
	

        private void cmdGrowSize_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton src = sender as RadioButton;
            if (src != null && src.Checked)
            {
                sizeMode = src.Name.Substring(3);
                switch (sizeMode)
                {
                    case Constantes.TOP_LEFT:
                        cmdTopLeft.Image = this.arrowsImgList.Images[Constantes.IMAGE];
                        cmdTop.Image =  this.arrowsImgList.Images[Constantes.ARROW_RIGHT];
                        cmdTopRight.Image = null;
                        cmdLeft.Image =  this.arrowsImgList.Images[Constantes.ARROW_DOWN];
                        cmdMiddle.Image = this.arrowsImgList.Images[Constantes.ARROW_DOWN_RIGHT];
                        cmdRight.Image = null;
                        cmdBottomLeft.Image = null;
                        cmdBottom.Image = null;
                        cmdBottomRight.Image = null;
                        break;
                    case Constantes.TOP:
                        cmdTopLeft.Image = this.arrowsImgList.Images[Constantes.ARROW_LEFT];
                        cmdTop.Image = this.arrowsImgList.Images[Constantes.IMAGE];
                        cmdTopRight.Image = this.arrowsImgList.Images[Constantes.ARROW_RIGHT];
                        cmdLeft.Image = this.arrowsImgList.Images[Constantes.ARROW_DOWN_LEFT];
                        cmdMiddle.Image = this.arrowsImgList.Images[Constantes.ARROW_DOWN];
                        cmdRight.Image = this.arrowsImgList.Images[Constantes.ARROW_DOWN_RIGHT];
                        cmdBottomLeft.Image = null;
                        cmdBottom.Image = null;
                        cmdBottomRight.Image = null;
                        break;
                    case Constantes.TOP_RIGHT:
                        cmdTopLeft.Image = null;
                        cmdTop.Image = this.arrowsImgList.Images[Constantes.ARROW_LEFT];
                        cmdTopRight.Image = this.arrowsImgList.Images[Constantes.IMAGE];
                        cmdLeft.Image = null;
                        cmdMiddle.Image = this.arrowsImgList.Images[Constantes.ARROW_DOWN_LEFT];
                        cmdRight.Image = this.arrowsImgList.Images[Constantes.ARROW_DOWN];
                        cmdBottomLeft.Image = null;
                        cmdBottom.Image = null;
                        cmdBottomRight.Image = null;
                        break;
                    case Constantes.LEFT:
                        cmdTopLeft.Image = this.arrowsImgList.Images[Constantes.ARROW_UP];
                        cmdTop.Image = this.arrowsImgList.Images[Constantes.ARROW_UP_RIGHT];
                        cmdTopRight.Image = null;
                        cmdLeft.Image = this.arrowsImgList.Images[Constantes.IMAGE];
                        cmdMiddle.Image = this.arrowsImgList.Images[Constantes.ARROW_RIGHT];
                        cmdRight.Image = null;
                        cmdBottomLeft.Image = this.arrowsImgList.Images[Constantes.ARROW_DOWN];
                        cmdBottom.Image = this.arrowsImgList.Images[Constantes.ARROW_DOWN_RIGHT];
                        cmdBottomRight.Image = null;
                        break;
                    case Constantes.MIDDLE:
                        cmdTopLeft.Image = this.arrowsImgList.Images[Constantes.ARROW_UP_LEFT];
                        cmdTop.Image = this.arrowsImgList.Images[Constantes.ARROW_UP];
                        cmdTopRight.Image = this.arrowsImgList.Images[Constantes.ARROW_UP_RIGHT];
                        cmdLeft.Image = this.arrowsImgList.Images[Constantes.ARROW_LEFT];
                        cmdMiddle.Image = this.arrowsImgList.Images[Constantes.IMAGE];
                        cmdRight.Image = this.arrowsImgList.Images[Constantes.ARROW_RIGHT];
                        cmdBottomLeft.Image = this.arrowsImgList.Images[Constantes.ARROW_DOWN_LEFT];
                        cmdBottom.Image = this.arrowsImgList.Images[Constantes.ARROW_DOWN];
                        cmdBottomRight.Image = this.arrowsImgList.Images[Constantes.ARROW_DOWN_RIGHT];
                        break;
                    case Constantes.RIGHT:
                        cmdTopLeft.Image = null;
                        cmdTop.Image = this.arrowsImgList.Images[Constantes.ARROW_UP_LEFT];
                        cmdTopRight.Image = this.arrowsImgList.Images[Constantes.ARROW_UP];
                        cmdLeft.Image = null;
                        cmdMiddle.Image = this.arrowsImgList.Images[Constantes.ARROW_LEFT];
                        cmdRight.Image = this.arrowsImgList.Images[Constantes.IMAGE];
                        cmdBottomLeft.Image = null;
                        cmdBottom.Image = this.arrowsImgList.Images[Constantes.ARROW_DOWN_LEFT];
                        cmdBottomRight.Image = this.arrowsImgList.Images[Constantes.ARROW_DOWN];
                        break;
                    case Constantes.BOTTOM_LEFT:
                        cmdTopLeft.Image = null;
                        cmdTop.Image = null;
                        cmdTopRight.Image = null;
                        cmdLeft.Image = this.arrowsImgList.Images[Constantes.ARROW_UP];
                        cmdMiddle.Image = this.arrowsImgList.Images[Constantes.ARROW_UP_RIGHT];
                        cmdRight.Image = null;
                        cmdBottomLeft.Image = this.arrowsImgList.Images[Constantes.IMAGE];
                        cmdBottom.Image = this.arrowsImgList.Images[Constantes.ARROW_RIGHT];
                        cmdBottomRight.Image = null;
                        break;
                    case Constantes.BOTTOM:
                        cmdTopLeft.Image = null;
                        cmdTop.Image = null;
                        cmdTopRight.Image = null;
                        cmdLeft.Image = this.arrowsImgList.Images[Constantes.ARROW_UP_LEFT];
                        cmdMiddle.Image = this.arrowsImgList.Images[Constantes.ARROW_UP];
                        cmdRight.Image = this.arrowsImgList.Images[Constantes.ARROW_UP_RIGHT];
                        cmdBottomLeft.Image = this.arrowsImgList.Images[Constantes.ARROW_LEFT];
                        cmdBottom.Image = this.arrowsImgList.Images[Constantes.IMAGE];
                        cmdBottomRight.Image = this.arrowsImgList.Images[Constantes.ARROW_RIGHT];
                        break;
                    case Constantes.BOTTOM_RIGHT:
                        cmdTopLeft.Image = null;
                        cmdTop.Image = null;
                        cmdTopRight.Image = null;
                        cmdLeft.Image = null;
                        cmdMiddle.Image = this.arrowsImgList.Images[Constantes.ARROW_UP_LEFT];
                        cmdRight.Image = this.arrowsImgList.Images[Constantes.ARROW_UP];
                        cmdBottomLeft.Image = null;
                        cmdBottom.Image = this.arrowsImgList.Images[Constantes.ARROW_LEFT];
                        cmdBottomRight.Image = this.arrowsImgList.Images[Constantes.IMAGE];
                        break;
                }
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}