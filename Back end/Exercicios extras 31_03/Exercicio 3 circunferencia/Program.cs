// Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre
//  o diâmetro, comprimento e área da circunferência.

Console.WriteLine($"Qual o raio da circunferencia:");
double raio = double.Parse(Console.ReadLine());

double area = (Math.Pow(raio,2))*Math.PI;

double diametro = raio*2;

double comprimento = (2*(Math.PI)*raio);


Console.WriteLine($"O diamentro da circunferencia é {diametro}:");
Console.WriteLine($"O comprimento da circunferencia é {comprimento}:");
Console.WriteLine($"A area da circunferencia é {area}:");


