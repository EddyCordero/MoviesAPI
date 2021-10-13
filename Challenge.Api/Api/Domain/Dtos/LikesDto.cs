
using System.Collections.Generic;

namespace Challenge.Api.Domain.Dtos
{
    public class LikesDto
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public int Likes { get; set; }
        public IList<string> CustomerEmails { get; set; }
    }
}
