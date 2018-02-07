using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoApp.Contollers;

namespace ToDoApp.Models
{
    public class TodoAppContext :DbContext
    {
        public DbSet<Feladat> Feladatok { get; set; }
    }
}