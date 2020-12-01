namespace Album.Application.Model
{
    using System.Collections.Generic;
    using Album.Business.Model;
    using Album.Domain.Model;
    using Album.Domain.Model.Services;

    public class AlbumApplicationService : IAlbumApplicationService
    {
        private readonly IAlbumDomainService albumDomainService;
        public AlbumApplicationService(IAlbumDomainService albumDomainService)
        {
            this.albumDomainService = albumDomainService;
            //this.albumDomainService = new AlbumDomainService();
        }

        public IEnumerable<Album> ListAlbumsByPopularity()
        {
            return this.albumDomainService.ListAlbumsByPopularity();
        }

        public IEnumerable<Album> ListAlbumsByArtist(string artistName)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Track> CreatePlayList(List<Album> albums)
        {
            throw new System.NotImplementedException();
        }
    }
}