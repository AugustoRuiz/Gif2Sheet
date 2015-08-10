using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Gif2Sheet.SpriteSheets
{
    public class Frame
    {
        private List<Rectangle> collisions;

        public List<Rectangle> Collisions
        {
            get { return collisions; }
            set { collisions = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private bool all;

        public bool All
        {
            get { return all; }
            set { all = value; }
        }

        private Rectangle source;

        public Rectangle Source
        {
            get { return source; }
            set { source = value; }
        }

        private Point drawPosition;

        public Point DrawPosition
        {
            get { return drawPosition; }
            set { drawPosition = value; }
        }

        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        private Animation parent;

        public Animation Parent
        {
            get { return parent; }
            set { parent = value; }
        }

    }
}
