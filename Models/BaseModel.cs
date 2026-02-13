using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public abstract class BaseModel
    {
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Column(Order = 1)]
        public DateTime CreatedOn { get; set; }

        [Column(Order = 2)]
        public Guid CreatedById { get; set; }

        [Column(Order = 3)]
        public DateTime? ModifiedOn { get; set; }

        [Column(Order = 4)]
        public Guid? ModifiedById { get; set; }

        [Required(ErrorMessage = "Name cannot be empty.")]
        [Column(Order = 5)]
        public virtual string Name { get; set; }

    }
}
