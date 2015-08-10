using System;
using System.Collections.Generic;
using System.Text;

namespace Gif2Sheet.SpriteSheets
{
    public class Sprite
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Animation> animations;

        public List<Animation> Animations
        {
            get { return animations; }
            set { animations = value; }
        }

        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        private SpriteSheet parent;

        public SpriteSheet Parent
        {
            get { return parent; }
            set { parent = value; }
        }

    }
}
