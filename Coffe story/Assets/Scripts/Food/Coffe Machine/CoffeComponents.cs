using System.Collections;
using System.Collections.Generic;

namespace Assets.Scripts.Food.Coffe_Machine
{
    public class CoffeComponents : IEnumerable
    {
        private List<CoffeComponentType> _coffeComponents = new List<CoffeComponentType>();
        public int Count
        { get { return _coffeComponents.Count; } }

        public void Add(params CoffeComponentType[] components)
        {
            foreach (var component in components)
            {
                _coffeComponents.Add(component);
            }
        }

        public CoffeComponents Copy()
        {
            CoffeComponents copy = new CoffeComponents();
            foreach (var component in _coffeComponents)
            {
                copy.Add(component);
            }
            return copy;
        }

        public void Clear()
        {
            _coffeComponents.Clear();
        }

        public override bool Equals(object obj)
        {
            CoffeComponents otherCoffeList = obj as CoffeComponents;
            for (int i = 0; i < _coffeComponents.Count; i++)
            {
                if (_coffeComponents[i] != otherCoffeList[i])
                    return false;
            }
            return true;
        }

        public IEnumerator GetEnumerator()
        {
            return _coffeComponents.GetEnumerator();
        }

        public override int GetHashCode()
        {
            int hash = 0;
            foreach (var component in _coffeComponents)
            {
                hash += component.GetHashCode();
            }
            return hash;
        }

        public CoffeComponentType this[int index]
        {
            get
            {
                return _coffeComponents[index];
            }
        }
    }
}