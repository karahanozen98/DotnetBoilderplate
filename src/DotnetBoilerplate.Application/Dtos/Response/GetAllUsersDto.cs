using DotnetBoilerplate.Domain.Entities;

namespace DotnetBoilerplate.Application.Dtos.Response
{
    public class GetAllUsersDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public GetAllUsersDto(User user)
        {
            this.Id = user.Id;
            this.Email = user.Email;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.CreatedAt = user.CreatedAt;
            this.UpdatedAt = user.UpdatedAt;
        }
    }
}