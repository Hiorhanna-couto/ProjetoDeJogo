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
        public void Atualizar(Guid id, Usuarios usuarios)
        {

            try
            {
                Usuarios usuarioBuscado = _context.Usuarios.Find(id)!;

                if (usuarioBuscado != null)
                {
                    usuarioBuscado.NomeUsuario = usuarios.NomeUsuario;
                    usuarioBuscado.NickName = usuarios.NickName;
                }

                _context.Usuarios.Update(usuarioBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuarios BuscarPorId(Guid id)
        {
            try
            {
                return _context.Usuarios.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Usuarios usuarios)
        {
            try
            {
                usuarios.UsuarioId = Guid.NewGuid();
                _context.Usuarios.Add(usuarios);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Usuarios usuarioBuscado = _context.Usuarios.Find(id)!;

                if (usuarioBuscado != null)
                {
                    _context.Usuarios.Remove(usuarioBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Usuarios> Listar()
        {

            try
            {
                return _context.Usuarios.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }




    }
}