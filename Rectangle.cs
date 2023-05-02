﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace interface_IComparable
{
    internal class Rectangle:Shape, Resizeable
    {
        private double width = 1.0;
        private double length = 1.0;
        public Rectangle()
        {
        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public double getWidth()
        {
            return width;
        }

        public virtual void setWidth(double width)
        {
            this.width = width;
        }

        public double getLength()
        {
            return length;
        }

        public virtual void setLength(double length)
        {
            this.length = length;
        }

        public double getArea()
        {
            return this.width * this.length;
        }

        public double getPerimeter()
        {
            return 2 * (this.width + this.length);
        }

        public override string ToString()
        {
            return "A Rectangle with width="
                    + getWidth()
                    + " and length="
                    + getLength()
                    + ", which is a subclass of "
                    + base.ToString();
        }
        public void Resize(double percent)
        {                        
            width *= percent;
            length*=percent;    
        }

        //internal bool Resize()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
