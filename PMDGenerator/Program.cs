using System;
using System.Collections.Generic;
using System.Text;

namespace PMDGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var touchInputs = new Dictionary<char, string>
            {
                { 'C', "t:33:67" },
                { 'F', "t:49:67" },
                { 'H', "t:61:67" },
                { 'J', "t:71:67" },
                { 'K', "t:76:67" },
                { 'M', "t:88:67" },
                { 'N', "t:22:73" },
                { 'P', "t:33:73" },
                { 'Q', "t:38:73" },
                { 'R', "t:44:73" },
                { 'S', "t:49:73" },
                { 'T', "t:55:73" },
                { 'W', "t:71:73" },
                { 'X', "t:77:73" },
                { 'Y', "t:82:73" },
                { '1', "t:27:79" },
                { '2', "t:33:79" },
                { '3', "t:38:79" },
                { '4', "t:44:79" },
                { '5', "t:49:79" },
                { '6', "t:55:79" },
                { '7', "t:60:79" },
                { '8', "t:65:79" },
                { '9', "t:71:79" },
                { '0', "t:77:79" },
                { '.', "t:87:79" },
                { '+', "t:21:85" },
                { '-', "t:27:85" },
                { '!', "t:43:85" },
                { '?', "t:49:85" },
                { '#', "t:77:85" },
                { '%', "t:82:85" }
            };

            while (true)
            {
                var input = Console.ReadLine();
                var output = new StringBuilder();

                if (input == null) return;

                foreach (var c in input.ToCharArray())
                {
                    if (touchInputs.TryGetValue(c, out var charValue)) output.Append(charValue + ",");
                }

                Console.WriteLine(output.ToString());
            }
        }
    }
}
