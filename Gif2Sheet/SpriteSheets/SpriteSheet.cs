using System;
using System.Collections.Generic;
using System.Text;

namespace Gif2Sheet.SpriteSheets
{
    public class SpriteSheet
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        private List<Sprite> sprites;

        public List<Sprite> Sprites
        {
            get { return sprites; }
            set { sprites = value; }
        }
	
    }
}
