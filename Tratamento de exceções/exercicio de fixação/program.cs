namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data ");
            Console.Write("Number");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder");
            string holder = Console.ReadLine();
            Console.Write("Initial balance : ");
            double initialbalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit : ");
            double withdrawlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(number, holder, initialbalance, withdrawlimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw :");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw Error " + e.Message);
            }


        }
        }
    }

