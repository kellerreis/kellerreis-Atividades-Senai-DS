// Nesta aula vamos fazer um pequeno sistema de calculadora, em um projeto de console no VsCode.

// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.

// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.

using Calculadora;

calc n = new calc();

Console.WriteLine($"Informe o primeiro numero:");
n.n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo numero:");
n.n2 = float.Parse(Console.ReadLine());

Console.WriteLine(@$"Informe o tipo de operacao de acordo com as opcoes abaixo:

1 - Subtrair
2 - Somar
3 - Dividir
4 - Multiplicar ");
int operador = int.Parse(Console.ReadLine());

switch (operador)
{
    case 1:
    Console.WriteLine(n);
    break;

    // case 2:
    // Console.WriteLine(n1+n2);
    // break;

    // case 3:
    // Console.WriteLine(n1/n2);
    // break;

    // case 4:
    // Console.WriteLine(n1*n2);
    // break;

    default:

    Console.WriteLine($"Opcao invalida.");
    break;



}
