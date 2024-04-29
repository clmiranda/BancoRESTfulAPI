using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Clientes.Commands.CreateClienteCommand
{
    public class CreateClienteCommand : IRequest<Response<int>>
    {
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public required string Telefono { get; set; }
        public required string Email { get; set; }
        public required string Direccion { get; set; }
    }

    public class CreateClienteCommandHandler : IRequestHandler<CreateClienteCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Cliente> _repositoryAsync;
        private readonly IMapper _mapper;
        public CreateClienteCommandHandler(IRepositoryAsync<Cliente> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
        {
            var nuevoRegistro = _mapper.Map<Cliente>(request);
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);
            return new Response<int>(data.Id);
        }
    }
}