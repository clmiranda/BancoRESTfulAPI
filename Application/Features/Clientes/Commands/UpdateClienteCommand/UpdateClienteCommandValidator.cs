using FluentValidation;

namespace Application.Features.Clientes.Commands.UpdateClienteCommand
{
    public class UpdateClienteCommandValidator : AbstractValidator<UpdateClienteCommand>
    {
        public UpdateClienteCommandValidator()
        {
            RuleFor(c => c.Nombre)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacío.")
                .MaximumLength(100).WithMessage("{PropertyName} no debe tener mas de {MaxLength} caracteres.");

            RuleFor(c => c.Apellido)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacío.")
                .MaximumLength(100).WithMessage("{PropertyName} no debe tener mas de {MaxLength} caracteres.");

            RuleFor(c => c.FechaNacimiento)
                .NotEmpty().WithMessage("Fecha de Nacimiento no puede estar vacía.");

            RuleFor(c => c.Telefono)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacío.")
                .MaximumLength(9).WithMessage("{PropertyName} no debe tener mas de {MaxLength} caracteres.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacío.")
                .EmailAddress().WithMessage("{PropertyName} debe ser una dirección de email válida")
                .MaximumLength(100).WithMessage("{PropertyName} no debe tener mas de {MaxLength} caracteres.");

            RuleFor(c => c.Direccion)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacía.")
                .MaximumLength(150).WithMessage("{PropertyName} no debe tener mas de {MaxLength} caracteres.");
        }
    }
}