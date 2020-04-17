using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    class Employee
    {
        [Key]
        [Column(Order =1)]
        public int EmployeeID { get; set; }
        [StringLength(25)]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [StringLength(30)]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Display(Name = "Miasto")]
        public string City { get; set; }
        [Display(Name = "Kraj")]
        public string Country { get; set; }
        [Display(Name = "Pensja")]
        [DataType(DataType.Currency)]
        public int Salary { get; set; }
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Poprawny numer Pesel musi zawierać 9 cyfr!")]
        [RegularExpression(@"^\(?([0-9]{11})$")]
        [Display(Name = "Pesel")]
        public string PESEL { get; set; }
        [Display(Name = "Data urodzenia")]
        public DateTime DateOfBirth { get; set; }


    }
}
