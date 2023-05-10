using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public  class ShopFacade
    {
        private Farm farm;
        private Garden garden;
        public ShopFacade()
        {
            farm = new();
            garden = new();
        }
        public string FarmPartion()
        {

            return $"Here is << Farm >> Product Partion our Product :{farm.tomato()} , {farm.Potato()} ";
        }
        public string GardenPartion()
        {
            return $"Here is << Garden >> Product Partion our Product :{garden.Bnana()} , {garden.Apple()} ";
        }
    }
}
