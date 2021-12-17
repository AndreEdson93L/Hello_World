using System;

namespace CSharpFundamentalsOOP
{
    public class Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        //method overload
        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Move(Point newLocation)
        {
            //defensive programming
            if (newLocation == null)
                throw new ArgumentNullException("newLocation is set to null");
            Move(newLocation.X, newLocation.Y);
            //X = newLocation.X;
            //Y = newLocation.Y;
        }
        public static void VirtualMain()
        {
            try
            {
                var point = new Point(5, 15);
                Console.WriteLine("The current object is at the position x: {0}, y: {1}", point.X, point.Y);

                point.Move(new Point(10, 5));
                Console.WriteLine("The current object is at the position x: {0}, y: {1}", point.X, point.Y);

                point.Move(20, 0);
                Console.WriteLine("The current object is at the position x: {0}, y: {1}", point.X, point.Y);

                point.Move(null);
                Console.WriteLine("The current object is at the position x: {0}, y: {1}", point.X, point.Y);
            }
            catch (Exception message)
            {
                //path to the error
                Console.WriteLine(message.StackTrace);
            }
        }
    }
}
