// 2. Faça um programa que leia um nome de usuário e a sua
//  senha e não aceite a senha igual ao nome do usuário, mostrando uma 
// mensagem de erro e voltando a pedir as informações.


    Console.WriteLine($"Digite um usuário");
    string usuario = Console.ReadLine();

    Console.WriteLine($"Digite uma senha");
    string senha = Console.ReadLine();


while (usuario == senha)
{
    Console.WriteLine($"Usuário e senhas não podem ser os mesmos");
    Console.WriteLine($"Digite um usuário");
    usuario = Console.ReadLine();

    Console.WriteLine($"Digite uma senha");
    senha = Console.ReadLine();
}

Console.WriteLine($"OK, Usuário e senha válidos");
