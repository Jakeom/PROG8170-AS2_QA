using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_QA
{
    public class Rectangle
    {
        private int length = 1;
        private int width = 1;
        private int heigth = 1;

        public int GetLength()
        {
            return this.length;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return GetLength();
        }
        public int GetWidth()
        {
            return this.width;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return GetWidth();
        }
        public int GetHeight()
        {
            return this.heigth;
        }
        public int SetHeight(int heigth)
        {
            this.heigth = heigth;
            return GetHeight();
        }
        public int GetVolume()
        {
            return length + width + heigth;
        }
    }
}
