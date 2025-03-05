using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace APItesting.Models
{
    public class UpdateEmployeeDto
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal Salary { get; set; }
    }
}
