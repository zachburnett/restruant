using System;
using System.ComponentModel.DataAnnotations;

namespace resturant.Models
{
    public class reviewer : BaseEntity
    {
        [Key]
        public int idtable1 {get; set;}

        [Required]
        public string username {get; set;}

        [Required]
        public string restruant {get; set;}

        [Required]
        public string review {get; set;}
        
        [Required]
        public DateTime datevisited {get; set;}
        
        [Required]
        public DateTime created_at {get; set;}
    }
}