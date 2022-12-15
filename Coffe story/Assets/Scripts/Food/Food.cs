using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Food : MonoBehaviour
{
    public abstract FoodType FoodType { get; }

    public void Destroy(int timeToDestroyFood)
    {
        StartCoroutine(DestroyFood(timeToDestroyFood));
    }
    private IEnumerator DestroyFood(int timeToDestroyFood)
    {
        float time = 0;
        while (time < timeToDestroyFood)
        {
            time += Time.deltaTime;
            yield return null;
        }
        Destroy(gameObject);

    }
}
