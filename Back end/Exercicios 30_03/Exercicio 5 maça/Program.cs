// As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem
//  compradas pelo menos doze. Escreva um programa
//  que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

Console.WriteLine($"Digite o número de maças compradas");
float qtdemaca = float.Parse(Console.ReadLine());
float precoatacado = 0.25f;
float precovarejo = 0.3f;
if (qtdemaca >=12){
    float atacado = (qtdemaca*precoatacado);
    Console.WriteLine($"valor total da compra R${atacado}");
}
else {
    float varejo = (qtdemaca*precovarejo);
    Console.WriteLine($"valor total da compra R${varejo}");
}