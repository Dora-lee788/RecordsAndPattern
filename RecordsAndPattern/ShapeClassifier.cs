using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsAndPattern
{
        public static class ShapeClassifier
        {
            public static string Classify(object shape)
            {
                return shape switch
                {
                    Circle { Center: { X: 0, Y: 0 } }
                        => "окружность в начале координат",

                    Circle { Radius: 0 }
                        => "вырожденная окружность (точка)",

                    Circle circle
                        => $"окружность с радиусом {circle.Radius}",

                    Rectangle rectangle
                        when rectangle.TopLeft == rectangle.BottomRight
                        => "вырожденный прямоугольник (точка)",

                    Rectangle rectangle
                        => $"прямоугольник с размерами " +
                           $"{Math.Abs(rectangle.BottomRight.X - rectangle.TopLeft.X)} x " +
                           $"{Math.Abs(rectangle.TopLeft.Y - rectangle.BottomRight.Y)}",

                    _ => "неизвестная фигура"
                };
            }
        }
    
}
