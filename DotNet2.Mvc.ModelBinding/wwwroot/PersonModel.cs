using System.ComponentModel.DataAnnotations;
namespace DotNet2.Mvc.ModelBinding
{
    public class PersonModel
    {
        [StringLength(5)]
        public string Name { get; set; }

        
        public int Age { get; set; }
    }
}
