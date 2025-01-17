namespace TestePratico
{
    public class Questao01
    {
        public void somar() 
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K++;
                SOMA += K;
            }

            Console.WriteLine("Questão 01 => SOMA = " + SOMA);
        }
    }
}
