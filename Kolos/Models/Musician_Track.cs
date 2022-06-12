using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolos.Models
{
    public class Musician_Track
    {
        [Key]
        public int IdTrack { get; set; }    
        [Key]
        public int IdMusician { get; set; }


        [ForeignKey("IdTrack")]
        public virtual Track Track { get; set; }
        [ForeignKey("IdMusician")]
        public virtual Musician Musician { get; set; }
    }
}
