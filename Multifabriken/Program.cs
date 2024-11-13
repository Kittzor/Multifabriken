namespace Multifabriken
{
    internal class Program
    {
        static List<object> orders = new List<object>();

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
                        OrderCar();
                        break;

                    case "2":
                        OrderCandy();
                        break;

                    case "3":
                        OrderPipe();
                        break;

                    case "4":
                        OrderOatmilk();
                        break;

                    case "5":
                        ListOrders();
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

        static void OrderCar()
        {
            Console.WriteLine("Ange registreringsnummer: ");
            string regNumber = Console.ReadLine();
            Console.WriteLine("Ange färg: ");
            string color = Console.ReadLine();
            Console.WriteLine("Ange modell: ");
            string brand = Console.ReadLine();

            Car car = new Car(regNumber, color, brand);
            orders.Add(car);
        }

        static void OrderCandy()
        {
            Console.WriteLine("Ange smak: ");
            string flavour = Console.ReadLine();
            Console.WriteLine("Ange antal: ");
            int quantity = int.Parse(Console.ReadLine());

            Candy candy = new Candy(flavour, quantity);
            orders.Add(candy);
        }

        static void OrderPipe()
        {
            Console.WriteLine("Ange diameter: ");
            int diameter = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange längd: ");
            int length = int.Parse(Console.ReadLine());

            Pipe pipe = new Pipe(diameter, length);
            orders.Add(pipe);
        }

        static void OrderOatmilk()
        {
            Console.WriteLine("Ange fetthalt: ");
            int fatContent = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange litermängd: ");
            int literAmount = int.Parse(Console.ReadLine());

            Oatmilk oatmilk = new Oatmilk(fatContent, literAmount);
            orders.Add(oatmilk);
        }

        static void ListOrders()
        {
            Console.Clear();
            Console.WriteLine("Dina beställnigar: ");

            foreach (var order in orders)
            {
                Console.WriteLine(order.ToString());
            }
            Console.WriteLine("Tryck på valfri tangent för att fortsätta.");
            Console.ReadKey();
        }
    }
}
