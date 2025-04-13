class Course
{


    static void Main(string[] args)
    {

        Console.WriteLine("Enter cliente data");
        Console.Write("Name : ");
        string name = Console.ReadLine();
        Console.Write("Email : ");
        string email = Console.ReadLine();
        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter order data : ");
        Console.Write("Status : ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        Client client = new Client(name, email, date);
        Order order = new Order(DateTime.Now, status, client);

        Console.Write("How many items to this order?");
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            Console.Write($"Enter {i} item data : ");
            Console.Write("Product Name : ");
            string nameproduct = Console.ReadLine();
            Console.Write("Price Product : ");
            double priceproduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Product product = new Product(nameproduct, priceproduct);

            Console.Write("Quantity : ");
            int quantity = int.Parse(Console.ReadLine());
            OrderItem orderitem = new OrderItem(quantity, priceproduct, product);

            //
            order.AddItem(orderitem);

        }



        Console.WriteLine();
        Console.WriteLine("ORDER SUMARY : ");
        Console.WriteLine(order);


    }


    }

}
