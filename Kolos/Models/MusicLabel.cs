﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kolos.Models
{
    public class MusicLabel
    {


        [Key]
        public int IdMusicLabel { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


        public virtual ICollection<Album> Album { get; set; }
    }
}
