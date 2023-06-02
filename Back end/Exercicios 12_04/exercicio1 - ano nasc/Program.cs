//1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
//ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

DateOnly actualDate = DateOnly.FromDateTime(DateTime.Now);

Console.Write($"Insira o ano em que nasceu: ");
int anonasc = int.Parse(Console.ReadLine());

int anos = actualDate.Year - anonasc;

if (anos >= 16 && anos < 18)
{
    Console.WriteLine($"Você poderá votar este ano caso queira.");
}
else
{
    if (anos >= 18)
    {
        Console.WriteLine($"Você deve votar este ano.");
    }
    else
    {
        Console.WriteLine($"Você não poderá votar este ano.");
    }
}