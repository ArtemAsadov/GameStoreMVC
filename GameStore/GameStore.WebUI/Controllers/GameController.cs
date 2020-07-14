using GameStore.Domain.Abstract;
using System.Linq;
using System.Web.Mvc;

namespace GameStore.WebUI.Controllers
{
    public class GameController : Controller
    {
        private IGameRepository repository;
        public int pageSize = 4; //Максимальное количество отоброжаемой информации на странице
        public GameController(IGameRepository _repository)
        {
            repository = _repository;
        }

        public ViewResult List(int page = 1)
        {
            return View(repository.Games
                .OrderBy(g => g.GameId) //Сортируем по ID ку
                .Skip((page - 1) * pageSize) // Пропускаем столько элементов сколько было сумарно на предыдущих страницах
                .Take(pageSize)); // Берем то что осталось в количестве pageSize
        }
    }
}