namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Imposto> list = new List<Imposto>();

            Console.WriteLine("Enter the number of tax payers:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {


                Console.WriteLine($"Tax payer #1 data: {i}");
                Console.WriteLine("Individual or company (i/c)?");
                char pessoa = char.Parse(Console.ReadLine());

                Console.Write("Name : ");
                string nome = Console.ReadLine();

                Console.WriteLine("Anual Income : ");
                double anual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if(pessoa == 'i')
                {
                    Console.WriteLine("Health expenditures : ");
                    double healthexpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome, anual, healthexpenditures));
                   

                }
                else
                {

                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(nome, anual, numberOfEmployees));

                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            foreach(Imposto cc in list)
            {
                double tp = cc.Paytax();
                Console.WriteLine(cc.Name + ": $ " + tp.ToString("F2", CultureInfo.InvariantCulture));
                sum += tp;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));



        }
        }
    }
