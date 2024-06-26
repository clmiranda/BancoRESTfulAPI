﻿using FluentValidation.Results;

namespace Application.Exceptions
{
    public class ValidationException:Exception
    {
        public ValidationException():base("Se han producido uno o varios errores de validación")
        {
            Errors = [];
        }
        public List<string> Errors { get; }

        public ValidationException(IEnumerable<ValidationFailure> failures): this()
        {
            foreach (var failure in failures)
            {
                Errors.Add(failure.ErrorMessage);
            }
        }
    }
}