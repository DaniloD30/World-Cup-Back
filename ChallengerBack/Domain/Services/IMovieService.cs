using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengerBack.Domain.Models;

namespace ChallengerBack.Domain.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
        IEnumerable<Movie> RunChampionship(IList<Movie> movies);
    }
}
