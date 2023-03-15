using AutoMapper;
using Backend.Data.IRepositories;
using Backend.DTO;
using Backend.Logic.ILogic;
using Backend.Models;

namespace Backend.Logic
{
    public class ClienteLogic : BaseLogic<Cliente,ClienteDTO>, IClienteLogic
    {
        private readonly IBaseRepository<Cliente> _baseRepository;
        private readonly IMapper _mapper;

        public ClienteLogic(IBaseRepository<Cliente> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
    }
}
