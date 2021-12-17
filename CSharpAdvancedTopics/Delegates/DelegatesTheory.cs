using CSharpAdvancedTopics.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTopics.Generics
{
    public class DelegatesTheory
    {
        public static void VirtualMain()
        {
            var dizionario = new Dictionary<string, string>();
            dizionario.Add("Delegates", "-An object that knows hot to call a method (or a group of methods)" +
                "\n-A reference to a function");
            dizionario.Add("Why do we need delegates?", "-For designing extensible and flexible applications (eg frameworks)" +
                "\n-Alternative: Interfaces");
            dizionario.Add("Interfaces or Delegates?", "-An eventing design pattern is used." +
                "\n-The caller doesn't need to access other properties or methods on the object implementing the method.");

            foreach (var value in dizionario)
            {
                Console.WriteLine("Key: {0}\n{1}\n",value.Key, value.Value);
            }
        }
        public static void VMain()
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
        }
        public static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
