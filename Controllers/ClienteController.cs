using Backend.DTO;
using Backend.Logic.ILogic;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {

        private readonly ILogger<ClienteController> _logger;
        private readonly IBaseLogic<Cliente, ClienteDTO> _baseLogic;

        public ClienteController(ILogger<ClienteController> logger, IBaseLogic<Cliente, ClienteDTO> baseLogic)
        {
            _logger = logger;
            _baseLogic = baseLogic;
        }

        [HttpGet]
        public List<ClienteDTO> GetAll()
        {
            return _baseLogic.GetAll();
        }

        [HttpGet("{id}")]
        public ClienteDTO Get(int id)
        {
            return _baseLogic.GetOne(id);
        }

        [HttpGet("nombre/{valor}")]
        public List<ClienteDTO> Search(string valor)
        {
            return _baseLogic.Search(x => x.Nombres.ToUpper().Contains(valor));
        }

        [HttpPost]
        public ActionResult<ClienteDTO> Create([FromBody] ClienteDTO cliente)
        {
            try
            {
                return _baseLogic.Create(cliente);

            }
            catch (Exception ex)
            {
                if (ex.InnerException.Message.ToUpper().Contains("IDENTITY_INSERT"))
                {
                    return NotFound("No debe enviar el ID. Se autorgenera.");
                }
                else
                {
                    throw ex;

                }
            }
        }

        [HttpPut]
        public ClienteDTO Update([FromBody] ClienteDTO cliente)
        {
            try
            {
                return _baseLogic.Update(cliente);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
