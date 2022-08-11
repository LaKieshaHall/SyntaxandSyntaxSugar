using System;

namespace SyntaxandSyntaxSugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var answer = 4; /*inferred*/
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine"; /*Ternary if else*/
            Console.WriteLine(response); /*replies to what the user entered*/
           
        }
    }
}
