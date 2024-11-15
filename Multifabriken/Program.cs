namespace Multifabriken
{
    internal class Program
    {
        //Created the list outside the Main class so it can be reached by multiple methods
        static List<object> orders = new List<object>();

        static void Main(string[] args)
        {
            
            // Variabel to handle the main loop of the program
            bool isRunning = true;

            while (isRunning)
            {
                //Types out the menu
                Console.Clear();
                Console.WriteLine("Välkommen till Multifabriken!");
                Console.WriteLine("1. Beställ en bil");
                Console.WriteLine("2. Beställ godis");
                Console.WriteLine("3. Beställ ett rör");
                Console.WriteLine("4. Beställ havremjölk");
                Console.WriteLine("5. Visa dina beställningar");
                Console.WriteLine("6. Avsluta programmet");
                Console.WriteLine("Välj ett alternativ:");

                //Users menu choice
                switch (Console.ReadLine())
                {
                    case "1":
                        OrderCar(); //Calls upon the method to order a car
                        break;

                    case "2":
                        OrderCandy(); //Calls upon the method to order candy
                        break;

                    case "3":
                        OrderPipe(); //Calls upon the method to order a pipe
                        break;

                    case "4":
                        OrderOatmilk(); //Calls upon the method to order oatmilk
                        break;

                    case "5":
                        ListOrders(); //Calls upon the method to type out the orders from the list
                        break;

                    case "6":
                        isRunning = false; //Ends the main loop and the program
                        break;

                    default: 
                        //Handles wrong input from the user
                        Console.WriteLine("Ogiltigt val, tryck på valfri tangent för nytt försök.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        //Method for ordering a car
        static void OrderCar()
        {
            Console.WriteLine("Ange registreringsnummer: ");
            string regNumber = Console.ReadLine();
            Console.WriteLine("Ange färg: ");
            string color = Console.ReadLine();
            Console.WriteLine("Ange modell: ");
            string brand = Console.ReadLine();

            //Creates a car object and adds it to the order list
            Car car = new Car(regNumber, color, brand);
            orders.Add(car);
        }

        //Method for ordering candy
        static void OrderCandy()
        {
            Console.WriteLine("Ange smak: ");
            string flavour = Console.ReadLine();
            Console.WriteLine("Ange antal: ");
            int quantity = int.Parse(Console.ReadLine());

            //Creates a candy object and adds it to the order list
            Candy candy = new Candy(flavour, quantity);
            orders.Add(candy);
        }

        //Method for ordering a pipe
        static void OrderPipe()
        {
            Console.WriteLine("Ange diameter: ");
            int diameter = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange längd: ");
            int length = int.Parse(Console.ReadLine());

            //Creates a pipe object and adds it to the order list
            Pipe pipe = new Pipe(diameter, length);
            orders.Add(pipe);
        }

        //Method for ordering oatmilk
        static void OrderOatmilk()
        {
            Console.WriteLine("Ange fetthalt: ");
            int fatContent = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange litermängd: ");
            int literAmount = int.Parse(Console.ReadLine());

            //Creates a oatmilk object and adds it to the order list
            Oatmilk oatmilk = new Oatmilk(fatContent, literAmount);
            orders.Add(oatmilk);
        }

        //Method to type out all the orders from the list 
        static void ListOrders()
        {
            Console.Clear();
            Console.WriteLine("Dina beställnigar: ");

            //Goes through every object in the list and types out its ToString representation
            foreach (var order in orders)
            {
                Console.WriteLine(order.ToString());
            }
            //Waits for the user before going back to the menu
            Console.WriteLine("Tryck på valfri tangent för att fortsätta.");
            Console.ReadKey();
        }
    }
}
