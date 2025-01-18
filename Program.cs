using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Globalization;

namespace Comerciante
{

    class Comerciante
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Serão digitados dados de quantos produtos ? ");
            int P = int.Parse(Console.ReadLine());

            string[] nome = new string[P];
            double[] compra = new double[P];
            double[] venda = new double[P];
            double[] resultado = new double[P];
            double[] lucro = new double[P];
            int embaixo = 0;
            int entre = 0;
            int acima = 0;

            for (int i = 0; i < P; i++)
            {
                Console.WriteLine($"Produto {i + 1}");
                Console.WriteLine("Nome : ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Preço de compra :");
                compra[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Preço de venda : ");
                venda[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }


            for (int i = 0; i < P; i++)
            {
                resultado[i] = venda[i] - compra[i];


            }

            for (int i = 0; i < P; i++)
            {
                lucro[i] = resultado[i] / compra[i] * 100;

            }

            for (int i = 0; i < P; i++)
            {
                if (lucro[i] < 10.00)
                {
                    embaixo += 1;
                }
                else if (lucro[i] >= 10 && lucro[i] <= 20)
                {
                    entre += 1;
                }
                else
                {
                    acima += 1;

                }



            }
            Console.WriteLine($"Abaixo de 10%: {embaixo}");
            Console.WriteLine($"Entre  10% e 20%: {entre}");
            Console.WriteLine($"Lucro acima de  20%: {acima}");

            double totaldecompra = compra[0];

            for (int i = 1; i < P; i++)
            {
                totaldecompra += compra[i];




            }
            Console.WriteLine($"Valor total de compra : {totaldecompra.ToString("F2", CultureInfo.InvariantCulture)}");

            double totaldevenda = venda[0];

            for (int i = 1; i < P; i++)
            {
                totaldevenda += venda[i];

            }

            Console.WriteLine($"Valor total de compra : {totaldevenda.ToString("F2", CultureInfo.InvariantCulture)}");

            double resultadototal = resultado[0];

            for (int i = 1; i < P; i++)
            {
                resultadototal += resultado[i];
            }

            Console.WriteLine($"Valor total de compra : {resultadototal.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();



        }
    }
}















