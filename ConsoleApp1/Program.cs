using System;

namespace ConsoleAppStartE
{
    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintPoint()
        {
            // Use 'this' to refer to the current instance's fields
            Console.WriteLine("({0},{1})", this.x, this.y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1;
            p1.x = 3;
            p1.y = 5;
            p1.PrintPoint(); // Now it will print: (3,5)

            Point p2;
            p2.x = Convert.ToInt32(Console.ReadLine());
            p2.y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("({0},{1})", p2.x, p2.y);

            Point p3 = p1;
            p3.x++;
            p3.y--;
            p3.PrintPoint();

            int ax = 10 ,bx = 20 ,cx = 30 ;
            Console.WriteLine("ax: " + ax + ", bx: " + bx + ", cx: " + cx);
            Console.WriteLine("ax: {0}, bx: {1}, cx: {2}", ax, bx, cx);

            ///string 
            Console.Write("Input : ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Output : {0} ", s1);

            ///Int
            Console.Write("Input2 : ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Output : {0} ", s2);

        }
        
    }
}
