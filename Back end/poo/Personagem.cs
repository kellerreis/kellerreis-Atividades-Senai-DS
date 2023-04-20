namespace poo
{
    public class Personagem
    {
        //atributos (nome, idade, armadura, ia)

        public string nome;
        public int idade;
        public string armadura;
        public string ia;

        //metodos (atacar, defender, restaurar, armadura)

        public void Atacar()
        {
            Console.WriteLine($"O personagem atacou");
        }

        public void Defender()
        {
            Console.WriteLine($"O personagem defendeu");
        }

        public void RestaurarArmadura()
        {
            Console.WriteLine($"Armadura restaurada");
        }
    }
}