using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class TheoryExceptionHandling
    {
        public static void VirtalMain()
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by 0.");
            }
            catch (ArithmeticException ex)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            finally
            {

            }
        }
        public static void VMain()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\Users\Computer\Desktop");
                var content = streamReader.ReadToEnd();
                throw new Exception("Hey buddy");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }
        }
        public static void VTMain()
        {
            try
            {
                using (var streamReader = new StreamReader(@"C:\Users\Computer\Desktop"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
        }
    }
}
