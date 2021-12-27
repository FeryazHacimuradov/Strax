using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Strax.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }


        public Category Category{ get; set; }


        public DateTime CreatedDate { get; set; }
    }
}
