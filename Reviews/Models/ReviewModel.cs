using System.ComponentModel.DataAnnotations;

namespace Reviews.Models
{
    public class ReviewModel
    {
        public int ?Id { get; set; }
        public string ?Author { get; set; }

        public string ?Content { get; set; }
    }
}
