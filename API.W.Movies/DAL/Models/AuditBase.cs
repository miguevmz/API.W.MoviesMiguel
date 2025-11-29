using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models
{
    public class AuditBase
    {
        [Key]
        public virtual int Id { get; set; }


        public DateTime CreatedDate { get; set; }//Me indica la fehca de creacion

        public DateTime? UpdateDate { get; set; }//me indica la fecha 
    }
}
