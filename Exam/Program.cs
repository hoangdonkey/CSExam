using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            People pp = new People();
            pp.addPeople("Dung", true, 29);
            System.Console.WriteLine(pp.display());
            pp.Increment();

            //Ex2
            Search srch = new Search();
            Console.WriteLine("Enter a String");
            String aString = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            String aWord = Console.ReadLine();
            int result = Search.SearchString(aString, aWord);
            Console.WriteLine("The word \"" + aWord + "\" was found " + result + " times in the string");

            Console.ReadKey();
        }
    }
}
