namespace Course
{
    class Course
    {


        static void Main(string[] args)
        {

            Account acc1 = new Account(1001, "Alex" , 500.0);
            Account acc2 = new SavingAccount(1002, "Ana ", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }


        }

    }
