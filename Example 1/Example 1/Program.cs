using System;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu program komputer yang dapat mengenali, meringkas, menerjemahkan, memprediksi, dan menghasilkan teks";
            Console.WriteLine(text);
            int start = text.IndexOf('(');
            int end = text.IndexOf(')');
            start += 1;

            int length = end - start;
            Console.WriteLine($"\nOutput: \n{text.Substring(start, length)} ");
        }
    }
}