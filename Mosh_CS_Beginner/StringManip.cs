using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// toLower()
// toUpper()
// Trim() removes white spaces
// Substring(startIndex) or (startIndex, length)
// Replace()
// IsNullOrEmpty or IsNullOrWhiteSpace. NullOrWhiteSpace avoids ' '.Trim() for checking with just IsNullOrEmpty
// Split()
// Convert.ToInt32 or Int.Parse (Int.Parse throws an exception, Convert returns default)
// ToString()
// Join()
// StringBuilder and its methods


namespace Mosh_CS_Beginner
{
    class StringManip
    {
        static void Main(string[] args)
        {
            var fullName = "RM Terrell ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim()); // Trim example
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper()); // ToUpper example

            var index = fullName.IndexOf(' '); // Exampe of index split
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            var names = fullName.Split(' '); //Much easier to use this split method. names[0] and names[1] to access

            var sentence = "This is a very long testing sentence for the purpose of testing the new textSummarizer method. Words. Words words words.";
            var summary = TextSummarizer(sentence, 25);

            Console.WriteLine(summary);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static string TextSummarizer(string text, int maxLength = 20) // method for summarizing a block of text with "stuff stuff stuff....." without cutting off words
        {

            
            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach(var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;

            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}
