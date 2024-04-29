using Application.Interfaces;
using Application.Wrappers;
using Domain.Entities;
using MediatR;

namespace Application.Features.Clientes.Commands.UpdateClienteCommand
{
    public class UpdateClienteCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public required string Telefono { get; set; }
        public required string Email { get; set; }
        public required string Direccion { get; set; }
    }
    public class UpdateClienteCommandHandler : IRequestHandler<UpdateClienteCommand, Response<int>> {
        private readonly IRepositoryAsync<Cliente> _repositoryAsync;

        public UpdateClienteCommandHandler(IRepositoryAsync<Cliente> repositoryAsync)
        {
            _repositoryAsync = repositoryAsync;
        }
        public async Task<Response<int>> Handle(UpdateClienteCommand request, CancellationToken cancellationToken) {
            var cliente = await _repositoryAsync.GetByIdAsync(request.Id);
            if (cliente == null)
            {
                throw new KeyNotFoundException($"No se encuentra un registro con el Id {request.Id}");
            }
            else
            {
                cliente.Nombre = request.Nombre;
                cliente.Apellido = request.Apellido;
                cliente.FechaNacimiento = request.FechaNacimiento;
                cliente.Telefono = request.Telefono;
                cliente.Email = request.Email;
                cliente.Direccion = request.Direccion;

                await _repositoryAsync.UpdateAsync(cliente);
                return new Response<int>(cliente.Id);
            }
        }
    }
}