using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleClass
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        private string Message;

        public Rectangle()
        {
            Length = 0;
            Width = 0;
            Message = string.Empty;
        }


        public double calculateArea()
        {
            return Length * Width;
        }

        public double calculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }

}
