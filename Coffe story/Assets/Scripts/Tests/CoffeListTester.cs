using Assets.Scripts.Food.Coffe_Machine;
using NUnit.Framework;
public class CoffeListTester
{
    [Test]
    public void EqualTest()
    {
        CoffeComponents coffeList = new CoffeComponents();
        coffeList.Add(CoffeComponent.Milk);
        coffeList.Add(CoffeComponent.Milk);
        coffeList.Add(CoffeComponent.Esspresso);

        CoffeComponents coffeList2 = new CoffeComponents();
        coffeList2.Add(CoffeComponent.Milk);
        coffeList2.Add(CoffeComponent.Milk);
        coffeList2.Add(CoffeComponent.Esspresso);
        Assert.AreEqual(coffeList,coffeList2);
    }
    [Test]
    public void NotEqualTest()
    {
        CoffeComponents coffeList = new CoffeComponents();
        coffeList.Add(CoffeComponent.Esspresso);
        coffeList.Add(CoffeComponent.Milk);
        coffeList.Add(CoffeComponent.Milk);

        CoffeComponents coffeList2 = new CoffeComponents();
        coffeList2.Add(CoffeComponent.Milk);
        coffeList2.Add(CoffeComponent.Milk);
        coffeList2.Add(CoffeComponent.Esspresso);
        Assert.AreNotEqual(coffeList, coffeList2);
    }


}
