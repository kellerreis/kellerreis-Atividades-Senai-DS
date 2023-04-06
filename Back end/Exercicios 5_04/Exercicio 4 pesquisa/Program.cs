// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

int x = 0;

Console.WriteLine($"Vamos iniciar nossa pesquisa");
do 
{  


Console.WriteLine(@$" Digite a letra correspondente ao seu sexo:

(M) - Masculino
(F) - Feminino

");
    string sexo = Console.ReadLine();

    Console.WriteLine(@$" Digite a letra correspondente á seguinte resposta:

    Você gostou do produto?

(S) - Sim
(N) - Não

");
    string gostou = Console.ReadLine();

    x++;
}
while (x<=10);

