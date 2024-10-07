using DotnetBoilerplate.Domain.Common;

namespace DotnetBoilerplate.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; protected set; }

        public string FirstName { get; protected set; }

        public string LastName { get; protected set; }

        public string Password { get; protected set; }
    }
}