class Course
{


    static void Main(string[] args)
    {

        BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

        Console.WriteLine(account.Balance);

        // o balance foi colocado como protected, então só podemos alterar na classe ou por alguma subclasse.
        // account.Balance = 200.0;

    }


    }
