using ApiPruebaCode.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ApiPruebaCode{

    [ApiController]
    [Route("usuarios")]
    public class UsuarioController:ControllerBase{
        private readonly ApplicationDbContext context;

        public UsuarioController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<Usuario>> Get(){
            return await context.USUARIOS.ToListAsync();
        }
        
        [HttpGet("{Id}")] //Obtener un usuario en especifico 
        public async Task<IActionResult>GetOne(int Id){
            var Usuario = await context.USUARIOS.FindAsync(Id);
            if(Usuario==null)
            return NotFound();

            return Ok(Usuario);
        }

        [HttpPost] //Crear un usuario 
        public async Task<ActionResult>Post(Usuario usuario){
            context.Add(usuario);
            await context.SaveChangesAsync();
            return Ok();
        }
        
        [HttpGet] //Obtener las direcciones de un usuario en especifico
        [Route("/Direcciones/{Id}")]
        public async Task<List<paVirtual>> GetDireccion( int Id){
            return await context.paVirtuals.FromSqlRaw("pa_SELECT_U @Id", new SqlParameter("@Id", Id)).ToListAsync();
        }


        [HttpGet]
        [Route("/DireccionesUsuarios")]
        public async Task<List<paVirtual>> GetAll(){
            return await context.paVirtuals.FromSqlRaw<paVirtual>("pa_SELECT_USUARIOS").ToListAsync();
        }
    }
}