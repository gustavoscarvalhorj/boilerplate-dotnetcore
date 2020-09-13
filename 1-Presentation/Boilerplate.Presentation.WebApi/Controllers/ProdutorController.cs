using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Boilerplate.AppServices.Resources.Dto;
using Boilerplate.AppServices.Resources.Interfaces;

namespace Boilerplate.Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutorController : ControllerBase
    {
        IProdutorAppService _appService;

        public ProdutorController(IProdutorAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public async Task<ICollection<ProdutorDto>> GetAll()
        {
            return await _appService.GetAll();
        }
    }
}
