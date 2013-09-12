using Grr.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace Grr.ViewModels
{
    public class GalleryViewModel
    {
        public IEnumerable<AlbumViewModel> Albums { get; set; }

        public GalleryViewModel()
        {
            this.Albums = DataPersister.GetFromXML("..\\..\\ImageGallery.xml");            
        }        
    }
}
