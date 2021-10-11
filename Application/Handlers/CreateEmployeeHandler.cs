using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Commands;
using Application.Mappers;
using Application.Responses;
using Core.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers
{
    public class CreateEmployeeHandler: IRequestHandler<CreateEmployeeCommand,EmployeeResponse>
    {
        private readonly IEmployeeRepository _employeeRepo;

        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<EmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeEntity = EmployeeMapper.Mapper.Map<Core.Entities.Employee>(request);
            if (employeeEntity is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newEmployee =  await _employeeRepo.AddAsync(employeeEntity);
            var employeeResponse = EmployeeMapper.Mapper.Map < EmployeeResponse > (newEmployee);
            return employeeResponse;
        }
    }
}