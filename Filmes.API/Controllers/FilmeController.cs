using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filmes.Shared.Interface;
using Filmes.Shared.Settings;
using Filmes.Shared.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Filmes.API.Controllers
{
    [ApiController]
    //[Authorize(SecurityRoles.User)]
    [Route("_api/[controller]")]
    public class FilmeController : Controller
    {
        private readonly IFilmeComponent _filmeComponent;

        public FilmeController(IFilmeComponent filmeComponent)
        {
            this._filmeComponent = filmeComponent;
        }

        [HttpGet("Todos")]
        public async Task<JsonResult> GetAllMovies()
        {
            var result = await _filmeComponent.GetAll();

            return Json(result);
        }

        [HttpGet("Pesquisar")]
        public async Task<JsonResult> SearchMovies(FilmeViewModel model)
        {
            var result = await _filmeComponent.Search(model);

            return Json(result);
        }
    }
}