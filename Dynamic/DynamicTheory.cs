using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    public class DynamicTheory
    {
        //Programming languages

        //Statically typed languages: C#, Java
        //Dynamically-typed languages: Ruby, Javascript, Python

        //Type resolution

        //Static languages: at compile-time
        //Dynamic languages: at run-time

        //Benefits

        //Static languages: early feedback (compile-time)
        //Dynamic languages: easier and faster to code

        //C# History

        //Started as a static language
        //.NET 4 added the dynamic capability, to improve interoperability with
        //  - COM (eg writing office applications)
        //  - Dynamic languages (IronPython)
        public static void VirtualMain()
        {
            //REFLECTION
            object obj = "Andrea Edson";
            //obj.GetHashCode();

            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            //DYNAMIC
            dynamic excelObject = "Cell1 Cell2 ...";
            excelObject.Optimize();

            //On .NET 4
            //DILR seats on top of CILR and gives dynamic language capability to C#
        }
    }
}
