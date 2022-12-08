using Microsoft.AspNetCore.Mvc;
using ProjetoEngenhariaDeSoftware.Domain.Entities;

namespace ProjetoEngenhariaDeSoftware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsultaController : ControllerBase
    {
        private static readonly IList<Consulta> Consultas = new List<Consulta> { };

        [HttpGet("/api/consultas")]
        public IEnumerable<Consulta> Get()
        {
            return Consultas.ToArray();
        }

        [HttpPost("/api/consultas")]
        public void RealizarConsulta(Consulta consulta)
        {
            Consultas.Add(consulta);
        }
    }
}