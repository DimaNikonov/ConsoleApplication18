using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleApplication18
{
    class CharCount
    {
        public void FileSplit(string FileName)
        {
            string s;
            s = File.ReadAllText("Text.txt");
        }
    }
    
    class Program
    {        
        static void Main(string[] args)
        {
            int count = 0;
            string s;
            s = File.ReadAllText("Text.txt");
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (dict.Keys.Contains(item))
                {
                   dict[item]++;
                } else
                    dict.Add(item, 1); 
            }

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
        }
    }
}
