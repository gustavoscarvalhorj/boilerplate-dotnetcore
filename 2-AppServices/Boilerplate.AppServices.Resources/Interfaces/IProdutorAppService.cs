using Boilerplate.AppServices.Resources.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Boilerplate.AppServices.Resources.Interfaces
{
    public interface IProdutorAppService 
    {
        Task<ICollection<ProdutorDto>> GetAll();
    }
}
