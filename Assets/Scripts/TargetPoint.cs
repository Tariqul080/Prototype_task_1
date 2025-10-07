using UnityEngine;
using UnityEngine.Events;

public class TargetPoint : MonoBehaviour
{
    [SerializeField] private IndicatorPoint indicator;
    [SerializeField] private bool isBattleA = true;
    [SerializeField] private UnityEvent completeCallback = null;

    private static int countThermometer = 0, countSeeds = 0;

    public static void Reset()
    {
        countThermometer = 0;
        countSeeds = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject game_object = other.gameObject;
        MoveableItem item = other.GetComponent<MoveableItem>();

        if (item == null || !game_object.CompareTag("Clickable"))
        {
            return;
        }

        if (item.isTargetBattalA != isBattleA)
        {
            return;
        }

        if (item.isThermometer)
        {
            if (item.move_Counter == 0)
            {
                item.StopMoving();
                if (item.move_Counter == 0)
                {
                    item.MovePos();
                    indicator.MoveIndicator(indicator.GetIndicatorByIndex(item.currentPos));
                }
                countThermometer++;
            }
        }
        else
        {
            if (item.move_Counter == 0)
            {
                item.StopMoving();
                item.MovePos();
                indicator.MoveIndicator(indicator.GetIndicatorByIndex(item.currentPos));
                countSeeds++;
            }
        }

        if (countThermometer >= 2 && countSeeds >= 2)
        {
            indicator.SetActivation(false);
            completeCallback?.Invoke();
        }
    }
}
