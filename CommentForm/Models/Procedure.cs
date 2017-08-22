using System.ComponentModel.DataAnnotations;

namespace CommentForm.Models
{
    public class Procedure
    {
        [Key]
        public int ProcedureID { get; set; }

        public int Priority { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }

    }
}