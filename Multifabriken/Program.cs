namespace Multifabriken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till Multifabriken!");
                Console.WriteLine("1. Beställ en bil");
                Console.WriteLine("2. Beställ godis");
                Console.WriteLine("3. Beställ ett rör");
                Console.WriteLine("4. Beställ havremjölk");
                Console.WriteLine("5. Visa dina beställningar");
                Console.WriteLine("6. Avsluta programmet");
                Console.WriteLine("Välj ett alternativ:");

                switch (Console.ReadLine())
                {
                    case "1":
                        //add order car method
                        break;

                    case "2":
                        // add order candy method
                        break;

                    case "3":
                        // add order pipe method
                        break;

                    case "4":
                        // add order oatmilk method
                        break;

                    case "5":
                        // show list
                        break;

                    case "6":
                        isRunning = false; 
                        break;

                    default: 
                        Console.WriteLine("Ogiltigt val, tryck på valfri tangent för nytt försök.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
