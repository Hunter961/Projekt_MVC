using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_MVC.Context
{
    public class DomainDbContext:DbContext
    {
        DbSet<Employee> Employees { get; set; }
    }
}
