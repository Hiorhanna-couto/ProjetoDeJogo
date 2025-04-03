using ProjetoDejogos.Contexts;
using ProjetoDejogos.Domains;
using ProjetoDejogos.Interfaces;

namespace ProjetoDejogos.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly ProjetoJogoContext _context;

        public JogoRepository(ProjetoJogoContext context)
        {
            _context = context;
        }
        public void Atualizar(Guid id, Jogo jogoAtualizado)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Jogo jogoNovo)
        {
            try
            {
                jogoNovo.JogoID = Guid.NewGuid();
                _context.Jogo.Add(jogoNovo);

                _context.SaveChanges();

            }
            catch (Exception )  
            {
                throw;
            }

        }

        public void Deletar(Guid idDoJogo)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Jogo> Listar()
        {
            try
            {
                List<Jogo> ListarJogo = _context.Jogo.ToList();

            }
            catch (Exception) 
            {
            
            }

        }
    }
}
