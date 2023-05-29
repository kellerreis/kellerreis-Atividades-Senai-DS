using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Projeto_gamer_com_back_e_sql.Models
{
    public class Jogador
    {
        [Key]
        public int IdJogador { get; set; }
        public string Nome {get; set; }
        public string Email {get; set; }

        public string Senha {get; set; }

        [ForeignKey("Equipe")]
        public int IdEquipe {get; set; }
        public Equipe Equipe {get; set;}
        
    }
}