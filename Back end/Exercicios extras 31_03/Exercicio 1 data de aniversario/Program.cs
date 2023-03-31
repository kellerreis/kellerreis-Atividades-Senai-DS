// // Escreva um programa que pergunte o dia, mês e ano 
// do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o
//  motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.WriteLine($"Digite o dia do seu nascimento:");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o mês do seu nascimento:");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o ano do seu nascimento:");
int ano = int.Parse(Console.ReadLine());


if(dia>31 || dia<1){
    Console.WriteLine($"Dia digitado não válido");
}

if(mes>12 || mes<1){
    Console.WriteLine($"mes digitado não válido");
}

if(ano>2013 || ano<0){
    Console.WriteLine($"ano digitado não válido");
}

else if((dia<=31 && dia>=1) && (mes<=12 && mes>=1) && (ano<=2013 && ano>=0)){
    Console.WriteLine($"Data válida");
}

 