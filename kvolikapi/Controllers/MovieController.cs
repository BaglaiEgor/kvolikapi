﻿using kvolikapi.Interfaces;
using kvolikapi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace kvolikapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            var movies = await _movieService.GetAllMoviesAsync();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            var movie = await _movieService.GetMovieByIdAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }


        [HttpGet("SearchByTitle")]
        public async Task<IActionResult> GetMoviesByTitle(string title)
        {
            var movies = await _movieService.GetMovieByTitleAsync(title);
            if (movies == null)
                return NotFound();

            return Ok(movies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(Movies movie)
        {
            var result = await _movieService.CreateMovieAsync(movie);
            if (!result)
                return BadRequest("Movie already exists");

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, Movies movie)
        {
            if (id != movie.id_Movie)
            {
                return BadRequest();
            }

            var result = await _movieService.UpdateMovieAsync(movie);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var result = await _movieService.DeleteMovieAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}