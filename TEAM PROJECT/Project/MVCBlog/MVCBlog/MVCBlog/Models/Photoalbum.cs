using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace MVCBlog.Models
{
    public class Photoalbum
    {
        [Key]
        public int ImageId { get; set; }
        public int ImageSize { get; set; }
        [StringLength(200)]
        public string FileName { get; set; }
        public byte[] ImageData { get; set; }
        [NotMapped]
        [Display(Name = "Снимка")]
        public HttpPostedFileBase File { get; set; }
    }
}