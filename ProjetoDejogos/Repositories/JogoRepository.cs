using ProjetoDejogos.Contexts;
using ProjetoDejogos.Domains;
using ProjetoDejogos.Interfaces;
using ProjetoDejogos.Migrations;

namespace ProjetoDejogos.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly ProjetoJogoContext _context;

        public JogoRepository(ProjetoJogoContext context)
        {
            _context = context;
        }
        public void Atualizar(Guid id, Jogo jogos)
        {
            try
            {
                Jogo jogoBuscado = _context.Jogo.Find(id)!;

                if (jogoBuscado != null)
                {
                    jogoBuscado.Jogo = jogos.NomeJogo;
                }

                _context.Jogo.Update(jogoBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Jogo BuscarPorId(Guid id)
        {
            try
            {
                return _context.Jogo.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Jogo jogos)
        {
            try
            {
                jogos.JogoID = Guid.NewGuid();
                _context.Jogo.Add(jogos);
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
                Jogo jogoBuscado = _context.Jogo.Find(id)!;

                if (jogoBuscado != null)
                {
                    _context.Jogo.Remove(jogoBuscado);
                }

                _context.SaveChanges();
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
                return _context.Jogo.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
