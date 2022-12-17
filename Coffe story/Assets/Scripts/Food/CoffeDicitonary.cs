using Assets.Scripts.Food.Coffe_Machine;
using System.Collections.Generic;

namespace Assets.Scripts.Food
{
    public class CoffeDicitonary
    {
        private Dictionary<CoffeComponents, FoodType> _coffeType;

        public CoffeDicitonary()
        {
            var latte = new CoffeComponents();
            latte.Add(CoffeComponentType.Milk, CoffeComponentType.Milk, CoffeComponentType.Esspresso);
            var cappuccino = new CoffeComponents();
            cappuccino.Add(CoffeComponentType.Esspresso, CoffeComponentType.Esspresso, CoffeComponentType.Milk);
            var esspresso = new CoffeComponents();
            esspresso.Add(CoffeComponentType.Esspresso);
            var americano = new CoffeComponents();
            americano.Add(CoffeComponentType.Esspresso, CoffeComponentType.Water, CoffeComponentType.Water);
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