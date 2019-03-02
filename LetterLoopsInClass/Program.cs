using System;
//using System.Collections.Generic;
using System.Linq;

namespace LetterLoopsInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some Letters!");
            var input = Console.ReadLine().ToLower();
            var loopCount = 0;
            //var myCharacters = new List<string>();

            //foreach (var character in input)
            //{
            //    var letterString = character.ToString().ToUpper();
            //        letterString +=  new string(character, loopCount);
            //    myCharacters.Add(letterString);
            //    loopCount++;
            // where the varible being incremented. so if it is ++loopcount then it will display 2 and starts.
            // }
            //Console.WriteLine(string.Join('-', myCharacters));
            var output = string.Join('-', input.ToCharArray().Select(x => x.ToString().ToUpper() + new string(x, loopCount++)));
            //Select is method like map it does for loop and call anonymous function or linq
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
