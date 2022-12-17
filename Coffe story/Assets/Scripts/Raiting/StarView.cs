using UnityEngine;

public class StarView : MonoBehaviour
{
    [SerializeField] private Star[] _stars;
    public int StarsUICount
    { get { return _stars.Length; } }

    private void Start()
    {
        _stars = GetComponentsInChildren<Star>();
    }

    public void ShowStarsUI(int countYellowStar)
    {
        for (int i = 0; i < _stars.Length; i++)
        {
            if (i <= countYellowStar - 1)
            {
                _stars[i].SetYellowStar();
            }
            else
            {
                _stars[i].SetEmptyStar();
            }
        }
    }
}