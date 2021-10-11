using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Repositories.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories.Implementation
{
    public class EmployeeRepository:Repository < Core.Entities.Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DatabaseContext context) : base(context) { }

        public async Task<IEnumerable<Core.Entities.Employee>> GetEmployeeByLastNameAsync(string lastname)
        {
            return await _context.Employees.Where(p => p.LastName == lastname).ToListAsync();
        }
    }
}