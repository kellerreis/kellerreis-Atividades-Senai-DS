using System.ComponentModel.DataAnnotations;
namespace Projeto_gamer_com_back_e_sql.Models
{
    public class Equipe
    {
        [Key]
        public int IdEquipe { get; set; }
        public string Nome {get; set; }
        public string imagem {get; set; }

        public ICollection<Jogador> Jogador {get; set;}
    }
}