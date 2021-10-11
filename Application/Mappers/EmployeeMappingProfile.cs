using Application.Commands;
using Application.Responses;
using AutoMapper;

namespace Application.Mappers
{
    public class EmployeeMappingProfile: Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap < Core.Entities.Employee, EmployeeResponse > ().ReverseMap();
            CreateMap < Core.Entities.Employee, CreateEmployeeCommand > ().ReverseMap();
        }
    }
}