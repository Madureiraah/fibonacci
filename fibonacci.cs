namespace atividade;

class Program
{
    static void Main(string[] args)
    {
        //Variável
        int num = 0;

        //Entrada
        Console.WriteLine("Digite um número");
        num = int.Parse(Console.ReadLine()!);
        
        //Chamda da função e verificação se pertence ou não a fibonacci
        if (fibonacci(num))
        {
            Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
        }
    }

    //Função para calcular fibonacci
    static bool fibonacci(int num)
    {
        int a = 0;
        int b = 1;
        int fibonacci = 0;
        
        if (num == 0 || num == 1)
        {
            return true;
        }

        //loop para calcular sequência
        while (fibonacci < num)
        {
            fibonacci = a + b;
            a = b;
            b = fibonacci;
        }

        return fibonacci == num;
    }
}
