using API.W.Movies.DAL.Models;

namespace API.W.Movies.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
        Task<Movie?> GetMovieAsync(int id);
        Task<Movie> CreateMovieAsync(Movie movie);
        Task<bool> UpdateMovieAsync(Movie movie);
        Task<bool> DeleteMovieAsync(int id);
        Task<bool> MovieExistsAsync(int id);
    }
}
