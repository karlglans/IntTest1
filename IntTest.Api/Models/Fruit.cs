using System.ComponentModel.DataAnnotations;

namespace IntTest.Api.Models
{
    public class Fruit
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
