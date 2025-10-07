using UnityEngine;

public class Restart : MonoBehaviour
{
    [SerializeField] private ClickManager clickManager;
    [SerializeField] private MoveableItem thermometerA;
    [SerializeField] private MoveableItem thermometerB;
    [SerializeField] private MoveableItem seedA;
    [SerializeField] private MoveableItem seedB;
    [SerializeField] private IndicatorPoint indicatorPoint;

    public void OnClickRestart()
    {
        clickManager.Restart();
        thermometerA.Restart();
        thermometerB.Restart();
        seedA.Restart();
        seedB.Restart();
        indicatorPoint.Restart();
        TargetPoint.Reset();
    }
}
