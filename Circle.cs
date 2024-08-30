using System;
using System.Collections.Generic;
using System.Text;

namespace LopCircleVaCylinder
{
    public class Circle
    {
        private double R;
        private string Color;
        public double Area;
        public Circle(double _R, string _Color)
        {
            R = _R;
            Color = _Color;
        }
        public Circle()
        {

        }
        public void setR(double r)
        {
            R = r;
        }
        public double getR()
        {
            return R;
        }
        public void setColor(string _Color)
        {
            Color = _Color;
        }
        public string getColor()
        {
            return Color;
        }
        public double getArea()
        {
            return Area = Math.PI * R * R;
        }
        public override string ToString()
        {
            return "Co R = " + getR() + "  Area =  "+ getArea() +"  Color  " + getColor();
        }
    }
}