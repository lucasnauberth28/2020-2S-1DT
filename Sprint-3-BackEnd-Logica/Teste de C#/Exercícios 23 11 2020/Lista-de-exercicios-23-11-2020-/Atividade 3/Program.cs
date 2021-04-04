using System;

namespace Atividade_3___23._11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
            // preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
            // desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
            // - Se quantidade &lt;= 5 o desconto será de 2%
            // - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
            // - Se quantidade &gt; 10 o desconto será de 5%

            float discount1 = 0.02f;
            float discount2 = 0.03f;
            float discount3 = 0.05f;

            Console.WriteLine("Bem vindo ao Mercadinho do Back, escreva o nome do produto que você comprou: ");
            string produto = Console.ReadLine();

            Console.WriteLine($"Agora escreva quantas unidades do(a) {produto} você comprou: ");
            int unidades = int.Parse(Console.ReadLine());

            Console.WriteLine($"Agora escreva o valor unitário do(a) {produto}: ");
            float preco = float.Parse(Console.ReadLine());

            if(unidades <= 5){

                float total = (unidades * preco);
                float desconto = (total * discount1);
                float final = (total - desconto);

                Console.WriteLine($"O preço final a se pagar com o desconto é de {final}");

            }else if(unidades >5 || unidades <=10){

                float total = (unidades * preco);
                float desconto = (total * discount2);
                float final = (total - desconto);

                Console.WriteLine($"O preço final a se pagar com o desconto é de {final}");
                
            }else{

                float total = (unidades * preco);
                float desconto = (total * discount3);
                float final = (total - desconto);

                Console.WriteLine($"O preço final a se pagar com o desconto é de {final}"); 
        
            }
        }
    }
}
