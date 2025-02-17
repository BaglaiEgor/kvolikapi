using kvolikapi.db;
using kvolikapi.Interfaces;
using kvolikapi.Model;
using kvolikapi.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static System.Reflection.Metadata.BlobBuilder;

namespace kvolikapi.Service
{
    public class MovieService : IMovieService
    {
        private readonly ContextDb _context;

        public MovieService(ContextDb context)
        {
            _context = context;
        }

        public async Task<List<Movies>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movies> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }


        public async Task<List<Movies>> GetMovieByTitleAsync(string title)
        {
            return await _context.Movies.Where(m => m.Title.StartsWith(title)).ToListAsync();
        }

        public async Task<bool> CreateMovieAsync(Movies movie)
        {
            if (await _context.Movies.AnyAsync(m => m.Title == movie.Title))
                return false;

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateMovieAsync(Movies movie)
        {
            var existingMovie = await _context.Movies.FindAsync(movie.id_Movie);
            if (existingMovie == null)
                return false;

            existingMovie.Title = movie.Title;
            existingMovie.Description = movie.Description;
            existingMovie.Genre = movie.Genre;
            existingMovie.ReleaseDate = movie.ReleaseDate;
            existingMovie.Rating = movie.Rating;
            existingMovie.ImageUrl = movie.ImageUrl;


            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return false;
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}