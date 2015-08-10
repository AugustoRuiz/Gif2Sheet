using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gif2Sheet.Properties;

namespace Gif2Sheet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public frmProcessImage CurrentProcessImage
        {
            get 
            { 
                return this.ActiveMdiChild as frmProcessImage; 
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdGIF.ShowDialog() == DialogResult.OK)
            {
                frmProcessImage newFrm = new frmProcessImage();
                
                try
                {
                    newFrm.MdiParent = this;
                    newFrm.SrcImage = Bitmap.FromFile(ofdGIF.FileName);
                    ConversionPreferences preferences = getConversionPreferences();
                    newFrm.Preferences = preferences;
                    newFrm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("No se pudo cargar la imagen de la ruta {0}.\nError:\n{1}", ofdGIF.FileName, ex.ToString()), 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private ConversionPreferences getConversionPreferences()
        {
            ConversionPreferences pref = new ConversionPreferences();
            pref.BetweenFrameColor = Properties.Settings.Default.BetweenFrameColor;
            pref.BetweenFrameWidth = Properties.Settings.Default.BetweenFrameWidth;
            pref.DestBackgroundColor = Properties.Settings.Default.DestBackgroundColor;
            pref.DrawFlipped = Properties.Settings.Default.DrawFlipped;
            pref.FramesPerRow = Properties.Settings.Default.FramesPerRow;
            pref.SrcBackgroundColor = Properties.Settings.Default.SrcBackgroundColor;
            pref.Zoom = Properties.Settings.Default.Zoom;
            return pref;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsImage();
        }

        private void saveImage()
        {
            if (this.CurrentProcessImage != null)
            {
                if (!string.IsNullOrEmpty(this.CurrentProcessImage.FileName))
                {
                    doSaveImage();
                }
                else
                {
                    saveAsImage();
                }
            }
        }

        private void saveAsImage()
        {
            if (this.CurrentProcessImage != null)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    this.CurrentProcessImage.FileName = sfd.FileName;
                    doSaveImage();
                }
            }
        }

        private void doSaveImage()
        {
            try
            {
                this.CurrentProcessImage.SaveImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("No se pudo guardar la imagen. El error es el siguiente:\n{0}", ex.ToString()),
                                "Error al guardar la imagen.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO:
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO:
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que quiere salir de la aplicación?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO:
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frmAbout = new About();
            frmAbout.ShowDialog();
        }

        private void changeSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.CurrentProcessImage != null)
            {
                frmCambioTamaño newFrm = new frmCambioTamaño();
                newFrm.Image = this.CurrentProcessImage.SrcImage;
                if (newFrm.ShowDialog() == DialogResult.OK)
                {
                    this.CurrentProcessImage.SetNewSize(newFrm.NewImageSize, newFrm.SizeMode);
                }
            }
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreferences newFrm = new frmPreferences();
            newFrm.ShowDialog();
        }

        private void abrirspritesheetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdSheet.ShowDialog() == DialogResult.OK)
            {
                frmSpriteSheetEdit newFrm = new frmSpriteSheetEdit();

                try
                {
                    newFrm.MdiParent = this;
                    newFrm.SrcImage = Bitmap.FromFile(ofdSheet.FileName);
                    newFrm.Sheet = new Gif2Sheet.SpriteSheets.SpriteSheet();
                    newFrm.Sheet.FilePath = System.IO.Path.GetFileName(ofdSheet.FileName);
                    newFrm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("No se pudo cargar la imagen de la ruta {0}.\nError:\n{1}", ofdGIF.FileName, ex.ToString()),
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}