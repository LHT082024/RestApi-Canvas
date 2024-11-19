using Microsoft.AspNetCore.Mvc;
using RestApi1.Models;

namespace RestApi1.Controllers
{
    [ApiController]
    [Route("[Anime]")]
    public class AnimeController : Controller
    {
        private static List<Anime> _animes = new List<Anime>();
        {
            new AnimeController{}
        }

    }
}
