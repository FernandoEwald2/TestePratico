namespace TestePratico
{
    public class Questao03
    {
        public void FaturamentoDiario() 
        {
            List<double> faturamentoDiario = new List<double> { 1000, 2000, 0, 1500, 0, 3000 };


            List<double> valores = faturamentoDiario.Where(x => x > 0).ToList();

           
            double menor = valores.Min();
            double maior = valores.Max();
            double media = valores.Average();

           
            int diasAcimaMedia = valores.Count(v => v > media);

            Console.WriteLine($"Menor faturamento: R${menor:F2}");
            Console.WriteLine($"Maior faturamento: R${maior:F2}");
            Console.WriteLine($"Dias acima da média: {diasAcimaMedia}");

        }
    }
}
