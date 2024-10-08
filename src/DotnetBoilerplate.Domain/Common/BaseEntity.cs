namespace DotnetBoilerplate.Domain.Common
{
    public class BaseEntity
    {
        public Guid Id { get; protected set; }

        public DateTime CreatedAt { get; protected set; }

        public DateTime UpdatedAt { get; protected set; }

        public void SetCreatedAt(DateTime date)
        {
            this.CreatedAt = date;
        }

        public void SetUpdatedAt(DateTime date)
        {
            this.UpdatedAt = date;
        }
    }
}