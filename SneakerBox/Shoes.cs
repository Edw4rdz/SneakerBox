
using System.Collections.Generic;

namespace SneakerBox
{
    public class Shoes
    {
        public string brand;
        public string model;
        public string description;
        public class ShoeLibrary
        {
            public List<Shoes> NikeList = new List<Shoes>();
            public List<Shoes> AdidasList = new List<Shoes>();
            public List<Shoes> NBList = new List<Shoes>();
        }
    }

}

