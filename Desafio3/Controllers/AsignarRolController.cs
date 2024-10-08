using Desafio3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("autorizacion/")]
[ApiController]
public class AsignarRolController : ControllerBase
{
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<Usuario> _userManager;

    public AsignarRolController(RoleManager<IdentityRole> roleManager, UserManager<Usuario> userManager)
    {
        _roleManager = roleManager;
        _userManager = userManager;
    }


    // Solo el admin puede crear roles
   // [Authorize(Roles = "Administrador")]
    [HttpPost("crear")]
    public async Task<IActionResult> CrearRol([FromBody] Rol modelo)
    {
        if (string.IsNullOrWhiteSpace(modelo?.NombreRol))
        {
            return BadRequest("El nombre del rol no puede estar vacío.");
        }

        // Verificar si el rol ya existe
        if (await _roleManager.RoleExistsAsync(modelo.NombreRol))
        {
            return Conflict($"El rol '{modelo.NombreRol}' ya existe.");
        }

        // Crear el rol
        var resultado = await _roleManager.CreateAsync(new IdentityRole(modelo.NombreRol));
        if (resultado.Succeeded)
        {
            return Ok($"Rol '{modelo.NombreRol}' creado con éxito.");
        }

        return BadRequest(resultado.Errors);
    }

    // Endpoint para asignar roles
    // Solo el admin puede asignar roles
   // [Authorize(Roles = "Administrador")]
    [HttpPost("asignar")]
    public async Task<IActionResult> AsignarRol([FromBody] AsignarRol modelo)
    {
        if (string.IsNullOrWhiteSpace(modelo.CorreoUsuario) || string.IsNullOrWhiteSpace(modelo.Rol))
        {
            return BadRequest("El correo y el nombre del rol son obligatorios.");
        }

        var usuario = await _userManager.FindByEmailAsync(modelo.CorreoUsuario);
        if (usuario == null)
        {
            return NotFound($"El usuario con el correo '{modelo.CorreoUsuario}' no existe.");
        }

        if (!await _roleManager.RoleExistsAsync(modelo.Rol))
        {
            return BadRequest($"El rol '{modelo.Rol}' no existe.");
        }

        var resultado = await _userManager.AddToRoleAsync(usuario, modelo.Rol);
        if (resultado.Succeeded)
        {
            return Ok($"Rol '{modelo.Rol}' asignado al usuario '{modelo.CorreoUsuario}' con éxito.");
        }

        return BadRequest(resultado.Errors);
    }
}
