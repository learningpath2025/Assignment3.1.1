using System.Text;

namespace Assignment3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Even Numbers: {ReturnEvenNumbers()}");
        }

        public static string ReturnEvenNumbers()
        {
            StringBuilder evenNumbers = new StringBuilder();
            for (int i = 2; i < 100; i += 2)
            {
                evenNumbers.Append(i);
                if (i < 98)
                {
                    evenNumbers.Append(" ");
                }
            }
            return evenNumbers.ToString();
        }
    }
}
