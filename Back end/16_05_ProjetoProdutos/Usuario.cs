namespace Projeto_Produtos
{
    public class Usuario
    {
        public int Codigo { get; set; } = 0;
        public string? Nome { get; set; } = "keller";
        public string? Email { get; set; } = "keller@gmail.com";
        public string? Senha { get; set; } = "nbcz";
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public Usuario()
        {
            
        }


        public void Listar()
        {

        }

        public void Cadastrar(Usuario _usuario)
        {
            Console.WriteLine($"___________ CADASTRO USUÁRIO ___________");
            Console.Write($"Código: ");
            _usuario.Codigo = int.Parse(Console.ReadLine()!);

            Console.Write($"Nome do usuário: ");
            _usuario.Nome = Console.ReadLine()!;

            Console.Write($"Email: ");
            _usuario.Email = Console.ReadLine()!;

            Console.Write($"Senha: ");
            _usuario.Senha = Console.ReadLine()!;



        }

        public void Deletar(Usuario _usuario)
        {

        }
    }
}