
namespace Album.Domain.Model
{
    public class  Track
    {
        public long Id {get;set;}
        public string Name {get;set;}
        public double Time { get; set; }
        public long AlbumId {get;set;}
        public long ArtistId {get;set;}
    }
}