using UnityEngine;
public class IndicatorPoint : MonoBehaviour
{
    [SerializeField] private GameObject indicator;
    [SerializeField] private Transform thermoPosOne;
    [SerializeField] private Transform thermoPosTwo;
    [SerializeField] private Transform seedPosOne;
    [SerializeField] private Transform seedPosTwo;
    [SerializeField] private Transform ColliderPosOne;
    [SerializeField] private Transform ColliderPosTwo;

    public int indicatorCurrentPos;
    public int counter = 1;
    bool countDone;

    private void Start()
    {
        indicator.transform.position = seedPosOne.transform.position;
        indicatorCurrentPos = 1;
    }

    public void MoveIndicator(Transform transform)
    {
        indicator.transform.position = transform.position;

    }

    public void SetActivation(bool isActive)
    {
        indicator.SetActive(isActive);
    }

    public Transform GetIndicatorPosition(GameObject gameObject)
    {
        if (gameObject.GetComponent<MoveableItem>().move_Counter == 0)
        {
            indicatorCurrentPos = gameObject.GetComponent<MoveableItem>().finalPos;
            return gameObject.GetComponent<MoveableItem>().indicator_final_pos;
        }
        else
        {
            indicatorCurrentPos = gameObject.GetComponent<MoveableItem>().finalPos;
            return gameObject.GetComponent<MoveableItem>().indicator_own_pos;
        }
    }

    public Transform GetIndicatorByIndex(int index)
    {
        if (index == 1)
        {
            indicatorCurrentPos = 2;
            return seedPosTwo;
        }
        else if (index == 2)
        {
            indicatorCurrentPos = 3;
            return thermoPosOne;

        }
        else if (index == 3)
        {
            indicatorCurrentPos = 4;
            return thermoPosTwo;
        }
        else
        {
            indicatorCurrentPos = 1;
            return seedPosOne;
        }

    }

    public void Restart()
    {
        indicator.transform.position = seedPosOne.transform.position;
        indicatorCurrentPos = 1;
        SetActivation(true);
    }
}
