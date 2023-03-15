using Backend.Data.IRepositories;
using Backend.Models;

namespace Backend.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(BackendContext context) : base(context)
        {

        }
    }
}
