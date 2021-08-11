using System;
using System.Collections.Generic;
using System.Text;

namespace UI_Xamarin.Models
{
    public class PET
    {
        int _idPet;
        string _namePet;
        string _imgPet;
        string _type;
        string _distription;

        public PET(int idPet, string namePet, string imgPet, string type, string distription)
        {
            this.IdPet = idPet;
            this.NamePet = namePet;
            this.ImgPet = imgPet;
            this.Type = type;
            this.Distription = distription;
        }

        public int IdPet { get => _idPet; set => _idPet = value; }
        public string NamePet { get => _namePet; set => _namePet = value; }
        public string ImgPet { get => _imgPet; set => _imgPet = value; }
        public string Type { get => _type; set => _type = value; }
        public string Distription { get => _distription; set => _distription = value; }
    }
}
