using System.ComponentModel.DataAnnotations;

namespace Task_ListOfEmployees.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }       
        public Departament Departament { get; set; }
        public int? DepartamentId { get; set; }
        public Language Language { get; set; }
        public int? LanguageId { get; set; }
    }
}