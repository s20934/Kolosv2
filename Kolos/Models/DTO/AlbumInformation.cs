using System;
using System.Collections.Generic;

namespace Kolos.Models.DTO
{
    public class AlbumInformation
    {


        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }

    }
}
