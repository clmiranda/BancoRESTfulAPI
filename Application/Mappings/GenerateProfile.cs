using Application.DTOs;
using Application.Features.Clientes.Commands.CreateClienteCommand;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class GenerateProfile : Profile
    {
        public GenerateProfile()
        {
            #region Commands
            CreateMap<CreateClienteCommand, Cliente>();
            #endregion

            #region DTOs
            CreateMap<Cliente, ClienteDto>();
            #endregion
        }
    }
}