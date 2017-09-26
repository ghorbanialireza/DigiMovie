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

        [Required(ErrorMessage ="لطفا نام خود را وارد نمایید")]
        [StringLength(50, ErrorMessage = "نام حداکثر می تواند 50 کاراکتر باشد")]
        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "لطفا تاریخ انتشار خود را وارد نمایید")]
        public DateTime DateRelseased { get; set; }

        [Required(ErrorMessage = "لطفا تعداد موجود خود را وارد نمایید")]
        [Range(1,20,ErrorMessage ="تعداد می تواند از بین 1 تا 20 باشد")]
        public byte NumberInStock { get; set; }

        #region RelationBetweenMovieAndGenre
        //This is forign key
        [Required(ErrorMessage ="لطفا دسته بندی فیلم را انتخاب نمایید")]
        public byte GenreId { get; set; }
        //This is navigation property
        public Genre Genre { get; set; }
        #endregion

    }
}