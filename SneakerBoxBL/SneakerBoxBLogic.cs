using System;
using System.Collections.Generic;
using SneakerBox;
using SneakerBoxDL;

namespace SneakerBoxBL
    {
        public class SneakerBoxBLogic
        {
            public List<Shoes> Shoes = new List<Shoes>();

            public void AddShoe(Shoes shoe)
            {
                Shoes.Add(shoe);
            }

            public Shoes SearchShoe(string model)
            {
                Shoes foundShoe = null;

                foreach (Shoes shoe in Shoes)
                {
                    if (shoe.model.Equals(model))
                    {
                        foundShoe = shoe;
                        break;
                    }
                }

                return foundShoe;
            }

            public void RemoveShoe(Shoes shoe)
            {
                Shoes.Remove(shoe);
            }

            public bool VerifyUser(string username, string password)
            {
                DataServices dataService = new DataServices();
                var result = dataService.GetUser(username, password);

                if (result.username == username && result.password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

