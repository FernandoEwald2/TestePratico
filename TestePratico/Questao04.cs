namespace TestePratico
{
    public class Questao04
    {
        public void Percentual() 
        {
            Dictionary<string, double> faturamentoEstados = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

            
            double totalFaturamento = 0;
            foreach (var valor in faturamentoEstados.Values)
            {
                totalFaturamento += valor;
            }

            
            foreach (var estado in faturamentoEstados)
            {
                double percentual = (estado.Value / totalFaturamento) * 100;
                Console.WriteLine($"{estado.Key}: {percentual:F2}%");
            }

        }
    }
}
