using System;

public class Jogador
{
    public string nome;
    public DateTime dataNascimento;
    public string nacionalidade;
    public float altura;
    public float peso;

    public Jogador(string nome, DateTime dataNascimento, string nacionalidade, float altura, float peso)
    {
        this.nome = nome;
        this.dataNascimento = dataNascimento;
        this.nacionalidade = nacionalidade;
        this.altura = altura;
        this.peso = peso;
    }

    public void ImprimirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Data de nascimento: " + dataNascimento.ToString("dd/MM/yyyy"));
        Console.WriteLine("Nacionalidade: " + nacionalidade);
        Console.WriteLine("Altura: " + altura.ToString("0.00") + "m");
        Console.WriteLine("Peso: " + peso.ToString("0.00") + "kg");
        Console.WriteLine("Idade: " + CalcularIdade());
        Console.WriteLine("Tempo para aposentar: " + CalcularTempoAposentar() + " anos");
    }

    public int CalcularIdade()
    {
        int idade = DateTime.Now.Year - dataNascimento.Year;
        if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
        {
            idade--;
        }
        return idade;
    }

    public int CalcularTempoAposentar();
}

public class JogadorDefesa : Jogador
{
    public JogadorDefesa(string nome, DateTime dataNascimento, string nacionalidade, double altura, double peso)
        : base(nome, dataNascimento, nacionalidade, altura, peso)
    {
    }

    public override int CalcularTempoAposentar()
    {
        return 40 - CalcularIdade();
    }
}

public class JogadorAtaque : Jogador
{
    public JogadorAtaque(string nome, DateTime dataNascimento, string nacionalidade, float altura, float peso)
        : base(nome, dataNascimento, nacionalidade, altura, peso)
    {
    }

    public override int CalcularTempoAposentar()
    {
        return 35 - CalcularIdade();
    }
}

public class JogadorMeioCampo : Jogador
{
    public JogadorMeioCampo(string nome, DateTime dataNascimento, string nacionalidade, float altura, float peso)
        : base(nome, dataNascimento, nacionalidade, altura, peso)
    {
    }

    public override int CalcularTempoAposentar()
    {
        return 38 - CalcularIdade();
    }
}

