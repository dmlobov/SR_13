using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Building
    {
        string address;
        int length;
        int width;
        int height;

        string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
         int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                    length = 0;
                else
                    length = value;
            }
        }
        int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                    width = 0;
                else
                    width = value;
            }
        }
        int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                    height = 0;
                else
                    height = value;
            }
        }
        public Building(string address, int length, int width, int height)
        {
            this.Address = address;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        {
            return $"Адрес: {address}, длина здания: {length}, ширина здания: {width}, высота здания: {height}";
        }
    }
}
