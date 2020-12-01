using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Album.Application.Model;
using Album.Domain.Model.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Album.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly ILogger<AlbumController> logger;
        private readonly IAlbumApplicationService albumApplicationService; 

        public AlbumController(ILogger<AlbumController> logger, IAlbumApplicationService albumApplicationService)
        {
            this.logger = logger;
            this.albumApplicationService = albumApplicationService;
        }

        [HttpGet]
        [Route("popular")]
        public IEnumerable<Album.Domain.Model.Album> GetPopularAlbums()
        {
            logger.LogInformation("api endpoint: api/album/popular");
            var popularAlbums = albumApplicationService.ListAlbumsByPopularity();
            return  popularAlbums;
        }
    }
}