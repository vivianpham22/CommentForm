using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CommentForm.Models
{
    public class Comment
    {
        // THIS IS CODE FIRST

        [Key]
        public int CommentID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }

        [ForeignKey("Procedure")]
        public int ProducureID { get; set; }
        public virtual Procedure Procedure { get; set; }

    }
}