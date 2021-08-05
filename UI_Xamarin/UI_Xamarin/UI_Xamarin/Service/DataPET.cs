using System;
using System.Collections.Generic;
using System.Text;
using UI_Xamarin.Models;
using System.Linq;

namespace UI_Xamarin.Service
{
    public class DataPET
    {
        public List<PET> pet;
        public DataPET()
        {
            pet = new List<PET>()
            {
                new PET(1,"Husky","https://lh3.googleusercontent.com/proxy/9WEZwUW5Cz6JrJhcvmccFCwmRJAvQqG95b-GMoAvPp7TPqKkITZuVc1WdfrxYR1xipQDUU3ohILiHcru7tvLAZ-6aVE0KyHYx-j6Qo3yL5hWNJRahLPJ1hJvFXF8wcZaKMxvSRrMhfsGwg","Chó Husky","Ngáo Nặng,Chuyên Phá Nhà Cửa"),
                new PET(2,"Meo","https://i.pinimg.com/236x/ca/fe/b2/cafeb2e288f830b582092fdcceea5dee.jpg","Meo","NMèo Quàng Thượng"),
                new PET(3,"Cat","https://i.pinimg.com/236x/fe/3f/ce/fe3fce7a9caeafebf6ef9b809a0327f6--harry-potter-couples.jpg","Meo","NMèo Quàng Thượng")
            };
        }
        public List<PET> GetALL()
        {
            List<PET> list = pet.ToList();
            return list;
        }

        public PET GetPETByName(string name)
        {
            return pet.Where(t => t.NamePet == name).FirstOrDefault();
        }
    }
}
