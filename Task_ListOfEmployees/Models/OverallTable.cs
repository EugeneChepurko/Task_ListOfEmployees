using System.ComponentModel.DataAnnotations;

namespace Task_ListOfEmployees.Models
{
    public class OverallTable
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int? DepartamentId { get; set; }
        public int? LanguageId { get; set; }
    }
}