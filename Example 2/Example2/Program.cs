using System;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu program komputer yang dapat (mengenali), (meringkas), (menerjemahkan), (memprediksi), dan (menghasilkan teks)";
            Console.WriteLine(text);
            Console.WriteLine("\nOutput:");
            while (true)
            {
                int start = text.IndexOf('(');
                if (start == -1) break;

                start += 1;
                int end = text.IndexOf(')');
                int length = end - start;
                Console.WriteLine($"-{text.Substring(start, length)}");
                text = text.Substring(end + 1);
            }
        }
    }
}