using System.ComponentModel.DataAnnotations;

namespace ECommerce.AzureStorage
{
    public class GetBlobRequestDTO
    {
        [Required]
        public string Name { get; set; }

        public override string ToString()
        {
            // Might Required to pursing?
            return base.ToString();
        }
    }

}
