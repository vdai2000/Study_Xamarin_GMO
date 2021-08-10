using System;
using System.Collections.Generic;
using System.Text;

namespace UI_Xamarin.Models
{
    public class ImgPET
    {
        string _type;
        string _imageType;
        string _image;

        public ImgPET(string type, string imageType, string image)
        {
            _type = type;
            _imageType = imageType;
            _image = image;
        }

        public string Type { get => _type; set => _type = value; }
        public string ImageType { get => _imageType; set => _imageType = value; }
        public string Image { get => _image; set => _image = value; }
    }
}
