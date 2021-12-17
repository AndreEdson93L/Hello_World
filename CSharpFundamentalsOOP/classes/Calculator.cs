using System;
namespace CSharpFundamentalsOOP
{
    public class Calculator
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public static void VirtualMain()
        {
            Console.WriteLine(Calculator.Add(4, 9, 4, 2));
            Console.WriteLine(Calculator.Add(new int[] { 1, 2, 5, 6}));

            var number0 = int.Parse("1");
            Console.WriteLine(number0);

            int num0;
            var result0 = int.TryParse("numero uno", out num0);

            int num1;
            var result1 = int.TryParse("numero uno", out num1);

            //first attempt
            if (result0)
                Console.WriteLine(num0);
            else
                Console.WriteLine("Conversion failed");

            //second attempt
            if (result1)
                Console.WriteLine(num1);
            else
                Console.WriteLine("Conversion failed");

            //third attempt
            try
            {
                var number1 = int.Parse("uno");
                Console.WriteLine(number1);
            }
            catch (Exception message)
            {

                Console.WriteLine(message);
            }
        }
    }
}
