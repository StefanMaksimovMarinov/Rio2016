using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.XPath;

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
        public HttpPostedFileBase File { get; set; }
    }
}