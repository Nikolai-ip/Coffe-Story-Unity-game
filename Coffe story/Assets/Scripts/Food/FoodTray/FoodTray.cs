using UnityEngine;

public class FoodTray : MonoBehaviour
{
    public FoodType ExpectedOrder;
    public FoodType CookedOrder;
    public VisitorReactingController VisitorReactingController { get; set; }
    public void CheckEqualFoods()
    {
        if (ExpectedOrder == CookedOrder)
        {
            VisitorReactingController.PositiveReacting();
        }
        else
        {
            VisitorReactingController.NegativeReacting();
        }
    }
}
