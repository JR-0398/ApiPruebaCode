using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPruebaCode.Models;
using Microsoft.Data.SqlClient;
using System.Configuration;


namespace ApiPruebaCode.Controllers
{
    [ApiController]
    [Route("detalle")]
    public class DetalleController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        

        public DetalleController(ApplicationDbContext context){
            this.context= context;
        }

         /*[HttpGet]
        public async Task<ActionResult<List<Detalle>>> Get()
        {
            //var resul = await (from _detalle in context.DETALLE_DIRECCION
            //           join _usuario in context.USUARIOS on _detalle.id_usuario equals _usuario.id_usuario
            //           select new {_detalle, _usuario.id_usuario,_usuario.primer_nombre, _usuario.primer_apellido}).ToListAsync();

            //return await context.DETALLE_DIRECCION.Include(x=> x.USUARIO.primer_nombre).Include(x=>x.id_direccion).ToListAsync();

            return await context.DETALLE_DIRECCION.ToListAsync();
        }
        */
        [HttpGet]
    
        public async Task<List<paVirtual>> GetAll(){
            return await context.paVirtuals.FromSqlRaw<paVirtual>("pa_SELECT_USUARIOS").ToListAsync();
        }
        
        
    }
}