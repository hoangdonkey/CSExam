using System;
namespace Exam
{
    public class Search
    {
        public Search()
        {
        }
        public static int SearchString(string str, string word)
        {
            int index = 0;
            int count = 0;
            while ((index = str.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                index++;
                count++;
            }
            return count;
        }
    }
}
