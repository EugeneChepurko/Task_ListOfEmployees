using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task_ListOfEmployees.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int? Id_department { get; set; }
        public virtual int? Id_Lang { get; set; }
        public virtual string departament { get; set; }
        //public virtual Departament departamentName { get; set; }
        //public Employee()
        //{
        //    departamentName = new Departament();
        //}

        //public byte Gender { get; set; }
    }
}