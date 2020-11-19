using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengerBack.Domain.Models;
using ChallengerBack.Domain.Services;

namespace ChallengerBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService movieService;

        public MoviesController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        [HttpGet]
        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            var result = await this.movieService.GetMoviesAsync();
            return result;
        }
    }
}
