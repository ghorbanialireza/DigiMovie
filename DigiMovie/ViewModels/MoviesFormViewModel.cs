using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DigiMovie.Models;
namespace DigiMovie.ViewModels
{
    public class MoviesFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}