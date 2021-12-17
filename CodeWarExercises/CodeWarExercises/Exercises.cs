using System;
using System.Collections.Generic;

namespace CodeWarExercises
{
    partial class Program
    {
        public class Exercises
        {
            
            public static long FindNextSquare(long num)
            {
                //return the next square if the actual number is a perfect square, otherwise it return -1
                //121 -> 144
                //123 -> -1
                return Math.Sqrt(num) % 1 == 0 ? (long)Math.Pow(Math.Sqrt(num) + 1, 2) : -1;
            }

            public static string GetMiddle(string s)
            {
                //se la parola è pari/even ritorna le due lettere nel mezzo, mentre se è dispari/odd ritorna la sola lettera nel mezzo.
                //calamarone -> ma
                //lucertola -> r
                return s.Length % 2 == 0 ? s.Substring(s.Length / 2 - 1, 2) : s.Substring(s.Length / 2, 1);
            }

            public static string NoSpace(string input)
            {
                //Simple, remove the spaces from the string, then return the resultant string.
                //"Adn A " -> "AdnA"
                //"A     " -> "A"
                
                var noSpaceString = "";

                foreach (var letter in input)
                    if (!(letter == ' ')) noSpaceString += letter;

                return noSpaceString;
            }
            public static int[] DiffArray(int[] houseNumbers, int[] thiefNumbers)
            {
                //Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.
                //It should remove all values from list houseNumbers, which are present in list thiefNumbers keeping their order.
                //Kata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }) => new int[] { 2 }
                //Kata.ArrayDiff(new int[] { 1, 2, 2, 2, 3 }, new int[] { 2 }) => new int[] { 1, 3 }
                
                List<Int32> mergeList = new List<Int32>(houseNumbers); 

                for (int i = 0; i < thiefNumbers.Length; i++)
                {
                    for (int j = 0; j < houseNumbers.Length; j++)
                        if (houseNumbers[j] == thiefNumbers[i]) mergeList.Remove(thiefNumbers[i]);
                }

                return mergeList.ToArray();
            }

            public static int GetVowelCount(string str)
            {
                //Return the number(count) of vowels in the given string.
                //We will consider a, e, i, o, u as vowels for this Kata(but not y).
                //The input string will only consist of lower case letters and / or spaces.

                int vowelCount = 0;

                foreach (var letter in str)
                {
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                        vowelCount++;
                }

                return vowelCount;
            }
            public static bool LoveFlower(int flower1, int flower2)
            {
                //Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each. 
                //If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.
                //Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.
                return (flower1 + flower2) % 2 == 1;
            }
            public static int sumTwoSmallestNumbers(int[] numbers)
            {
                Array.Sort(numbers);
                int result = (numbers.Length >= 2) ? numbers[0] + numbers[1] : -1;
                return result;
            }
            public static int PositiveSum(int[] arr)
            {
                //You get an array of numbers, return the sum of all of the positives ones.
                //Example[1, -4, 7, 12] => 1 + 7 + 12 = 20
                //Note: if there is nothing to sum, the sum is default to 0.
                int sum = 0;
                foreach (var n in arr)
                    if (n >= 0)
                        sum += n;
                return sum;
            }
            public static int FindShort(string s)
            {
                var words = s.Split(" ");
                int shortest = words[0].Length;
                foreach (var word in words)
                {
                    if (word.Length < shortest)
                        shortest = word.Length;
                }
                return shortest;
            }
            public static bool IsValidWalk(string[] walk)
            {
                if (walk.Length != 10) return false;
                var x = 0; var y = 0;
                foreach (var dir in walk)
                {
                    if (dir == "n") y++;
                    else if (dir == "s") y--;
                    else if (dir == "e") x++;
                    else if (dir == "w") x--;
                }
                return x == 0 && y == 0;
            }
            public static int Test(string numbers)
            {
                int[] array = Array.ConvertAll(numbers.Split(" "), s => Convert.ToInt32(s));
                int countOdd = 0, countEven = 0, correctSolution = 0;
                bool condition = true;

                foreach (var num in array)
                {
                    if (num % 2 == 0) countEven++;
                    else countOdd++;
                }

                for (int i = 0; i < array.Length; i++)
                {
                    condition = (countOdd < countEven) ? !(array[i] % 2 == 0) : array[i] % 2 == 0;
                    if (condition) correctSolution = i + 1;
                }

                return correctSolution;
            }
            public static string OddOrEven(params int[] array)
            {
                int sum = 0;
                foreach (var n in array)
                {
                    sum += n;
                }

                var returnMessage = (sum % 2 == 0) ? "even" : "odd";
                return returnMessage;
            }
            public static string DispariOPari(int[] array)
            {
                return array.Sum() % 2 == 0 ? "pari" : "dispari";
            }
        }
    }
}

