using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task_ListOfEmployees.Models
{
    public class ListEmpContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }    
        public DbSet<Departament> Departaments { get; set; }    
        public DbSet<Language> Languages { get; set; }
        public DbSet<OverallTable> OverallTables { get; set; }
    }
}