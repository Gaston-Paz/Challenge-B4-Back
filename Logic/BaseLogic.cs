using AutoMapper;
using Backend.Data.IRepositories;
using Backend.Logic.ILogic;
using System.Linq.Expressions;

namespace Backend.Logic
{
    public class BaseLogic<T, T2> : IBaseLogic<T, T2>
        where T : class
        where T2 : class
    {
        private readonly IBaseRepository<T> _baseRepository;
        private readonly IMapper _mapper;

        public BaseLogic(IBaseRepository<T> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public T2 Create(T2 entity)
        {
            var eToSave = _mapper.Map<T>(entity);
            var e = _baseRepository.Create(eToSave);
            return _mapper.Map<T2>(e);
        }

        public List<T2> GetAll()
        {
            var e = _baseRepository.GetAll();
            return _mapper.Map<List<T2>>(e);
        }

        public T2 GetOne(int id)
        {
            var e = _baseRepository.GetOne(id);
            return _mapper.Map<T2>(e);
        }

        public List<T2> Search(Expression<Func<T, bool>>? where = null)
        {
            var e = _baseRepository.Search(where);
            return _mapper.Map<List<T2>>(e);
        }

        public T2 Update(T2 entity)
        {
            var eToSave = _mapper.Map<T>(entity);
            var e = _baseRepository.Update(eToSave);
            return _mapper.Map<T2>(e);
        }
    }
}
