﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Реализует статическую обработку данных о двух прямоугольниках.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли два прямоугольника.
        /// </summary>
        /// <param name="rectangle1"></param>
        /// <param name="rectangle2"></param>
        /// <returns>Возвращает true, если все условия пересечения выполнены,
        /// и false, если нет.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.Center.X < rectangle2.Center.X + rectangle2.Width &&
                rectangle1.Center.X + rectangle1.Width > rectangle2.Center.X &&
                rectangle1.Center.Y < rectangle2.Center.Y + rectangle2.Length &&
                rectangle1.Length + rectangle1.Center.Y > rectangle2.Center.Y;
        }

        /// <summary>
        /// Проверяет, пересекаются ли два кольца.
        /// </summary>
        /// <param name="ring1"></param>
        /// <param name="ring2"></param>
        /// <returns>Возвращает true, если условие пересечения выполнено, и false, если нет.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dX * dX + dY * dY);
            return c < (ring1.OuterRadius + ring2.OuterRadius);
        }
    }
}
