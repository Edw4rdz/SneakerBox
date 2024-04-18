using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBox
{
    public class ShoeModel
    {
        public List<Shoes> NikeList = new List<Shoes>();
        public List<Shoes> AdidasList = new List<Shoes>();
        public List<Shoes> NBList = new List<Shoes>();

        public ShoeModel()
        {

            Shoes NikeOne = new Shoes();
            NikeOne.brand = "Nike";
            NikeOne.model = "Sabrina 1";
            NikeOne.description = "Basketball Shoes";

            Shoes NikeTwo = new Shoes();
            NikeTwo.brand = "Nike";
            NikeTwo.model = "Lebron 20";
            NikeTwo.description = "Basketball Shoes";

            NikeList.Add(NikeOne);
            NikeList.Add(NikeTwo);

            Shoes AdidasOne = new Shoes();
            AdidasOne.brand = "Adidas";
            AdidasOne.model = "Samba";
            AdidasOne.description = "Lifestyle Shoes";

            Shoes AdidasTwo = new Shoes();
            AdidasTwo.brand = "Adidas";
            AdidasTwo.model = "AE 1";
            AdidasTwo.description = "Basketball Shoes";

            AdidasList.Add(AdidasOne);
            AdidasList.Add(AdidasTwo);

            Shoes NBOne = new Shoes();
            NBOne.brand = "New Balance";
            NBOne.model = "Kawhi 1";
            NBOne.description = "Basketball Shoes";

            Shoes NBTwo = new Shoes();
            NBTwo.brand = "New Balance";
            NBTwo.model = "Galaxy 1";
            NBTwo.description = "Hiking" + " Shoes";

            NBList.Add(NBOne);
            NBList.Add(NBTwo);
        }
    }
}
