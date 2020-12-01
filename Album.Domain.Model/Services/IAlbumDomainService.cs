
namespace Album.Domain.Model.Services
{
    using System.Collections.Generic;
    public interface IAlbumDomainService
    {
        IEnumerable<Album> ListAlbumsByPopularity();
        IEnumerable<Album> ListAlbumsByArtist(string artistName);
        IEnumerable<Track> GetTracks(long albumId, long artistId);
    }
}