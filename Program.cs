using System;
using System.Globalization;

namespace estoque {
    class Program {
        static void Main(string[] args) {
            //declaração da classe
            Produto X;
           
            X = new Produto();

            //entrada de informações
            Console.WriteLine("Digite o nome do produto:");
            X.nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto");
            X.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite  a quantidade no estoque desse produto");
            X.quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //calculo
            double total = X.preco * X.quantidade;

            //saida das informações 
            Console.WriteLine("Dados do produto: " + X.nome + ", $ " + X.preco.ToString("F2", CultureInfo.InvariantCulture) + ", " +
               X.quantidade + " Unidades," + " Total: " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("");
            //adicionando produtos ao estoque
            Console.WriteLine("Digite o número de produtos a serem adicionado ao estoque:");
            int ad;
            Console.WriteLine("");
            ad = int.Parse(Console.ReadLine());
            X.quantidade += ad;
            total = X.preco * X.quantidade;


            Console.WriteLine("");

            Console.WriteLine("Dados atualizados: " + X.nome + ", $ " + X.preco.ToString("F2", CultureInfo.InvariantCulture) + ", " +
               X.quantidade + " Unidades," + " Total: " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("");
            // tirando produtos do estoque
            Console.WriteLine("Digite o número de produtos a serem removido do estoque:");
            int remo = int.Parse(Console.ReadLine());
            X.quantidade -= remo;
            total = X.preco * X.quantidade;
            Console.WriteLine("");

            Console.WriteLine("Dados atualizados: " + X.nome + ", $ " + X.preco.ToString("F2", CultureInfo.InvariantCulture) + ", " +
              X.quantidade + " Unidades," + " Total: " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();






        }
    }
}
