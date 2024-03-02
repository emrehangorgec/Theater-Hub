using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TheaterReservationPage.Data
{
    public class TheaterReservationPageContext : DbContext
    {

    
        public TheaterReservationPageContext() : base("name=TheaterReservationPageContext")
        {
        }

        public System.Data.Entity.DbSet<TheaterReservationPage.Models.TheaterGames> TheaterGames { get; set; }

    }
}
