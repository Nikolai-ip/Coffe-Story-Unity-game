using Assets.Scripts.Food;
using Assets.Scripts.Food.Coffe_Machine;
using NUnit.Framework;

public class CoffeListTester
{
    [Test]
    public void EqualTest()
    {
        CoffeComponents coffeList = new CoffeComponents();
        coffeList.Add(CoffeComponentType.Milk);
        coffeList.Add(CoffeComponentType.Milk);
        coffeList.Add(CoffeComponentType.Esspresso);

        CoffeComponents coffeList2 = new CoffeComponents();
        coffeList2.Add(CoffeComponentType.Milk);
        coffeList2.Add(CoffeComponentType.Milk);
        coffeList2.Add(CoffeComponentType.Esspresso);
        Assert.AreEqual(coffeList, coffeList2);
    }

    [Test]
    public void NotEqualTest()
    {
        CoffeComponents coffeList = new CoffeComponents();
        coffeList.Add(CoffeComponentType.Esspresso);
        coffeList.Add(CoffeComponentType.Milk);
        coffeList.Add(CoffeComponentType.Milk);

        CoffeComponents coffeList2 = new CoffeComponents();
        coffeList2.Add(CoffeComponentType.Milk);
        coffeList2.Add(CoffeComponentType.Milk);
        coffeList2.Add(CoffeComponentType.Esspresso);
        Assert.AreNotEqual(coffeList, coffeList2);
    }

    [Test]
    public void CorrectDevLatteTest()
    {
        CoffeDicitonary coffeDicitonary = new CoffeDicitonary();
        CoffeComponents coffeList = new CoffeComponents();
        coffeList.Add(CoffeComponentType.Milk);
        coffeList.Add(CoffeComponentType.Milk);
        coffeList.Add(CoffeComponentType.Esspresso);
        Assert.AreEqual(FoodType.Latte, coffeDicitonary[coffeList]);
    }

    [Test]
    public void CorrectDevEsspressoTest()
    {
        CoffeDicitonary coffeDicitonary = new CoffeDicitonary();
        CoffeComponents coffeList = new CoffeComponents();
        coffeList.Add(CoffeComponentType.Esspresso);
        Assert.AreEqual(FoodType.Esspresso, coffeDicitonary[coffeList]);
    }

    [Test]
    public void CorrectDevCappucinoTest()
    {
        CoffeDicitonary coffeDicitonary = new CoffeDicitonary();
        CoffeComponents coffeList = new CoffeComponents();
        coffeList.Add(CoffeComponentType.Esspresso);
        coffeList.Add(CoffeComponentType.Esspresso);
        coffeList.Add(CoffeComponentType.Milk);
        Assert.AreEqual(FoodType.Cappuccino, coffeDicitonary[coffeList]);
    }

    [Test]
    public void CorrectDevAmericanoTest()
    {
        CoffeDicitonary coffeDicitonary = new CoffeDicitonary();
        CoffeComponents coffeList = new CoffeComponents();
        coffeList.Add(CoffeComponentType.Esspresso);
        coffeList.Add(CoffeComponentType.Water);
        coffeList.Add(CoffeComponentType.Water);
        Assert.AreEqual(FoodType.Americano, coffeDicitonary[coffeList]);
    }
}