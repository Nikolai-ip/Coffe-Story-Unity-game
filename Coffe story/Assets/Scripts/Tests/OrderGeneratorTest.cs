using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Food.Coffe_Machine;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CoffeListTester
{
    [Test]
    public void EqualTest()
    {
        CoffeList coffeList = new CoffeList();
        coffeList.Add(CoffeComponent.Milk);
        coffeList.Add(CoffeComponent.Milk);
        coffeList.Add(CoffeComponent.Expresso);

        CoffeList coffeList2 = new CoffeList();
        coffeList2.Add(CoffeComponent.Milk);
        coffeList2.Add(CoffeComponent.Milk);
        coffeList2.Add(CoffeComponent.Expresso);
        Assert.AreEqual(coffeList,coffeList2);
    }
    [Test]
    public void NotEqualTest()
    {
        CoffeList coffeList = new CoffeList();
        coffeList.Add(CoffeComponent.Expresso);
        coffeList.Add(CoffeComponent.Milk);
        coffeList.Add(CoffeComponent.Milk);

        CoffeList coffeList2 = new CoffeList();
        coffeList2.Add(CoffeComponent.Milk);
        coffeList2.Add(CoffeComponent.Milk);
        coffeList2.Add(CoffeComponent.Expresso);
        Assert.AreNotEqual(coffeList, coffeList2);
    }


}
