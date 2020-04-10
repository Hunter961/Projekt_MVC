using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    class Employee
    {
        [Key]
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


    }
}
