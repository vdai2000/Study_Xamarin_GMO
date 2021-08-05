using System;
using System.Collections.Generic;
using System.Text;

namespace UI_Xamarin.Models
{
    public class PET
    {
        int idPet;
        string namePet;
        string imgPet;
        string type;
        string distription;

        public PET(int idPet, string namePet, string imgPet, string type, string distription)
        {
            this.idPet = idPet;
            this.namePet = namePet;
            this.imgPet = imgPet;
            this.type = type;
            this.distription = distription;
        }

        public int IdPet { get => idPet; set => idPet = value; }
        public string NamePet { get => namePet; set => namePet = value; }
        public string ImgPet { get => imgPet; set => imgPet = value; }
        public string Type { get => type; set => type = value; }
        public string Distription { get => distription; set => distription = value; }
    }
}
