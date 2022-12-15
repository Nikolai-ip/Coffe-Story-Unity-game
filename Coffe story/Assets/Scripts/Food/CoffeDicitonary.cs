using Assets.Scripts.Food.Coffe_Machine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Food
{
    internal class CoffeDicitonary
    {

        private Dictionary<CoffeComponents, FoodType> _coffeType;
        public CoffeDicitonary()
        {
            var latte = new CoffeComponents();
            latte.Add(CoffeComponent.Milk, CoffeComponent.Milk, CoffeComponent.Esspresso);
            var cappuccino = new CoffeComponents();
            cappuccino.Add(CoffeComponent.Esspresso, CoffeComponent.Esspresso, CoffeComponent.Milk);
            var esspresso = new CoffeComponents();
            esspresso.Add(CoffeComponent.Esspresso);
            var americano = new CoffeComponents();
            americano.Add(CoffeComponent.Esspresso, CoffeComponent.Water, CoffeComponent.Water);
            _coffeType = new Dictionary<CoffeComponents, FoodType>()
            {
                {latte,FoodType.Latte},
                {cappuccino,FoodType.Cappuccino },
                {esspresso,FoodType.Esspresso },
                {americano,FoodType.Americano},
            };
        }
        public FoodType this[CoffeComponents key] 
        {
            get
            {
                if (_coffeType.ContainsKey(key))
                    return _coffeType[key];
                return FoodType.NotExist;
            }
        }
        

    }
}
