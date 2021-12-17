using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    //NOTE: we can implement multiple interfaces
    //NOTE: a class implement an interface, an interface is simply a contract

    /* We are making sure that the public interface of our class has the methos or the members as declared in the interfaces*/

    //INTERFACE
    
    /* Interfaces are used to build to loosely coupled extensible and testable application */
    /* Interfaces can provide polymorphic bheaviour*/
    public class TextBox : UiControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }
    public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }
        public virtual void Draw()
        {

        }
        public void Focurs()
        {
            Console.WriteLine("Received focus");
        }
    }
}
