using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Custom_Paint
{
    class Shape
    {
        public String shapeType
        {
            get;
            set;
        }

        public Color lineColor
        {
            get;
            set;
        }

        public int penWidth
        {
            get;
            set;
        }

        public bool filled
        {
            get;
            set;
        }

        public Color fillColor
        {
            get;
            set;
        }

        public String text
        {
            get;
            set;
        }

        public Font font
        {
            get;
            set;
        }

        public Point end
        {
            get;
            set;
        }

        public Point start
        {
            get;
            set;
        }

        public int width
        {
            get;
            set;
        }

        public int height
        {
            get;
            set;
        }
    }
}
