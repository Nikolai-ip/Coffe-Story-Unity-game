using Assets.Scripts.Food;
using Assets.Scripts.Food.Coffe_Machine;
using UnityEngine;

public class Coffe : Food
{
    private CoffeComponents _coffeComponents;
    private CoffeDicitonary _coffeDicitonary = new CoffeDicitonary();

    public override FoodType FoodType
    {
        get
        {
            return _coffeDicitonary[_coffeComponents];
        }
    }

    public void PourAllComponents(CoffeComponents components)
    {
        _coffeComponents = components.Copy();
        GivePlayerCupIntoHand();
    }

    private void GivePlayerCupIntoHand()
    {
        var takePoint = GameObject.FindGameObjectWithTag("TakePointPlayer");
        takePoint.GetComponentInParent<Player>().IsHoldFood = true;
        transform.SetParent(takePoint.transform);
        transform.localPosition = new Vector3();
    }
}