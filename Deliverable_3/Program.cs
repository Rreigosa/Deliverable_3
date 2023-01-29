using System.Security.Cryptography.X509Certificates;

namespace Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            while (true)
            {
                Console.WriteLine("Enter a number between 1 and 100: ");
                input = int.Parse(Console.ReadLine());

                if (input >= 1 && input <= 100)
                    break;

                else
                    Console.WriteLine("input not valid");
            }

            while (true)
            {
                Console.WriteLine("specify the saries type: Even or Odd ");
                series = Console.ReadLine();

                if (series == "Odd" || series == "Even")
                    break;

                else
                    Console.WriteLine("input not valid");
            }
            

            if (series == "Odd")
            {
                Console.WriteLine("You have selected " + series + " series. The numbers betwee 0 and " + input + " are:");
                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            if (series == "Even")
            {
                Console.WriteLine("You have selected " + series + " series. The numbers betwee 0 and " + input + "are:");
                for (int i = 0; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}