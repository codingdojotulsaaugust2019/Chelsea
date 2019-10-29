using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace weddingPlanner.Models
{
    public class DashboardView
    {
        public List<Wedding> Weddings {get;set;}

        public User User {get;set;}

        public List<Guest> Guests {get;set;}
    }
}