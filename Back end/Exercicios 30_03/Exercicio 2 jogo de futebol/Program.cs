//Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol
// (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.//

Console.WriteLine($"Digite o numero de gols feito pelo time A");
int golstimeA = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o numero de gols feito pelo time B");
int golstimeB = int.Parse(Console.ReadLine());

if (golstimeA == golstimeB){
    Console.WriteLine($"Empate");
}

else if (golstimeA >golstimeB)
{
    Console.WriteLine($"Vitória do time A");
}

else {
    Console.WriteLine($"Vitória do time B");
}