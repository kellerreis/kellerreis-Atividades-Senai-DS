using Atividade_extra;

        JogadorDefesa jogadorDefesa = new JogadorDefesa("João Silva", new DateTime(1990, 1, 1), "Brasileiro", 1.80, 80);
        jogadorDefesa.ImprimirDados();

        Console.WriteLine();

        JogadorAtaque jogadorAtaque = new JogadorAtaque("Pedro Santos", new DateTime(1995, 5, 5), "Português", 1,75, 70);
        jogadorAtaque.ImprimirDados();

        Console.WriteLine();

        JogadorMeioCampo jogadorMeioCampo = new JogadorMeioCampo("Juan Perez", new DateTime(1988, 10, 10), "Argentino", 1,85, 85);
        jogadorMeioCampo.ImprimirDados();
