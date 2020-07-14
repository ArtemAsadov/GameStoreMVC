using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using GameStore.WebUI.Controllers;
using System.Linq;

namespace GameStore.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanPaginate()
        {
            var listGames = new List<Game>();
            for(int i = 0; i < 5; i++)
            {
                listGames.Add(new Game { GameId = i, Name = $"Game {i}" });
            }
            //Организация (arrange)
            Mock<IGameRepository> mock = new Mock<IGameRepository>();
            mock.Setup(m => m.Games).Returns(listGames);

            GameController controller = new GameController(mock.Object);
            controller.pageSize = 3;

            //Действие (act)
            IEnumerable<Game> result = (IEnumerable<Game>)controller.List(2).Model; //Забыл установить System.Web.Mvc

            //Утверждение (assert)
            List<Game> games = result.ToList();
            Assert.IsTrue(games.Count == 2);
            Assert.AreEqual(games[0].Name,"Game 3");
            Assert.AreEqual(games[1].Name,"Game 4");

        }
    }
}
