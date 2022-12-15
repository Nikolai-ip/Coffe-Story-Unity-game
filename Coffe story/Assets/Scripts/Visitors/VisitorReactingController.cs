using UnityEngine;

public class VisitorReactingController : MonoBehaviour
{
    private VisitorMoveController _moveController;
    private void Start()
    {
        _moveController = GetComponent<VisitorMoveController>();
    }
    public void NegativeReacting()
    {
        Debug.Log("UGHHHHHHHH");
        _moveController.GoAway();
    }
    public void PositiveReacting()
    {
        Debug.Log("Thank u!");
        _moveController.GoAway();
    }
}
