using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DigiMovie.Models;
using DigiMovie.ViewModels;

namespace DigiMovie.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            //var movie = new DigiMovie.Models.Movie {
            //    Id = 1,
            //    Name="Hangover 3"
            //};
            //return View(movie);

            var movies = new List<Movie>() {
                new Movie{Id=1,Name="Hangover 3"},
                new Movie{Id=2,Name="Taken"},
                new Movie{Id=3,Name="Seperation"},
                new Movie{Id=4,Name="James Band"}
            };
            return View(movies);
        }

        public ActionResult Random()
        {
            var viewModel = new RandomViewModel {
                Movie = new Movie
                {
                    Id = 1,
                    Name = "Taken"
                },
                Customers = new List<Customer>
            {
                new Customer{Id=1,Name="Ali"},
                new Customer{Id=2,Name="Reza"},
                new Customer{Id=3,Name="Mina"},
                new Customer{Id=4,Name="Nahid"}
            }
            };
            return View(viewModel);
        }
    }
}