using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        //pass in the delegate that will handle the photo object
        public void Process(string path, PhotoFilterHandler photoFilterHandler)
        {

            var photo = Photo.Load(path);

            photoFilterHandler(photo);

            photo.Save();
        }
    }
}
