using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gif2Sheet
{
    public partial class frmPreferences : Form
    {
        public frmPreferences()
        {
            InitializeComponent();
            initControls();
        }

        private void initControls()
        {
            ConversionPreferences pref = new ConversionPreferences();
            pref.BetweenFrameColor = Properties.Settings.Default.BetweenFrameColor;
            pref.BetweenFrameWidth = Properties.Settings.Default.BetweenFrameWidth;
            pref.DestBackgroundColor = Properties.Settings.Default.DestBackgroundColor;
            pref.DrawFlipped = Properties.Settings.Default.DrawFlipped;
            pref.FramesPerRow = Properties.Settings.Default.FramesPerRow;
            pref.SrcBackgroundColor = Properties.Settings.Default.SrcBackgroundColor;
            pref.Zoom = Properties.Settings.Default.Zoom;
            this.propertyGrid1.SelectedObject = pref;
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            ConversionPreferences pref = this.propertyGrid1.SelectedObject as ConversionPreferences;
            Properties.Settings.Default.BetweenFrameColor = pref.BetweenFrameColor;
            Properties.Settings.Default.BetweenFrameWidth = pref.BetweenFrameWidth;
            Properties.Settings.Default.DestBackgroundColor = pref.DestBackgroundColor;
            Properties.Settings.Default.DrawFlipped = pref.DrawFlipped;
            Properties.Settings.Default.FramesPerRow = pref.FramesPerRow;
            Properties.Settings.Default.SrcBackgroundColor = pref.SrcBackgroundColor;
            Properties.Settings.Default.Zoom = pref.Zoom;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}