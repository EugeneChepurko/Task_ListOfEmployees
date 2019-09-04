using System.ComponentModel.DataAnnotations;

namespace Task_ListOfEmployees.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        public string LangName { get; set; }
    }
}