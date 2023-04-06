// 3. Faça um programa que receba um número inteiro
//  e mostre a sua tabuada.


Console.WriteLine($"Digite um número para receber sua tabuada");
int numero = int.Parse(Console.ReadLine());

for (int x=0; x<=10; x++)
{
    Console.WriteLine($"{x} x {numero} é igual a: {x * numero}");
    
}
