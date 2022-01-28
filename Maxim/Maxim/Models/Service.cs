using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Maxim.Models
{
    public class Service
    {
        public int ID { get; set; }
        [MaxLength(255)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(15)]
        public string  Title{ get; set; }
        [Column(TypeName = "nText")]
        public string Text { get; set; }
    }
}
