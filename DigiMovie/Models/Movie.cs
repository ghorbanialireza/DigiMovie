using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace DigiMovie.Models
{
	public class Movie
	{
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime DateRelseased { get; set; }

        public byte NumberInStock { get; set; }

        #region RelationBetweenMovieAndGenre
        //This is forign key
        [Required]
        public byte GenreId { get; set; }
        //This is navigation property
        public Genre Genre { get; set; }
        #endregion

    }
}