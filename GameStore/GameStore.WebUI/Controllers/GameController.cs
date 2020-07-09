using GameStore.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.WebUI.Controllers
{
    public class GameController : Controller
    {
        private IGameRepository repository;
        public GameController(IGameRepository _repository) {
            repository = _repository;
        }

        public ViewResult List() {
            return View(repository.Games);
        }
    }
}