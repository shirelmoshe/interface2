using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape
{

    interface IShape
    {

        public int frametHickness { get; set; }
        public string frameColor { get; set; }
        public int codcodim { get;  }
    }
    internal class Rectangle : IShape
    {
        protected int Length { get; }
        protected int width { get; }
        public int frametHickness { get; set; }
        public string frameColor { get; set; }

        public int codcodim { get { return 4; } } 
        public Rectangle(int aframetHickness, string aframeColor, int awidth, int aLength)
        {
            frameColor = aframeColor;
            frametHickness = aframetHickness;
            Length = aLength;
            width = awidth;


        }
        public int vertices()
        {

            return 4;
        }

    }

    internal class Circle : IShape
    {
        public int codcodim { get { return 0; } }
        public int frametHickness { get; set; }
        public string frameColor { get; set; }
        public int radiusLength { get; set; }
        public Circle(int aframetHickness, string aframeColor, int aradiusLength)
        {
            frameColor = aframeColor;
            frametHickness = aframetHickness;
            radiusLength = aradiusLength;
        }
        public void Roll()
        {
            MessageBox.Show("Circle");
        }

    }
    internal class ellipse : Circle
    {
        public int frametHickness { get; set; }
        public string frameColor { get; set; }
        public int radiusLength { get; set; }
        public int radiusLength2 { get; set; }

        public ellipse(int aframetHickness, string aframeColor, int aradiusLength, int aradiusLength2) : base(aframetHickness, aframeColor, aradiusLength)
        {
            this.frameColor = aframeColor;
            this.frametHickness = aframetHickness;
            this.radiusLength = aradiusLength;
            this.radiusLength2 = aradiusLength2;
        }
        public void Roll()
        {
            MessageBox.Show("ellipse");
        }

    }

    internal class Triangle : IShape
    {
         public int codcodim { get { return 3; } }
        public int frametHickness { get; set; }
        public string frameColor { get; set; }
        public int Length { get; }
        public int widthTriangle { get; }
        public Triangle(int aframetHickness, string aframeColor, int awidth, int aLength)
        {
            this.frameColor = aframeColor;
            this.frametHickness = aframetHickness;
            this.Length = aLength;
            this.widthTriangle = awidth;

        }
        public int vertices()
        {

            return 3;
        }

    }

    internal class Moon : IShape
    {
        public int codcodim { get { return 2; } }
        public int frametHickness { get; set; }
        public string frameColor { get; set; }
        public int distance { get; set; }
        public Moon(int aframetHickness, string aframeColor, int adistance)
        {
            this.frameColor = aframeColor;
            this.frametHickness = aframetHickness;
            this.distance = adistance;


        }
        public int vertices()
        {

            return 2;
        }
        public void Roll()
        {
            MessageBox.Show("Moon");
        }
        
    }
    internal class Runner
    {

        Circle circle1 = new Circle(7, "RED", 6);
        public void Run()
        {
            circle1.Roll();
            
        }
        
        public  IShape Max(IShape shape1,IShape shape2){
            if (shape1.codcodim < shape2.codcodim)
            {
                return shape2;
            }
            else
            {
                return shape1;
            }
        
        }

    }
}

  

