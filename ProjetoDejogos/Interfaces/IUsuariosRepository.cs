using ProjetoDejogos.Domains;

namespace ProjetoDejogos.Interfaces
{
    public interface IUsuariosRepository
    {
        //Cadastra
        void Cadastrar(Usuario usuarios);

       //Deletar
       void Deletar (Guid ID);

        //listra
        List<Usuario> Listar();

       //Atualizar
        void Atualizar( Guid ID,Usuario usuarios);   
    }
}
