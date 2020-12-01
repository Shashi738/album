
using System.Collections.Generic;

namespace Album.Domain.Model
{
    public class Album
    {
        public long Id {get;set;}
        public string Name {get;set;}
        public Artist Artist { get; set; }
        public List<Track> Tracks { get; set; }
    }
}