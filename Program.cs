using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Прямоугольник: ");
            Rectangle ABCD = new Rectangle(3.792, 5.031);
            ABCD.Print();

            Console.WriteLine("Квадрат: ");
            Square EFGH = new Square(9.254);
            EFGH.Print();

            Console.WriteLine("Круг: ");
            Circle OR = new Circle(7.598);
            OR.Print();

            Console.ReadLine();
        }
    }

    public interface IPrint
    {
        void Print();
    }

    public abstract class Geometric_figure
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    public class Rectangle : Geometric_figure, IPrint
    {
        private double m_Weight;
        private double m_Height;

        public double Height
        {
            get
            {
                return this.m_Height;
            }
            set
            {
                if (value > 0)
                    this.m_Height = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.m_Weight;
            }
            set
            {
                if (value > 0)
                {
                    this.m_Weight = value;
                }
            }
        }

        public Rectangle(double weight_intro, double height_intro)
        {
            Weight = weight_intro;
            Height = height_intro;
        }

        public override double Area()
        {
            return m_Weight * m_Height;
        }

        public override string ToString()
        {
            string temp = "Ширина: " + m_Weight + " Длина: " + m_Height + " Площадь: " + Area();
            return temp;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }
    }

    public class Square : Geometric_figure, IPrint
    {
        private double m_Side;

        public double Side
        {
            get
            {
                return this.m_Side;
            }
            set
            {
                if (value > 0)
                    this.m_Side = value;
            }
        }

        public Square(double side_intro)
        {
            Side = side_intro;
        }

        public override double Area()
        {
            return m_Side * m_Side;
        }

        public override string ToString()
        {
            string temp = "Сторона: " + m_Side + " Площадь: " + Area();
            return temp;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }
    }

    public class Circle : Geometric_figure, IPrint
    {
        private double m_Radius;

        public double Radius
        {
            get
            {
                return this.m_Radius;
            }
            set
            {
                if (value > 0)
                    this.m_Radius = value;
            }
        }

        public Circle(double radius_intro)
        {
            Radius = radius_intro;
        }

        public override double Area()
        {
            return Math.PI * m_Radius * m_Radius;
        }

        public override string ToString()
        {
            string temp = "Радиус: " + m_Radius + " Площадь: " + Area();
            return temp;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }
    }
}