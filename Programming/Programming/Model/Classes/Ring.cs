﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private double _outerRadius;

        private double _innerRadius;

        public Ring()
        {
        }

        public Ring(double outerRadius,
                    double innerRadius,
                    Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }

        public Point2D Center { get; set; }

        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertValueInRange(value, Convert.ToInt32(InnerRadius), 250, nameof(OuterRadius));
                value = _outerRadius;
            }
        }

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validator.AssertValueInRange(value, 0, Convert.ToInt32(OuterRadius), nameof(InnerRadius));
                value = _innerRadius;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
            }
        }
    }
}
