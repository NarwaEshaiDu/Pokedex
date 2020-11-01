using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pokedex.Models;

namespace Pokedex.Controllers
{
    public class PokedexController : Controller
    {
        private List<Pokemon> getPokemon()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            var lines = System.IO.File.ReadAllText(@"pokedex.json");
            return JsonSerializer.Deserialize<List<Pokemon>>(lines, options);
        }
        private readonly ILogger <PokedexController> logger;
        public PokedexController(ILogger<PokedexController> logger )
        {
            this.logger = logger;
        }
        public IActionResult Index()
        {
            ViewBag.TimeStampGenerated = DateTime.Now.ToString();
            logger.LogInformation("Someone visited the pokedex");
            return View(); 
        }
        public IActionResult Details(int id)
        {
            List<Pokemon> pokemon = getPokemon();
            foreach (var p in pokemon)
            {
                if (p.Id==id)
                {
                    return View(p);
                }
            }
            return NotFound();
            
        }
    }
}
