using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GrupoMokApi.Models;
using GrupoMokApi.Services;

namespace GrupoMokApi.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtManager _jwtManager;

        public AuthController(JwtManager jwtManager)
        {
            _jwtManager = jwtManager;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            // Lógica para verificar las credenciales del usuario y generar un token JWT
            if (user.Username == "grupomok" && user.Password == "password")
            {
                // Si las credenciales son válidas, genera un token JWT
                var token = _jwtManager.GenerateToken(user.Username);
                return Ok(new { Token = token });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
