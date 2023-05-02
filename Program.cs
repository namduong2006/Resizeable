using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ComperableCircle[] circles = new ComperableCircle[3];
            //circles[0] = new ComperableCircle(3.6);
            //circles[1] = new ComperableCircle();
            //circles[2] = new ComperableCircle(3.5, "indigo", false);

            //Console.WriteLine("Pre-sorted:");
            //foreach (ComperableCircle circle in circles)
            //{
            //    Console.WriteLine(circle);
            //}

            //Array.Sort(circles);

            //Console.WriteLine("After-sorted:");
            //foreach (ComperableCircle circle in circles)
            //{
            //    Console.WriteLine(circle);
            //}
            //Rectangle[] rectangles = new Rectangle[3];
            //rectangles[0] = new Rectangle(4, 9);
            //rectangles[1] = new Rectangle();
            //rectangles[2] = new Rectangle(5, 7, "Red", false);
            //Console.WriteLine("Pre-sorted:");
            //foreach (Rectangle rectangle in rectangles)
            //{
            //    Console.WriteLine(rectangle);
            //}

            //Array.Sort(rectangles);

            //Console.WriteLine("After-sorted:");
            //foreach (Rectangle rectangle in rectangles)
            //{
            //    Console.WriteLine(rectangle);
            //}
            /////////////////////////////////////////////////////////////
            //Circle[] circles = new Circle[3];
            //circles[0] = new Circle(3.6);
            //circles[1] = new Circle();
            //circles[2] = new Circle(3.5, "indigo", false);

            //Console.WriteLine("Pre-sorted:");
            //foreach (Circle circle in circles)
            //{
            //    Console.WriteLine(circle);
            //}

            //IComparer<Circle> circleComparator = new CircleComparer();
            //Array.Sort(circles, circleComparator);

            //Console.WriteLine("After-sorted:");
            //foreach (Circle circle in circles)
            //{
            //    Console.WriteLine(circle);
            //}
            //Rectangle[] rectangles = new Rectangle[3];
            //rectangles[0] = new Rectangle(4,9);
            //rectangles[1] = new Rectangle();
            //rectangles[2] = new Rectangle(5,7,"Red",false);
            //Console.WriteLine("Pre-sorted:");
            //foreach (Rectangle rectangle in rectangles)
            //{
            //    Console.WriteLine(rectangle);
            //}
            //IComparer<Rectangle> rectanglesComparator = new RectangleComparer();
            //Array.Sort(rectangles, rectanglesComparator);

            //Console.WriteLine("After-sorted:");
            //foreach (Rectangle rectangle in rectangles)
            //{
            //    Console.WriteLine(rectangle);
            //}
            //////////////////////////////
            ///
            
            double t,n;           
            Random random = new Random();
            n = random.NextDouble();
            t = n+1;
            Console.WriteLine($"TANG KICH THUOC {n*100}%");
            Console.WriteLine("RECTANGLE");
            Rectangle rectangle = new Rectangle();            
            rectangle.Resize(n);            
            Rectangle[] rectangles = new Rectangle[3];
            rectangles[0] = new Rectangle(4, 6);
            rectangles[1]=new Rectangle(8,5 );
            rectangles[2]=new Rectangle(9,6);
            Console.WriteLine("AREA-Pre");
            Console.WriteLine("======================================");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(rectangles[i]);                
                Console.Write("AREA:");
                Console.WriteLine(rectangles[i].getArea());
                rectangles[i].Resize(t);
            }
            Console.WriteLine("=========================");
            Console.WriteLine("AREA-After");
            Console.WriteLine("===========================================");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(rectangles[i]);
                Console.Write("AREA:");
                Console.WriteLine(rectangles[i].getArea());                
            }
            Console.WriteLine("============================ \n CIRCLES");
            Circle circle = new Circle();
            Circle[] circles = new Circle[3];
            circles[0] = new Circle(11.2);
            circles[1] = new Circle(7.9);
            circles[2] = new Circle(3.5);

            Console.WriteLine("Pre-sorted:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(circles[i]);
                Console.Write("AREA : ");
                Console.WriteLine(circles[i].getArea());               
                circles[i].Resize(t);
            }
            Console.WriteLine("After-sorted:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(circles[i]);
                Console.Write("AREA : ");
                Console.WriteLine(circles[i].getArea());                
            }
            Console.ReadLine();
        }
        
    }
}
