using DotnetBoilerplate.Domain.Entities;

namespace DotnetBoilerplate.Application.Dtos
{
    public class GetAllUsersDto
    {
        public Guid Id { get; set; }

        public string Email { get; protected set; }

        public string FirstName { get; protected set; }

        public string LastName { get; protected set; }

        public GetAllUsersDto(User user)
        {
            this.Id = user.Id;
            this.Email = user.Email;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
        }
    }
}