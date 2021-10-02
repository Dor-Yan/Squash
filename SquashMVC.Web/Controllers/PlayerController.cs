using Microsoft.AspNetCore.Mvc;
using SquashMVC.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquashMVC.Web.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerService _playService;
        public PlayerController(IPlayerService playService)
        {
            _playService = playService;
        }
        public IActionResult Index()
        {
            // utworzyć widok dla tej akcji
            // tabela z graczami
            // filtrowanie graczy
            // przygotować dane
            // przekazać filtry do serwisu
            // serwis musi przygotować dane
            // serwis musi zwrócić dane w odpowiednim formacie

            var model = _playService.GetAllPlayerForList();
            return View(model);
        }

        [HttpGet]

        public IActionResult AddPlayer()
        {
            return View();
        }

        //[HttpPost]

        //public IActionResult AddPlayer(PlayerModel model)
        //{
        //    var id = _playService.AddPlayer(model);
        //    return View();
        //}

        public IActionResult Details(int id)
        {
            var playerModel = _playService.GetPlayerDetails(id);
            return View(playerModel);
        }
    }
}
