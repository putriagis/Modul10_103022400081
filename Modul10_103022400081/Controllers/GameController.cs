using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace Modul10_103022400081.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class GameController : ControllerBase
    {
        private static List<Game> games = new List<Game>
        {
            new Game { nama ="Valorant", Developer = "Riot Games", TahunRilis = 2020,Genre = "FPS", Rating= 8.5, Platform=["PC"], Mode= ["Multiplayer"], IsOnline = true, Harga = 0},
            new Game { nama = "GTA Vt", Developer = "“Rockstar Games", TahunRilis=  2013,Genre= "Open World", Rating = 9.5, Platform=["PC","PS4","PS5","Xbox"], Mode =["Singleplayer", "Multiplayer"], IsOnline =true, Harga =300000},
            new Game { nama = "“The Witcher 3", Developer = "CD Projekt Red", TahunRilis=  2015,Genre= "RPG", Rating = 9.7, Platform=["PC","PS4","PS5","Xbox","Switch"], Mode =["Singleplayer"], IsOnline =false, Harga =250000}
        };
        [HttpGet]
        public ActionResult<List<Game>> GetAll()
        {
            return games;
        }

        [HttpGet("{index}")]
        public ActionResult<Game> GetByIndex(int index)
        {
            if(index < 0 || index >= games.Count)
                return NotFound();
            return games[index];
        }
        [HttpPut]
        public ActionResult<Game> putByIndex(int index)
        {
            if (index < 0 || index >= games.Count)
                return NotFound();
            return games [index];
        }

        [HttpPost]
        public ActionResult <Game> addGame( Game game)
        {
            games.Add(game);
            return Ok(games);
        }
        [HttpDelete("{index}")]
        public ActionResult DeleteGame(int index)
        {
            var game = games.FirstOrDefault(g => g.id == index);
            if (game == null)
            {
                return NotFound();
            }
            games.Remove(game);
            return Ok(games);
        }
    }
}
