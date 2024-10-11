using DotnetBoilerplate.Domain.Entities;

namespace DotnetBoilerplate.Application.Features.Queries.GetUserById
{
    public class GetUserByIdResponseDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public GetUserByIdResponseDto(User user)
        {
            this.Id = user.Id;
            this.Email = user.Email;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
        }
    }
}