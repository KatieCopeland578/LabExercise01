using System;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace LabExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("input.txt"))
            {
                Console.WriteLine("File exists.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }

            string data = null;
            
            using (var reader = new StreamReader("input.txt"))
            {
                data = reader.ReadToEnd();
                data = data.ToLower();
                data = StripPunctuation(data);
                data = SortAlphabetically(data);
                
            }

            Console.ReadKey();
        }

        public static string StripPunctuation(string data)
        {
            var sb = new StringBuilder();
            foreach (char character in data)
            {
                if(!char.IsPunctuation(character))
                {
                    sb.Append(character);
                }
            }
            return sb.ToString();
        }

        public static string SortAlphabetically(string data)
        {
            string[] words;
            words = data.Split(' ');
            Array.Sort(words);
            var sb = new StringBuilder();
            foreach(string word in words)
            {
                sb.Append(word);
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
