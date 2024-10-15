using DotnetBoilerplate.Core.Validation;

namespace DotnetBoilerplate.Core.Exceptions
{
    public class ValidationException : Exception
    {
        public readonly IEnumerable<ValidationError> ValidationErrors;

        public ValidationException(string message, IEnumerable<ValidationError> validationErrors) : base(message)
        {
            this.ValidationErrors = validationErrors;
        }
    }
}