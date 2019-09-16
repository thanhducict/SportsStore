using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SnippetCode
{
    class Program
    {
        // Useful code snippets
        static void Main(string[] args)
        {
            Console.WriteLine("\n=== CODE SNIPPETS ===\n");
            // Write all Console output to a text file.
            // ConsoleToText();

            // Cut a few words in a sentence or a paragraph then add "..." to the end
            GetWordsInParagraph();

            Console.ReadKey();
        }

        #region Write all Console output to a text file
        public static void ConsoleToText()
        {
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("Output.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);

            Console.WriteLine("=== OUTPUT ===");
            Console.WriteLine("Everything written to Console.Write() or");
            Console.WriteLine("Console.WriteLine() will be written to a file");

            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("Done");
        }
        #endregion
        #region Cut a few words in a sentence or a paragraph then add ... to the end
        public static void GetWordsInParagraph()
        {
            string p = @"
                    what the hell is, this how can I do it
                        
                    ";

            MatchCollection wordColl = Regex.Matches(p, @"[\S]+");
            StringBuilder sb = new StringBuilder();
            if (wordColl.Count > 5)
            {
                foreach (var subWord in wordColl.Cast<Match>().Select(r => r.Value).Take(5))
                {
                    sb.Append(subWord);
                    sb.Append(" ");
                }
            }

            Console.WriteLine(sb.Append("..."));
        }
        #endregion
    }
}