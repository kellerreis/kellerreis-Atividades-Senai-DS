// 1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso
//  o valor seja inválido e continue pedindo até que o usuário informe um valor válido.


Console.WriteLine($"Digite uma nota de 0 a 10");
int nota = int.Parse(Console.ReadLine());

while ((nota <0) || (nota>10))
{
    Console.WriteLine($"Digite uma nota válida! (o valor deve estar entre 0 e 10)");
    nota = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Nota {nota} validada");