using System;

namespace AbstractClassesAndMembers
{
    public class AbstractTheory
    {
        public static void VMain()
        {
            //Cannor create an instance of the abstract class "AbstractClasses.Shape"
            //var shape = new Shape();

            //Visualizza/Visualizzatore di oggetti

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
        //Abstract Modifier
        //indicates that a class or a member is missing implementation

        //RULES
        //1 Rule
        //Do not include implementation
        //public abstract void Draw();

        //2 Rule
        //If a member is declared as abstract, the containing class need to
        //be declared as abstract too

        /*
         public abstract class Shape
         {
            public abstract void Draw();
         }
         */

        //3 rule
        //Must implement all absctract members in the base abstract class.

        /*
         public class Circle : Shape
         {
            public override void Draw()
            {
                //Implementation for Circle
            }
        }
         */

        //4 rule
        //Cannot be instantiated

        //var shape = new Shape(); //Won't compile

        //Why to use Abstract?
        //When you want to provide some common behaviour, while forcing
        //other developers to follow your design.
    }
}
