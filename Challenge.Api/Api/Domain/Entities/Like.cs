namespace Challenge.Api.Domain.Entities
{
    public class Like : Entity
    {
        public int MovieId { get; set; }
        public string CustomerEmail { get; set; }
    }
}
