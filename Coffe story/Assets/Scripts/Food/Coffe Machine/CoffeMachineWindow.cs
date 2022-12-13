using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeMachineWindow : MonoBehaviour
{
    private SpriteRenderer _windowInteractionUI;
    private SpriteRenderer _goCoffeButtonUI;

    [SerializeField] float timeForAppearenceWindow = 1f;
    private Animator _animator;
    private void Start()
    {
        
        var coffeMachineWindow = GameObject.FindGameObjectWithTag("CoffeMachineWindow");
        _goCoffeButtonUI = GameObject.FindGameObjectWithTag("GoCoffeButton").GetComponent<SpriteRenderer>();
        _windowInteractionUI = coffeMachineWindow.GetComponent<SpriteRenderer>();
        _animator = coffeMachineWindow.GetComponent<Animator>();   
    }
    public void SetPourMilkAnimation()
    {
        _animator.SetTrigger("PourMilk");
    }
    public void SetPourExpressoAnimation()
    {
        _animator.SetTrigger("PourExpresso");
    }
    public void SetPourWaterAnimation()
    {
        _animator.SetTrigger("PourWater");
    }


    public void AppearenceCoffeMachineWindow()
    {
        StartCoroutine(AppearenceWindow());
    }
    private IEnumerator AppearenceWindow()
    {
        float time = 0;
        while (time < timeForAppearenceWindow)
        {
            time += Time.deltaTime;
            _windowInteractionUI.color = new Color(1, 1, 1, time / timeForAppearenceWindow);
            _goCoffeButtonUI.color = new Color(1, 1, 1, time / timeForAppearenceWindow);
            yield return null;
        }
    }
    public void CloseCoffeMachineWindow()
    {
        StartCoroutine(CloseWindow());
    }
    private IEnumerator CloseWindow()
    {
        float time = 0;
        while (time < timeForAppearenceWindow)
        {
            time += Time.deltaTime;
            _windowInteractionUI.color = new Color(1, 1, 1, 1 - time / timeForAppearenceWindow);
            _goCoffeButtonUI.color = new Color(1, 1, 1, 1 - time / timeForAppearenceWindow);
            yield return null;
        }
    }
}
