using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoDejogos.Domains;
using ProjetoDejogos.Interfaces;

namespace ProjetoDejogos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuariosRepository? _usuarioRepository;
        public UsuarioController(IUsuariosRepository? usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

       


    }
}