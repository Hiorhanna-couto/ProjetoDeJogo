using ProjetoDejogos.Contexts;
using ProjetoDejogos.Domains;
using ProjetoDejogos.Interfaces;

namespace ProjetoDejogos.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly ProjetoJogoContext _context;

        public UsuariosRepository(ProjetoJogoContext context)
        {
            _context = context;
        }
        public void Atualizar(Guid ID, Usuario usuarios)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuarios)
        {
            try
            {
                usuarios.UsuarioID = Guid.NewGuid();
                _context.Usuario.Add);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid ID)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
