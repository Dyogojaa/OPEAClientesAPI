using System.ComponentModel.DataAnnotations;

namespace OPEA.ClienteAPI.Models.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

    }
}
