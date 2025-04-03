using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjetoDejogos.Domains
{
    [Table("Usuario")]
    // O Index faz com o Nomedo jogo NAO ser repitar
    [Index(nameof(Nicknome), IsUnique = true)]
    public class Usuario
    { 
        //Preencher os atributos!
        [Key]
        public Guid  UsuarioID { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required (ErrorMessage = "o nemo e obrigatorio!")]
        public string? NomeUsuario { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        [Required (ErrorMessage = "Nicknome e obrigatorio!") ]
        public string? Nicknome { get; set; }


        public Guid JogoFavorito { get; set; }

        [ForeignKey("JogoFavorito")]
        public Jogo? Jogo{ get; set; } 
    }
}