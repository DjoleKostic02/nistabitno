using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AlbumBusiness
    {
        private readonly AlbumsRepository albumsRepository;
        
        public AlbumBusiness()
        {
            this.albumsRepository = new AlbumsRepository();
        }

        public List<Album> GelAllAlbums() { 

        return this.albumsRepository.GetAllAlbums();
        
        }

        public bool InsertAlbum(Album a) { 
        
            if(this.albumsRepository.InsertAlbum(a)>0)
            {
                return true;
            }
            return false;
        }

        public List<Album> GetAlbumMinMax(decimal min, decimal max)
        {
            return this.albumsRepository.GetAllAlbums().
                Where(a => min< a.Price && a.Price < max).ToList();
        }
    }
}
