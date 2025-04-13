namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // a classe abstrata Account.cs continua sendo uma generalização... 
            // e posso criar uma lista dessa classe abstrata de modo que eu possa guardar elementos de todos tipos possiveis como segue abaixo.

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500.0, 500.0));

            double sum = 0.0;

            foreach(Account acc in list)
            {

                sum += acc.Balance;

            }

            Console.WriteLine("Total balance : " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in list)
            {
                // e posso fazer chamadas polimorficas de operações que vai ser executadas de todos os elementos.
                acc.Withdraw(10.0);

            }

            foreach(Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}


