namespace Album.Application.Model
{
    using System.Collections.Generic;
    using Album.Domain.Model;

    public interface IAlbumApplicationService
    {
        IEnumerable<Album> ListAlbumsByPopularity();
        IEnumerable<Album> ListAlbumsByArtist(string artistName);
        IEnumerable<Track> CreatePlayList(List<Album> albums);
    }
}