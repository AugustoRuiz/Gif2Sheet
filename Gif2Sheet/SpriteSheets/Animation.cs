using System;
using System.Collections.Generic;
using System.Text;

namespace Gif2Sheet.SpriteSheets
{
    public class Animation
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool createHFlip;

        public bool CreateHFlip
        {
            get { return createHFlip; }
            set { createHFlip = value; }
        }

        private List<Frame> frames;

        public List<Frame> Frames
        {
            get { return frames; }
            set { frames = value; }
        }

        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        private Sprite parent;

        public Sprite Parent
        {
            get { return parent; }
            set { parent = value; }
        }

    }
}
