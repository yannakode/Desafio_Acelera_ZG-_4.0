namespace Resolução_Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Pergunta:
            //P4 - As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem compradas pelo menos 12.
            //Escreva um algoritmo (sequência de passos) que leia o número de maçãs compradas, calcule e escreva o custo total da compra.
            double ValorTotal = 0;
            Console.WriteLine("Cálculo maçãs");
            Console.WriteLine("Digite a quantidade de maçãs que deseja comprar.");
            int quant = int.Parse(Console.ReadLine());
            if( quant < 12 )
            {
                ValorTotal = quant;
            }
            else if( quant >= 12 )
            {
                ValorTotal = quant * 1.3;
            }
            else
            {
                Console.WriteLine("Valor nulo.");
            }
            Console.WriteLine("O valor total é: " + ValorTotal);


        }
    }
}