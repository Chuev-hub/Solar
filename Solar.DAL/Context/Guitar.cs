﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.DAL.Context
{
    public class Guitar
    { 

        public int GuitarId { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string Material { get; set; }
        public string Shape { get; set; }
        public string NumberOfStrings { get; set; }
        public string Color { get; set; }
        public string LeftHanded { get; set; }
        public string Switch { get; set; }
        public string Neck { get; set; }
        public string Middle { get; set; }
        public string Bridge { get; set; }
        public int GuitarCategoryId { get; set; }
        public int MainPhotoId { get; set; }
        public int SecondPhotoId { get; set; }
        public int ThirdPhotoId { get; set; }
        public int CharacteristicPhotoId { get; set; }

        public virtual GuitarCategory GuitarCategory { get; set; }

    }
}
