namespace API.W.Movies.DAL.Models
{
    public class Movie : AuditBase
    {
       
        public string Name { get; set; } = null!;


        
        public int Duration { get; set; }
       
        public string Clasification { get; set; } = null!;

       

        public string? Director { get; set; }

        public string? Studio { get; set; }

        public DateTime? ReleaseDate { get; set; }
        public DateTime? UpdatedDate { get; internal set; }
    }
}
