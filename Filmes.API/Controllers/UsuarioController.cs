using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filmes.Shared.Interface;
using Filmes.Shared.Models;
using Filmes.Shared.Settings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Filmes.API.Controllers
{
    [ApiController]
    [Authorize(SecurityRoles.User)]
    [Route("_api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioComponent _usuarioComponent;

        public UsuarioController(IUsuarioComponent usuarioComponent)
        {
            this._usuarioComponent = usuarioComponent;
        }

        //[AllowAnonymous]
        //public Task<IActionResult> Register(Usuario usuario)
        //{
        //    if(ModelState.IsValid)
        //    {

        //    }
        //    return View();
        //}
    }
}