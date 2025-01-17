namespace TestePratico
{
    public  class Questao05
    {
        public void InverterString() 
        {
            Console.Write("Informe uma string para inverter: ");
            string texto = Console.ReadLine();

            string textoInvertido = ReverseString(texto);
            Console.WriteLine($"String invertida: {textoInvertido}");

        }

        private static string ReverseString(string str)
        {
            string result = "";
            foreach (char c in str)
            {
                result = c + result;
            }

            return result;
        }
    }
}
