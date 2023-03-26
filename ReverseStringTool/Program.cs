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
        }
    }
}