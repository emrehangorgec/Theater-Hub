using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TheaterReservationPage.Models
{
    public class TheaterGames
    {
        [Key]
        public int TheaterId { get; set; }

        public  string Plays { get; set; }

        public  string Title { get; set; }

        public  decimal Price { get; set; }

    }
}