namespace Course
{
    class Course
    {


        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            Console.WriteLine("Enter the number of products ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product {i} data :");

                Console.WriteLine("Common , used or imported (c/u/i)");
                char Import = char.Parse(Console.ReadLine());
                Console.Write("Name : ");
                string Nome = Console.ReadLine();
                Console.Write("Price : ");
                double Price = double.Parse(Console.ReadLine());
                if (Import == 'i')
                {
                    Console.WriteLine("Customs Fee ");
                    double customsfe = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(Nome, Price, customsfe));
                }
                else if (Import == 'c')
                {
                    products.Add(new Product(Nome, Price));
                }
                else if (Import == 'u')
                {

                    Console.WriteLine("Manufacture date (DD/MM/YYYY):");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(Nome, Price, data));
                }
            }


                Console.WriteLine();
                Console.WriteLine("PRICE TAGS : ");
                foreach(Product product in products)
                {
                    Console.WriteLine(product.priceTag());
                }

            }


        }

        }
