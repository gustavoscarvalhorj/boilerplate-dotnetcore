using Boilerplate.AppServices.Resources.Dto;
using Boilerplate.AppServices.Resources.Interfaces;
using Boilerplate.Domain.Core.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boilerplate.AppServices.ApiAppService.Produtor
{
    public class ProdutorAppService : IProdutorAppService
    {
        IProdutorRepository _produtorRepository;
        
        public ProdutorAppService(IProdutorRepository produtorRepository)
        {
            _produtorRepository = produtorRepository;
        }

        public async Task<ICollection<ProdutorDto>> GetAll()
        {
            var produtores = await _produtorRepository.GetAll();
            return produtores.Select(produtor => new ProdutorDto() { Id = produtor.Id, Nome = produtor.Nome }).ToList();
        }
    }
}
