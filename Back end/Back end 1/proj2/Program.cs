﻿Console.WriteLine(@$"


Vamos calcular sua idade em meses, dias, horas e minutos 

");

Console.WriteLine($"digite seu ano de nascimento");
int ano = int.Parse(Console.ReadLine());

Console.WriteLine($"digite seu mes de nascimento");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"digite seu dia de nascimento");
int dia = int.Parse(Console.ReadLine());

DateTime data = DateTime.Now;

int Meses = ((data.Year - ano)*12);
Console.WriteLine(Meses);







