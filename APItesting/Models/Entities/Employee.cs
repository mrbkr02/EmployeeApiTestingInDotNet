using System.ComponentModel.DataAnnotations.Schema;

namespace APItesting.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal Salary { get; set; }

    }
}
