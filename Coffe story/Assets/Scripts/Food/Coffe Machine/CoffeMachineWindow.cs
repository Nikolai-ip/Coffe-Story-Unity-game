using Assets.Scripts.Food.Coffe_Machine;
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
    private Dictionary<CoffeComponent, string> _animationsTrigger = new Dictionary<CoffeComponent, string>()
    {
        { CoffeComponent.Milk,"PourMilk"},
        { CoffeComponent.Esspresso,"PourExpresso"},
        { CoffeComponent.Water,"PourWater"},
    };
    public void SetPourAnimation(CoffeComponent component)
    {
        _animator.SetTrigger(_animationsTrigger[component]);
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
