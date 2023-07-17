using System;

class Program
{
    public static void Main(string[] args)
    {
        //calcular a média salarial

        //ler o número de funcionários 
        int n, f;

        Console.Write("Quantos são os funcionários? ");
        n = Convert.ToInt32(Console.ReadLine());

        float[,] func = new float[n, 2]; //ler o número do funcionário e o seu salário

        for(f = 0; f < n; f++)
        {
            Console.Write("Qual o número do funcionário? ");
            func[f,0] = Convert.ToSingle(Console.ReadLine());
            Console.Write("Qual o salário do funcionário? ");
            func[f,1] = Convert.ToSingle(Console.ReadLine());
        }

        //fazer a soma do salário

        int cont = 0;
        float soma = 0;

        for(f = 0; f < n; f++)
        {
           soma += func[f,1];

           if(func[f,1] > 1000)
            {
              func[f,1] =  cont++;
            }
        }

        //calcular a média 

        float media = soma / n; 

        Console.WriteLine();
        Console.WriteLine("A média salarial é de " + media + "€");
    }
}