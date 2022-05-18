﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _allRectanglesCount;

        private int _length;

        private int _width;

        private int _id;        

        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle(int length,
                        int width,
                        string color,
                        Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(AllRectanglesCount));
                _allRectanglesCount = value;
            }
        }
    }
}
