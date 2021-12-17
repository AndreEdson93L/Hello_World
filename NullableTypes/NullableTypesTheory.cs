using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    public class NullableTypesTheory
    {
        //Value Types

        /*
         * Cannot be null
         * bool hasAccess = true; // or false
         */

        //Database

        //Customers.Birthday (datetime NULL)
        public static void VirtualMain()
        {
            //Nullable<DateTime> date = null;
            DateTime? date = null; //<- Nullable type

            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            Console.WriteLine("Value: " + date.Value);

            Console.WriteLine();

            DateTime? dateX = new DateTime(2014, 1, 1);

            //DateTime date2 = date; error
            DateTime date2 = dateX.GetValueOrDefault();

            DateTime? date3 = date2;
            Console.WriteLine(date3.GetValueOrDefault());
        }
        public static void VMain()
        {
            //Null Coalescing Operator
            //First way...
            DateTime? date = null;
            DateTime date2;


            if (date != null)
                date2 = date.GetValueOrDefault();
            else
                date2 = DateTime.Today;


            Console.WriteLine(date2);
            Console.WriteLine();

            //Null Coalescing Operator
            //Second way...
            DateTime? dateCool = null;
            DateTime dateDue = dateCool ?? DateTime.Today; //if has a value initializes dateCool, otherwise use DateTime.Today
            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;
        }
    }
}
