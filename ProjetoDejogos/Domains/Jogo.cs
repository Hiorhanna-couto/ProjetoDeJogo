//Namespace -> caminho em que a classe jogo esta
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjetoDejogos.Domains
{
    //Publica classe -> Criar um classe publica
    [Table ("Jogo")]
    // O Index faz com o Nomedo jogo NAO ser repitar
    [Index(nameof(NomeDoJogo), IsUnique = true)]
    public class Jogo
    {
        [Key]
        //Preencher os atributos!

        public Guid JogoID { get; set; }

    
        [Column(TypeName = "VARCHAR(50)")]
        //required faz com que seja obrigatorio preencher o campo NomeDojogos
        [Required(ErrorMessage ="o nome do jogo e obrigatorio!")]
        public string? NomeDoJogo { get; set; }
            
        [Column(TypeName = "VARCHAR(50)")]
        public string? Plataforma { get; set; }

    }
}
