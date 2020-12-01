
namespace Album.Business.Model
{
    using System.Collections.Generic;
    using Album.Domain.Model.Services;
    using Album.Domain.Model;
    public class AlbumDomainService : IAlbumDomainService
    {
        public IEnumerable<Album> ListAlbumsByArtist(string artistName)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Album> ListAlbumsByPopularity()
        {            
            return new List<Album>()
            {
                new Album
                {
                    Id = 1,
                    Name = "Aventine",
                    Artist =   new Artist
                    {
                        Name = "Agnes Obel"
                    },
                    Tracks = new List<Track>()
                    {
                        new Track
                        {
                            Name = "Fuel to Fire",
                            Time = 5.30
                        },
                        new Track
                        {
                            Name = "Dorian",
                            Time = 4.48
                        }
                    }
                }
            };
        }

        public IEnumerable<Track> GetTracks(long albumId, long artistId)
        {
            throw new System.NotImplementedException();
        }      
    }
}