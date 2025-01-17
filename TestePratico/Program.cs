// See https://aka.ms/new-console-template for more information
using TestePratico;

Questao01 questao01 = new Questao01();
Questao02 questao02 = new Questao02();
Questao03 questao03 = new Questao03();
Questao04 questao04 = new Questao04();
Questao05 questao05 = new Questao05();


Console.WriteLine("Teste prático");

Console.WriteLine(" =========================================Teste 01 =========================================");
questao01.somar();

Console.WriteLine(" =========================================Teste 02 =========================================");
questao02.VerificarFibonati();

Console.WriteLine(" =========================================Teste 03 =========================================");
questao03.FaturamentoDiario();

Console.WriteLine(" =========================================Teste 04 =========================================");
questao04.Percentual();

Console.WriteLine(" =========================================Teste 05 =========================================");
questao05.InverterString();

Console.WriteLine(" =========================================Fim teste ========================================");

