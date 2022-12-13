using System;
using System.Collections;
using System.Collections.Generic;

namespace Assets.Scripts.Food.Coffe_Machine
{
    public class CoffeList:IEnumerable
    {
        private List<CoffeComponent> _coffe = new List<CoffeComponent>();
        public void Add(CoffeComponent component)
        {
            _coffe.Add(component);
        }
        public override bool Equals(object obj)
        {
            CoffeList otherCoffeList = obj as CoffeList;
            for (int i = 0; i < _coffe.Count; i++)
            {
                if (_coffe[i] != otherCoffeList[i])
                    return false;
            }
            return true;
        }

        public IEnumerator GetEnumerator()
        {
            return _coffe.GetEnumerator();  
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_coffe);
        }

        public CoffeComponent this[int index]
        {
            get
            {
                return _coffe[index];
            }
        }
    }
}
