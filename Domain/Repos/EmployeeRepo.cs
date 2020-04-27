using Projekt_MVC.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos
{

    public class EmployeeRepo : IEmployeeRepo

    {
        private DomainDbContext _context = new DomainDbContext();

    }
}
