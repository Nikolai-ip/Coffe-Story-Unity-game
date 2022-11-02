using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML
{
    public class Guests : Characters
    {
        private Order _order;

        public Order Order
        {
            get => default;
            set
            {
            }
        }

        public void MakeOrder()
        {
            throw new System.NotImplementedException();
        }

        public void InitGuests()
        {
            throw new System.NotImplementedException();
        }

        public void MoveGuest()
        {
            throw new System.NotImplementedException();
        }
    }
}