using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ContadorVisitas.controller
{
    [ApiController]
    [Route("api/visitas")]
    public class VisitController : ControllerBase
    {

        private static int ContadorVisitas = 0;

        [HttpGet]
        public IActionResult GetVisitas(){
            ContadorVisitas++;
            return Ok(new{visitas = ContadorVisitas});
        }
        [HttpPost("reset")]
        public IActionResult ResetVisitas(){
            ContadorVisitas = 0;
            return Ok(new{Message = "Contador de visitas reiniciado"});
        }      
        [HttpDelete("deletar")]
        public IActionResult DeletarVisitas(){
            ContadorVisitas --;
            return Ok(new{visitas = ContadorVisitas});
        }  
    }
}