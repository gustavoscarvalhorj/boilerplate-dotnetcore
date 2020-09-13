using Boilerplate.Domain.Core.Shared;

namespace Boilerplate.Domain.Core.Entities.Produtor
{
    public class ProdutorEntity : TEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}