using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextFileAnalyzer textFile;
            if (args.Length > 0)
            {
                textFile = new TextFileAnalyzer(args[0]);
            }
            else
            {
                textFile = new TextFileAnalyzer(System.Console.ReadLine());
            }
            System.Console.WriteLine("Number of spaces in file: " + textFile.SpaceNumber);
            System.Console.WriteLine("Number of letters in file: " + textFile.LettersNumber);   
        }
    }
}
