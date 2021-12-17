using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace CSharpFundamentalsOOP
{
    public class Esempi
    {
        //upcasting is implicit, int to long
        //downcasting is explicit, long to short
        public static void PrimoEsempio()
        {
            //MAIN
            Texture texture = new Texture();

            //downcasting conversion
            Shape shape = texture;

            texture.Width = 200;
            shape.Width = 100;

            //It will display 100 (they reference the same object)
            Console.WriteLine(texture.Width);
        }
        public static void SecondoEsempio()
        {
            //we can pass any object that derives from the stream class without any convertion
            StreamReader reader = new StreamReader(new MemoryStream());

            //not safe because we can pass every kind of type
            var list = new ArrayList();
            list.Add(1);
            list.Add("Andrea Edson");
            list.Add(new Texture());

            foreach (var item in list)
                Console.WriteLine(item);

            var saferList = new List<Shape>();
            saferList.Add(new Shape());
            saferList.Add(new Shape());
            saferList.Add(new Shape());

            foreach (var item in saferList)
                Console.WriteLine(item);
        }
        public static void TerzoEsempio()
        {
            Shape shape = new Texture();

            //downcasting
            Texture texture = (Texture)shape;
        }
    }
}
