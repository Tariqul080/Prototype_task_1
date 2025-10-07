using UnityEditor.Rendering;
using UnityEngine;

public class TargetPoint : MonoBehaviour
{
    [SerializeField] private Transform thermometerPos = null;
    [SerializeField] private Transform seedPos = null;
    [SerializeField] private IndicatorPoint indicator;

    public bool isThermometerDone = false;
    public bool isSeedDone = false;

    private void OnTriggerEnter(Collider other)
    {
        GameObject game_object = other.gameObject;
        MoveableItem item = other.GetComponent<MoveableItem>();

        if (game_object.CompareTag("Clickable") && item.isThermometer)
        {
            if (item != null)
            {
                if (item.isThermometer && item.move_Counter == 0)
                {
                    item.StopMoving();
                    if (item.move_Counter == 0)
                    {
                        item.MovePos();
                        indicator.MoveIndicator(indicator.GetIndicatorByIndex(item.index));
                    }
                }
            }
        }
        else
        {
            if (item != null)
            {
                if (!item.isThermometer && item.move_Counter == 0)
                {
                    item.StopMoving();
                    item.MovePos();
                    indicator.MoveIndicator(indicator.GetIndicatorByIndex(item.index));
                }
            }
        }
    }
}
