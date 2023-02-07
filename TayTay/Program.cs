using System;
using System.Diagnostics.Metrics;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            char[][] words = new char[str.Length][];
            string[][] russian = new string[str.Length][];
            for (int i = 0; i<str.Length; i++)
            {
                words[i] = str[i].ToArray();
            }
            int countletter = 0;
            int countword = 0;
            for (int i = str.Length/2; i<str.Length;i++)
            {
                string[] word = new string[words[i].Length];
                for (int j = words[i].Length/2; j< words[i].Length;j++)
                {
                    word[countletter] = Convert.ToString(words[i][j]);
                    countletter+= 2;
                }
                countletter = 1;
                for (int j = words[i].Length/2-1; j > -1; j--)
                {
                    word[countletter] = Convert.ToString(words[i][j]);
                    countletter+= 2;
                }
                russian[countword] = word;
                countword += 2;
                countletter = 0;
            }
            countletter = 0;
            countword = 1;
            for (int i = (str.Length / 2)-1; i > -1; i--)
            {
                string[] word = new string[words[i].Length];
                for (int j = words[i].Length / 2; j < words[i].Length; j++)
                {
                    word[countletter] = Convert.ToString(words[i][j]);
                    countletter += 2;
                }
                countletter = 1;
                for (int j = words[i].Length / 2 - 1; j > -1; j--)
                {
                    word[countletter] = Convert.ToString(words[i][j]);
                    countletter += 2;
                }
                russian[countword] = word;
                countword+= 2;
                countletter = 0;
            }
            for (int i = 0; i < russian.Length;i++)
            {
                for (int j = 0; j < russian[i].Length;j++)
                {
                    Console.Write(russian[i][j]);
                }
                Console.Write(" ");
            }
        }
    }
}
