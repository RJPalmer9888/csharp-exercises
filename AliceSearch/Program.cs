using System;

namespace AliceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string Alice;
            string Alice_l;
            string input1;
            bool match;

            Alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine(Alice);
            Alice_l = Alice.ToLower();

            Console.WriteLine("I can search this sentence for a phrase");
            Console.WriteLine("What phrase do you want me to search for?");
            input1 = Console.ReadLine();

            match = Alice_l.Contains(input1);
            Console.WriteLine(match);
            Console.ReadLine();
        }
    }
}
