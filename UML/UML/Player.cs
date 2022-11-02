using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML
{
    public class Player : Characters
    {
        public Order Order
        {
            get => default;
            set
            {
            }
        }

        public void Move()
        {
            throw new System.NotImplementedException();
        }

        public void TakeOrder()
        {
            throw new System.NotImplementedException();
        }
    }
}