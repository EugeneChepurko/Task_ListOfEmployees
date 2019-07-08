using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task_ListOfEmployees.Models
{
    public class Departament
    {
        [Key]
        public int Id { get; set; }
        public string Depart_Name { get; set; }
        public int Frool { get; set; }
        //public IEnumerable<Employee> Employees { get; set; }
    }
}