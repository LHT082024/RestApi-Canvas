using Microsoft.AspNetCore.Mvc;
using RestApi1.Models;

namespace RestApi1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimeController : Controller
    {
        private static List<Anime> animes = new List<Anime>()
        {
            new Anime{Id = 1, Title = "The Devil is a part timer", MyRating = "season 1 is a 10/10 perfect then they waited 9 years to make season 2 with half the budget and it shows :("},
            new Anime{Id = 2, Title = "Tokyo ghoul", MyRating = "if you were emo between 2007-2016 its either gonna be a 10/10 blast to past or a 0/10 blast to past. Either way dont watch season 2 or 3 they stop following the manga and cut the budget and it shows :(" },
            new Anime{Id = 3, Title = "Cyberpunk edgerunners", MyRating = "I really want to stay at your house :("},
            new Anime{Id = 4, Title = "Solo leveling", MyRating = "every fight is a blast and shadow demons are cool 8/10"},
           new Anime{Id = 5, Title = "Sword art online alternitve", MyRating = "You know that one person who gets way to into video games to the point that it needs a diagonsis? they made an anime about them :) 7/10 Most realistic battle royal ending in media"},
           new Anime{Id = 6, Title = "Noragami", MyRating ="You know that dude in his 20s who dosent know what to do with his life, is constantly broke and will show up at your house drunk asking to sleep on the couch cause winter has arrived and the bridge he usally sleep under is occupied. What if that dude was a god? 9/10 for the opening alone" },
           new Anime{Id = 7, Title = "91 days", MyRating = "Classic mafia revenge story with an anime touch 5/10 made me cry when I was 16"},
           new Anime{Id = 8, Title = "Attack on titan", MyRating = "The biggest 'we live in a soceity' anime ever made where you think you know what's gonna happen then season 3 finishes and drags it in a completly new and bloody direction. Eren did nothing wrong/10" },
        };

        [HttpGet]
        public IEnumerable<Anime> Get()
        { 
            return animes; 
        }

        [HttpPost]
        public IActionResult Post([FromBody] Anime _animes)
        {
            if (animes == null)
            {
                return BadRequest("It's you, not me");
            }
            animes.Add(_animes);
            return CreatedAtAction(nameof(Post), new { id = _animes.Id, title = _animes.Title, myRating = _animes.MyRating}, _animes);
        }

    }   
}