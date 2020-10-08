using System;
using System.IO;
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
            string[] words;
            using (var reader = new StreamReader("input.txt"))
            {
                data = reader.ReadToEnd();
                data = data.ToLower();
                StripPunctuation(data);
                words = data.Split(' ');
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
    }
}
