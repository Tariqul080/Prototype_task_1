using Unity.VisualScripting;
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

    private void Start()
    {
        MoveIndicator(seedPosOne);

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
            return gameObject.GetComponent<MoveableItem>().indicator_final_pos;
        }
        else
        {
            return gameObject.GetComponent<MoveableItem>().indicator_own_pos;
        }
    }

    public Transform GetIndicatorByIndex(int index)
    {
        if (index == 1)
        {
            return seedPosTwo;
        }
        else if (index == 2)
        {
            return thermoPosOne;

        }
        else if (index == 3)
        {
            return thermoPosTwo;
        }
        else
        {
            return seedPosOne;
        }

    }
}
