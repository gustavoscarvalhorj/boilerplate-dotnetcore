using System.Collections.Generic;
using System.Threading.Tasks;

namespace Boilerplate.Domain.Core.Shared.Interfaces
{
    public interface IGetAll<T> where T : TEntity
    {
        Task<ICollection<T>> GetAll();
    }
}
