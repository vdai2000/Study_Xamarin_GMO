using System;
using System.Collections.Generic;
using System.Text;
using UI_Xamarin.Models;
using System.Linq;

namespace UI_Xamarin.Service
{
    public class DataPET
    {
        public List<PET> listpet;
        public DataPET()
        {
            listpet = new List<PET>()
            {
                new PET(1,"Husky","https://petmaster.vn/petroom/wp-content/uploads/2020/03/thanh-bieu-cam-cho-husky.jpg","Chó Husky","Ngáo Nặng,Chuyên Phá Nhà Cửa"),
                new PET(2,"Meo","https://i.pinimg.com/236x/ca/fe/b2/cafeb2e288f830b582092fdcceea5dee.jpg","Meo","NMèo Quàng Thượng"),
                new PET(3,"Cat","https://i.pinimg.com/236x/fe/3f/ce/fe3fce7a9caeafebf6ef9b809a0327f6--harry-potter-couples.jpg","Meo","NMèo Quàng Thượng")
            };
        }
        public List<PET> GetALL()
        {
            List<PET> list = listpet.ToList();
            return list;
        }

        public PET GetPETByName(string name)
        {
            return listpet.Where(t => t.NamePet == name).FirstOrDefault();
        }
    }
}
