namespace DotnetBoilerplate.Domain.Common
{
    public class BaseEntity
    {
        public Guid Id { get; protected set; }

        public DateTime CreatedAt { get; protected set; }

        public DateTime UpdatedAt { get; protected set; }

        public void SetCreatedAt()
        {
            this.CreatedAt = DateTime.Now;
        }

        public void SetUpdatedAt()
        {
            this.UpdatedAt = DateTime.Now;
        }
    }
}