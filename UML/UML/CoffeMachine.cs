using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML
{
    public class CoffeMachine : KitchenTools
    {
        private int _coffeComponents;

        public CoffeComponents CoffeComponents
        {
            get => default;
            set
            {
            }
        }

        public void MakeCoffe()
        {
            throw new System.NotImplementedException();
        }
    }
}