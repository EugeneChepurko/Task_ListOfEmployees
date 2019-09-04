using System.ComponentModel.DataAnnotations;

namespace Task_ListOfEmployees.Models
{
    public class Departament
    {
        [Key]
        public int Id { get; set; }
        public string Depart_Name { get; set; }
        public int Frool { get; set; }
    }
}