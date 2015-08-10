using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gif2Sheet.SpriteSheets;

namespace Gif2Sheet
{
    public partial class frmSpriteSheetEdit : Form
    {
        public frmSpriteSheetEdit()
        {
            InitializeComponent();
        }

        private Image srcImage;

        public Image SrcImage
        {
            get { return srcImage; }
            set 
            { 
                srcImage = value;
                this.picViewer.Image = value;
            }
        }

        private SpriteSheet sheet;

        public SpriteSheet Sheet
        {
            get { return sheet; }
            set
            {
                sheet = value;
                this.propertyGrid1.SelectedObject = sheet;
            }
        }

    }
}