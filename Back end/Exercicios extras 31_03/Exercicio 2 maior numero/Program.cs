// Faça um programa que leia três números e mostre o maior e o menor deles.


Console.WriteLine($"Digite o primeiro numero:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero:");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o terceiro numero:");
float n3 = float.Parse(Console.ReadLine());

float maiorentren1en2 = Math.Max(n1,n2);
float maiorentren2en3 = Math.Max(n2,n3);
float maiorentren1en3 = Math.Max(n1,n3);

float menorentren1en2 = Math.Min(n1,n2);
float menorentren2en3 = Math.Min(n2,n3);
float menorentren1en3 = Math.Min(n1,n3);

if ((n1==n2)&&(n2==n3)&&(n1==n3)){
    Console.WriteLine($"Os números são iguais");
}

if (!((n1==n2)&&(n2==n3)&&(n1==n3))){
    float maior = Math.Max(maiorentren1en2,maiorentren2en3);

    Console.WriteLine($"o maior numero é:{maior}");


}

if (!((n1==n2)&&(n2==n3)&&(n1==n3))){
    float menor = Math.Min(menorentren1en2,menorentren2en3);

    Console.WriteLine($"o menor numero é:{menor}"); }