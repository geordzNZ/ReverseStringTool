namespace ReverseStringTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Header section
            Console.WriteLine("\t\t\tWELCOME");
            Console.WriteLine("\t\t  String Reversing Tool");
            Console.WriteLine("==========================================================\n");

            // Retrieve User input
            Console.Write($"\tPlease enter text to be reversed...\n\t");
            string textToBeReversed = Console.ReadLine();

            // Process User input
            string reversedText = "";
            for (var i = textToBeReversed.Length - 1; i >= 0; i--)
            {
                reversedText += textToBeReversed[i];
            }

            // Output results
            Console.WriteLine($"\n\tYour reversed text is '{reversedText}'");

            if (textToBeReversed == reversedText)
            {
                Console.WriteLine($"\tYou entered some Palindrome text... Cool!!");
            }
        }
    }
}