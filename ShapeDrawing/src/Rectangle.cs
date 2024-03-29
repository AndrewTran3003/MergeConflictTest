﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    class Rectangle : Shape
    {
        private int _width, _height;

        public Rectangle() : this(Color.Green, 0, 0, 100, 100)
        {

        }
        public Rectangle(Color color, float x, float y, int width, int height) :
        base(color)
        {
            Color = color;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SwinGame.FillRectangle(Color, X, Y, _width, _height);
        }

        public override void DrawOutline()
        {
            SwinGame.DrawRectangle(Color.Black, X - 1, Y - 1, Width + 2, Height +
            2);
        }

        public override bool IsAt(Point2D pt)
        {
            return SwinGame.PointInRect(pt, X, Y, Width, Height);
        }
    }
}