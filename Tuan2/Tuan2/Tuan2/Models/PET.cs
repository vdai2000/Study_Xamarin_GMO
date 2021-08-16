using System;
using System.Collections.Generic;
using System.Text;

namespace Tuan2.Models
{
    public class PET
    {
        string name;
        string mota;

        public PET(string name, string mota)
        {
            this.Name = name;
            this.Mota = mota;
        }

        public string Name { get => name; set => name = value; }
        public string Mota { get => mota; set => mota = value; }
    }
}
