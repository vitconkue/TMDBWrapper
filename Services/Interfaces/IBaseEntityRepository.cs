using System.Threading.Tasks;

namespace MainLibrary.Services.Interfaces
{
    public interface IBaseEntityRepository<T>
    {
        Task<T> GetById(int id); 
    }
}