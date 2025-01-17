namespace TestePratico
{
    public class Questao02
    {
        public void VerificarFibonati() 
        {
            Console.Write("Informe um número: ");
            int number = int.Parse(Console.ReadLine());

            if (IsFibonacci(number))
            {
                Console.WriteLine($"O número {number} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {number} NÃO pertence à sequência de Fibonacci.");
            }
        }

        private static bool IsFibonacci(int num)
        {
            int a = 0, b = 1;
            while (b < num)
            {
                int temp =a;
                a = b;
                b = temp +b;
            }
            return b == num || num == 0;
        }
    }
}
