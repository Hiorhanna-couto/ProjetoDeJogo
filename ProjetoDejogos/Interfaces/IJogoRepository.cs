using ProjetoDejogos.Domains;

namespace ProjetoDejogos.Interfaces
{
    public interface IJogoRepository
    {
        //Cadastra
        void Cadastrar(Jogo jogoNovo);
        //Deletar
        void Deletar(Guid idDoJogo);
        //listra
        List<Jogo> Listar();
        //Atualizar
        void Atualizar(Guid id, Jogo jogoAtualizado);
    }
}
