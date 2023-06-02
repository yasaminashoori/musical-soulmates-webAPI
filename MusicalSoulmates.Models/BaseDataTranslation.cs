using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicSoulmates.Data
{
    public class BaseDataTranslation
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("BaseData")]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string Lang { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public virtual BaseData BaseData { get; set; }
    }
}
