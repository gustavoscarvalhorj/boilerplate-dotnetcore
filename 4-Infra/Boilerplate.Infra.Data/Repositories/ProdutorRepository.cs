using Boilerplate.Domain.Core.Entities.Produtor;
using Boilerplate.Domain.Core.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Boilerplate.Infra.Data.Repositories
{
    public class ProdutorRepository : IProdutorRepository
    {
        public async Task<ICollection<ProdutorEntity>> GetAll()
        {
            var lista = new List<ProdutorEntity>();
            lista.Add(new ProdutorEntity() { Id = 1, Nome = "NORTE A SUL" });
            return await Task.FromResult(lista);
        }
    }
}
