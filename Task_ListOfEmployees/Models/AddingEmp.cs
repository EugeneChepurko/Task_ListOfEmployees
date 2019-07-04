using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task_ListOfEmployees.Models
{
    public class AddingEmp
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public byte Gender { get; set; }
        public Departament departament { get; set; }
        public virtual int? Id_Department { get; set; }
        public virtual int? Id_Language { get; set; }

        public AddingEmp()
        {
            departament = new Departament();
        }


    }
}