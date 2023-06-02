using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicSoulmates.Data
{
    public class BaseData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        public string Code { get; set; }

        [StringLength(255)]
        public string Value { get; set; }

        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public virtual BaseData Parent { get; set; }

        public int Order { get; set; }

        [Required]
        public bool IsDeleted { get; set; }
    }
}
